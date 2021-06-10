using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentRefineMasterData
{
/*ID*/
public int ID; 
/*装备类型*/
public int EquipmentType; 
/*需要等级*/
public int RefineLevel; 
/*激活大师等级*/
public int RefineMaster; 
/*激活效果*/
public int EffectRefine; 
/*效果描述*/
public string Desc; 
}
public partial class EquipmentRefineMasterConfig : ConfigBase
{
private static EquipmentRefineMasterConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentRefineMasterData>> _datas;
public static EquipmentRefineMasterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentRefineMasterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentRefineMaster.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 44;i++)
{
EquipmentRefineMasterData data = new EquipmentRefineMasterData();
data.ID = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
data.RefineLevel = br.ReadInt32();
data.RefineMaster = br.ReadInt32();
data.EffectRefine = br.ReadInt32();
data.Desc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentRefineMasterData>>();
if (!_datas.ContainsKey(data.EquipmentType))
{
Dictionary<int, EquipmentRefineMasterData> _dic = new Dictionary<int, EquipmentRefineMasterData>();
_datas.Add(data.EquipmentType, _dic);
}
_datas[data.EquipmentType].Add(data.RefineLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentRefineMasterData> Get(int newEquipmentType)
{
if (_datas.ContainsKey(newEquipmentType))
return _datas[newEquipmentType];
else
return null;
}
public EquipmentRefineMasterData Get(int newEquipmentType,int newRefineLevel)
{
if (_datas.ContainsKey(newEquipmentType) && _datas[newEquipmentType].ContainsKey(newRefineLevel))
return _datas[newEquipmentType][newRefineLevel];
else
return null;
}
}
}
