using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class MonsterPPData
{
/*强度类型*/
public int ID; 
/*物攻系数*/
public double PhysicsAtk; 
/*魔攻系数*/
public double MagicAtk; 
/*物防系数*/
public double PhysicsDef; 
/*魔防系数*/
public double MagicDef; 
/*血量系数*/
public double HP; 
/*命中系数*/
public double HitRate; 
/*闪避系数*/
public double DodgeRate; 
/*暴击系数*/
public double CritRate; 
/*韧性系数*/
public double Toughness; 
/*招架系数*/
public double ParryRate; 
/*精准系数*/
public double PrecisionRate; 
/*资质系数*/
public double MonsterStarStr; 
/*怪物类型系数*/
public double MonsterTypeStr; 
}
public partial class MonsterPPConfig : ConfigBase
{
private static MonsterPPConfig _instance;
public Dictionary<int, MonsterPPData> _datas;
public static MonsterPPConfig Instance
{
get
{
if (_instance == null)
{
_instance = new MonsterPPConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("MonsterPP.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 26;i++)
{
MonsterPPData data = new MonsterPPData();
data.ID = br.ReadInt32();
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
data.MonsterStarStr = (float)br.ReadDouble();
data.MonsterTypeStr = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, MonsterPPData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public MonsterPPData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
