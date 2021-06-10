﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Monster_act2Data
{
/*等级*/
public int Level; 
/*物攻*/
public int PhysicsAtk; 
/*魔攻*/
public int MagicAtk; 
/*物防*/
public int PhysicsDef; 
/*魔防*/
public int MagicDef; 
/*血量*/
public int HP; 
/*命中*/
public int HitRate; 
/*闪避*/
public int DodgeRate; 
/*暴击*/
public int CritRate; 
/*韧性*/
public int Toughness; 
/*招架*/
public int ParryRate; 
/*精准*/
public int PrecisionRate; 
}
public partial class Monster_act2Config : ConfigBase
{
private static Monster_act2Config _instance;
public Dictionary<int, Monster_act2Data> _datas;
public static Monster_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new Monster_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Monster_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 300;i++)
{
Monster_act2Data data = new Monster_act2Data();
data.Level = br.ReadInt32();
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
if (_datas == null)
_datas = new Dictionary<int, Monster_act2Data>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public Monster_act2Data Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}