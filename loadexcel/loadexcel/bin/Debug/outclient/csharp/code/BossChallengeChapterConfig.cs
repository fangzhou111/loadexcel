using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeChapterData
{
/*章节ID，主键唯一不可重复*/
public int BossChallengeChapterID; 
/*boss名称*/
public string BossChallengeChapterName; 
/*触发概率*/
public int BossChallengeChapterProbability; 
/*无奖励时预览*/
public string BossChallengeShow; 
}
public partial class BossChallengeChapterConfig : ConfigBase
{
private static BossChallengeChapterConfig _instance;
public Dictionary<int, BossChallengeChapterData> _datas;
public static BossChallengeChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
BossChallengeChapterData data = new BossChallengeChapterData();
data.BossChallengeChapterID = br.ReadInt32();
data.BossChallengeChapterName = br.ReadString();
data.BossChallengeChapterProbability = br.ReadInt32();
data.BossChallengeShow = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, BossChallengeChapterData>();
_datas.Add(data.BossChallengeChapterID,data);
}
br.Close();
fs.Close();
}
public BossChallengeChapterData Get(int newBossChallengeChapterID)
{
if (_datas.ContainsKey(newBossChallengeChapterID))
return _datas[newBossChallengeChapterID];
else
return null;
}
}
}
