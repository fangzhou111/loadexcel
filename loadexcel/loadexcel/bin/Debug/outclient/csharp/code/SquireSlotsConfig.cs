using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SquireSlotsData
{
/*英雄编号*/
public int HeroID; 
/*侍从位置*/
public int SquireSlot; 
/*开启要求主角等级*/
public int OpenLevel; 
/*激活要求英雄星级*/
public int NeedHeroStar; 
/*栏位加成索引*/
public int SlotAdd; 
/*专属英雄*/
public int SpecialHeroID; 
/*传属英雄额外加成*/
public int ExtraBonus; 
/*全部激活奖励*/
public int AllActivationEffect; 
}
public partial class SquireSlotsConfig : ConfigBase
{
private static SquireSlotsConfig _instance;
public Dictionary<int, SquireSlotsData> _datas;
public static SquireSlotsConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SquireSlotsConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SquireSlots.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
SquireSlotsData data = new SquireSlotsData();
data.HeroID = br.ReadInt32();
data.SquireSlot = br.ReadInt32();
data.OpenLevel = br.ReadInt32();
data.NeedHeroStar = br.ReadInt32();
data.SlotAdd = br.ReadInt32();
data.SpecialHeroID = br.ReadInt32();
data.ExtraBonus = br.ReadInt32();
data.AllActivationEffect = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, SquireSlotsData>();
_datas.Add(data.SquireSlot,data);
}
br.Close();
fs.Close();
}
public SquireSlotsData Get(int newSquireSlot)
{
if (_datas.ContainsKey(newSquireSlot))
return _datas[newSquireSlot];
else
return null;
}
}
}
