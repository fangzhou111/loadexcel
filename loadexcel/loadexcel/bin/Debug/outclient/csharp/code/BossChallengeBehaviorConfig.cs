﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeBehaviorData
{
/*怪物行为AI*/
public int MonsterBehaviorID; 
/*普攻技能*/
public string GelSkill; 
/*普攻子弹*/
public string BulletName; 
/*怒攻技能*/
public string AngSkill; 
/*触发技能*/
public string trrigers; 
/*携带AI*/
public string AIs; 
/*携带技能*/
public string SkillIDs; 
/*自动索敌AI*/
public string BaseFindEnemyAIs; 
}
public partial class BossChallengeBehaviorConfig : ConfigBase
{
private static BossChallengeBehaviorConfig _instance;
public Dictionary<int, BossChallengeBehaviorData> _datas;
public static BossChallengeBehaviorConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeBehaviorConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeBehavior.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 293;i++)
{
BossChallengeBehaviorData data = new BossChallengeBehaviorData();
data.MonsterBehaviorID = br.ReadInt32();
data.GelSkill = br.ReadString();
data.BulletName = br.ReadString();
data.AngSkill = br.ReadString();
data.trrigers = br.ReadString();
data.AIs = br.ReadString();
data.SkillIDs = br.ReadString();
data.BaseFindEnemyAIs = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, BossChallengeBehaviorData>();
_datas.Add(data.MonsterBehaviorID,data);
}
br.Close();
fs.Close();
}
public BossChallengeBehaviorData Get(int newMonsterBehaviorID)
{
if (_datas.ContainsKey(newMonsterBehaviorID))
return _datas[newMonsterBehaviorID];
else
return null;
}
}
}
