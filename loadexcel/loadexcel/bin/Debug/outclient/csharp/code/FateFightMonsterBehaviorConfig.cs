﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FateFightMonsterBehaviorData
{
/*怪物行为AI*/
public int MonsterBehaviorID; 
/*携带AI*/
public string AIs; 
/*携带技能*/
public string SkillIDs; 
/*自动索敌AI*/
public string BaseFindEnemyAIs; 
}
public partial class FateFightMonsterBehaviorConfig : ConfigBase
{
private static FateFightMonsterBehaviorConfig _instance;
public Dictionary<int, FateFightMonsterBehaviorData> _datas;
public static FateFightMonsterBehaviorConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FateFightMonsterBehaviorConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FateFightMonsterBehavior.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 280;i++)
{
FateFightMonsterBehaviorData data = new FateFightMonsterBehaviorData();
data.MonsterBehaviorID = br.ReadInt32();
data.AIs = br.ReadString();
data.SkillIDs = br.ReadString();
data.BaseFindEnemyAIs = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, FateFightMonsterBehaviorData>();
_datas.Add(data.MonsterBehaviorID,data);
}
br.Close();
fs.Close();
}
public FateFightMonsterBehaviorData Get(int newMonsterBehaviorID)
{
if (_datas.ContainsKey(newMonsterBehaviorID))
return _datas[newMonsterBehaviorID];
else
return null;
}
}
}