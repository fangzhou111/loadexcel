using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ResourceCampaignData
{
/*章节ID，对应章节信息表上的章节ID*/
public int ResourceChapterID; 
/*关卡ID*/
public int CampaignID; 
/*关卡等级*/
public int CampaignLevel; 
/*关卡名称*/
public string CampaignName; 
/*关卡备注*/
public string CampaignDesc; 
/*怪物预览*/
public string MonsterReviewID; 
/*关卡开放所需玩家等级*/
public int CampaignOpeningLevel; 
/*每天可挑战次数上限*/
public int CampaignChallengeTime; 
/*模式*/
public string FightType; 
/*限制回合数*/
public int RoundNum; 
/*胜利条件描述*/
public string WinConDes; 
/*奖励类型*/
public string RewardType; 
/*最高奖励道具*/
public int MaxItem; 
/*奖励极限*/
public string RewardMax; 
/*掉落权重*/
public string weight; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class ResourceCampaignConfig : ConfigBase
{
private static ResourceCampaignConfig _instance;
public Dictionary<int, ResourceCampaignData> _datas;
public static ResourceCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ResourceCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ResourceCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 45;i++)
{
ResourceCampaignData data = new ResourceCampaignData();
data.ResourceChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignLevel = br.ReadInt32();
data.CampaignName = br.ReadString();
data.CampaignDesc = br.ReadString();
data.MonsterReviewID = br.ReadString();
data.CampaignOpeningLevel = br.ReadInt32();
data.CampaignChallengeTime = br.ReadInt32();
data.FightType = br.ReadString();
data.RoundNum = br.ReadInt32();
data.WinConDes = br.ReadString();
data.RewardType = br.ReadString();
data.MaxItem = br.ReadInt32();
data.RewardMax = br.ReadString();
data.weight = br.ReadString();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ResourceCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public ResourceCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
