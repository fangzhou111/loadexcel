using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TempleChapterData
{
/*章节ID，主键唯一不可重复*/
public int TempleChapterID; 
/*资源副本章节名称*/
public string TempleChapterName; 
/*资源副本章节开放时间（星期）*/
public string TempleChapterOpeningTime; 
/*每日可挑战次数*/
public int TempleChapterChallengeTime; 
/*奖励预览类型*/
public string RewardReview; 
}
public partial class TempleChapterConfig : ConfigBase
{
private static TempleChapterConfig _instance;
public Dictionary<int, TempleChapterData> _datas;
public static TempleChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TempleChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TempleChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
TempleChapterData data = new TempleChapterData();
data.TempleChapterID = br.ReadInt32();
data.TempleChapterName = br.ReadString();
data.TempleChapterOpeningTime = br.ReadString();
data.TempleChapterChallengeTime = br.ReadInt32();
data.RewardReview = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, TempleChapterData>();
_datas.Add(data.TempleChapterID,data);
}
br.Close();
fs.Close();
}
public TempleChapterData Get(int newTempleChapterID)
{
if (_datas.ContainsKey(newTempleChapterID))
return _datas[newTempleChapterID];
else
return null;
}
}
}
