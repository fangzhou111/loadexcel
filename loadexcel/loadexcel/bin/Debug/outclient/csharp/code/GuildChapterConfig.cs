using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuildChapterData
{
/*章节ID，主键唯一不可重复*/
public int CampaignChapterID; 
/*章节名称*/
public string CampaignChapterName; 
/*沙盘资源ID*/
public string CampaignSandID; 
/*路线预制体ID*/
public string NodeID; 
/*奖励预览*/
public string RwardShow; 
/*显示头像*/
public int Riadshow; 
/*显示头像框*/
public int RiadFrameShow; 
/*进入等级限制*/
public int RiadNeedLevel; 
/*前置章节*/
public int PreposeChapter; 
/*限时通关*/
public int RaidDoneTime; 
/*限时通关奖励*/
public int RaidDoneRward; 
/*通关奖励*/
public int DoneReward; 
}
public partial class GuildChapterConfig : ConfigBase
{
private static GuildChapterConfig _instance;
public Dictionary<int, GuildChapterData> _datas;
public static GuildChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuildChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GuildChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
GuildChapterData data = new GuildChapterData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignChapterName = br.ReadString();
data.CampaignSandID = br.ReadString();
data.NodeID = br.ReadString();
data.RwardShow = br.ReadString();
data.Riadshow = br.ReadInt32();
data.RiadFrameShow = br.ReadInt32();
data.RiadNeedLevel = br.ReadInt32();
data.PreposeChapter = br.ReadInt32();
data.RaidDoneTime = br.ReadInt32();
data.RaidDoneRward = br.ReadInt32();
data.DoneReward = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GuildChapterData>();
_datas.Add(data.CampaignChapterID,data);
}
br.Close();
fs.Close();
}
public GuildChapterData Get(int newCampaignChapterID)
{
if (_datas.ContainsKey(newCampaignChapterID))
return _datas[newCampaignChapterID];
else
return null;
}
}
}
