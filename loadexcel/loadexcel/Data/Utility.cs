using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace loadexcel
{
    class Utility
    {

        public static DataSet ToDataTable2(string filePath)
        {
            string connStr = "";
            string fileType = System.IO.Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(fileType)) return null;
            if (fileType == ".xls")
                connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            else
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";

            string sql_F = "Select * FROM [{0}]";
            OleDbConnection conn = null;
            OleDbDataAdapter da = null;
            DataTable dtSheetName = null;
            DataSet ds = new DataSet();
            try
            {
                
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                HSSFWorkbook workbook = new HSSFWorkbook(fs);

                for (int i = 0; i < workbook.NumberOfSheets; i++)
                {
                    ISheet sheet = workbook.GetSheetAt(i);


                }
                fs.Close();
                // 初始化连接，并打开
                conn = new OleDbConnection(connStr);
                conn.Open();
                // 获取数据源的表定义元数据
                string SheetName = "";
                dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, null });
                // 初始化适配器
                da = new OleDbDataAdapter();
                for (int i = 0; i < dtSheetName.Rows.Count; i++)
                {
                    SheetName = (string)dtSheetName.Rows[i]["TABLE_NAME"];
                    if (SheetName.Contains("$") && !SheetName.Replace("'", "").EndsWith("$"))
                    {
                        continue;
                    }
                    da.SelectCommand = new OleDbCommand(String.Format(sql_F, SheetName), conn);
                    DataSet dsItem = new DataSet();
                    da.Fill(dsItem, SheetName.Replace("$", ""));
                    ds.Tables.Add(dsItem.Tables[0].Copy());
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                // 关闭连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    da.Dispose();
                    conn.Dispose();
                }
            }
            return ds;
        }

        public static DataSet ToDataTable(string filePath)
        {
            FileStream fs = null;
            //try
            {
                DataSet ds = new DataSet();
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                HSSFWorkbook workbook = new HSSFWorkbook(fs);
                List<ISheet> sheetList = new List<ISheet>();
                for (int i = 0; i < workbook.NumberOfSheets; i++)
                {
                    sheetList.Add(workbook.GetSheetAt(i));
                }

                List<string> formulaSheets = new List<string>();

                foreach (ISheet sheet in sheetList)
                {
                    if (sheet.SheetName.Contains('#'))
                        continue;

                    DataTable table = new DataTable(sheet.SheetName);

                    IRow headerRow = sheet.GetRow(1);       // 原来使用的是0，后来因为策划第一行注释不同表可能注释不同，所以改为用1了
                    IRow typeRow = sheet.GetRow(2);
                    if (headerRow == null || sheet.GetRow(0) == null || sheet.GetRow(2) == null)
                    {
                        throw (new Exception("\"" + Path.GetFileName(filePath) + "\"  中出现空白Sheet(" + sheet.SheetName + ")，请检查"));
                    }

                    //int cellCount = headerRow.LastCellNum;
                    int cellCount = sheet.GetRow(0).LastCellNum;    // 使用headerRow的时候，有时候莫名奇妙的会多出很多列，改为用第一行

                    Dictionary<int, string> headerDic = new Dictionary<int, string>();
                    for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                    {
                        ICell c = headerRow.GetCell(i);
                        if(c == null)
                        {
                            Console.WriteLine("表头为空，File:"+ Path.GetFileNameWithoutExtension(filePath) + "-Sheet:" + sheet.SheetName + "第" + (i+1) + "列");
                        }
                        string headerString = c.StringCellValue;
                        if(string.IsNullOrEmpty((headerString + "").Trim()))
                        {
                            Console.WriteLine("表头为空，File:" + Path.GetFileNameWithoutExtension(filePath) + "-Sheet:" + sheet.SheetName + "第" + (i + 1) + "列");
                        }
                        if (string.IsNullOrEmpty(headerString)) continue;
                        while (table.Columns.Contains(headerString))
                        {
                            headerString += "1";
                        }
                        DataColumn column = new DataColumn(headerString);
                        table.Columns.Add(column);
                        headerDic.Add(i, headerString);
                    }


                    Dictionary<int, string> typeDic = new Dictionary<int, string>();
                    for (int i = typeRow.FirstCellNum; i < cellCount; i++)
                    {
                        ICell c = typeRow.GetCell(i);
                        string typeString = c.ToString();
                        typeDic.Add(i, typeString);
                    }

                    bool hasmainkey = false;
                    for (int j = headerRow.FirstCellNum; j < headerRow.LastCellNum; j++)
                    {
                        ICell c = headerRow.GetCell(j);
                        if (c != null)
                        {
                            string str = c.ToString();
                            if (str.Contains("!"))
                                hasmainkey = true;
                        }
                    }

                    if(hasmainkey == false)
                    {
                        Console.WriteLine(Path.GetFileName(filePath) + "  " +sheet.SheetName + " 没有主键！");
                        throw new Exception();
                    }

                    //int rowCount = sheet.LastRowNum;
                    for (int i = (sheet.FirstRowNum); i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;

                        //如果主键是无效数据
                        int ignorecount = 0;
                        int mainkeycount = 0;
                        for (int j = headerRow.FirstCellNum; j < headerRow.LastCellNum; j++)
                        {
                            ICell c = headerRow.GetCell(j);
                            if (c != null)
                            {
                                string str = c.ToString();
                                if (str.Contains("!"))
                                {
                                    ICell c1 = row.GetCell(j);
                                    mainkeycount++;

                                    if (c1 == null)
                                        ignorecount++;
                                    else if (c1.ToString() == "")
                                        ignorecount++;
                                    else if (c1.CellType == CellType.Numeric && c1.NumericCellValue == 0)
                                        ignorecount++;
                                }
                            }
                        }

                        if (ignorecount == mainkeycount)
                            continue;

                        DataRow dataRow = table.NewRow();

                        //for (int j = row.FirstCellNum; j < row.LastCellNum; j++)
                        for (int j = headerRow.FirstCellNum; j <= headerRow.LastCellNum; j++)
                        {
                            if (!headerDic.ContainsKey(j)) continue;
                            string k = headerDic[j];
                            string t = typeDic[j];

                            ICell c = row.GetCell(j);
                            if (c == null)
                            {
                                dataRow[k] = "";
                            }
                            else
                            {
                                if (c.CellType == CellType.Formula && k.Contains("#") == false && t.Contains("#") == false)
                                {
                                    string sss = Path.GetFileNameWithoutExtension(filePath) + ":" + sheet.SheetName;
                                    if (!formulaSheets.Contains(sss))
                                    {
                                        formulaSheets.Add(sss);
                                    }
                                    // 出现公式直接报错
                                    Console.WriteLine(sheet.SheetName + "有公式，请修改！");

                                    dataRow[k] = "0";
                                }
                                else
                                {
                                    dataRow[k] = c.ToString();
                                }
                            }
                            //if (row.GetCell(j) != null)
                            //    dataRow[j] = row.GetCell(j).RichStringCellValue.String;
                        }

                        table.Rows.Add(dataRow);
                    }
                    ds.Tables.Add(table);
                }
                //workbook = null;
                //sheet = null;

                fs.Close();

                return ds;
            }
            //catch (Exception ex)
            //{
               // throw new Exception("ToDataTable error, filepath:" + filePath, ex);
                //throw ex;
           // }
            //finally
            //{
                //if(fs != null)
                //{
                    //fs.Close();
                //}
           // }
        }
    }
}
