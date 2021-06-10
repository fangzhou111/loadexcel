using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RunesNameData
{
/*套装ID*/
public int SuitID; 
/*套装名称*/
public string SuitName; 
/*符文部位*/
public int RunesPart; 
/*符文名字*/
public string Name; 
/*符文说明*/
public string Text; 
/*符文图标*/
public int icon; 
}
public partial class RunesNameConfig : ConfigBase
{
private static RunesNameConfig _instance;
public Dictionary<int, Dictionary<int, RunesNameData>> _datas;
public static RunesNameConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RunesNameConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RunesName.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 72;i++)
{
RunesNameData data = new RunesNameData();
data.SuitID = br.ReadInt32();
data.SuitName = br.ReadString();
data.RunesPart = br.ReadInt32();
data.Name = br.ReadString();
data.Text = br.ReadString();
data.icon = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, RunesNameData>>();
if (!_datas.ContainsKey(data.SuitID))
{
Dictionary<int, RunesNameData> _dic = new Dictionary<int, RunesNameData>();
_datas.Add(data.SuitID, _dic);
}
_datas[data.SuitID].Add(data.RunesPart,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, RunesNameData> Get(int newSuitID)
{
if (_datas.ContainsKey(newSuitID))
return _datas[newSuitID];
else
return null;
}
public RunesNameData Get(int newSuitID,int newRunesPart)
{
if (_datas.ContainsKey(newSuitID) && _datas[newSuitID].ContainsKey(newRunesPart))
return _datas[newSuitID][newRunesPart];
else
return null;
}
}
}
