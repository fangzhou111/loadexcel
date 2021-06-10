using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainQuestData
{
/*任务ID*/
public int QuestID; 
/*任务名*/
public string QuestName; 
/*任务描述*/
public string Dec; 
}
public partial class DomainQuestConfig : ConfigBase
{
private static DomainQuestConfig _instance;
public Dictionary<int, DomainQuestData> _datas;
public static DomainQuestConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainQuestConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainQuest.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
DomainQuestData data = new DomainQuestData();
data.QuestID = br.ReadInt32();
data.QuestName = br.ReadString();
data.Dec = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, DomainQuestData>();
_datas.Add(data.QuestID,data);
}
br.Close();
fs.Close();
}
public DomainQuestData Get(int newQuestID)
{
if (_datas.ContainsKey(newQuestID))
return _datas[newQuestID];
else
return null;
}
}
}
