using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ObjectiveLeadingData
{
/*主键ID，唯一不可重复*/
public int ID; 
/*功能ID*/
public int SubFunctionId; 
/*完成条件类型*/
public int ConditionType; 
/*任务达成条件*/
public int Condition; 
/*任务进度*/
public int Progress; 
/*任务名称*/
public string Name; 
/*任务ICON*/
public string Icon; 
/*任务描述*/
public string Desc; 
/*完成任务奖励*/
public int Order; 
/*显示排序*/
public int Index; 
}
public partial class ObjectiveLeadingConfig : ConfigBase
{
private static ObjectiveLeadingConfig _instance;
public Dictionary<int, ObjectiveLeadingData> _datas;
public static ObjectiveLeadingConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ObjectiveLeadingConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ObjectiveLeading.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 13;i++)
{
ObjectiveLeadingData data = new ObjectiveLeadingData();
data.ID = br.ReadInt32();
data.SubFunctionId = br.ReadInt32();
data.ConditionType = br.ReadInt32();
data.Condition = br.ReadInt32();
data.Progress = br.ReadInt32();
data.Name = br.ReadString();
data.Icon = br.ReadString();
data.Desc = br.ReadString();
data.Order = br.ReadInt32();
data.Index = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ObjectiveLeadingData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ObjectiveLeadingData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
