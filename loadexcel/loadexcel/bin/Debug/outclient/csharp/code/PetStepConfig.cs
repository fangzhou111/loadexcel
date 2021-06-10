using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PetStepData
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
}
public partial class PetStepConfig : ConfigBase
{
private static PetStepConfig _instance;
public Dictionary<int, PetStepData> _datas;
public static PetStepConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PetStepConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PetStep.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 15;i++)
{
PetStepData data = new PetStepData();
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
if (_datas == null)
_datas = new Dictionary<int, PetStepData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public PetStepData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
