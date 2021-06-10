using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PlayerUpgradeExpData
{
/*人物等级*/
public int Level; 
/*升到下一级所需经验*/
public int Exp; 
/*当前等级体力上限*/
public int MaxStrength; 
/*精力上限*/
public int MaxSpirit; 
/*升级获得体力*/
public int UpgradeOfferStrength; 
/*升级获得精力*/
public int UpgradeOfferSpirit; 
/*英雄等级上限*/
public int MaxHeroLevel; 
}
public partial class PlayerUpgradeExpConfig : ConfigBase
{
private static PlayerUpgradeExpConfig _instance;
public Dictionary<int, PlayerUpgradeExpData> _datas;
public static PlayerUpgradeExpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PlayerUpgradeExpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PlayerUpgradeExp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
PlayerUpgradeExpData data = new PlayerUpgradeExpData();
data.Level = br.ReadInt32();
data.Exp = br.ReadInt32();
data.MaxStrength = br.ReadInt32();
data.MaxSpirit = br.ReadInt32();
data.UpgradeOfferStrength = br.ReadInt32();
data.UpgradeOfferSpirit = br.ReadInt32();
data.MaxHeroLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, PlayerUpgradeExpData>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public PlayerUpgradeExpData Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
