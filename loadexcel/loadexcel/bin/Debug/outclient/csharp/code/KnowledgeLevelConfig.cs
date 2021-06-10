using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class KnowledgeLevelData
{
/*阶段*/
public int Step; 
/*等级*/
public int Level; 
/*效果ID*/
public int EffectID; 
/*加成对象*/
public int Type; 
/*需要关卡ID*/
public int CampaignID; 
}
public partial class KnowledgeLevelConfig : ConfigBase
{
private static KnowledgeLevelConfig _instance;
public Dictionary<int, Dictionary<int, KnowledgeLevelData>> _datas;
public static KnowledgeLevelConfig Instance
{
get
{
if (_instance == null)
{
_instance = new KnowledgeLevelConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("KnowledgeLevel.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 110;i++)
{
KnowledgeLevelData data = new KnowledgeLevelData();
data.Step = br.ReadInt32();
data.Level = br.ReadInt32();
data.EffectID = br.ReadInt32();
data.Type = br.ReadInt32();
data.CampaignID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, KnowledgeLevelData>>();
if (!_datas.ContainsKey(data.Step))
{
Dictionary<int, KnowledgeLevelData> _dic = new Dictionary<int, KnowledgeLevelData>();
_datas.Add(data.Step, _dic);
}
_datas[data.Step].Add(data.Level,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, KnowledgeLevelData> Get(int newStep)
{
if (_datas.ContainsKey(newStep))
return _datas[newStep];
else
return null;
}
public KnowledgeLevelData Get(int newStep,int newLevel)
{
if (_datas.ContainsKey(newStep) && _datas[newStep].ContainsKey(newLevel))
return _datas[newStep][newLevel];
else
return null;
}
}
}
