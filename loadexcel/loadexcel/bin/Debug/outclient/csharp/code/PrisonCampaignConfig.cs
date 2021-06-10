using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PrisonCampaignData
{
/*关卡ID*/
public int CampaignID; 
/*关卡概率*/
public int Campaign; 
/*怪物预览*/
public int MonsterReviewID; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class PrisonCampaignConfig : ConfigBase
{
private static PrisonCampaignConfig _instance;
public Dictionary<int, PrisonCampaignData> _datas;
public static PrisonCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PrisonCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PrisonCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
PrisonCampaignData data = new PrisonCampaignData();
data.CampaignID = br.ReadInt32();
data.Campaign = br.ReadInt32();
data.MonsterReviewID = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, PrisonCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public PrisonCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
