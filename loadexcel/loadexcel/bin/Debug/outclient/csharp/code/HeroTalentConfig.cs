using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroTalentData
{
/*职业*/
public int HeroJob; 
/*等级*/
public int TalentLevel; 
/*物攻*/
public double PhysicsAtk; 
/*魔攻*/
public double MagicAtk; 
/*物防*/
public double PhysicsDef; 
/*法防*/
public double MagicDef; 
/*生命*/
public double HP; 
/*命中*/
public double HitRate; 
/*闪避*/
public double DodgeRate; 
/*暴击*/
public double CritRate; 
/*韧性*/
public double Toughness; 
/*招架*/
public double ParryRate; 
/*精准*/
public double PrecisionRate; 
/*基础属性加成(百分比)*/
public double AllRatio; 
}
public partial class HeroTalentConfig : ConfigBase
{
private static HeroTalentConfig _instance;
public Dictionary<int, Dictionary<int, HeroTalentData>> _datas;
public static HeroTalentConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroTalentConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroTalent.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 32;i++)
{
HeroTalentData data = new HeroTalentData();
data.HeroJob = br.ReadInt32();
data.TalentLevel = br.ReadInt32();
data.PhysicsAtk = (float)br.ReadDouble();
data.MagicAtk = (float)br.ReadDouble();
data.PhysicsDef = (float)br.ReadDouble();
data.MagicDef = (float)br.ReadDouble();
data.HP = (float)br.ReadDouble();
data.HitRate = (float)br.ReadDouble();
data.DodgeRate = (float)br.ReadDouble();
data.CritRate = (float)br.ReadDouble();
data.Toughness = (float)br.ReadDouble();
data.ParryRate = (float)br.ReadDouble();
data.PrecisionRate = (float)br.ReadDouble();
data.AllRatio = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroTalentData>>();
if (!_datas.ContainsKey(data.HeroJob))
{
Dictionary<int, HeroTalentData> _dic = new Dictionary<int, HeroTalentData>();
_datas.Add(data.HeroJob, _dic);
}
_datas[data.HeroJob].Add(data.TalentLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroTalentData> Get(int newHeroJob)
{
if (_datas.ContainsKey(newHeroJob))
return _datas[newHeroJob];
else
return null;
}
public HeroTalentData Get(int newHeroJob,int newTalentLevel)
{
if (_datas.ContainsKey(newHeroJob) && _datas[newHeroJob].ContainsKey(newTalentLevel))
return _datas[newHeroJob][newTalentLevel];
else
return null;
}
}
}
