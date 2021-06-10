using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TimeCaveCampaignData
{
/*章节ID，对应章节信息表上的章节ID*/
public int CampaignChapterID; 
/*关卡ID*/
public int CampaignID; 
/*副本描述*/
public string CampaignDesc; 
/*关卡开放所需玩家等级*/
public int CampaignOpeningLevel; 
/*开放此关卡前置关卡ID*/
public int PreposeCampaignID; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*1星奖励ID*/
public int DropOneStar; 
/*2星奖励ID*/
public int DropTwoStar; 
/*3星奖励ID*/
public int DropThreeStar; 
}
public partial class TimeCaveCampaignConfig : ConfigBase
{
private static TimeCaveCampaignConfig _instance;
public Dictionary<int, TimeCaveCampaignData> _datas;
public static TimeCaveCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TimeCaveCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TimeCaveCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
TimeCaveCampaignData data = new TimeCaveCampaignData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignDesc = br.ReadString();
data.CampaignOpeningLevel = br.ReadInt32();
data.PreposeCampaignID = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.DropOneStar = br.ReadInt32();
data.DropTwoStar = br.ReadInt32();
data.DropThreeStar = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TimeCaveCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public TimeCaveCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
