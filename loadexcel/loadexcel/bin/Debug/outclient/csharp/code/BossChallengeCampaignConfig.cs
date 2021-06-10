using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeCampaignData
{
/*章节ID，对应章节信息表上的章节ID*/
public int BossChallengeChapterID; 
/*关卡ID*/
public int CampaignID; 
/*适用玩家最小区间*/
public int CampaignPlayerLevel; 
/*适用玩家最大区间*/
public int CampaignPlayerLevelMax; 
/*挑战消耗体力*/
public int CampaignChallengeTime; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*强度增长*/
public int StrengthUp; 
}
public partial class BossChallengeCampaignConfig : ConfigBase
{
private static BossChallengeCampaignConfig _instance;
public Dictionary<int, BossChallengeCampaignData> _datas;
public static BossChallengeCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 35;i++)
{
BossChallengeCampaignData data = new BossChallengeCampaignData();
data.BossChallengeChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignPlayerLevel = br.ReadInt32();
data.CampaignPlayerLevelMax = br.ReadInt32();
data.CampaignChallengeTime = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.StrengthUp = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BossChallengeCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public BossChallengeCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
