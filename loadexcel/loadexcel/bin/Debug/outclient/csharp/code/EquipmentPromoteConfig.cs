using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentPromoteData
{
/*装备Id*/
public int ID; 
/*装备部位*/
public int EquipmentPart; 
/*装备类型*/
public int EquipmentType; 
/*分段起始等级*/
public int PromoteStart; 
/*分段结束等级*/
public int PromoteOver; 
/*物攻增量*/
public double PhysicsAtkInc; 
/*魔攻增量*/
public double MagicAtkInc; 
/*物防增量*/
public double PhysicsDefInc; 
/*魔防增量*/
public double MagicDefInc; 
/*血量增量*/
public double HPInc; 
/*命中增量*/
public double HitRateInc; 
/*闪避增量*/
public double DodgeRateInc; 
/*暴击增量*/
public double CritRateInc; 
/*韧性增量*/
public double ToughnessInc; 
/*招架增量*/
public double ParryRateInc; 
/*精准增量*/
public double PrecisionRateInc; 
}
public partial class EquipmentPromoteConfig : ConfigBase
{
private static EquipmentPromoteConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentPromoteData>> _datas;
public static EquipmentPromoteConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentPromoteConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentPromote.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 71;i++)
{
EquipmentPromoteData data = new EquipmentPromoteData();
data.ID = br.ReadInt32();
data.EquipmentPart = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
data.PromoteStart = br.ReadInt32();
data.PromoteOver = br.ReadInt32();
data.PhysicsAtkInc = (float)br.ReadDouble();
data.MagicAtkInc = (float)br.ReadDouble();
data.PhysicsDefInc = (float)br.ReadDouble();
data.MagicDefInc = (float)br.ReadDouble();
data.HPInc = (float)br.ReadDouble();
data.HitRateInc = (float)br.ReadDouble();
data.DodgeRateInc = (float)br.ReadDouble();
data.CritRateInc = (float)br.ReadDouble();
data.ToughnessInc = (float)br.ReadDouble();
data.ParryRateInc = (float)br.ReadDouble();
data.PrecisionRateInc = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentPromoteData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, EquipmentPromoteData> _dic = new Dictionary<int, EquipmentPromoteData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.PromoteStart,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentPromoteData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public EquipmentPromoteData Get(int newID,int newPromoteStart)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newPromoteStart))
return _datas[newID][newPromoteStart];
else
return null;
}
}
}
