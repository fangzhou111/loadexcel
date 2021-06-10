using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ValhallaData
{
/*Id*/
public int ID; 
/*当前好感阶段*/
public int IntimacyStep; 
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
public partial class ValhallaConfig : ConfigBase
{
private static ValhallaConfig _instance;
public Dictionary<int, Dictionary<int, ValhallaData>> _datas;
public static ValhallaConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ValhallaConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Valhalla.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 255;i++)
{
ValhallaData data = new ValhallaData();
data.ID = br.ReadInt32();
data.IntimacyStep = br.ReadInt32();
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
_datas = new Dictionary<int, Dictionary<int, ValhallaData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, ValhallaData> _dic = new Dictionary<int, ValhallaData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.IntimacyStep,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ValhallaData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public ValhallaData Get(int newID,int newIntimacyStep)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newIntimacyStep))
return _datas[newID][newIntimacyStep];
else
return null;
}
}
}
