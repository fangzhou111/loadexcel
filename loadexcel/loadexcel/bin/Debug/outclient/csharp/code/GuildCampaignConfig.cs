using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuildCampaignData
{
/*章节ID，对应章节信息表上的章节ID*/
public int CampaignChapterID; 
/*关卡ID*/
public int CampaignID; 
/*关卡类型*/
public int CampaignOptionType; 
/*关卡名称*/
public string CampaignName; 
/*关卡描述*/
public string CampaignDesc; 
/*是否Boss关卡*/
public int CampaignType; 
/*怪物预览*/
public string MonsterReviewID; 
/*开放此关卡前置关卡ID*/
public int PreposeCampaignID; 
/*战斗掉落*/
public int CampaignFightReward; 
/*进度掉落1，对应副本奖励表内的掉落ID*/
public string BloodRward1; 
/*进度掉落2，对应副本奖励表内的掉落ID*/
public string BloodRward2; 
/*进度掉落3，对应副本奖励表内的掉落ID*/
public string BloodRward3; 
/*进度掉落4，对应副本奖励表内的掉落ID*/
public string BloodRward4; 
/*进度掉落5，对应副本奖励表内的掉落ID*/
public string BloodRward5; 
/*最后一击奖励*/
public int LastReward; 
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
}
public partial class GuildCampaignConfig : ConfigBase
{
private static GuildCampaignConfig _instance;
public Dictionary<int, GuildCampaignData> _datas;
public static GuildCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuildCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GuildCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 25;i++)
{
GuildCampaignData data = new GuildCampaignData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignOptionType = br.ReadInt32();
data.CampaignName = br.ReadString();
data.CampaignDesc = br.ReadString();
data.CampaignType = br.ReadInt32();
data.MonsterReviewID = br.ReadString();
data.PreposeCampaignID = br.ReadInt32();
data.CampaignFightReward = br.ReadInt32();
data.BloodRward1 = br.ReadString();
data.BloodRward2 = br.ReadString();
data.BloodRward3 = br.ReadString();
data.BloodRward4 = br.ReadString();
data.BloodRward5 = br.ReadString();
data.LastReward = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.ArmyID = br.ReadString();
data.HelperID = br.ReadString();
data.Dialog1 = br.ReadString();
data.Dialog2 = br.ReadString();
data.DialogBoss = br.ReadString();
data.MonShow = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, GuildCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public GuildCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
