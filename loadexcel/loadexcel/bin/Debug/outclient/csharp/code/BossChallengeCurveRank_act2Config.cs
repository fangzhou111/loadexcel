using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeCurveRank_act2Data
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
public partial class BossChallengeCurveRank_act2Config : ConfigBase
{
private static BossChallengeCurveRank_act2Config _instance;
public Dictionary<int, Dictionary<int, BossChallengeCurveRank_act2Data>> _datas;
public static BossChallengeCurveRank_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeCurveRank_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeCurveRank_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
BossChallengeCurveRank_act2Data data = new BossChallengeCurveRank_act2Data();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, BossChallengeCurveRank_act2Data>>();
if (!_datas.ContainsKey(data.RewardID))
{
Dictionary<int, BossChallengeCurveRank_act2Data> _dic = new Dictionary<int, BossChallengeCurveRank_act2Data>();
_datas.Add(data.RewardID, _dic);
}
_datas[data.RewardID].Add(data.Order,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, BossChallengeCurveRank_act2Data> Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
public BossChallengeCurveRank_act2Data Get(int newRewardID,int newOrder)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newOrder))
return _datas[newRewardID][newOrder];
else
return null;
}
}
}
