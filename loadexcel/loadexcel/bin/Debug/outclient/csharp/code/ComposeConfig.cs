using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ComposeData
{
/*合成ID*/
public int ID; 
/*新物品ID*/
public int NewMaterial1; 
/*合成名字*/
public string Name; 
/*合成描述*/
public string Desc; 
/*合成类型*/
public int Type; 
/*物品1ID*/
public int Material1; 
/*物品1数量*/
public int Count1; 
/*物品2ID*/
public int Material2; 
/*物品2数量*/
public int Count2; 
/*物品3ID*/
public int Material3; 
/*物品3数量*/
public int Count3; 
/*物品4ID*/
public int Material4; 
/*物品4数量*/
public int Count4; 
/*物品5ID*/
public int Material5; 
/*物品5数量*/
public int Count5; 
/*物品6ID*/
public int Material6; 
/*物品6数量*/
public int Count6; 
/*合成消耗金币*/
public int NeedGold; 
}
public partial class ComposeConfig : ConfigBase
{
private static ComposeConfig _instance;
public Dictionary<int, Dictionary<int, ComposeData>> _datas;
public static ComposeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ComposeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Compose.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 56;i++)
{
ComposeData data = new ComposeData();
data.ID = br.ReadInt32();
data.NewMaterial1 = br.ReadInt32();
data.Name = br.ReadString();
data.Desc = br.ReadString();
data.Type = br.ReadInt32();
data.Material1 = br.ReadInt32();
data.Count1 = br.ReadInt32();
data.Material2 = br.ReadInt32();
data.Count2 = br.ReadInt32();
data.Material3 = br.ReadInt32();
data.Count3 = br.ReadInt32();
data.Material4 = br.ReadInt32();
data.Count4 = br.ReadInt32();
data.Material5 = br.ReadInt32();
data.Count5 = br.ReadInt32();
data.Material6 = br.ReadInt32();
data.Count6 = br.ReadInt32();
data.NeedGold = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, ComposeData>>();
if (!_datas.ContainsKey(data.Type))
{
Dictionary<int, ComposeData> _dic = new Dictionary<int, ComposeData>();
_datas.Add(data.Type, _dic);
}
_datas[data.Type].Add(data.Material1,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ComposeData> Get(int newType)
{
if (_datas.ContainsKey(newType))
return _datas[newType];
else
return null;
}
public ComposeData Get(int newType,int newMaterial1)
{
if (_datas.ContainsKey(newType) && _datas[newType].ContainsKey(newMaterial1))
return _datas[newType][newMaterial1];
else
return null;
}
}
}
