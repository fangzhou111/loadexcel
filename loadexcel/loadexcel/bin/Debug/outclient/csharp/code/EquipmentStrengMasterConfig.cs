using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentStrengMasterData
{
/*ID*/
public int ID; 
/*装备类型*/
public int EquipmentType; 
/*需要等级*/
public int StrengLevel; 
/*激活强化大师等级*/
public int StrengMaster; 
/*激活效果*/
public int EffectStreng; 
/*效果描述*/
public string Desc; 
}
public partial class EquipmentStrengMasterConfig : ConfigBase
{
private static EquipmentStrengMasterConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentStrengMasterData>> _datas;
public static EquipmentStrengMasterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentStrengMasterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentStrengMaster.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 38;i++)
{
EquipmentStrengMasterData data = new EquipmentStrengMasterData();
data.ID = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
data.StrengLevel = br.ReadInt32();
data.StrengMaster = br.ReadInt32();
data.EffectStreng = br.ReadInt32();
data.Desc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentStrengMasterData>>();
if (!_datas.ContainsKey(data.EquipmentType))
{
Dictionary<int, EquipmentStrengMasterData> _dic = new Dictionary<int, EquipmentStrengMasterData>();
_datas.Add(data.EquipmentType, _dic);
}
_datas[data.EquipmentType].Add(data.StrengLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentStrengMasterData> Get(int newEquipmentType)
{
if (_datas.ContainsKey(newEquipmentType))
return _datas[newEquipmentType];
else
return null;
}
public EquipmentStrengMasterData Get(int newEquipmentType,int newStrengLevel)
{
if (_datas.ContainsKey(newEquipmentType) && _datas[newEquipmentType].ContainsKey(newStrengLevel))
return _datas[newEquipmentType][newStrengLevel];
else
return null;
}
}
}
