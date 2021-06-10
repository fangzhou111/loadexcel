using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentAwakeData
{
/*Id*/
public int ID; 
/*觉醒等级*/
public int AwakeID; 
/*觉醒系数*/
public double AwakeGrow; 
/*觉醒道具*/
public int ItemID; 
/*消耗数量*/
public int Item1Num; 
/*金币消耗*/
public int Item2Num; 
/*装备觉醒钻石分解*/
public int EquipDecAwakeRatio; 
}
public partial class EquipmentAwakeConfig : ConfigBase
{
private static EquipmentAwakeConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentAwakeData>> _datas;
public static EquipmentAwakeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentAwakeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentAwake.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1344;i++)
{
EquipmentAwakeData data = new EquipmentAwakeData();
data.ID = br.ReadInt32();
data.AwakeID = br.ReadInt32();
data.AwakeGrow = (float)br.ReadDouble();
data.ItemID = br.ReadInt32();
data.Item1Num = br.ReadInt32();
data.Item2Num = br.ReadInt32();
data.EquipDecAwakeRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentAwakeData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, EquipmentAwakeData> _dic = new Dictionary<int, EquipmentAwakeData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.AwakeID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentAwakeData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public EquipmentAwakeData Get(int newID,int newAwakeID)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newAwakeID))
return _datas[newID][newAwakeID];
else
return null;
}
}
}
