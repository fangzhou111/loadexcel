using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ModelClothesBaseData
{
/*时装ID*/
public int ID; 
/*显示用序列*/
public int ShowID; 
/*名称*/
public string Name; 
/*时装模型*/
public string Model; 
/*头像*/
public int icon; 
/*时装描述*/
public string Desc; 
/*VIP等级*/
public int VipLv; 
/*消耗类型*/
public int ItemType; 
/*价格*/
public int Price; 
/*属性类型*/
public int AttriType; 
/*先手值*/
public int FirstHandValue; 
/*物攻*/
public double PhysicsAtk; 
/*魔攻*/
public double MagicAtk; 
/*物防*/
public double PhysicsDef; 
/*魔防*/
public double MagicDef; 
/*血量*/
public double HP; 
/*命中*/
public double HitRate; 
/*闪避*/
public double DodgeRate; 
/*暴击*/
public double CritRate; 
/*韧性*/
public double Toughness; 
}
public partial class ModelClothesBaseConfig : ConfigBase
{
private static ModelClothesBaseConfig _instance;
public Dictionary<int, ModelClothesBaseData> _datas;
public static ModelClothesBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ModelClothesBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ModelClothesBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 22;i++)
{
ModelClothesBaseData data = new ModelClothesBaseData();
data.ID = br.ReadInt32();
data.ShowID = br.ReadInt32();
data.Name = br.ReadString();
data.Model = br.ReadString();
data.icon = br.ReadInt32();
data.Desc = br.ReadString();
data.VipLv = br.ReadInt32();
data.ItemType = br.ReadInt32();
data.Price = br.ReadInt32();
data.AttriType = br.ReadInt32();
data.FirstHandValue = br.ReadInt32();
data.PhysicsAtk = (float)br.ReadDouble();
data.MagicAtk = (float)br.ReadDouble();
data.PhysicsDef = (float)br.ReadDouble();
data.MagicDef = (float)br.ReadDouble();
data.HP = (float)br.ReadDouble();
data.HitRate = (float)br.ReadDouble();
data.DodgeRate = (float)br.ReadDouble();
data.CritRate = (float)br.ReadDouble();
data.Toughness = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, ModelClothesBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ModelClothesBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
