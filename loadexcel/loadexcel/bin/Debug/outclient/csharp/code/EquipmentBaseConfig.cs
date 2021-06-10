using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentBaseData
{
/*装备ID*/
public int ID; 
/*装备模型*/
public string Model; 
/*装备等级*/
public int GS; 
/*装备星级*/
public int EquipmentStar; 
/*装备精炼次数*/
public int EquipAwakeNum; 
/*装备部位*/
public int EquipmentPart; 
/*装备类型*/
public int EquipmentType; 
/*所属套装*/
public int SuitID; 
/*被吞噬提供经验*/
public int OfferExp; 
/*效果1开启等级*/
public int Effect1Level; 
/*效果1ID*/
public string Effect1ID; 
/*效果2开启等级*/
public int Effect2Level; 
/*效果2ID*/
public string Effect2ID; 
/*效果3开启等级*/
public int Effect3Level; 
/*效果3ID*/
public string Effect3ID; 
/*初始品质*/
public int Quality; 
}
public partial class EquipmentBaseConfig : ConfigBase
{
private static EquipmentBaseConfig _instance;
public Dictionary<int, EquipmentBaseData> _datas;
public static EquipmentBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 132;i++)
{
EquipmentBaseData data = new EquipmentBaseData();
data.ID = br.ReadInt32();
data.Model = br.ReadString();
data.GS = br.ReadInt32();
data.EquipmentStar = br.ReadInt32();
data.EquipAwakeNum = br.ReadInt32();
data.EquipmentPart = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
data.SuitID = br.ReadInt32();
data.OfferExp = br.ReadInt32();
data.Effect1Level = br.ReadInt32();
data.Effect1ID = br.ReadString();
data.Effect2Level = br.ReadInt32();
data.Effect2ID = br.ReadString();
data.Effect3Level = br.ReadInt32();
data.Effect3ID = br.ReadString();
data.Quality = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, EquipmentBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public EquipmentBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
