using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentStepData
{
/*装备Id*/
public int ID; 
/*分段起始*/
public int Step; 
/*分段结束*/
public int stepMax; 
/*当前阶名*/
public string StepName; 
/*当前阶颜色*/
public int StepColor; 
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
/*被吞噬消耗金钱*/
public int NeedGold; 
/*效果*/
public string EffectID; 
/*宝石孔数*/
public int GemHoleNum; 
/*最大宝石孔*/
public int MaxGemNum; 
/*特殊孔类型*/
public int SpecialGemHoleType; 
/*特殊孔等级*/
public int SpecialGemHoleLevel; 
/*特殊孔携带效果*/
public int SpecialGemHoleEffect; 
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
/*装备分解进阶返还系数*/
public int EquipDecAdvancedRatio; 
}
public partial class EquipmentStepConfig : ConfigBase
{
private static EquipmentStepConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentStepData>> _datas;
public static EquipmentStepConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentStepConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentStep.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 212;i++)
{
EquipmentStepData data = new EquipmentStepData();
data.ID = br.ReadInt32();
data.Step = br.ReadInt32();
data.stepMax = br.ReadInt32();
data.StepName = br.ReadString();
data.StepColor = br.ReadInt32();
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
data.NeedGold = br.ReadInt32();
data.EffectID = br.ReadString();
data.GemHoleNum = br.ReadInt32();
data.MaxGemNum = br.ReadInt32();
data.SpecialGemHoleType = br.ReadInt32();
data.SpecialGemHoleLevel = br.ReadInt32();
data.SpecialGemHoleEffect = br.ReadInt32();
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
data.EquipDecAdvancedRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentStepData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, EquipmentStepData> _dic = new Dictionary<int, EquipmentStepData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.Step,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentStepData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public EquipmentStepData Get(int newID,int newStep)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newStep))
return _datas[newID][newStep];
else
return null;
}
}
}
