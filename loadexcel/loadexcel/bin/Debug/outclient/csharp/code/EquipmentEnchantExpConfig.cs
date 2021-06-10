using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentEnchantExpData
{
/*当前熟练度等级*/
public int ExchantLevel; 
/*升级到当前熟练度等级所需经验*/
public int EnchantExp; 
/*属性数下限*/
public int PropertyNumLowerLimit; 
/*属性数上限*/
public int PropertyNumUpperLimit; 
/*每次消耗材料*/
public int NeedMaterial; 
/*每次消耗钻石*/
public int NeedDiamond; 
/*升级后第一次随机条目数*/
public int UpgradeFirstEnchantNum; 
/*大随机范围百分比*/
public int Confine; 
/*最大值刷出率*/
public int MAXProbability; 
}
public partial class EquipmentEnchantExpConfig : ConfigBase
{
private static EquipmentEnchantExpConfig _instance;
public Dictionary<int, EquipmentEnchantExpData> _datas;
public static EquipmentEnchantExpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentEnchantExpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentEnchantExp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
EquipmentEnchantExpData data = new EquipmentEnchantExpData();
data.ExchantLevel = br.ReadInt32();
data.EnchantExp = br.ReadInt32();
data.PropertyNumLowerLimit = br.ReadInt32();
data.PropertyNumUpperLimit = br.ReadInt32();
data.NeedMaterial = br.ReadInt32();
data.NeedDiamond = br.ReadInt32();
data.UpgradeFirstEnchantNum = br.ReadInt32();
data.Confine = br.ReadInt32();
data.MAXProbability = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, EquipmentEnchantExpData>();
_datas.Add(data.ExchantLevel,data);
}
br.Close();
fs.Close();
}
public EquipmentEnchantExpData Get(int newExchantLevel)
{
if (_datas.ContainsKey(newExchantLevel))
return _datas[newExchantLevel];
else
return null;
}
}
}
