using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FateFightChapterData
{
/*章节ID*/
public int CampaignChapterID; 
/*章节名称*/
public string CampaignChapterName; 
/*章节开启等级*/
public int CampaignOpeningLevel; 
/*奖励预览*/
public string RewardPreview; 
}
public partial class FateFightChapterConfig : ConfigBase
{
private static FateFightChapterConfig _instance;
public Dictionary<int, FateFightChapterData> _datas;
public static FateFightChapterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FateFightChapterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FateFightChapter.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
FateFightChapterData data = new FateFightChapterData();
data.CampaignChapterID = br.ReadInt32();
data.CampaignChapterName = br.ReadString();
data.CampaignOpeningLevel = br.ReadInt32();
data.RewardPreview = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, FateFightChapterData>();
_datas.Add(data.CampaignChapterID,data);
}
br.Close();
fs.Close();
}
public FateFightChapterData Get(int newCampaignChapterID)
{
if (_datas.ContainsKey(newCampaignChapterID))
return _datas[newCampaignChapterID];
else
return null;
}
}
}
