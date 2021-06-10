using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GemBaseData
{
/*宝石ID*/
public int GemID; 
/*宝石类型*/
public int Type; 
/*宝石等级*/
public int Level; 
/*宝石品质*/
public int Profile; 
/*提供的物理攻击*/
public int PhysicsAtk; 
/*提供的魔法攻击*/
public int MagicAtk; 
/*提供的物理防御*/
public int PhysicsDef; 
/*提供的魔法防御*/
public int MagicDef; 
/*提供的血量*/
public int HP; 
/*提供的命中值*/
public int HitRate; 
/*提供的闪避值*/
public int DodgeRate; 
/*提供的暴击值*/
public int CritRate; 
/*提供的韧性值*/
public int Toughness; 
/*提供的招架值*/
public int ParryRate; 
/*提供的精准值*/
public int PrecisionRate; 
/*模型颜色*/
public string ModelColor; 
}
public partial class GemBaseConfig : ConfigBase
{
private static GemBaseConfig _instance;
public Dictionary<int, GemBaseData> _datas;
public static GemBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GemBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GemBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 66;i++)
{
GemBaseData data = new GemBaseData();
data.GemID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Level = br.ReadInt32();
data.Profile = br.ReadInt32();
data.PhysicsAtk = br.ReadInt32();
data.MagicAtk = br.ReadInt32();
data.PhysicsDef = br.ReadInt32();
data.MagicDef = br.ReadInt32();
data.HP = br.ReadInt32();
data.HitRate = br.ReadInt32();
data.DodgeRate = br.ReadInt32();
data.CritRate = br.ReadInt32();
data.Toughness = br.ReadInt32();
data.ParryRate = br.ReadInt32();
data.PrecisionRate = br.ReadInt32();
data.ModelColor = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, GemBaseData>();
_datas.Add(data.GemID,data);
}
br.Close();
fs.Close();
}
public GemBaseData Get(int newGemID)
{
if (_datas.ContainsKey(newGemID))
return _datas[newGemID];
else
return null;
}
}
}
