using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CarnivalItems_act2Data
{
/*唯一标识*/
public int id; 
/*功能id*/
public int FunctionId; 
/*子功能id*/
public int SubFunctionId; 
/*子功能要求*/
public int SubFunctionValue1; 
/*子功能要求2*/
public int SubFunctionValue2; 
/*奖励id*/
public int RewardId; 
/*功能跳转*/
public int JumpId; 
/*子功能名称*/
public string SubFunctionName; 
/*子功能项目描述*/
public string SubFunctionDesc; 
}
public partial class CarnivalItems_act2Config : ConfigBase
{
private static CarnivalItems_act2Config _instance;
public Dictionary<int, Dictionary<int, Dictionary<int, CarnivalItems_act2Data>>> _datas;
public static CarnivalItems_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new CarnivalItems_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CarnivalItems_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
CarnivalItems_act2Data data = new CarnivalItems_act2Data();
data.id = br.ReadInt32();
data.FunctionId = br.ReadInt32();
data.SubFunctionId = br.ReadInt32();
data.SubFunctionValue1 = br.ReadInt32();
data.SubFunctionValue2 = br.ReadInt32();
data.RewardId = br.ReadInt32();
data.JumpId = br.ReadInt32();
data.SubFunctionName = br.ReadString();
data.SubFunctionDesc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, Dictionary<int, CarnivalItems_act2Data>>>();
if (!_datas.ContainsKey(data.id))
{
Dictionary<int, Dictionary<int, CarnivalItems_act2Data>> _dic = new Dictionary<int, Dictionary<int, CarnivalItems_act2Data>>();
_datas.Add(data.id, _dic);
}
if (!_datas[data.id].ContainsKey(data.FunctionId))
{
Dictionary<int, CarnivalItems_act2Data> _dic = new Dictionary<int, CarnivalItems_act2Data>();
_datas[data.id].Add(data.FunctionId, _dic);
}
_datas[data.id][data.FunctionId].Add(data.SubFunctionId,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, Dictionary<int, CarnivalItems_act2Data>> Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
public Dictionary<int, CarnivalItems_act2Data> Get(int newid,int newFunctionId)
{
if (_datas.ContainsKey(newid) && _datas[newid].ContainsKey(newFunctionId))
return _datas[newid][newFunctionId];
else
return null;
}
public CarnivalItems_act2Data Get(int newid,int newFunctionId,int newSubFunctionId)
{
if (_datas.ContainsKey(newid) && _datas[newid].ContainsKey(newFunctionId) && _datas[newid][newFunctionId].ContainsKey(newSubFunctionId))
return _datas[newid][newFunctionId][newSubFunctionId];
else
return null;
}
}
}
