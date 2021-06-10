using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Quest30Data
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
}
public partial class Quest30Config : ConfigBase
{
private static Quest30Config _instance;
public Dictionary<int, Quest30Data> _datas;
public static Quest30Config Instance
{
get
{
if (_instance == null)
{
_instance = new Quest30Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Quest30.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 30;i++)
{
Quest30Data data = new Quest30Data();
data.ID = br.ReadInt32();
data.SubFunctionId = br.ReadInt32();
data.ConditionType = br.ReadInt32();
data.Condition = br.ReadInt32();
data.Progress = br.ReadInt32();
data.Name = br.ReadString();
data.Icon = br.ReadString();
data.Desc = br.ReadString();
data.Order = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Quest30Data>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public Quest30Data Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
