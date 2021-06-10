using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CarnivalOpenDayData
{
/*开服第几天*/
public int OpenDay; 
/*功能id*/
public int FunctionId; 
/*#功能名称*/
public string FunctionName; 
}
public partial class CarnivalOpenDayConfig : ConfigBase
{
private static CarnivalOpenDayConfig _instance;
public Dictionary<int, CarnivalOpenDayData> _datas;
public static CarnivalOpenDayConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CarnivalOpenDayConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CarnivalOpenDay.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 6;i++)
{
CarnivalOpenDayData data = new CarnivalOpenDayData();
data.OpenDay = br.ReadInt32();
data.FunctionId = br.ReadInt32();
data.FunctionName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, CarnivalOpenDayData>();
_datas.Add(data.OpenDay,data);
}
br.Close();
fs.Close();
}
public CarnivalOpenDayData Get(int newOpenDay)
{
if (_datas.ContainsKey(newOpenDay))
return _datas[newOpenDay];
else
return null;
}
}
}
