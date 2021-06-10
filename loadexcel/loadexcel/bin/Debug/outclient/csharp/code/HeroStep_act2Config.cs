using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroStep_act2Data
{
/*Id*/
public int ID; 
/*资质*/
public int HeroStarStrength; 
/*下一资质*/
public int NextStarStrength; 
/*当前阶颜色*/
public int StepColor; 
/*阶数*/
public int Step; 
/*物攻*/
public double PhysicsAtk; 
/*魔攻*/
public double MagicAtk; 
/*物防*/
public double PhysicsDef; 
/*魔防*/
public double MagicDef; 
/*血量*/
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
/*物攻增量*/
public double PhysicsAtkInc; 
/*魔攻增量*/
public double MagicAtkInc; 
/*物防增量*/
public double PhysicsDefInc; 
/*魔防增量*/
public double MagicDefInc; 
/*血量增量*/
public double HPInc; 
/*命中增量*/
public double HitRateInc; 
/*闪避增量*/
public double DodgeRateInc; 
/*暴击增量*/
public double CritRateInc; 
/*韧性增量*/
public double ToughnessInc; 
/*招架增量*/
public double ParryRateInc; 
/*精准增量*/
public double PrecisionRateInc; 
/*普通攻击获取怒气（单位：次）*/
public int RagePointDamage; 
/*血量耗尽后可获得怒气（单位：100%血量）*/
public int RagePointByDamage; 
/*受击获取怒气值*/
public int RagePointHurt; 
/*怒气最大值*/
public int RagePointMax; 
/*阶级系数（技能用）*/
public double SkillStep; 
/*进阶所需等级下限*/
public int NeedLevel; 
/*携带技能*/
public string SkillIDs; 
/*被吞噬消耗金钱*/
public int NeedGold; 
/*进阶消耗金钱*/
public int StepNeedGold; 
/*物品1ID*/
public int Item1ID; 
/*物品1数量*/
public int Item1Num; 
/*物品2ID*/
public int Item2ID; 
/*物品2数量*/
public int Item2Num; 
/*物品3ID*/
public int Item3ID; 
/*物品3数量*/
public int Item3Num; 
/*物品4ID*/
public int Item4ID; 
/*物品4数量*/
public int Item4Num; 
/*物品5ID*/
public int Item5ID; 
/*物品5数量*/
public int Item5Num; 
/*物品6ID*/
public int Item6ID; 
/*物品6数量*/
public int Item6Num; 
/*英雄分解返还系数*/
public int ResolveStep; 
}
public partial class HeroStep_act2Config : ConfigBase
{
private static HeroStep_act2Config _instance;
public Dictionary<int, Dictionary<int, HeroStep_act2Data>> _datas;
public static HeroStep_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new HeroStep_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroStep_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4560;i++)
{
HeroStep_act2Data data = new HeroStep_act2Data();
data.ID = br.ReadInt32();
data.HeroStarStrength = br.ReadInt32();
data.NextStarStrength = br.ReadInt32();
data.StepColor = br.ReadInt32();
data.Step = br.ReadInt32();
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
data.PhysicsAtkInc = (float)br.ReadDouble();
data.MagicAtkInc = (float)br.ReadDouble();
data.PhysicsDefInc = (float)br.ReadDouble();
data.MagicDefInc = (float)br.ReadDouble();
data.HPInc = (float)br.ReadDouble();
data.HitRateInc = (float)br.ReadDouble();
data.DodgeRateInc = (float)br.ReadDouble();
data.CritRateInc = (float)br.ReadDouble();
data.ToughnessInc = (float)br.ReadDouble();
data.ParryRateInc = (float)br.ReadDouble();
data.PrecisionRateInc = (float)br.ReadDouble();
data.RagePointDamage = br.ReadInt32();
data.RagePointByDamage = br.ReadInt32();
data.RagePointHurt = br.ReadInt32();
data.RagePointMax = br.ReadInt32();
data.SkillStep = (float)br.ReadDouble();
data.NeedLevel = br.ReadInt32();
data.SkillIDs = br.ReadString();
data.NeedGold = br.ReadInt32();
data.StepNeedGold = br.ReadInt32();
data.Item1ID = br.ReadInt32();
data.Item1Num = br.ReadInt32();
data.Item2ID = br.ReadInt32();
data.Item2Num = br.ReadInt32();
data.Item3ID = br.ReadInt32();
data.Item3Num = br.ReadInt32();
data.Item4ID = br.ReadInt32();
data.Item4Num = br.ReadInt32();
data.Item5ID = br.ReadInt32();
data.Item5Num = br.ReadInt32();
data.Item6ID = br.ReadInt32();
data.Item6Num = br.ReadInt32();
data.ResolveStep = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroStep_act2Data>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, HeroStep_act2Data> _dic = new Dictionary<int, HeroStep_act2Data>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.Step,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroStep_act2Data> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public HeroStep_act2Data Get(int newID,int newStep)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newStep))
return _datas[newID][newStep];
else
return null;
}
}
}
