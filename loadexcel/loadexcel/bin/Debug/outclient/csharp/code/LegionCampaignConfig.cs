using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LegionCampaignData
{
/*军团ID，对应章节信息表上的章节ID*/
public int LegionID; 
/*波次ID*/
public int LegionWaveID; 
/*需要通关普通关卡*/
public int PreposeCampaignID; 
/*需要通关精英关卡*/
public int PreposeEliteCampaignID; 
/*波次等级*/
public int WaveLevel; 
/*波次名称*/
public string WaveName; 
/*波次描述*/
public string WaveDesc; 
/*是否Boss波次*/
public int BossWave; 
/*波次战斗回合*/
public int WaveBattleTime; 
/*波次跳波时间（秒）*/
public int JumpWaveBattleTime; 
/*波次跳波ID*/
public int JumpWaveID; 
/*预览模型*/
public int Model; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
/*通关首次奖励*/
public int FirstRewardOrder; 
/*通过当前波次奖励，对应副本奖励表内的掉落ID*/
public string RewardOrder; 
/*通关额外宝箱
空或0表示无宝箱*/
public int Chest; 
/*模型大小/100*/
public int ModelScale; 
}
public partial class LegionCampaignConfig : ConfigBase
{
private static LegionCampaignConfig _instance;
public Dictionary<int, LegionCampaignData> _datas;
public static LegionCampaignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LegionCampaignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LegionCampaign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 120;i++)
{
LegionCampaignData data = new LegionCampaignData();
data.LegionID = br.ReadInt32();
data.LegionWaveID = br.ReadInt32();
data.PreposeCampaignID = br.ReadInt32();
data.PreposeEliteCampaignID = br.ReadInt32();
data.WaveLevel = br.ReadInt32();
data.WaveName = br.ReadString();
data.WaveDesc = br.ReadString();
data.BossWave = br.ReadInt32();
data.WaveBattleTime = br.ReadInt32();
data.JumpWaveBattleTime = br.ReadInt32();
data.JumpWaveID = br.ReadInt32();
data.Model = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
data.FirstRewardOrder = br.ReadInt32();
data.RewardOrder = br.ReadString();
data.Chest = br.ReadInt32();
data.ModelScale = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, LegionCampaignData>();
_datas.Add(data.LegionWaveID,data);
}
br.Close();
fs.Close();
}
public LegionCampaignData Get(int newLegionWaveID)
{
if (_datas.ContainsKey(newLegionWaveID))
return _datas[newLegionWaveID];
else
return null;
}
}
}
