using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class JewelryStepData
{
/*雕文编号*/
public int ID; 
/*类型*/
public int Type; 
/*品质*/
public int Quality; 
/*最低等级
等级在该范围内的属性成长*/
public int LevelMin; 
/*最高等级*/
public int LevelMax; 
/*分段起始*/
public int Step; 
/*分段结束*/
public int stepMax; 
/*装备部位*/
public int EquipmentPart; 
/*装备类型*/
public int EquipmentType; 
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
/*物攻万分比
万分比加成，其它属性也一样*/
public double PhysicsAtkRatio; 
/*魔攻万分比*/
public double MagicAtkRatio; 
/*物防万分比*/
public double PhysicsDefRatio; 
/*魔防万分比*/
public double MagicDefRatio; 
/*血量万分比*/
public double HPRatio; 
/*命中万分比*/
public double HitRateRatio; 
/*闪避万分比*/
public double DodgeRateRatio; 
/*暴击万分比*/
public double CritRateRatio; 
/*韧性万分比*/
public double ToughnessRatio; 
/*招架万分比*/
public double ParryRateRatio; 
/*精准万分比*/
public double PrecisionRateRatio; 
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
/*效果*/
public string EffectID; 
/*装备分解进阶返还系数*/
public int EquipDecAdvancedRatio; 
}
public partial class JewelryStepConfig : ConfigBase
{
private static JewelryStepConfig _instance;
public Dictionary<int, Dictionary<int, JewelryStepData>> _datas;
public static JewelryStepConfig Instance
{
get
{
if (_instance == null)
{
_instance = new JewelryStepConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("JewelryStep.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 182;i++)
{
JewelryStepData data = new JewelryStepData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Quality = br.ReadInt32();
data.LevelMin = br.ReadInt32();
data.LevelMax = br.ReadInt32();
data.Step = br.ReadInt32();
data.stepMax = br.ReadInt32();
data.EquipmentPart = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
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
data.PhysicsAtkRatio = (float)br.ReadDouble();
data.MagicAtkRatio = (float)br.ReadDouble();
data.PhysicsDefRatio = (float)br.ReadDouble();
data.MagicDefRatio = (float)br.ReadDouble();
data.HPRatio = (float)br.ReadDouble();
data.HitRateRatio = (float)br.ReadDouble();
data.DodgeRateRatio = (float)br.ReadDouble();
data.CritRateRatio = (float)br.ReadDouble();
data.ToughnessRatio = (float)br.ReadDouble();
data.ParryRateRatio = (float)br.ReadDouble();
data.PrecisionRateRatio = (float)br.ReadDouble();
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
data.EffectID = br.ReadString();
data.EquipDecAdvancedRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, JewelryStepData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, JewelryStepData> _dic = new Dictionary<int, JewelryStepData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.Step,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, JewelryStepData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public JewelryStepData Get(int newID,int newStep)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newStep))
return _datas[newID][newStep];
else
return null;
}
}
}
