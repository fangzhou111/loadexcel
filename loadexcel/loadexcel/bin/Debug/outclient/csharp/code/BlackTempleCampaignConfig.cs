using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BlackTempleCampaignData
{
/*波次ID*/
public int CampaignID; 
/*波次名称*/
public string WaveName; 
/*波次战斗回合*/
public int WaveBattleTime; 
/*预览模型*/
public int Model; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*战斗奖励*/
public int RewardOrder; 
/*5关宝箱奖励*/
public int RewardBox; 
/*通关波次奖励*/
public int CampaignFightReward; 
/*通关增加血瓶*/
public int AddBlood; 
/*模型大小/100*/
public int ModelScale; 
/*可上阵人数*/
public int HeroNum; 
/*重置关数*/
public int ResetCampaignID; 
}
public partial class BlackTempleCampaignConfig : ConfigBase
{
private static BlackTempleCampaignConfig _instance;
public Dictionary<int, BlackTempleCampaignData> _datas;
public static BlackTempleCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BlackTempleCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BlackTempleCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 200;i++)
{
BlackTempleCampaignData data = new BlackTempleCampaignData();
data.CampaignID = br.ReadInt32();
data.WaveName = br.ReadString();
data.WaveBattleTime = br.ReadInt32();
data.Model = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.RewardOrder = br.ReadInt32();
data.RewardBox = br.ReadInt32();
data.CampaignFightReward = br.ReadInt32();
data.AddBlood = br.ReadInt32();
data.ModelScale = br.ReadInt32();
data.HeroNum = br.ReadInt32();
data.ResetCampaignID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BlackTempleCampaignData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public BlackTempleCampaignData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
