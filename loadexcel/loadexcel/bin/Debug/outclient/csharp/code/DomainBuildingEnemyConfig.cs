using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainBuildingEnemyData
{
/*匹配值
=活跃度*领地匹配系数
代表比值以上*/
public int MatchValue; 
/*机器人最低生命加成
百分比，90指90%*/
public int BotHPMin; 
/*机器人最高生命加成
百分比，90指90%*/
public int BotHPMax; 
/*机器人最低攻击加成*/
public int BotAttMin; 
/*机器人最高攻击加成*/
public int BotAttMax; 
/*机器人最低防御加成*/
public int BotDefMin; 
/*机器人最高防御加成*/
public int BotDefMax; 
/*机器人最低等级差*/
public int BotLevelMin; 
/*机器人最高等级差*/
public int BotLevelMax; 
/*玩家最低战力系数
百分比，90指90%*/
public int PlayerPowerMin; 
/*列家最高战力系数
百分比，90指90%*/
public int PlayerPowerMax; 
}
public partial class DomainBuildingEnemyConfig : ConfigBase
{
private static DomainBuildingEnemyConfig _instance;
public Dictionary<int, DomainBuildingEnemyData> _datas;
public static DomainBuildingEnemyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainBuildingEnemyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainBuildingEnemy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
DomainBuildingEnemyData data = new DomainBuildingEnemyData();
data.MatchValue = br.ReadInt32();
data.BotHPMin = br.ReadInt32();
data.BotHPMax = br.ReadInt32();
data.BotAttMin = br.ReadInt32();
data.BotAttMax = br.ReadInt32();
data.BotDefMin = br.ReadInt32();
data.BotDefMax = br.ReadInt32();
data.BotLevelMin = br.ReadInt32();
data.BotLevelMax = br.ReadInt32();
data.PlayerPowerMin = br.ReadInt32();
data.PlayerPowerMax = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, DomainBuildingEnemyData>();
_datas.Add(data.PlayerPowerMin,data);
}
br.Close();
fs.Close();
}
public DomainBuildingEnemyData Get(int newPlayerPowerMin)
{
if (_datas.ContainsKey(newPlayerPowerMin))
return _datas[newPlayerPowerMin];
else
return null;
}
}
}
