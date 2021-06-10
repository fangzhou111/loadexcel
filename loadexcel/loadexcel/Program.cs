using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Text;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Newtonsoft.Json.Linq;

namespace loadexcel
{
    class Program
    {
        private static void BuildGoHead(List<ConfigFileInfo> configFileInfos, string outpath)
        {
            List<string> strs = new List<string>();

            strs.Add("package configdata");

            foreach (ConfigFileInfo cfi in configFileInfos)
            {
                foreach (SheetInfo si in cfi.Sheets)
                {
                    //添加sheet文件名输出部分
                    string s ="\\";
                    string str = "\n";
                    if (si.ConfigFileInfo.FilePath.LastIndexOf(s) >=0)
                    {
                        str +="// " + si.ConfigFileInfo.FilePath.Substring(si.ConfigFileInfo.FilePath.LastIndexOf(s)+1) + "\n";
                    }else
                    {
                        str += "//" + si.ConfigFileInfo.FilePath + "\n";
                    }
                        
                    for(int i = 0;i < si.SameNameFilePaths.Count; i++)
                    {
                        if (si.SameNameFilePaths[i].LastIndexOf(s) >= 0)
                            str += "// " + si.SameNameFilePaths[i].Substring(si.SameNameFilePaths[i].LastIndexOf(s)+1) + "\n";
                        else 
                            str += "//" + si.SameNameFilePaths[i] + "\n";
                    }
                    str += "type Conf_" + si.SheetName + " struct { \n";

                    for(int i = 0;i < si.HeaderEN.Count;i++)
                    {
                        if (si.HeaderEN[i].Contains("#"))
                            continue;

                        string temp = "";
                        string stype = "int32";
                        string name = si.HeaderEN[i];

                        if (si.ColumnRole[i].ToLower() == "double" || si.ColumnRole[i].ToLower() == "float")
                            stype = "float32";
                        else if(si.ColumnRole[i].ToLower() == "string")
                            stype = "string";

                        if (si.mainkey.Contains(si.HeaderEN[i].Replace("!", "").Trim()))
                        {
                            temp = "`key`";
                            name = si.HeaderEN[i].Replace("!", "").Trim();
                        }

                        string firstchar = name.ToCharArray()[0].ToString().ToUpper();
                        name = name.Remove(0,1);                    
                        name = name.Insert(0, firstchar);

                        str += "\t" + name + " " + stype + "\t\t" + temp + "\t" + "/*" + si.HeaderCN[i] + "*/\n";
                    }

                    str += "} \n";

                    str += "var MConf_" + si.SheetName + " = map[string] * Conf_" + si.SheetName + "{}";

                    strs.Add(str);
                }
            }

            strs.Add("func load() {");

            foreach (ConfigFileInfo cfi in configFileInfos)
            {
                foreach (SheetInfo si in cfi.Sheets)
                {
                    string str = "";
                    str = "\tloadconfigdata(&MConf_" + si.SheetName + ")";

                    strs.Add(str);
                }
            }

            strs.Add("}");

            strs.Add("func HotUpdateConfigData(sheetname string) bool {");

            strs.Add("\tswitch sheetname {");

            foreach (ConfigFileInfo cfi in configFileInfos)
            {
                foreach (SheetInfo si in cfi.Sheets)
                {
                    strs.Add("\tcase \"" + si.SheetName + "\":");
                    strs.Add("\t\tm :=map[string]*Conf_" + si.SheetName + "{}");
                    strs.Add("\t\tloadconfigdata(&m)");
                    strs.Add("\t\tMConf_" + si.SheetName + " = m");
                    strs.Add("\t\treturn true");
                    //strs.Add("\tcase \"" + si.SheetName + "\":\n\t\tm:= &MConf_" + si.SheetName + "\n\t\tfor k, _:= range * m { delete(*m, k)}\n\t\tloadconfigdata(m)\n\t\treturn true");
                }
            }
            strs.Add("\tdefault:");
            strs.Add("\t}");

            strs.Add("\treturn false");
            strs.Add("}");

            if (!File.Exists(outpath + "/config_data.go"))
            {
                FileStream f = File.Create(outpath + "/config_data.go");
                f.Close();
            }

            var encoding = new UTF8Encoding(false);
            File.WriteAllLines(outpath + "/config_data.go", strs.ToArray(), encoding);

        }

