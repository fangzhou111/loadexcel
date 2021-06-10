using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroTalentCostData
{
/*阶段*/
public int TalentStep; 
/*等级*/
public int TalentLevel; 
/*消耗道具数量*/
public int NeedItemID; 
/*消耗道具数量*/
public int NeedNum; 
/*成功率(万分比）*/
public int Probability; 
}
public partial class HeroTalentCostConfig : ConfigBase
{
private static HeroTalentCostConfig _instance;
public Dictionary<int, Dictionary<int, HeroTalentCostData>> _datas;
public static HeroTalentCostConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroTalentCostConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroTalentCost.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 408;i++)
{
HeroTalentCostData data = new HeroTalentCostData();
data.TalentStep = br.ReadInt32();
data.TalentLevel = br.ReadInt32();
data.NeedItemID = br.ReadInt32();
data.NeedNum = br.ReadInt32();
data.Probability = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroTalentCostData>>();
if (!_datas.ContainsKey(data.TalentStep))
{
Dictionary<int, HeroTalentCostData> _dic = new Dictionary<int, HeroTalentCostData>();
_datas.Add(data.TalentStep, _dic);
}
_datas[data.TalentStep].Add(data.TalentLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroTalentCostData> Get(int newTalentStep)
{
if (_datas.ContainsKey(newTalentStep))
return _datas[newTalentStep];
else
return null;
}
public HeroTalentCostData Get(int newTalentStep,int newTalentLevel)
{
if (_datas.ContainsKey(newTalentStep) && _datas[newTalentStep].ContainsKey(newTalentLevel))
return _datas[newTalentStep][newTalentLevel];
else
return null;
}
}
}
