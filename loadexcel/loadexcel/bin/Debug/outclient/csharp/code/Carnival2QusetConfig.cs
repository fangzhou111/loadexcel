using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Carnival2QusetData
{
/*唯一标识*/
public int ID; 
/*分页id*/
public int Openday; 
/*子分页id*/
public int SubPage; 
/*子分页名称*/
public string SubPageName; 
/*任务类型*/
public int QuestType; 
/*任务目标*/
public int Condition; 
/*任务需要数量*/
public int Progress; 
/*奖励id*/
public int RewardId; 
/*功能跳转*/
public int JumpId; 
/*任务描述*/
public string QuestDesc; 
}
public partial class Carnival2QusetConfig : ConfigBase
{
private static Carnival2QusetConfig _instance;
public Dictionary<int, Dictionary<int, Dictionary<int, Carnival2QusetData>>> _datas;
public static Carnival2QusetConfig Instance
{
get
{
if (_instance == null)
{
_instance = new Carnival2QusetConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Carnival2Quset.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 116;i++)
{
Carnival2QusetData data = new Carnival2QusetData();
data.ID = br.ReadInt32();
data.Openday = br.ReadInt32();
data.SubPage = br.ReadInt32();
data.SubPageName = br.ReadString();
data.QuestType = br.ReadInt32();
data.Condition = br.ReadInt32();
data.Progress = br.ReadInt32();
data.RewardId = br.ReadInt32();
data.JumpId = br.ReadInt32();
data.QuestDesc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, Dictionary<int, Carnival2QusetData>>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, Dictionary<int, Carnival2QusetData>> _dic = new Dictionary<int, Dictionary<int, Carnival2QusetData>>();
_datas.Add(data.ID, _dic);
}
if (!_datas[data.ID].ContainsKey(data.Openday))
{
Dictionary<int, Carnival2QusetData> _dic = new Dictionary<int, Carnival2QusetData>();
_datas[data.ID].Add(data.Openday, _dic);
}
_datas[data.ID][data.Openday].Add(data.SubPage,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, Dictionary<int, Carnival2QusetData>> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public Dictionary<int, Carnival2QusetData> Get(int newID,int newOpenday)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newOpenday))
return _datas[newID][newOpenday];
else
return null;
}
public Carnival2QusetData Get(int newID,int newOpenday,int newSubPage)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newOpenday) && _datas[newID][newOpenday].ContainsKey(newSubPage))
return _datas[newID][newOpenday][newSubPage];
else
return null;
}
}
}
