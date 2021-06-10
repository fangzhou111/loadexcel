using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PetBaseData
{
/*符文ID*/
public int ID; 
/*宠物模型*/
public string Model; 
/*宠物资质*/
public int GS; 
/*品质*/
public int Quality; 
/*宠物升星上限*/
public int RunesAwake; 
/*物攻基础*/
public double PhysicsAtk; 
/*魔攻基础*/
public double MagicAtk; 
/*物防基础*/
public double PhysicsDef; 
/*魔防基础*/
public double MagicDef; 
/*血量基础*/
public double HP; 
/*命中基础*/
public double HitRate; 
/*闪避基础*/
public double DodgeRate; 
/*暴击基础*/
public double CritRate; 
/*韧性基础*/
public double Toughness; 
/*招架基础*/
public double ParryRate; 
/*精准基础*/
public double PrecisionRate; 
/*灼烧增加基础*/
public double FireUp; 
/*毒伤增加基础*/
public double PoisonUp; 
/*最终增伤基础*/
public double DamageUp; 
/*治疗量增加基础*/
public double HealthUp; 
/*灼烧降低基础*/
public double FireDown; 
/*毒伤降低基础*/
public double PoisonDown; 
/*最终伤害降低*/
public double DamageDown; 
/*被治疗提升基础*/
public double Becured; 
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
/*治疗量提升增量*/
public double HealthUpInc; 
/*灼烧降低基础*/
public double FireDownInc; 
/*毒伤降低基础*/
public double PoisonDownInc; 
/*最终伤害降低*/
public double DamageDownInc; 
/*被治疗提升增量*/
public double BecuredInc; 
}
public partial class PetBaseConfig : ConfigBase
{
private static PetBaseConfig _instance;
public Dictionary<int, PetBaseData> _datas;
public static PetBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PetBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PetBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 17;i++)
{
PetBaseData data = new PetBaseData();
data.ID = br.ReadInt32();
data.Model = br.ReadString();
data.GS = br.ReadInt32();
data.Quality = br.ReadInt32();
data.RunesAwake = br.ReadInt32();
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
data.FireUp = (float)br.ReadDouble();
data.PoisonUp = (float)br.ReadDouble();
data.DamageUp = (float)br.ReadDouble();
data.HealthUp = (float)br.ReadDouble();
data.FireDown = (float)br.ReadDouble();
data.PoisonDown = (float)br.ReadDouble();
data.DamageDown = (float)br.ReadDouble();
data.Becured = (float)br.ReadDouble();
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
_datas = new Dictionary<int, PetBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public PetBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
