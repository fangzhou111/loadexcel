using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace loadexcel
{
    public class SheetInfo
    {
        public SheetInfo(DataTable dt, ConfigFileInfo fi)
        {
            this.SheetName = dt.TableName;
            this.ConfigFileInfo = fi;
            this.SameNameFilePaths = new List<string>();
            this.HeaderCN = new List<string>();
            this.HeaderEN = new List<string>();
            this.ColumnRole = new List<string>();
            if (dt.Rows.Count >= 2)
            {
                DataRow dr1 = dt.Rows[0];
                DataRow dr3= dt.Rows[1];
                DataRow dr2 = dt.Rows[2];
                foreach (DataColumn dc in dt.Columns)
                {
                    if (dr1[dc] == DBNull.Value)
                    {
                        continue;
                    }
                    else if (dr3[dc].ToString().Contains("!"))
                    {
                        string temp = dr3[dc].ToString().Replace("!", "").Trim();
                        mainkey.Add(temp.ToString());

                        // 表头是中文
                        this.HeaderCN.Add(dr1[dc].ToString());
                        // 第一列是英文表头名
                        this.HeaderEN.Add(dr3[dc].ToString());
                        // 第二列是数据规则
                        this.ColumnRole.Add(dr2[dc].ToString());
                    }
                    else
                    {
                        string enHeader = dr3[dc].ToString().Replace("#", "").Trim();
                        if (this.HeaderEN.Contains(enHeader))
                        {
                            string errorMsg = "File:\"" + Path.GetFileName(fi.FilePath) + "\",  Sheet:\"" + this.SheetName + "\"    出现同名表头" + enHeader;
                            Console.WriteLine(errorMsg);
                        }
                        // 表头是中文
                        this.HeaderCN.Add(dr1[dc].ToString());
                        // 第一列是英文表头名
                        this.HeaderEN.Add(dr3[dc].ToString());
                        // 第二列是数据规则
                        this.ColumnRole.Add(dr2[dc].ToString());
                    }
                }
                dt.Rows.Remove(dr1);
                // 这一栏暂时不考虑
                dt.Rows.Remove(dr2);
                this.SheetDataTable = dt;
            }
            else
            {
                throw new Exception(string.Format("\"{0}\\{1}\" 表列头行数不够三行", Path.GetFileName(this.ConfigFileInfo.FilePath), SheetName));
            }

            List<DataRow> removeList = new List<DataRow>();
            // 筛选出首列为空的行
            foreach (DataRow dr in this.SheetDataTable.Rows)
            {
                if (dr[0].ToString() == "")
                    removeList.Add(dr);
            }
            removeList.ForEach(p=>this.SheetDataTable.Rows.Remove(p));
        }

        public ConfigFileInfo ConfigFileInfo { get; set; }
        //添加sheet文件名记录
        public List<string> SameNameFilePaths { get; set; }
        public string SheetName { get; set; }
        public DataTable SheetDataTable { get; set; }

        /// <summary>
        /// 中文标头
        /// </summary>
        public List<string> HeaderCN { get; set; }
        /// <summary>
        /// 英文标头
        /// </summary>
        public List<string> HeaderEN { get; set; }
        /// <summary>
        /// 列数据效检规则
        /// </summary>
        public List<string> ColumnRole { get; set; }

        public List<string> mainkey = new List<string>();

        public override string ToString()
        {
            return SheetName;
        }

        // 检测是否有主键
        private void CheckPK()
        {

        }
        // 检测是否有外键
        private void CheckFK()
        {

        }
    }
}
