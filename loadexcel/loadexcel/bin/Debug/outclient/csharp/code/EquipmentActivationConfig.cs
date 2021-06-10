using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipmentActivationData
{
/*装备ID*/
public int ID; 
/*装备名*/
public string Name; 
/*装备部位*/
public int EquipmentPart; 
/*装备类型*/
public int EquipmentType; 
/*激活等级*/
public int ActivationLevel; 
/*激活效果*/
public int Effect; 
/*增加怒气*/
public int Anger; 
/*普攻技能*/
public string GelSkill; 
/*普攻技能*/
public string BulletName; 
/*怒攻技能*/
public string AngSkill; 
/*触发器*/
public string trrigers; 
/*开启效果名*/
public string Effect1Name; 
/*开启效果描述*/
public string Effect1Des; 
}
public partial class EquipmentActivationConfig : ConfigBase
{
private static EquipmentActivationConfig _instance;
public Dictionary<int, Dictionary<int, EquipmentActivationData>> _datas;
public static EquipmentActivationConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipmentActivationConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipmentActivation.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1006;i++)
{
EquipmentActivationData data = new EquipmentActivationData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.EquipmentPart = br.ReadInt32();
data.EquipmentType = br.ReadInt32();
data.ActivationLevel = br.ReadInt32();
data.Effect = br.ReadInt32();
data.Anger = br.ReadInt32();
data.GelSkill = br.ReadString();
data.BulletName = br.ReadString();
data.AngSkill = br.ReadString();
data.trrigers = br.ReadString();
data.Effect1Name = br.ReadString();
data.Effect1Des = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, EquipmentActivationData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, EquipmentActivationData> _dic = new Dictionary<int, EquipmentActivationData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.ActivationLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, EquipmentActivationData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public EquipmentActivationData Get(int newID,int newActivationLevel)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newActivationLevel))
return _datas[newID][newActivationLevel];
else
return null;
}
}
}