        private static void BuildBinary(List<ConfigFileInfo> configFileInfos, string outpath)
        {
            foreach (ConfigFileInfo fi in configFileInfos)
            {
                foreach (SheetInfo si in fi.Sheets)
                {
                    string name = si.SheetName;//文件名

                    FileStream fs = new FileStream(outpath + name + ".bytes", FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

                    for (int row = 0; row < si.SheetDataTable.Rows.Count; row++)
                    {
                        if (row == 0)
                        {
                            continue;
                        }
                        else
                        {
                            DataRow irow = si.SheetDataTable.Rows[row];

                            for (int col = 0; col < si.ColumnRole.Count; col++)
                            {
                                if (si.HeaderEN[col].Contains("#"))
                                {
                                    continue;
                                }

                                if (si.ColumnRole[col].Trim() == "int")
                                {
                                    if (irow[col].ToString() != "")
                                        bw.Write(int.Parse(irow[col].ToString()));
                                    else
                                        bw.Write(0);
                                }
                                else if (si.ColumnRole[col].Trim() == "float" || si.ColumnRole[col].Trim() == "double")
                                {
                                    if (irow[col].ToString() != "")
                                        bw.Write(double.Parse(irow[col].ToString()));
                                    else
                                        bw.Write(0.0);
                                }
                                else 
                                //if (si.ColumnRole[col].Trim() == "string")
                                {
                                    bw.Write(irow[col].ToString());
                                }
                            }
                        }
                    }

                    bw.Flush();
                    bw.Close();
                    fs.Close();
                }
            }
        }

        private static void BuildCharp(List<ConfigFileInfo> configFileInfos, string outpath)
        {
            foreach (ConfigFileInfo fi in configFileInfos)
            {
                foreach (SheetInfo si in fi.Sheets)
                {
                    List<string> lst = new List<string>();//C#内容
                    List<MainKey> keys = new List<MainKey>();

                    //制造主键列表
                    for (int i = 0; i < si.HeaderEN.Count; i++)
                    {
                        if (si.HeaderEN[i].Contains("!"))
                        {
                            MainKey newkey = new MainKey();
                            newkey.name = si.HeaderEN[i].Replace("!", "");
                            newkey.type = si.ColumnRole[i];

                            keys.Add(newkey);
                        }
                    }

                    string name = si.SheetName;//文件名

                    int rowCount = si.SheetDataTable.Rows.Count - 1;//行数

                    //制造存储列表名称
                    List<string> dicnames = new List<string>();

                    string str = string.Format("{0}Data", name);
                    dicnames.Insert(0, str);

                    for (int i = keys.Count - 1; i >= 0; i--)
                    {
                        str = string.Format("Dictionary<{0}, {1}>", keys[i].type, str);
                        dicnames.Insert(0, str);
                    }

                    //添加头文件
                    lst.Add("using System.IO;");
                    lst.Add("using System.Collections;");
                    lst.Add("using System.Collections.Generic;");
                    lst.Add("using UnityEngine;");

                    lst.Add("namespace SuperMobs.Config");
                    lst.Add("{");

                    //制作DataClass
                    lst.Add(string.Format("public class {0}Data", name));
                    lst.Add("{");

                    //制作变量
                    for (int i = 0; i < si.HeaderEN.Count; i++)
                    {
                        if (si.HeaderEN[i].Contains("#"))
                            continue;
                        else
                        {
                            string paramName = si.HeaderEN[i].Replace("!", "");

                            lst.Add(string.Format("/*{2}*/\npublic {0} {1}; ", si.ColumnRole[i], paramName,si.HeaderCN[i]));
                        }
                    }
                    lst.Add("}");



                    //制作ConfigClass
                    lst.Add(string.Format("public partial class {0}Config : ConfigBase", name));
                    lst.Add("{");

                    //制作存储结构
                    lst.Add(string.Format("private static {0}Config _instance;", name));


                    lst.Add(string.Format("public {0} _datas;", dicnames[0]));

                    //制作单例接口
                    lst.Add(string.Format("public static {0}Config Instance", name));
                    lst.Add("{");
                    lst.Add("get");
                    lst.Add("{");
                    lst.Add("if (_instance == null)");
                    lst.Add("{");
                    lst.Add(string.Format("_instance = new {0}Config();", name));
                    lst.Add("_instance.Load();");
                    lst.Add("ConfigManager.Add(_instance);");
                    lst.Add("}");//end if

                    lst.Add("return _instance;");

                    lst.Add("}");//end get
                    lst.Add("}");//end Instance


                    //制作解析函数
                    lst.Add("private void Load()");
                    lst.Add("{");

                    lst.Add(string.Format("Stream fs = base.Load(\"{0}.bytes\");", name));
                    lst.Add("BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);");

                    lst.Add(string.Format("for(int i = 0;i < {0};i++)", rowCount));
                    lst.Add("{");

                    lst.Add(string.Format("{0}Data data = new {0}Data();", name));

                    for (int col = 0; col < si.ColumnRole.Count; col++)
                    {
                        string paramName = si.HeaderEN[col].Replace("!", "");

                        if (si.HeaderEN[col].Contains("#"))
                        {
                            continue;
                        }

                        if (si.ColumnRole[col].Trim() == "int")
                        {
                            lst.Add(string.Format("data.{0} = br.ReadInt32();", paramName));
                        }
                        else if (si.ColumnRole[col].Trim() == "float" || si.ColumnRole[col].Trim() == "double")
                        {
                            lst.Add(string.Format("data.{0} = (float)br.ReadDouble();", paramName));
                        }
                        else 
                        //if (si.ColumnRole[col] == "string")
                        {
                            lst.Add(string.Format("data.{0} = br.ReadString();", paramName));
                        }
                    }

                    //制造保存逻辑
                    string res = "_datas";

                    lst.Add("if (_datas == null)");
                    lst.Add(string.Format("_datas = new {0}();", dicnames[0]));

                    for(int i = 1;i < dicnames.Count - 1;i++)
                    {
                        string tempname = "_dic";

                        lst.Add(string.Format("if (!{0}.ContainsKey(data.{1}))", res, keys[i - 1].name));
                        lst.Add("{");

                        lst.Add(string.Format("{0} {1} = new {0}();", dicnames[i], tempname));
                        lst.Add(string.Format("{0}.Add(data.{1}, {2});",res, keys[i - 1].name, tempname));


                        lst.Add("}");//end if 


                        res = string.Format("{0}[data.{1}]", res, keys[i - 1].name);
                    }
                    
                    lst.Add(string.Format("{0}.Add(data.{1},data);",res, keys[keys.Count - 1].name));

                    lst.Add("}");//end for i

                    lst.Add("br.Close();");
                    lst.Add("fs.Close();");


                    lst.Add("}");//end load

                    //制造获取逻辑
                    string ifstr = "";
                    string lastresstr = "";
                    for (int i = 0; i < dicnames.Count - 1; i++)
                    {
                        string paramstr = "";
                        string resstr = "";
                        int paramcount = i + 1;

                        for (int j = 0; j < paramcount; j++)
                        {
                            paramstr = paramstr + keys[j].type + " new" + keys[j].name;
                            resstr = resstr + "[new" + keys[j].name + "]";

                            if (j < paramcount - 1)
                                paramstr = paramstr + ",";
                        }


                        ifstr = ifstr + string.Format("{0}.ContainsKey(new{1})", lastresstr, keys[paramcount - 1].name);

                        lst.Add(string.Format("public {0} Get({1})", dicnames[i + 1], paramstr));
                        lst.Add("{");
                        lst.Add(string.Format("if (_datas{0})", ifstr));
                        lst.Add(string.Format("return _datas{0};", resstr));
                        lst.Add("else");
                        lst.Add("return null;");
                        lst.Add("}");

                        lastresstr = resstr;
                        ifstr = ifstr + " && _datas";
                    }

                    //制造析构接口
                    lst.Add("public override void Dispose()");
                    lst.Add("{");
                    lst.Add("_datas = null;");
                    lst.Add("base.Dispose();");
                    lst.Add("}");//end dispose

                    lst.Add("}");//end classconfig

                    lst.Add("}");//end namespace

                    var encoding = new UTF8Encoding(true);
                    File.WriteAllLines(outpath + si.SheetName + "Config.cs", lst.ToArray(), encoding);
                }
            }
        }

        private static void BuildJson(List<ConfigFileInfo> configFileInfos,string outpath)
        {
            foreach (ConfigFileInfo fi in configFileInfos)
            {
                //string fileName = fi.Sheets.First().SheetName;
                //fileName = Config.Instance.OutputPath.TrimEnd('\\') + "\\" + fileName + ".json";
                //FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                //StreamWriter sw = new StreamWriter(fs);
                //JObject root = new JObject();
                foreach (SheetInfo si in fi.Sheets)
                {
                    string fileName = outpath + si.SheetName + ".json";
                    FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    JObject root = new JObject();

                    JArray jarray = new JArray();
                    int rowIndex = 3;
                    foreach (DataRow dr in si.SheetDataTable.Rows)
                    {
                        rowIndex++;
                        if (rowIndex < 5)
                            continue;

                        JObject jrow = new JObject();
                        for (int i = 0; i < si.HeaderEN.Count; i++)
                        {
                            string role = si.ColumnRole[i];
                            string s = dr[si.HeaderEN[i]].ToString();

                            if (si.HeaderEN[i].Contains("#"))
                                continue;

                            if (role.ToLower() == "datetime")
                            {
                                DateTime dtValue;
                                if (DateTime.TryParse(s, out dtValue))
                                {
                                    TimeSpan ts = dtValue.ToUniversalTime() - new DateTime(1970, 1, 1);
                                    jrow.Add(new JProperty(si.HeaderEN[i].Replace("!", ""), ts.TotalSeconds));
                                }
                                else
                                {
                                    throw new Exception(string.Format("Excel {0}, Sheet {1}, 第 {2} 行, {3} 列数据类型错误不为datetime,值为{4}", Path.GetFileName(fi.FilePath), si.SheetName, rowIndex, si.HeaderEN[i], s));
                                }
                            }
                            else if (role.ToLower() == "double" || role.ToLower() == "float")
                            {
                                double doubleValue;
                                if (s == "")
                                {
                                    jrow.Add(new JProperty(si.HeaderEN[i].Replace("!", ""), 0));
                                }
                                else if (double.TryParse(s, out doubleValue))
                                {
                                    string strdoubleValue = (Math.Floor(doubleValue * 10000) / 10000).ToString();
                                    jrow.Add(new JProperty(si.HeaderEN[i].Replace("!", ""), doubleValue));
                                }
                                else
                                {
                                    throw new Exception(string.Format("Excel {0}, Sheet {1}, 第 {2} 行, {3} 列数据类型错误,不为int, 值为{4}", Path.GetFileName(fi.FilePath), si.SheetName, rowIndex, si.HeaderEN[i], s));
                                }
                            }
                            else if (role.ToLower() == "string")
                            {
                                jrow.Add(new JProperty(si.HeaderEN[i].Replace("!", ""), s.Replace("\n", "\\n")));
                            }
                            else
                            {
                                int intValue;
                                if (s == "")
                                {
                                    jrow.Add(new JProperty(si.HeaderEN[i].Replace("!", ""), 0));
                                }
                                else if (int.TryParse(s, out intValue))
                                {
                                    jrow.Add(new JProperty(si.HeaderEN[i].Replace("!", ""), intValue));
                                }
                                else
                                {
                                    throw new Exception(string.Format("Excel {0}, Sheet {1}, 第 {2} 行, {3} 列数据类型错误,不为int, 值为{4}", Path.GetFileName(fi.FilePath), si.SheetName, rowIndex, si.HeaderEN[i], s));
                                }
                            }

                        }
                        jarray.Add(jrow);
                    }
                    JProperty jp = new JProperty(si.SheetName, jarray);
                    root.Add(jp);
                    string rootString = root.ToString(Newtonsoft.Json.Formatting.Indented);
                    sw.Write(rootString.Replace("\\\\n", "\\n").Replace("\\\\\\n", "\\n").Replace("\\\\\\\\n", "\\n"));
                    sw.Flush();
                    sw.Close();
                    fs.Close();

                    Console.WriteLine("生成" + si.SheetName + "完毕");
                }
            }
        }

        private static void BuildLua(List<ConfigFileInfo> configFileInfos, string outpath)
        {
            foreach (ConfigFileInfo cfi in configFileInfos)
            {
                foreach (SheetInfo si in cfi.Sheets)
                {
                    List<string> lst = new List<string>();
                    int index = 1;

                    for (int row = 0; row < si.SheetDataTable.Rows.Count; row++)
                    {
                        if (row == 0)
                        {
                            continue;
                        }
                        else
                        {
                            DataRow irow = si.SheetDataTable.Rows[row];
                            string res = "[" + index + "]={";
                            for (int col = 0; col < si.ColumnRole.Count; col++)
                            {
                                object icell = irow[col];
                                if (si.HeaderEN.Count > col)
                                {
                                    if (si.HeaderEN[col].Contains("#"))
                                        continue;

                                    string temp = si.HeaderEN[col].Replace("!", "");

                                    if (si.ColumnRole[col] != "string")
                                    {
                                        if (icell == null || icell.ToString() == "")
                                            res = res + temp + "=0";
                                        else
                                            res = res + temp + "=" + icell.ToString();
                                    }
                                    else if (icell != null)
                                        res = res + temp + "=" + "'" + icell.ToString() + "'" as string;
                                    else
                                        res = res + temp + "=" + "''" as string;

                                    if (col < si.ColumnRole.Count - 1 && col < si.HeaderEN.Count - 1)
                                        res += ",";
                                }
                            }
                            if (row < si.SheetDataTable.Rows.Count - 1)
                                res = res + "},";
                            else
                                res = res + "}";

                            lst.Add(res);
                            index++;
                        }
                    }

                    lst.Insert(0, "local list = {");
                    lst.Add("}");
                    lst.Add("return list");

                    if (!File.Exists(outpath + si.SheetName + ".lua"))
                    {
                        FileStream f = File.Create(outpath + si.SheetName + ".lua");
                        f.Close();
                    }

                    var encoding = new UTF8Encoding(false);
                    File.WriteAllLines(outpath + si.SheetName + ".lua", lst.ToArray(), encoding);

                    Console.WriteLine("生成" + si.SheetName + "完毕");
                }
            }       
        }

        private static void BuildLuaConfigHead(List<ConfigFileInfo> configFileInfos, string outpath)
        {
            List<string> strs = new List<string>();
            foreach (ConfigFileInfo cfi in configFileInfos)
            {
                foreach (SheetInfo si in cfi.Sheets)
                {
                    string str = "";
                    str = str + "getconfig." + si.SheetName + " = require \"supermobs.config."+ si.SheetName + "\"";
                    strs.Add(str);

                    string addstr = "";
                    string keystr = "";

                    for(int i = 0;i < si.mainkey.Count;i++)
                    {
                        if(i < si.mainkey.Count - 1)
                            keystr = keystr + "\"" + si.mainkey[i] + "\",";
                        else
                            keystr = keystr + "\"" + si.mainkey[i] + "\"";
                    }

                    addstr = addstr + "getconfig.addconfig(\"" + si.SheetName + "\"," + keystr + ")";
                    strs.Add(addstr);
                }
            }

            string text = "";

            foreach (string line in strs)
            {
                text += line + "\n";
            }

            text += "getconfig.init()";

            if (!File.Exists(outpath + "confighead.lua"))
            {
                FileStream f = File.Create(outpath + "confighead.lua");
                f.Close();
            }

            var encoding = new UTF8Encoding(false);
            File.WriteAllText(outpath + "confighead.lua", text, encoding);
        }

        private static void BuildLuaFormulaHead(List<ConfigFileInfo> configFileInfos, string outpath)
        {
            List<string> strs = new List<string>();
            foreach (ConfigFileInfo cfi in configFileInfos)
            {
                foreach (SheetInfo si in cfi.Sheets)
                {
                    string strfunname = si.SheetName.ToUpper();
                    string strparam = "";

                    for (int i = 0; i < si.mainkey.Count; i++)
                    {
                        if (i < si.mainkey.Count - 1)
                            strparam = strparam + si.mainkey[i] + ",";
                        else
                            strparam = strparam + si.mainkey[i];
                    }

                    strparam = "(" + strparam + ")";

                    string str = strfunname + " = function" + strparam + " return getconfig.get" + si.SheetName + strparam + " end";
                    strs.Add(str);
                }
            }

            string text = "getconfig._translate =\n{\n";

            for(int i = 0;i < strs.Count;i++)
            {
                if(i < strs.Count - 1)
                    text += strs[i] + ",\n";
                else
                    text += strs[i] + "\n";
            }

            text += "}";

            if (!File.Exists(outpath + "confighead.lua"))
            {
                FileStream f = File.Create(outpath + "confighead.lua");
                f.Close();
            }

            var encoding = new UTF8Encoding(false);
            File.WriteAllText(outpath + "configf.lua", text, encoding);
        }

        static void Main(string[] args)
        {
            string Current;
            Current = Directory.GetCurrentDirectory();
            string[] paths = Directory.GetFiles(Current + "/excel");

            //Console.WriteLine("输入s打包serverconfig，输入c打包clientconfig");
            //char a = Console.ReadKey().KeyChar;

            List<ConfigFileInfo> lst = ConfigFileInfo.GetConfigFileInfoList(paths);

            BuildJson(lst, Current + "/outserver/");
            Console.WriteLine("输出json完毕!");
            BuildGoHead(lst, Current + "/outserver/");
            Console.WriteLine("输出config_data.go完毕");
            BuildLua(lst, Current + "/outclient/");
            Console.WriteLine("输出lua完毕!");
            BuildLuaConfigHead(lst, Current + "/outclient/");
            Console.WriteLine("输出ConfigHead完毕!");
            BuildLuaFormulaHead(lst, Current + "/outclient/");
            Console.WriteLine("输出FormulaHead完毕!");

            BuildBinary(lst, Current + "/outclient/csharp/config/");
            Console.WriteLine("输出binary完毕!");
            BuildCharp(lst, Current + "/outclient/csharp/code/");
            Console.WriteLine("输出csharp完毕!");

            Console.WriteLine("全部导出完毕！");
            Console.ReadKey();
        }
    }
}


