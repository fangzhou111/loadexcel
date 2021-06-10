using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentSuitData
{
/*主键，唯一ID*/
public int SuitID; 
/*套装名*/
public string Name; 
/*套装描述*/
public string Desc; 
/*装备ID1*/
public int Equipment1; 
/*装备ID2*/
public int Equipment2; 
/*装备ID3*/
public int Equipment3; 
/*装备ID4*/
public int Equipment4; 
/*装备ID5*/
public int Equipment5; 
/*装备ID6*/
public int Equipment6; 
/*1套装效果ID*/
public string EffectID1; 
/*2套装效果ID*/
public string EffectID2; 
/*3套装效果ID*/
public string EffectID3; 
/*4套装效果ID*/
public string EffectID4; 
/*5套装效果ID*/
public string EffectID5; 
/*6套装效果ID*/
public string EffectID6; 
/*1套装触发器*/
public string trrigers1; 
/*2套装触发器*/
public string trrigers2; 
/*3套装触发器*/
public string trrigers3; 
/*4套装触发器*/
public string trrigers4; 
/*2套装描述*/
public string Desc2; 
/*3套装描述*/
public string Desc3; 
/*4套装描述*/
public string Desc4; 
}
public partial class EquipmentSuitConfig : ConfigBase
{
private static EquipmentSuitConfig _instance;
public Dictionary<int, EquipmentSuitData> _datas;
public static EquipmentSuitConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentSuitConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentSuit.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
EquipmentSuitData data = new EquipmentSuitData();
data.SuitID = br.ReadInt32();
data.Name = br.ReadString();
data.Desc = br.ReadString();
data.Equipment1 = br.ReadInt32();
data.Equipment2 = br.ReadInt32();
data.Equipment3 = br.ReadInt32();
data.Equipment4 = br.ReadInt32();
data.Equipment5 = br.ReadInt32();
data.Equipment6 = br.ReadInt32();
data.EffectID1 = br.ReadString();
data.EffectID2 = br.ReadString();
data.EffectID3 = br.ReadString();
data.EffectID4 = br.ReadString();
data.EffectID5 = br.ReadString();
data.EffectID6 = br.ReadString();
data.trrigers1 = br.ReadString();
data.trrigers2 = br.ReadString();
data.trrigers3 = br.ReadString();
data.trrigers4 = br.ReadString();
data.Desc2 = br.ReadString();
data.Desc3 = br.ReadString();
data.Desc4 = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, EquipmentSuitData>();
_datas.Add(data.SuitID,data);
}
br.Close();
fs.Close();
}
public EquipmentSuitData Get(int newSuitID)
{
if (_datas.ContainsKey(newSuitID))
return _datas[newSuitID];
else
return null;
}
}
}
