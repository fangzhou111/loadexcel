using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace WConfigBuild
{
    public class ConfigFileInfo
    {
        public string FilePath { get; set; }
        public List<SheetInfo> Sheets { get; set; }
        public ConfigFileInfo()
        {
            this.Sheets = new List<SheetInfo>();
        }

        public ConfigFileInfo(string filePath)
        {
            this.FilePath = filePath;
            this.Sheets = new List<SheetInfo>();
            DataSet ds = Utility.ToDataTable(filePath);
            this.Sheets = new List<SheetInfo>();
            foreach (DataTable dt in ds.Tables)
            {
                SheetInfo si = new SheetInfo(dt, this);
                //si.ConfigFileInfo = this;
                this.Sheets.Add(si);
            }
        }

        public override string ToString()
        {
            return Path.GetFileName(this.FilePath);
        }

        /// <summary>
        /// 获取配置文件列表
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static List<ConfigFileInfo> GetConfigFileInfoList(string[] paths)
        {
            List<ConfigFileInfo> list = new List<ConfigFileInfo>();
            List<SheetInfo> sheetList = new List<SheetInfo>();
            foreach (string path in paths)
            {
                ConfigFileInfo fi = new ConfigFileInfo();
                fi.FilePath = path;
                DataSet ds = Utility.ToDataTable(path);
                foreach (DataTable dt in ds.Tables)
                {
                    try
                    {
                        string sName = dt.TableName;
                        // 查看已有的fi中是否有同名的sheet
                        SheetInfo existSheet = sheetList.FirstOrDefault(p => p.SheetName == sName);
                        if (existSheet == null)
                        //if(true)
                        {
                            SheetInfo si = new SheetInfo(dt, fi);
                            //si.ConfigFileInfo = fi;
                            fi.Sheets.Add(si);
                            sheetList.Add(si);
                        }
                        else
                        {
                            DataTable existDataTable = existSheet.SheetDataTable;
                            // 有同名的Sheet合并
                            for (int i = 2; i < dt.Rows.Count; i++)
                            {
                                DataRow dr = existDataTable.NewRow();
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    // 为了找到全局设置中的空行
                                    //if (existSheet.SheetName == "GlobalConfig" && dc.ColumnName == "功能名称" && dt.Rows[i][dc].ToString() == "")
                                    //{
                                    //    int asdfasdf = 0;
                                    //}

                                    dr[dc.ColumnName] = dt.Rows[i][dc];
                                }
                                existDataTable.Rows.Add(dr);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("整理文件 " + Path.GetFileName(path) + " 出错:" + ex.Message);
                        throw ex;
                    }
                }
                list.Add(fi);
            }
            return list;
        }
    }
}
