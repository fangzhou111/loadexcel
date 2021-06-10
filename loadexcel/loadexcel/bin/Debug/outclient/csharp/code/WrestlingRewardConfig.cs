using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WrestlingRewardData
{
/*奖励ID，主键唯一不可重复*/
public int RewardID; 
/*奖励分组*/
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
/*子分组*/
public int SubOrder; 
/*刷新最低等级*/
public int MinLevel; 
/*刷新最高等级*/
public int MaxLevel; 
}
public partial class WrestlingRewardConfig : ConfigBase
{
private static WrestlingRewardConfig _instance;
public Dictionary<int, WrestlingRewardData> _datas;
public static WrestlingRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WrestlingRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WrestlingReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 53;i++)
{
WrestlingRewardData data = new WrestlingRewardData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNumMin = br.ReadInt32();
data.RewardItemNumMax = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.SubOrder = br.ReadInt32();
data.MinLevel = br.ReadInt32();
data.MaxLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, WrestlingRewardData>();
_datas.Add(data.RewardID,data);
}
br.Close();
fs.Close();
}
public WrestlingRewardData Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
}
}
