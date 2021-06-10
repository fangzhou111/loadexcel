using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class dailyData
{
/*编号*/
public int Index; 
/*功能名称*/
public string Name; 
/*功能编号*/
public int FuncID; 
/*功能跳转*/
public int ModuleParameter; 
/*功能图标*/
public string Icon; 
/*功能产出*/
public string Des; 
/*未开启*/
public string NotOpen; 
/*描述1*/
public string ProDesc1; 
/*描述2*/
public string ProDesc2; 
/*描述2*/
public string ProDesc3; 
/*任务结束*/
public string Over; 
}
public partial class dailyConfig : ConfigBase
{
private static dailyConfig _instance;
public Dictionary<int, Dictionary<int, dailyData>> _datas;
public static dailyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new dailyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("daily.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 23;i++)
{
dailyData data = new dailyData();
data.Index = br.ReadInt32();
data.Name = br.ReadString();
data.FuncID = br.ReadInt32();
data.ModuleParameter = br.ReadInt32();
data.Icon = br.ReadString();
data.Des = br.ReadString();
data.NotOpen = br.ReadString();
data.ProDesc1 = br.ReadString();
data.ProDesc2 = br.ReadString();
data.ProDesc3 = br.ReadString();
data.Over = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, dailyData>>();
if (!_datas.ContainsKey(data.FuncID))
{
Dictionary<int, dailyData> _dic = new Dictionary<int, dailyData>();
_datas.Add(data.FuncID, _dic);
}
_datas[data.FuncID].Add(data.ModuleParameter,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, dailyData> Get(int newFuncID)
{
if (_datas.ContainsKey(newFuncID))
return _datas[newFuncID];
else
return null;
}
public dailyData Get(int newFuncID,int newModuleParameter)
{
if (_datas.ContainsKey(newFuncID) && _datas[newFuncID].ContainsKey(newModuleParameter))
return _datas[newFuncID][newModuleParameter];
else
return null;
}
}
}
