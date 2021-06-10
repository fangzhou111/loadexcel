using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FateFightCampaignData
{
/*章节ID*/
public int CampaignChapterID; 
/*关卡ID*/
public int CampaignID; 
/*副本描述*/
public string CampaignDesc; 
/*开放此关卡前置关卡ID*/
public int PreposeCampaignID; 
/*可上阵人数*/
public int FighthHeroNum; 
/*地图名*/
public string MapName; 
/*地图配置名*/
public string MapEditorName; 
/*奖励ID*/
public string RewardID; 
}
public partial class FateFightCampaignConfig : ConfigBase
{
private static FateFightCampaignConfig _instance;
public Dictionary<int, FateFightCampaignData> _datas;
public static FateFightCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FateFightCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FateFightCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
FateFightCampaignData data = new FateFightCampaignData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.CampaignDesc = br.ReadString();
data.PreposeCampaignID = br.ReadInt32();
data.FighthHeroNum = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.RewardID = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, FateFightCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public FateFightCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
