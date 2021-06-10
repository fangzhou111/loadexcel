using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PrisonData
{
/*层数*/
public int PrisonLevel; 
/*星级*/
public int PrisonStar; 
/*刷星价格*/
public int StarUp; 
/*直接5星概率*/
public int StarUpProbability; 
/*怪物等级*/
public int PrisonDifficulty; 
/*奖励ID*/
public int PrisonRewardID; 
}
public partial class PrisonConfig : ConfigBase
{
private static PrisonConfig _instance;
public Dictionary<int, Dictionary<int, PrisonData>> _datas;
public static PrisonConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PrisonConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Prison.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 25;i++)
{
PrisonData data = new PrisonData();
data.PrisonLevel = br.ReadInt32();
data.PrisonStar = br.ReadInt32();
data.StarUp = br.ReadInt32();
data.StarUpProbability = br.ReadInt32();
data.PrisonDifficulty = br.ReadInt32();
data.PrisonRewardID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, PrisonData>>();
if (!_datas.ContainsKey(data.PrisonLevel))
{
Dictionary<int, PrisonData> _dic = new Dictionary<int, PrisonData>();
_datas.Add(data.PrisonLevel, _dic);
}
_datas[data.PrisonLevel].Add(data.PrisonStar,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, PrisonData> Get(int newPrisonLevel)
{
if (_datas.ContainsKey(newPrisonLevel))
return _datas[newPrisonLevel];
else
return null;
}
public PrisonData Get(int newPrisonLevel,int newPrisonStar)
{
if (_datas.ContainsKey(newPrisonLevel) && _datas[newPrisonLevel].ContainsKey(newPrisonStar))
return _datas[newPrisonLevel][newPrisonStar];
else
return null;
}
}
}
