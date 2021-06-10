using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ChapterData
{
/*章节ID，主键唯一不可重复*/
public int CampaignChapterID; 
/*章节名称*/
public string CampaignChapterName; 
/*宝箱开启条件（通关某关）*/
public string CampaignID; 
/*关卡宝箱*/
public string CampaignChest; 
/*星级条件*/
public string Star; 
/*星级宝箱*/
public string Order; 
/*通关天命道具奖励*/
public int Customs ; 
/*沙盘资源ID*/
public string CampaignSandID; 
/*路线预制体ID*/
public string NodeID; 
}
public partial class ChapterConfig : ConfigBase
{
private static ChapterConfig _instance;
public Dictionary<int, ChapterData> _datas;
public static ChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Chapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 102;i++)
{
ChapterData data = new ChapterData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignChapterName = br.ReadString();
data.CampaignID = br.ReadString();
data.CampaignChest = br.ReadString();
data.Star = br.ReadString();
data.Order = br.ReadString();
data.Customs  = br.ReadInt32();
data.CampaignSandID = br.ReadString();
data.NodeID = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ChapterData>();
_datas.Add(data.CampaignChapterID,data);
}
br.Close();
fs.Close();
}
public ChapterData Get(int newCampaignChapterID)
{
if (_datas.ContainsKey(newCampaignChapterID))
return _datas[newCampaignChapterID];
else
return null;
}
}
}
