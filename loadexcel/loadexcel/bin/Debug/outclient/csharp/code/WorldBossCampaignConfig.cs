using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WorldBossCampaignData
{
/*关卡ID*/
public int CampaignID; 
/*单次挑战可获得奖励*/
public int AttackReward; 
/*杀死以后可获得奖励*/
public int KilledReward; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class WorldBossCampaignConfig : ConfigBase
{
private static WorldBossCampaignConfig _instance;
public Dictionary<int, WorldBossCampaignData> _datas;
public static WorldBossCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WorldBossCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WorldBossCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 46;i++)
{
WorldBossCampaignData data = new WorldBossCampaignData();
data.CampaignID = br.ReadInt32();
data.AttackReward = br.ReadInt32();
data.KilledReward = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, WorldBossCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public WorldBossCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
