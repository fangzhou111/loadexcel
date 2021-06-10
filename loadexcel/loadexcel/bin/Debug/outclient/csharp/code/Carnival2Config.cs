using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Carnival2Data
{
/*开服第几天*/
public int OpenDay; 
/*分页名称*/
public string PageName; 
}
public partial class Carnival2Config : ConfigBase
{
private static Carnival2Config _instance;
public Dictionary<int, Carnival2Data> _datas;
public static Carnival2Config Instance
{
get
{
if (_instance == null)
{
_instance = new Carnival2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Carnival2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 7;i++)
{
Carnival2Data data = new Carnival2Data();
data.OpenDay = br.ReadInt32();
data.PageName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Carnival2Data>();
_datas.Add(data.OpenDay,data);
}
br.Close();
fs.Close();
}
public Carnival2Data Get(int newOpenDay)
{
if (_datas.ContainsKey(newOpenDay))
return _datas[newOpenDay];
else
return null;
}
}
}
