using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ArenaHistoryGradeRewardData
{
/*奖励ID，主键唯一不可重复*/
public int RewardID; 
/*历史排名*/
public int order; 
/*奖励钻石(可使用小数）*/
public double Reward; 
}
public partial class ArenaHistoryGradeRewardConfig : ConfigBase
{
private static ArenaHistoryGradeRewardConfig _instance;
public Dictionary<int, ArenaHistoryGradeRewardData> _datas;
public static ArenaHistoryGradeRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ArenaHistoryGradeRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ArenaHistoryGradeReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 13;i++)
{
ArenaHistoryGradeRewardData data = new ArenaHistoryGradeRewardData();
data.RewardID = br.ReadInt32();
data.order = br.ReadInt32();
data.Reward = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, ArenaHistoryGradeRewardData>();
_datas.Add(data.order,data);
}
br.Close();
fs.Close();
}
public ArenaHistoryGradeRewardData Get(int neworder)
{
if (_datas.ContainsKey(neworder))
return _datas[neworder];
else
return null;
}
}
}
