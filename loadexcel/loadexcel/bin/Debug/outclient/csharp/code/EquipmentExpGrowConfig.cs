using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentExpGrowData
{
/*参数ID*/
public int ID; 
/*参数类型*/
public int Type; 
/*参数对应的值*/
public int Idvalue; 
/*系数*/
public double ExpGrow; 
}
public partial class EquipmentExpGrowConfig : ConfigBase
{
private static EquipmentExpGrowConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentExpGrowData>> _datas;
public static EquipmentExpGrowConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentExpGrowConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentExpGrow.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 72;i++)
{
EquipmentExpGrowData data = new EquipmentExpGrowData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Idvalue = br.ReadInt32();
data.ExpGrow = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentExpGrowData>>();
if (!_datas.ContainsKey(data.Type))
{
Dictionary<int, EquipmentExpGrowData> _dic = new Dictionary<int, EquipmentExpGrowData>();
_datas.Add(data.Type, _dic);
}
_datas[data.Type].Add(data.Idvalue,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentExpGrowData> Get(int newType)
{
if (_datas.ContainsKey(newType))
return _datas[newType];
else
return null;
}
public EquipmentExpGrowData Get(int newType,int newIdvalue)
{
if (_datas.ContainsKey(newType) && _datas[newType].ContainsKey(newIdvalue))
return _datas[newType][newIdvalue];
else
return null;
}
}
}
