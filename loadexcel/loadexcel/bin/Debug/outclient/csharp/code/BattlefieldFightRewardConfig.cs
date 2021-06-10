using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BattlefieldFightRewardData
{
/*奖励类型*/
public int RewardType; 
/*奖励条件*/
public int RewardCondition; 
/*奖励积分*/
public int Score; 
/*奖励征服点数*/
public int ConquerPoints; 
}
public partial class BattlefieldFightRewardConfig : ConfigBase
{
private static BattlefieldFightRewardConfig _instance;
public Dictionary<int, Dictionary<int, BattlefieldFightRewardData>> _datas;
public static BattlefieldFightRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BattlefieldFightRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BattlefieldFightReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 12;i++)
{
BattlefieldFightRewardData data = new BattlefieldFightRewardData();
data.RewardType = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.Score = br.ReadInt32();
data.ConquerPoints = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, BattlefieldFightRewardData>>();
if (!_datas.ContainsKey(data.RewardType))
{
Dictionary<int, BattlefieldFightRewardData> _dic = new Dictionary<int, BattlefieldFightRewardData>();
_datas.Add(data.RewardType, _dic);
}
_datas[data.RewardType].Add(data.RewardCondition,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, BattlefieldFightRewardData> Get(int newRewardType)
{
if (_datas.ContainsKey(newRewardType))
return _datas[newRewardType];
else
return null;
}
public BattlefieldFightRewardData Get(int newRewardType,int newRewardCondition)
{
if (_datas.ContainsKey(newRewardType) && _datas[newRewardType].ContainsKey(newRewardCondition))
return _datas[newRewardType][newRewardCondition];
else
return null;
}
}
}
