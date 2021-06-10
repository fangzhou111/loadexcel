using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LeagueMatchChestRewardData
{
/*主键ID*/
public int RewardID; 
/*宝箱编号*/
public int Order; 
/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
public int RewardCondition; 
/*掉落物品ID*/
public int RewardItemID; 
/*掉落物品数量最小*/
public int RewardItemNumMin; 
/*掉落物品数量最大*/
public int RewardItemNumMax; 
/*概率或权重*/
public int RewardProbability; 
/*等级下限*/
public int MinLevel; 
/*等级上限*/
public int MaxLevel; 
}
public partial class LeagueMatchChestRewardConfig : ConfigBase
{
private static LeagueMatchChestRewardConfig _instance;
public Dictionary<int, Dictionary<int, LeagueMatchChestRewardData>> _datas;
public static LeagueMatchChestRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LeagueMatchChestRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LeagueMatchChestReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 305;i++)
{
LeagueMatchChestRewardData data = new LeagueMatchChestRewardData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNumMin = br.ReadInt32();
data.RewardItemNumMax = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.MinLevel = br.ReadInt32();
data.MaxLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, LeagueMatchChestRewardData>>();
if (!_datas.ContainsKey(data.RewardID))
{
Dictionary<int, LeagueMatchChestRewardData> _dic = new Dictionary<int, LeagueMatchChestRewardData>();
_datas.Add(data.RewardID, _dic);
}
_datas[data.RewardID].Add(data.Order,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, LeagueMatchChestRewardData> Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
public LeagueMatchChestRewardData Get(int newRewardID,int newOrder)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newOrder))
return _datas[newRewardID][newOrder];
else
return null;
}
}
}
