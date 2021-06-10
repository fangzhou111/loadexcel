using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroAwake_act2Data
{
/*Id*/
public int ID; 
/*英雄星级*/
public int AwakeID; 
/*星级系数*/
public double AwakeGrow; 
/*消耗道具*/
public int Item1ID; 
/*消耗数量*/
public int Item1Num; 
/*消耗道具*/
public int Item3ID; 
/*消耗数量*/
public int Item3Num; 
/*金币消耗*/
public int Item2Num; 
/*英雄觉醒钻石分解*/
public int ResolveAwake; 
/*要求阶级*/
public int NeedStep; 
/*初始怒气值*/
public int RagePointBegin; 
/*开启属性类型*/
public int EffectType; 
/*开启效果(特质)*/
public int Effect1ID; 
/*普攻技能*/
public string GelSkill; 
/*普攻技能*/
public string BulletName; 
/*怒攻技能*/
public string AngSkill; 
/*触发器*/
public string triggers; 
/*开启效果名*/
public string Effect1Name; 
/*开启效果描述*/
public string Effect1Des; 
}
public partial class HeroAwake_act2Config : ConfigBase
{
private static HeroAwake_act2Config _instance;
public Dictionary<int, Dictionary<int, HeroAwake_act2Data>> _datas;
public static HeroAwake_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new HeroAwake_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroAwake_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 2376;i++)
{
HeroAwake_act2Data data = new HeroAwake_act2Data();
data.ID = br.ReadInt32();
data.AwakeID = br.ReadInt32();
data.AwakeGrow = (float)br.ReadDouble();
data.Item1ID = br.ReadInt32();
data.Item1Num = br.ReadInt32();
data.Item3ID = br.ReadInt32();
data.Item3Num = br.ReadInt32();
data.Item2Num = br.ReadInt32();
data.ResolveAwake = br.ReadInt32();
data.NeedStep = br.ReadInt32();
data.RagePointBegin = br.ReadInt32();
data.EffectType = br.ReadInt32();
data.Effect1ID = br.ReadInt32();
data.GelSkill = br.ReadString();
data.BulletName = br.ReadString();
data.AngSkill = br.ReadString();
data.triggers = br.ReadString();
data.Effect1Name = br.ReadString();
data.Effect1Des = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroAwake_act2Data>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, HeroAwake_act2Data> _dic = new Dictionary<int, HeroAwake_act2Data>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.AwakeID,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroAwake_act2Data> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public HeroAwake_act2Data Get(int newID,int newAwakeID)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newAwakeID))
return _datas[newID][newAwakeID];
else
return null;
}
}
}
