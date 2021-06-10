using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EffectData
{
/*主键，唯一ID*/
public int ID; 
/*效果名*/
public string Name; 
/*描述*/
public string Desc; 
/*类型*/
public int Type; 
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
/*招架*/
public double ParryRate; 
/*精准*/
public double PrecisionRate; 
/*携带技能ID*/
public string SkillID; 
}
public partial class EffectConfig : ConfigBase
{
private static EffectConfig _instance;
public Dictionary<int, EffectData> _datas;
public static EffectConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EffectConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Effect.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 474;i++)
{
EffectData data = new EffectData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.Desc = br.ReadString();
data.Type = br.ReadInt32();
data.PhysicsAtk = (float)br.ReadDouble();
data.MagicAtk = (float)br.ReadDouble();
data.PhysicsDef = (float)br.ReadDouble();
data.MagicDef = (float)br.ReadDouble();
data.HP = (float)br.ReadDouble();
data.HitRate = (float)br.ReadDouble();
data.DodgeRate = (float)br.ReadDouble();
data.CritRate = (float)br.ReadDouble();
data.Toughness = (float)br.ReadDouble();
data.ParryRate = (float)br.ReadDouble();
data.PrecisionRate = (float)br.ReadDouble();
data.SkillID = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, EffectData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public EffectData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
