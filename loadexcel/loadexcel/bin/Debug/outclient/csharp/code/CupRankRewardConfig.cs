using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CupRankRewardData
{
/*奖励ID，主键唯一不可重复*/
public int RewardID; 
/*奖励分组*/
public int Order; 
/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
public int RewardCondition; 
/*掉落物品ID*/
public int RewardItemID; 
/*掉落物品数量*/
public int RewardItemNum; 
/*概率或权重*/
public int RewardProbability; 
/*奖励预览*/
public int RewardPreview; 
/*比赛阶段
1本服赛
2跨服赛*/
public int CupType; 
}
public partial class CupRankRewardConfig : ConfigBase
{
private static CupRankRewardConfig _instance;
public Dictionary<int, Dictionary<int, Dictionary<int, CupRankRewardData>>> _datas;
public static CupRankRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CupRankRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CupRankReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 42;i++)
{
CupRankRewardData data = new CupRankRewardData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
data.CupType = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, Dictionary<int, CupRankRewardData>>>();
if (!_datas.ContainsKey(data.RewardID))
{
Dictionary<int, Dictionary<int, CupRankRewardData>> _dic = new Dictionary<int, Dictionary<int, CupRankRewardData>>();
_datas.Add(data.RewardID, _dic);
}
if (!_datas[data.RewardID].ContainsKey(data.Order))
{
Dictionary<int, CupRankRewardData> _dic = new Dictionary<int, CupRankRewardData>();
_datas[data.RewardID].Add(data.Order, _dic);
}
_datas[data.RewardID][data.Order].Add(data.CupType,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, Dictionary<int, CupRankRewardData>> Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
public Dictionary<int, CupRankRewardData> Get(int newRewardID,int newOrder)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newOrder))
return _datas[newRewardID][newOrder];
else
return null;
}
public CupRankRewardData Get(int newRewardID,int newOrder,int newCupType)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newOrder) && _datas[newRewardID][newOrder].ContainsKey(newCupType))
return _datas[newRewardID][newOrder][newCupType];
else
return null;
}
}
}
