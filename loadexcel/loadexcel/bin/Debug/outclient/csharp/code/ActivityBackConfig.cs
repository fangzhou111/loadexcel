using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ActivityBackData
{
/*系统ID*/
public int ActivityID; 
/*子系统*/
public int ChildID; 
/*系统图片*/
public int Icon; 
/*系统名称*/
public string ActivityName; 
/*内容描述*/
public string ActivityDesc; 
/*单次次数找回金额*/
public int Money; 
/*货币类型*/
public int MoneyType; 
/*找回数量*/
public int BackNum; 
/*排序*/
public int sort; 
}
public partial class ActivityBackConfig : ConfigBase
{
private static ActivityBackConfig _instance;
public Dictionary<int, Dictionary<int, ActivityBackData>> _datas;
public static ActivityBackConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ActivityBackConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ActivityBack.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 14;i++)
{
ActivityBackData data = new ActivityBackData();
data.ActivityID = br.ReadInt32();
data.ChildID = br.ReadInt32();
data.Icon = br.ReadInt32();
data.ActivityName = br.ReadString();
data.ActivityDesc = br.ReadString();
data.Money = br.ReadInt32();
data.MoneyType = br.ReadInt32();
data.BackNum = br.ReadInt32();
data.sort = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, ActivityBackData>>();
if (!_datas.ContainsKey(data.ActivityID))
{
Dictionary<int, ActivityBackData> _dic = new Dictionary<int, ActivityBackData>();
_datas.Add(data.ActivityID, _dic);
}
_datas[data.ActivityID].Add(data.ChildID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ActivityBackData> Get(int newActivityID)
{
if (_datas.ContainsKey(newActivityID))
return _datas[newActivityID];
else
return null;
}
public ActivityBackData Get(int newActivityID,int newChildID)
{
if (_datas.ContainsKey(newActivityID) && _datas[newActivityID].ContainsKey(newChildID))
return _datas[newActivityID][newChildID];
else
return null;
}
}
}
