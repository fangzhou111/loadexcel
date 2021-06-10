using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuideData
{
/*唯一编号*/
public int ID; 
/*道具编号*/
public int ItemID; 
/*来源功能*/
public int Function; 
/*功能值*/
public int Value; 
}
public partial class GuideConfig : ConfigBase
{
private static GuideConfig _instance;
public Dictionary<int, Dictionary<int, GuideData>> _datas;
public static GuideConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuideConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Guide.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 82;i++)
{
GuideData data = new GuideData();
data.ID = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.Function = br.ReadInt32();
data.Value = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, GuideData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, GuideData> _dic = new Dictionary<int, GuideData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.ItemID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, GuideData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public GuideData Get(int newID,int newItemID)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newItemID))
return _datas[newID][newItemID];
else
return null;
}
}
}
