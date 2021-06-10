using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FateFightCampaignRewardData
{
/*奖励ID，主键唯一不可重复*/
public int RewardID; 
/*章节ID*/
public int CampaignID; 
/*奖励等级*/
public int RewardLv; 
/*掉落物品ID1*/
public int RewardItemID1; 
/*掉落物品数量1*/
public int RewardItemNum1; 
/*掉落物品ID2*/
public int RewardItemID2; 
/*掉落物品数量2*/
public int RewardItemNum2; 
/*奖励预览*/
public int RewardPreview; 
}
public partial class FateFightCampaignRewardConfig : ConfigBase
{
private static FateFightCampaignRewardConfig _instance;
public Dictionary<int, Dictionary<int, FateFightCampaignRewardData>> _datas;
public static FateFightCampaignRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FateFightCampaignRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FateFightCampaignReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 300;i++)
{
FateFightCampaignRewardData data = new FateFightCampaignRewardData();
data.RewardID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.RewardLv = br.ReadInt32();
data.RewardItemID1 = br.ReadInt32();
data.RewardItemNum1 = br.ReadInt32();
data.RewardItemID2 = br.ReadInt32();
data.RewardItemNum2 = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, FateFightCampaignRewardData>>();
if (!_datas.ContainsKey(data.RewardID))
{
Dictionary<int, FateFightCampaignRewardData> _dic = new Dictionary<int, FateFightCampaignRewardData>();
_datas.Add(data.RewardID, _dic);
}
_datas[data.RewardID].Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, FateFightCampaignRewardData> Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
public FateFightCampaignRewardData Get(int newRewardID,int newCampaignID)
{
if (_datas.ContainsKey(newRewardID) && _datas[newRewardID].ContainsKey(newCampaignID))
return _datas[newRewardID][newCampaignID];
else
return null;
}
}
}
