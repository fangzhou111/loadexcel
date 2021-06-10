using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WrestlingGoldData
{
/*奖励ID，主键唯一不可重复*/
public int RewardID; 
/*奖励分组*/
public int Order; 
/*等级段*/
public int OrderLevel; 
/*掉落物品数量最小*/
public int RewardItemNumMin; 
/*掉落物品数量最大*/
public int RewardItemNumMax; 
}
public partial class WrestlingGoldConfig : ConfigBase
{
private static WrestlingGoldConfig _instance;
public Dictionary<int, WrestlingGoldData> _datas;
public static WrestlingGoldConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WrestlingGoldConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WrestlingGold.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 40;i++)
{
WrestlingGoldData data = new WrestlingGoldData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.OrderLevel = br.ReadInt32();
data.RewardItemNumMin = br.ReadInt32();
data.RewardItemNumMax = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, WrestlingGoldData>();
_datas.Add(data.RewardID,data);
}
br.Close();
fs.Close();
}
public WrestlingGoldData Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
}
}
