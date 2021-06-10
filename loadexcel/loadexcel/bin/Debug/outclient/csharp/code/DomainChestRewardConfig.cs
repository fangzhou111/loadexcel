using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainChestRewardData
{
/*奖励ID，主键唯一不可重复*/
public int RewardID; 
/*奖励分组
按领主等级区分，表示XX级以上的奖励*/
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
}
public partial class DomainChestRewardConfig : ConfigBase
{
private static DomainChestRewardConfig _instance;
public Dictionary<int, Dictionary<int, DomainChestRewardData>> _datas;
public static DomainChestRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainChestRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainChestReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 35;i++)
{
DomainChestRewardData data = new DomainChestRewardData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, DomainChestRewardData>>();
if (!_datas.ContainsKey(data.RewardID))
{
Dictionary<int, DomainChestRewardData> _dic = new Dictionary<int, DomainChestRewardData>();
_datas.Add(data.RewardID, _dic);
}
_datas[data.RewardID].Add(data.Order,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, DomainChestRewardData> Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
public DomainChestRewardData Get(int newRewardID,int newOrder)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newOrder))
return _datas[newRewardID][newOrder];
else
return null;
}
}
}
