using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentExpData
{
/*当前等级*/
public int Level; 
/*装备*/
public int Type; 
/*提升所需*/
public int BaseExp; 
/*精炼需要金钱*/
public int BaseGold; 
/*进阶等级限制*/
public int StepLevel; 
/*装备分解等级返还系数*/
public int EquipDecLevelRatio; 
}
public partial class EquipmentExpConfig : ConfigBase
{
private static EquipmentExpConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentExpData>> _datas;
public static EquipmentExpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentExpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentExp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 761;i++)
{
EquipmentExpData data = new EquipmentExpData();
data.Level = br.ReadInt32();
data.Type = br.ReadInt32();
data.BaseExp = br.ReadInt32();
data.BaseGold = br.ReadInt32();
data.StepLevel = br.ReadInt32();
data.EquipDecLevelRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentExpData>>();
if (!_datas.ContainsKey(data.Level))
{
Dictionary<int, EquipmentExpData> _dic = new Dictionary<int, EquipmentExpData>();
_datas.Add(data.Level, _dic);
}
_datas[data.Level].Add(data.Type,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentExpData> Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
public EquipmentExpData Get(int newLevel,int newType)
{
if (_datas.ContainsKey(newLevel) && _datas[newLevel].ContainsKey(newType))
return _datas[newLevel][newType];
else
return null;
}
}
}
