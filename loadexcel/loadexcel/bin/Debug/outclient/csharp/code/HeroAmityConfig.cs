using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroAmityData
{
/*主键ID，唯一不可更改*/
public int ID; 
/*英雄ID*/
public int HeroID; 
/*英雄阶数*/
public int HeroStep; 
/*缘分名*/
public string AmityName; 
/*缘分类型*/
public int AmityType; 
/*条件1*/
public int Parameter1; 
/*条件2*/
public int Parameter2; 
/*条件3*/
public int Parameter3; 
/*条件4*/
public int Parameter4; 
/*条件5*/
public int Parameter5; 
/*条件6*/
public int Parameter6; 
/*激活效果*/
public int EffectID; 
/*分组序列*/
public int Order; 
/*生效需要主角考古阶段*/
public int NeedKnowledgeStep; 
}
public partial class HeroAmityConfig : ConfigBase
{
private static HeroAmityConfig _instance;
public Dictionary<int, Dictionary<int, HeroAmityData>> _datas;
public static HeroAmityConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroAmityConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroAmity.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 553;i++)
{
HeroAmityData data = new HeroAmityData();
data.ID = br.ReadInt32();
data.HeroID = br.ReadInt32();
data.HeroStep = br.ReadInt32();
data.AmityName = br.ReadString();
data.AmityType = br.ReadInt32();
data.Parameter1 = br.ReadInt32();
data.Parameter2 = br.ReadInt32();
data.Parameter3 = br.ReadInt32();
data.Parameter4 = br.ReadInt32();
data.Parameter5 = br.ReadInt32();
data.Parameter6 = br.ReadInt32();
data.EffectID = br.ReadInt32();
data.Order = br.ReadInt32();
data.NeedKnowledgeStep = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroAmityData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, HeroAmityData> _dic = new Dictionary<int, HeroAmityData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.HeroID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroAmityData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public HeroAmityData Get(int newID,int newHeroID)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newHeroID))
return _datas[newID][newHeroID];
else
return null;
}
}
}
