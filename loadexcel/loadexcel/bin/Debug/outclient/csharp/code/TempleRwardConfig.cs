﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TempleRwardData
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
public partial class TempleRwardConfig : ConfigBase
{
private static TempleRwardConfig _instance;
public Dictionary<int, TempleRwardData> _datas;
public static TempleRwardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TempleRwardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TempleRward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 216;i++)
{
TempleRwardData data = new TempleRwardData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TempleRwardData>();
_datas.Add(data.RewardID,data);
}
br.Close();
fs.Close();
}
public TempleRwardData Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
}
}
