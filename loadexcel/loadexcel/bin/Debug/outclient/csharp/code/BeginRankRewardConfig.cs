﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BeginRankRewardData
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
/*掉落物品数量*/
public int RewardItemNum; 
/*概率或权重*/
public int RewardProbability; 
/*奖励预览*/
public int RewardPreview; 
}
public partial class BeginRankRewardConfig : ConfigBase
{
private static BeginRankRewardConfig _instance;
public Dictionary<int, Dictionary<int, BeginRankRewardData>> _datas;
public static BeginRankRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BeginRankRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BeginRankReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 40;i++)
{
BeginRankRewardData data = new BeginRankRewardData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, BeginRankRewardData>>();
if (!_datas.ContainsKey(data.RewardID))
{
Dictionary<int, BeginRankRewardData> _dic = new Dictionary<int, BeginRankRewardData>();
_datas.Add(data.RewardID, _dic);
}
_datas[data.RewardID].Add(data.Order,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, BeginRankRewardData> Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
public BeginRankRewardData Get(int newRewardID,int newOrder)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newOrder))
return _datas[newRewardID][newOrder];
else
return null;
}
}
}
