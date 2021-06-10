using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeRewardData
{
/*章节ID*/
public int BossChallengeChapterID; 
/*怪物等级*/
public int BossChallengeMonsterlv; 
/*boss强度等级*/
public int CampaignBossLevel; 
/*每次战斗获取经验*/
public string BattleExp; 
/*发现奖励*/
public int FindReward; 
/*击杀奖励*/
public int KillReward; 
/*每次战斗奖励*/
public int OnceReward; 
/*分享奖励*/
public int ShareReward; 
}
public partial class BossChallengeRewardConfig : ConfigBase
{
private static BossChallengeRewardConfig _instance;
public Dictionary<int, Dictionary<int, BossChallengeRewardData>> _datas;
public static BossChallengeRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 400;i++)
{
BossChallengeRewardData data = new BossChallengeRewardData();
data.BossChallengeChapterID = br.ReadInt32();
data.BossChallengeMonsterlv = br.ReadInt32();
data.CampaignBossLevel = br.ReadInt32();
data.BattleExp = br.ReadString();
data.FindReward = br.ReadInt32();
data.KillReward = br.ReadInt32();
data.OnceReward = br.ReadInt32();
data.ShareReward = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, BossChallengeRewardData>>();
if (!_datas.ContainsKey(data.BossChallengeChapterID))
{
Dictionary<int, BossChallengeRewardData> _dic = new Dictionary<int, BossChallengeRewardData>();
_datas.Add(data.BossChallengeChapterID, _dic);
}
_datas[data.BossChallengeChapterID].Add(data.CampaignBossLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, BossChallengeRewardData> Get(int newBossChallengeChapterID)
{
if (_datas.ContainsKey(newBossChallengeChapterID))
return _datas[newBossChallengeChapterID];
else
return null;
}
public BossChallengeRewardData Get(int newBossChallengeChapterID,int newCampaignBossLevel)
{
if (_datas.ContainsKey(newBossChallengeChapterID) && _datas[newBossChallengeChapterID].ContainsKey(newCampaignBossLevel))
return _datas[newBossChallengeChapterID][newCampaignBossLevel];
else
return null;
}
}
}
