using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentEnchantData
{
/*主键，唯一ID*/
public int ID; 
/*附魔等级*/
public int ExchantLevel; 
/*装备装等*/
public int GS; 
/*装备类型*/
public int EquipmentType; 
/*物攻最小值*/
public int PhysicsAtkMIN; 
/*物攻最大值*/
public int PhysicsAtkMAX; 
/*魔攻最小值*/
public int MagicAtkMIN; 
/*魔攻最大值*/
public int MagicAtkMAX; 
/*物防最小值*/
public int PhysicsDefMIN; 
/*物防最大值*/
public int PhysicsDefMAX; 
/*魔防最小值*/
public int MagicDefMIN; 
/*魔防最大值*/
public int MagicDefMAX; 
/*血量最小值*/
public int HPMIN; 
/*血量最大值*/
public int HPMAX; 
/*命中最小值*/
public int HitRateMIN; 
/*命中最大值*/
public int HitRateMAX; 
/*闪避最小值*/
public int DodgeRateMIN; 
/*闪避最小值*/
public int DodgeRateMAX; 
/*暴击最小值*/
public int CritRateMIN; 
/*暴击最大值*/
public int CritRateMAX; 
/*韧性最小值*/
public int ToughnessMIN; 
/*韧性最打值*/
public int ToughnessMAX; 
/*招架最小值*/
public int ParryRateMIN; 
/*招架最大值*/
public int ParryRateMAX; 
/*精准最小值*/
public int PrecisionRateMIN; 
/*精准最大值*/
public int PrecisionRateMAX; 
/*灼烧增加最小值*/
public int FireUpMIN; 
/*灼烧增加最大值*/
public int FireUpMAX; 
/*毒伤增加最小值*/
public int PoisonUpMIN; 
/*毒伤增加最大值*/
public int PoisonUpMAX; 
/*最终增伤最小值*/
public int DamageUpMIN; 
/*最终增伤最大值*/
public int DamageUpMAX; 
/*治疗量增加最小值*/
public int HealthUpMIN; 
/*治疗量增加最大值*/
public int HealthUpMAX; 
/*灼烧降低最小*/
public int FireDownMIN; 
/*灼烧降低最大*/
public int FireDownMAX; 
/*毒伤降低最小*/
public int PoisonDownMIN; 
/*毒伤降低最大*/
public int PoisonDownMAX; 
/*最终减伤最小*/
public int DamageDownMIN; 
/*最终减伤最大*/
public int DamageDownMAX; 
/*被治疗提升最小*/
public int BecuredMIN; 
/*被治疗提升最大*/
public int BecuredMAX; 
}
public partial class EquipmentEnchantConfig : ConfigBase
{
private static EquipmentEnchantConfig _instance;
public Dictionary<int, Dictionary<int, Dictionary<int, EquipmentEnchantData>>> _datas;
public static EquipmentEnchantConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentEnchantConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentEnchant.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 64;i++)
{
EquipmentEnchantData data = new EquipmentEnchantData();
data.ID = br.ReadInt32();
data.ExchantLevel = br.ReadInt32();
data.GS = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
data.PhysicsAtkMIN = br.ReadInt32();
data.PhysicsAtkMAX = br.ReadInt32();
data.MagicAtkMIN = br.ReadInt32();
data.MagicAtkMAX = br.ReadInt32();
data.PhysicsDefMIN = br.ReadInt32();
data.PhysicsDefMAX = br.ReadInt32();
data.MagicDefMIN = br.ReadInt32();
data.MagicDefMAX = br.ReadInt32();
data.HPMIN = br.ReadInt32();
data.HPMAX = br.ReadInt32();
data.HitRateMIN = br.ReadInt32();
data.HitRateMAX = br.ReadInt32();
data.DodgeRateMIN = br.ReadInt32();
data.DodgeRateMAX = br.ReadInt32();
data.CritRateMIN = br.ReadInt32();
data.CritRateMAX = br.ReadInt32();
data.ToughnessMIN = br.ReadInt32();
data.ToughnessMAX = br.ReadInt32();
data.ParryRateMIN = br.ReadInt32();
data.ParryRateMAX = br.ReadInt32();
data.PrecisionRateMIN = br.ReadInt32();
data.PrecisionRateMAX = br.ReadInt32();
data.FireUpMIN = br.ReadInt32();
data.FireUpMAX = br.ReadInt32();
data.PoisonUpMIN = br.ReadInt32();
data.PoisonUpMAX = br.ReadInt32();
data.DamageUpMIN = br.ReadInt32();
data.DamageUpMAX = br.ReadInt32();
data.HealthUpMIN = br.ReadInt32();
data.HealthUpMAX = br.ReadInt32();
data.FireDownMIN = br.ReadInt32();
data.FireDownMAX = br.ReadInt32();
data.PoisonDownMIN = br.ReadInt32();
data.PoisonDownMAX = br.ReadInt32();
data.DamageDownMIN = br.ReadInt32();
data.DamageDownMAX = br.ReadInt32();
data.BecuredMIN = br.ReadInt32();
data.BecuredMAX = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, Dictionary<int, EquipmentEnchantData>>>();
if (!_datas.ContainsKey(data.ExchantLevel))
{
Dictionary<int, Dictionary<int, EquipmentEnchantData>> _dic = new Dictionary<int, Dictionary<int, EquipmentEnchantData>>();
_datas.Add(data.ExchantLevel, _dic);
}
if (!_datas[data.ExchantLevel].ContainsKey(data.GS))
{
Dictionary<int, EquipmentEnchantData> _dic = new Dictionary<int, EquipmentEnchantData>();
_datas[data.ExchantLevel].Add(data.GS, _dic);
}
_datas[data.ExchantLevel][data.GS].Add(data.EquipmentType,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, Dictionary<int, EquipmentEnchantData>> Get(int newExchantLevel)
{
if (_datas.ContainsKey(newExchantLevel))
return _datas[newExchantLevel];
else
return null;
}
public Dictionary<int, EquipmentEnchantData> Get(int newExchantLevel,int newGS)
{
if (_datas.ContainsKey(newExchantLevel) && _datas[newExchantLevel].ContainsKey(newGS))
return _datas[newExchantLevel][newGS];
else
return null;
}
public EquipmentEnchantData Get(int newExchantLevel,int newGS,int newEquipmentType)
{
if (_datas.ContainsKey(newExchantLevel) && _datas[newExchantLevel].ContainsKey(newGS) && _datas[newExchantLevel][newGS].ContainsKey(newEquipmentType))
return _datas[newExchantLevel][newGS][newEquipmentType];
else
return null;
}
}
}
