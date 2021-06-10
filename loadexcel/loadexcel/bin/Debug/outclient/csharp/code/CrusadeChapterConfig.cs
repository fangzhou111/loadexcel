using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CrusadeChapterData
{
/*章节ID*/
public int ChapterID; 
/*前置剧情副本章节id*/
public int CampaignChapterID; 
/*章节名称*/
public string CampaignChapterName; 
/*显示头像*/
public int Riadshow; 
/*通关奖励*/
public int DoneReward; 
}
public partial class CrusadeChapterConfig : ConfigBase
{
private static CrusadeChapterConfig _instance;
public Dictionary<int, CrusadeChapterData> _datas;
public static CrusadeChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CrusadeChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CrusadeChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 23;i++)
{
CrusadeChapterData data = new CrusadeChapterData();
data.ChapterID = br.ReadInt32();
data.CampaignChapterID = br.ReadInt32();
data.CampaignChapterName = br.ReadString();
data.Riadshow = br.ReadInt32();
data.DoneReward = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, CrusadeChapterData>();
_datas.Add(data.ChapterID,data);
}
br.Close();
fs.Close();
}
public CrusadeChapterData Get(int newChapterID)
{
if (_datas.ContainsKey(newChapterID))
return _datas[newChapterID];
else
return null;
}
}
}
