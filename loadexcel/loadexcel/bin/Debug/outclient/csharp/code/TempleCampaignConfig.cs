using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TempleCampaignData
{
/*章节ID，对应章节信息表上的章节ID*/
public int TempleChapterID; 
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
/*奖励*/
public int TempleReward; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*允许进入的职业*/
public string BattleJob; 
/*掉落装备预览文字*/
public string ItemReviewWord; 
}
public partial class TempleCampaignConfig : ConfigBase
{
private static TempleCampaignConfig _instance;
public Dictionary<int, TempleCampaignData> _datas;
public static TempleCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TempleCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TempleCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 24;i++)
{
TempleCampaignData data = new TempleCampaignData();
data.TempleChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignLevel = br.ReadInt32();
data.CampaignName = br.ReadString();
data.CampaignDesc = br.ReadString();
data.MonsterReviewID = br.ReadString();
data.CampaignOpeningLevel = br.ReadInt32();
data.CampaignChallengeTime = br.ReadInt32();
data.TempleReward = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.BattleJob = br.ReadString();
data.ItemReviewWord = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, TempleCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public TempleCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
