using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ResolveRunesData
{
/*装等*/
public int StarStrength; 
/*回收道具*/
public int ResolveID; 
/*回收数量*/
public int ResolveNum; 
}
public partial class ResolveRunesConfig : ConfigBase
{
private static ResolveRunesConfig _instance;
public Dictionary<int, Dictionary<int, ResolveRunesData>> _datas;
public static ResolveRunesConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ResolveRunesConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ResolveRunes.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1;i++)
{
ResolveRunesData data = new ResolveRunesData();
data.StarStrength = br.ReadInt32();
data.ResolveID = br.ReadInt32();
data.ResolveNum = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, ResolveRunesData>>();
if (!_datas.ContainsKey(data.StarStrength))
{
Dictionary<int, ResolveRunesData> _dic = new Dictionary<int, ResolveRunesData>();
_datas.Add(data.StarStrength, _dic);
}
_datas[data.StarStrength].Add(data.ResolveID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ResolveRunesData> Get(int newStarStrength)
{
if (_datas.ContainsKey(newStarStrength))
return _datas[newStarStrength];
else
return null;
}
public ResolveRunesData Get(int newStarStrength,int newResolveID)
{
if (_datas.ContainsKey(newStarStrength) && _datas[newStarStrength].ContainsKey(newResolveID))
return _datas[newStarStrength][newResolveID];
else
return null;
}
}
}
