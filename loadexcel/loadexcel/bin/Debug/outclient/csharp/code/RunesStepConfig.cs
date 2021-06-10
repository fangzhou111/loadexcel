using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RunesStepData
{
/*雕文编号*/
public int ID; 
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
/*灼烧增加基础*/
public double FireUpInc; 
/*毒伤增加基础*/
public double PoisonUpInc; 
/*最终增伤基础*/
public double DamageUpInc; 
/*治疗量提升基础*/
public double HealthUpInc; 
/*灼烧降低基础*/
public double FireDownInc; 
/*毒伤降低基础*/
public double PoisonDownInc; 
/*最终增伤降低*/
public double DamageDownInc; 
/*被治疗基础*/
public double BecuredInc; 
/*物攻万分比增量
万分比加成，后面也一样*/
public double PhysicsAtkRatioInc; 
/*魔攻万分比增量*/
public double MagicAtkRatioInc; 
/*物防万分比增量*/
public double PhysicsDefRatioInc; 
/*魔防万分比增量*/
public double MagicDefRatioInc; 
/*血量万分比增量*/
public double HPRatioInc; 
/*命中万分比增量*/
public double HitRateRatioInc; 
/*闪避万分比增量*/
public double DodgeRateRatioInc; 
/*暴击万分比增量*/
public double CritRateRatioInc; 
/*韧性万分比增量*/
public double ToughnessRatioInc; 
/*招架万分比增量*/
public double ParryRateRatioInc; 
/*精准万分比增量*/
public double PrecisionRateRatioInc; 
/*灼烧增加万分比*/
public double FireUpRatioInc; 
/*毒伤增加万分比*/
public double PoisonUpRatioInc; 
/*最终增伤万分比*/
public double DamageUpRatioInc; 
/*治疗量提升万分比*/
public double HealthUpRatioInc; 
/*灼烧降低万分比*/
public double FireDownRatioInc; 
/*毒伤降低万分比*/
public double PoisonDownRatioInc; 
/*最终伤害降低万分比*/
public double DamageDownRatioInc; 
/*被治疗量提升*/
public double BecuredRatioInc; 
}
public partial class RunesStepConfig : ConfigBase
{
private static RunesStepConfig _instance;
public Dictionary<int, RunesStepData> _datas;
public static RunesStepConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RunesStepConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RunesStep.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 13;i++)
{
RunesStepData data = new RunesStepData();
data.ID = br.ReadInt32();
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
data.FireUpInc = (float)br.ReadDouble();
data.PoisonUpInc = (float)br.ReadDouble();
data.DamageUpInc = (float)br.ReadDouble();
data.HealthUpInc = (float)br.ReadDouble();
data.FireDownInc = (float)br.ReadDouble();
data.PoisonDownInc = (float)br.ReadDouble();
data.DamageDownInc = (float)br.ReadDouble();
data.BecuredInc = (float)br.ReadDouble();
data.PhysicsAtkRatioInc = (float)br.ReadDouble();
data.MagicAtkRatioInc = (float)br.ReadDouble();
data.PhysicsDefRatioInc = (float)br.ReadDouble();
data.MagicDefRatioInc = (float)br.ReadDouble();
data.HPRatioInc = (float)br.ReadDouble();
data.HitRateRatioInc = (float)br.ReadDouble();
data.DodgeRateRatioInc = (float)br.ReadDouble();
data.CritRateRatioInc = (float)br.ReadDouble();
data.ToughnessRatioInc = (float)br.ReadDouble();
data.ParryRateRatioInc = (float)br.ReadDouble();
data.PrecisionRateRatioInc = (float)br.ReadDouble();
data.FireUpRatioInc = (float)br.ReadDouble();
data.PoisonUpRatioInc = (float)br.ReadDouble();
data.DamageUpRatioInc = (float)br.ReadDouble();
data.HealthUpRatioInc = (float)br.ReadDouble();
data.FireDownRatioInc = (float)br.ReadDouble();
data.PoisonDownRatioInc = (float)br.ReadDouble();
data.DamageDownRatioInc = (float)br.ReadDouble();
data.BecuredRatioInc = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, RunesStepData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public RunesStepData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
