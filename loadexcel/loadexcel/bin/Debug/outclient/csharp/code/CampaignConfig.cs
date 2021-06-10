using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CampaignData
{
/*章节ID，对应章节信息表上的章节ID*/
public int CampaignChapterID; 
/*关卡ID*/
public int CampaignID; 
/*关卡类型*/
public int CampaignOptionType; 
/*关卡等级*/
public int CampaignLevel; 
/*关卡名称*/
public string CampaignName; 
/*关卡描述*/
public string CampaignDesc; 
/*是否Boss关卡*/
public int CampaignType; 
/*怪物预览*/
public string MonsterReviewID; 
/*关卡开放所需玩家等级*/
public int CampaignOpeningLevel; 
/*每天可挑战次数上限*/
public int CampaignChallengeTime; 
/*每次挑战此关卡所消耗体力*/
public int ActionPoint; 
/*开放此关卡前置章节ID*/
public int PreposeChapterID; 
/*开放此关卡前置关卡ID*/
public int PreposeCampaignID; 
/*通关奖励，对应副本奖励表内的掉落ID*/
public string RewardOrder; 
/*通关首次掉落*/
public int FirstRewardOrder; 
/*通关可获得人物经验*/
public int RewardPlayerExp; 
/*通关获得英雄经验*/
public int RewardHeroExp; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*调用战斗部队ID*/
public string ArmyID; 
/*调用外援英雄的队伍*/
public string HelperID; 
/*怪物对白1*/
public string Dialog1; 
/*怪物对白2*/
public string Dialog2; 
/*关底BOSS喊话*/
public string DialogBoss; 
/*怪物展示动作*/
public string MonShow; 
/*胜利条件*/
public string AchievementCondition; 
/*胜利条件参数*/
public int AchievementNum; 
/*关卡成就*/
public string AchievementNames; 
/*星级奖励1*/
public int StarReward1; 
/*星级奖励2*/
public int StarReward2; 
/*星级奖励3*/
public int StarReward3; 
/*剧情对白ID(出现1次直接填值，出现多次天ID#true)*/
public int DramaID; 
/*表演关卡(需加到白名单)*/
public int ShowCampaign; 
}
public partial class CampaignConfig : ConfigBase
{
private static CampaignConfig _instance;
public Dictionary<int, Dictionary<int, CampaignData>> _datas;
public static CampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Campaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 774;i++)
{
CampaignData data = new CampaignData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignOptionType = br.ReadInt32();
data.CampaignLevel = br.ReadInt32();
data.CampaignName = br.ReadString();
data.CampaignDesc = br.ReadString();
data.CampaignType = br.ReadInt32();
data.MonsterReviewID = br.ReadString();
data.CampaignOpeningLevel = br.ReadInt32();
data.CampaignChallengeTime = br.ReadInt32();
data.ActionPoint = br.ReadInt32();
data.PreposeChapterID = br.ReadInt32();
data.PreposeCampaignID = br.ReadInt32();
data.RewardOrder = br.ReadString();
data.FirstRewardOrder = br.ReadInt32();
data.RewardPlayerExp = br.ReadInt32();
data.RewardHeroExp = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.ArmyID = br.ReadString();
data.HelperID = br.ReadString();
data.Dialog1 = br.ReadString();
data.Dialog2 = br.ReadString();
data.DialogBoss = br.ReadString();
data.MonShow = br.ReadString();
data.AchievementCondition = br.ReadString();
data.AchievementNum = br.ReadInt32();
data.AchievementNames = br.ReadString();
data.StarReward1 = br.ReadInt32();
data.StarReward2 = br.ReadInt32();
data.StarReward3 = br.ReadInt32();
data.DramaID = br.ReadInt32();
data.ShowCampaign = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, CampaignData>>();
if (!_datas.ContainsKey(data.CampaignChapterID))
{
Dictionary<int, CampaignData> _dic = new Dictionary<int, CampaignData>();
_datas.Add(data.CampaignChapterID, _dic);
}
_datas[data.CampaignChapterID].Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, CampaignData> Get(int newCampaignChapterID)
{
if (_datas.ContainsKey(newCampaignChapterID))
return _datas[newCampaignChapterID];
else
return null;
}
public CampaignData Get(int newCampaignChapterID,int newCampaignID)
{
if (_datas.ContainsKey(newCampaignChapterID) && _datas[newCampaignChapterID].ContainsKey(newCampaignID))
return _datas[newCampaignChapterID][newCampaignID];
else
return null;
}
}
}
