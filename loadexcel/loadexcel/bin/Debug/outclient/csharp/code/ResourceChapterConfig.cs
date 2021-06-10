using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ResourceChapterData
{
/*章节ID，主键唯一不可重复*/
public int ResourceChapterID; 
/*资源副本章节名称*/
public string ResourceChapterName; 
/*资源副本章节开放时间（星期）*/
public string ResourceChapterOpeningTime; 
/*每日可挑战次数*/
public int ResourceChapterChallengeTime; 
/*奖励预览类型*/
public int RewardReview; 
/*章节介绍*/
public string ResourceChapterMessage; 
/*章节开放描述*/
public string ResourceChapterTxt; 
}
public partial class ResourceChapterConfig : ConfigBase
{
private static ResourceChapterConfig _instance;
public Dictionary<int, ResourceChapterData> _datas;
public static ResourceChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ResourceChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ResourceChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 6;i++)
{
ResourceChapterData data = new ResourceChapterData();
data.ResourceChapterID = br.ReadInt32();
data.ResourceChapterName = br.ReadString();
data.ResourceChapterOpeningTime = br.ReadString();
data.ResourceChapterChallengeTime = br.ReadInt32();
data.RewardReview = br.ReadInt32();
data.ResourceChapterMessage = br.ReadString();
data.ResourceChapterTxt = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ResourceChapterData>();
_datas.Add(data.ResourceChapterID,data);
}
br.Close();
fs.Close();
}
public ResourceChapterData Get(int newResourceChapterID)
{
if (_datas.ContainsKey(newResourceChapterID))
return _datas[newResourceChapterID];
else
return null;
}
}
}
