using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TimeCaveChapterData
{
/*章节ID，主键唯一不可重复*/
public int CampaignChapterID; 
/*章节名称*/
public string CampaignChapterName; 
/*预览Boss模型*/
public string Model; 
/*开放时间（星期几）*/
public string OpenDay; 
/*Boss描述*/
public string Desc; 
}
public partial class TimeCaveChapterConfig : ConfigBase
{
private static TimeCaveChapterConfig _instance;
public Dictionary<int, TimeCaveChapterData> _datas;
public static TimeCaveChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TimeCaveChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TimeCaveChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 2;i++)
{
TimeCaveChapterData data = new TimeCaveChapterData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignChapterName = br.ReadString();
data.Model = br.ReadString();
data.OpenDay = br.ReadString();
data.Desc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, TimeCaveChapterData>();
_datas.Add(data.CampaignChapterID,data);
}
br.Close();
fs.Close();
}
public TimeCaveChapterData Get(int newCampaignChapterID)
{
if (_datas.ContainsKey(newCampaignChapterID))
return _datas[newCampaignChapterID];
else
return null;
}
}
}
