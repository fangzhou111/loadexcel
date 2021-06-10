using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BattleEffectivenessData
{
/*主键ID，指代职业*/
public int ID; 
/*物攻系数*/
public double PhysicsAtkPoint; 
/*魔攻系数*/
public double MagicAtkPoint; 
/*物防系数*/
public double PhysicsDefPoint; 
/*魔防系数*/
public double MagicDefPoint; 
/*血量系数*/
public double HPPoint; 
/*命中系数*/
public double HitRatePoint; 
/*闪避系数*/
public double DodgeRatePoint; 
/*暴击系数*/
public double CritRatePoint; 
/*韧性系数*/
public double ToughnessPoint; 
/*招架系数*/
public double ParryRatePoint; 
/*精准系数*/
public double PrecisionRatePoint; 
/*灼烧增加基础*/
public double FireUpPoint; 
/*毒伤增加基础*/
public double PoisonUpPoint; 
/*最终增伤基础*/
public double DamageUpPoint; 
/*灼烧降低基础*/
public double FireDownPoint; 
/*毒伤降低基础*/
public double PoisonDownPoint; 
/*最终增伤降低*/
public double DamageDownPoint; 
/*治疗量增加*/
public double HealthUpPoint; 
/*被治疗量增加*/
public double BecuredPoint; 
}
public partial class BattleEffectivenessConfig : ConfigBase
{
private static BattleEffectivenessConfig _instance;
public Dictionary<int, BattleEffectivenessData> _datas;
public static BattleEffectivenessConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BattleEffectivenessConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BattleEffectiveness.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
BattleEffectivenessData data = new BattleEffectivenessData();
data.ID = br.ReadInt32();
data.PhysicsAtkPoint = (float)br.ReadDouble();
data.MagicAtkPoint = (float)br.ReadDouble();
data.PhysicsDefPoint = (float)br.ReadDouble();
data.MagicDefPoint = (float)br.ReadDouble();
data.HPPoint = (float)br.ReadDouble();
data.HitRatePoint = (float)br.ReadDouble();
data.DodgeRatePoint = (float)br.ReadDouble();
data.CritRatePoint = (float)br.ReadDouble();
data.ToughnessPoint = (float)br.ReadDouble();
data.ParryRatePoint = (float)br.ReadDouble();
data.PrecisionRatePoint = (float)br.ReadDouble();
data.FireUpPoint = (float)br.ReadDouble();
data.PoisonUpPoint = (float)br.ReadDouble();
data.DamageUpPoint = (float)br.ReadDouble();
data.FireDownPoint = (float)br.ReadDouble();
data.PoisonDownPoint = (float)br.ReadDouble();
data.DamageDownPoint = (float)br.ReadDouble();
data.HealthUpPoint = (float)br.ReadDouble();
data.BecuredPoint = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, BattleEffectivenessData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public BattleEffectivenessData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
