using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class JoyMachinePriceData
{
/*次数*/
public int Time; 
/*金币价格*/
public int GoldPrice; 
/*折扣显示1*/
public int Discount1; 
/*金币二倍暴击几率（1000000为100%）*/
public int GoldDoubleCrit; 
/*金币四倍暴击几率（1000000为100%）*/
public int GoldFourCrit; 
/*英雄经验价格*/
public int HeroExpPrice; 
/*折扣显示2*/
public int Discount2; 
/*英雄经验二倍暴击几率（1000000为100%）*/
public int HeroExpDoubleCrit; 
/*英雄经验四倍暴击几率（1000000为100%）*/
public int HeroExpFourCrit; 
/*装备经验价格*/
public int EquipmentExpPrice; 
/*装备经验二倍暴击几率（1000000为100%）*/
public int EquipmentExpDoubleCrit; 
/*装备经验四倍暴击几率（1000000为100%）*/
public int EquipmentExpFourCrit; 
/*技能经验价格*/
public int SkillExpPrice; 
/*技能经验二倍暴击几率（1000000为100%）*/
public int SkillExpDoubleCrit; 
/*技能经验四倍暴击几率（1000000为100%）*/
public int SkillExpFourCrit; 
/*雕文经验价格*/
public int TalentExpPrice; 
/*折扣显示3*/
public int Discount3; 
/*雕文经验二倍暴击几率（1000000为100%）*/
public int TalentExpDoubleCrit; 
/*雕文经验四倍暴击几率（1000000为100%）*/
public int TalentExpFourCrit; 
}
public partial class JoyMachinePriceConfig : ConfigBase
{
private static JoyMachinePriceConfig _instance;
public Dictionary<int, JoyMachinePriceData> _datas;
public static JoyMachinePriceConfig Instance
{
get
{
if (_instance == null)
{
_instance = new JoyMachinePriceConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("JoyMachinePrice.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 50;i++)
{
JoyMachinePriceData data = new JoyMachinePriceData();
data.Time = br.ReadInt32();
data.GoldPrice = br.ReadInt32();
data.Discount1 = br.ReadInt32();
data.GoldDoubleCrit = br.ReadInt32();
data.GoldFourCrit = br.ReadInt32();
data.HeroExpPrice = br.ReadInt32();
data.Discount2 = br.ReadInt32();
data.HeroExpDoubleCrit = br.ReadInt32();
data.HeroExpFourCrit = br.ReadInt32();
data.EquipmentExpPrice = br.ReadInt32();
data.EquipmentExpDoubleCrit = br.ReadInt32();
data.EquipmentExpFourCrit = br.ReadInt32();
data.SkillExpPrice = br.ReadInt32();
data.SkillExpDoubleCrit = br.ReadInt32();
data.SkillExpFourCrit = br.ReadInt32();
data.TalentExpPrice = br.ReadInt32();
data.Discount3 = br.ReadInt32();
data.TalentExpDoubleCrit = br.ReadInt32();
data.TalentExpFourCrit = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, JoyMachinePriceData>();
_datas.Add(data.Time,data);
}
br.Close();
fs.Close();
}
public JoyMachinePriceData Get(int newTime)
{
if (_datas.ContainsKey(newTime))
return _datas[newTime];
else
return null;
}
}
}
