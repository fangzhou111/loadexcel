using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ResolvePetData
{
/*宠物类型
1整体2碎片*/
public int Type; 
/*装等*/
public int StarStrength; 
/*回收道具*/
public int ResolveID; 
/*回收数量*/
public int ResolveNum; 
}
public partial class ResolvePetConfig : ConfigBase
{
private static ResolvePetConfig _instance;
public Dictionary<int, Dictionary<int, ResolvePetData>> _datas;
public static ResolvePetConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ResolvePetConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ResolvePet.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
ResolvePetData data = new ResolvePetData();
data.Type = br.ReadInt32();
data.StarStrength = br.ReadInt32();
data.ResolveID = br.ReadInt32();
data.ResolveNum = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, ResolvePetData>>();
if (!_datas.ContainsKey(data.Type))
{
Dictionary<int, ResolvePetData> _dic = new Dictionary<int, ResolvePetData>();
_datas.Add(data.Type, _dic);
}
_datas[data.Type].Add(data.StarStrength,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ResolvePetData> Get(int newType)
{
if (_datas.ContainsKey(newType))
return _datas[newType];
else
return null;
}
public ResolvePetData Get(int newType,int newStarStrength)
{
if (_datas.ContainsKey(newType) && _datas[newType].ContainsKey(newStarStrength))
return _datas[newType][newStarStrength];
else
return null;
}
}
}
