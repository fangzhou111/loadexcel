using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CarnivalItemsData
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
public partial class CarnivalItemsConfig : ConfigBase
{
private static CarnivalItemsConfig _instance;
public Dictionary<int, Dictionary<int, Dictionary<int, CarnivalItemsData>>> _datas;
public static CarnivalItemsConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CarnivalItemsConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CarnivalItems.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 106;i++)
{
CarnivalItemsData data = new CarnivalItemsData();
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
_datas = new Dictionary<int, Dictionary<int, Dictionary<int, CarnivalItemsData>>>();
if (!_datas.ContainsKey(data.id))
{
Dictionary<int, Dictionary<int, CarnivalItemsData>> _dic = new Dictionary<int, Dictionary<int, CarnivalItemsData>>();
_datas.Add(data.id, _dic);
}
if (!_datas[data.id].ContainsKey(data.FunctionId))
{
Dictionary<int, CarnivalItemsData> _dic = new Dictionary<int, CarnivalItemsData>();
_datas[data.id].Add(data.FunctionId, _dic);
}
_datas[data.id][data.FunctionId].Add(data.SubFunctionId,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, Dictionary<int, CarnivalItemsData>> Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
public Dictionary<int, CarnivalItemsData> Get(int newid,int newFunctionId)
{
if (_datas.ContainsKey(newid) && _datas[newid].ContainsKey(newFunctionId))
return _datas[newid][newFunctionId];
else
return null;
}
public CarnivalItemsData Get(int newid,int newFunctionId,int newSubFunctionId)
{
if (_datas.ContainsKey(newid) && _datas[newid].ContainsKey(newFunctionId) && _datas[newid][newFunctionId].ContainsKey(newSubFunctionId))
return _datas[newid][newFunctionId][newSubFunctionId];
else
return null;
}
}
}
