using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CrusadeCampaignData
{
/*章节ID*/
public int ChapterID; 
/*关卡ID*/
public int CampaignID; 
/*是否Boss关卡*/
public int CampaignType; 
/*加载怪物模型*/
public string MonsterBase; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*两倍暴击概率*/
public int Critprobability1; 
/*4倍暴击概率*/
public int Critprobability2; 
/*每点血奖励金钱*/
public int bloodGold; 
/*每点血奖励经验*/
public int bloodExp; 
/*打死奖励*/
public int reward; 
/*怪物对白1*/
public string Dialog1; 
/*怪物对白2*/
public string Dialog2; 
/*关底BOSS喊话*/
public string Dialog3; 
}
public partial class CrusadeCampaignConfig : ConfigBase
{
private static CrusadeCampaignConfig _instance;
public Dictionary<int, CrusadeCampaignData> _datas;
public static CrusadeCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CrusadeCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CrusadeCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 253;i++)
{
CrusadeCampaignData data = new CrusadeCampaignData();
data.ChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignType = br.ReadInt32();
data.MonsterBase = br.ReadString();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.Critprobability1 = br.ReadInt32();
data.Critprobability2 = br.ReadInt32();
data.bloodGold = br.ReadInt32();
data.bloodExp = br.ReadInt32();
data.reward = br.ReadInt32();
data.Dialog1 = br.ReadString();
data.Dialog2 = br.ReadString();
data.Dialog3 = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, CrusadeCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public CrusadeCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
