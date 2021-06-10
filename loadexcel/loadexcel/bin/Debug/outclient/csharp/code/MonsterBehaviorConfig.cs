using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class MonsterBehaviorData
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
public partial class MonsterBehaviorConfig : ConfigBase
{
private static MonsterBehaviorConfig _instance;
public Dictionary<int, MonsterBehaviorData> _datas;
public static MonsterBehaviorConfig Instance
{
get
{
if (_instance == null)
{
_instance = new MonsterBehaviorConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("MonsterBehavior.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 300;i++)
{
MonsterBehaviorData data = new MonsterBehaviorData();
data.MonsterBehaviorID = br.ReadInt32();
data.GelSkill = br.ReadString();
data.BulletName = br.ReadString();
data.AngSkill = br.ReadString();
data.trrigers = br.ReadString();
data.AIs = br.ReadString();
data.SkillIDs = br.ReadString();
data.BaseFindEnemyAIs = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, MonsterBehaviorData>();
_datas.Add(data.MonsterBehaviorID,data);
}
br.Close();
fs.Close();
}
public MonsterBehaviorData Get(int newMonsterBehaviorID)
{
if (_datas.ContainsKey(newMonsterBehaviorID))
return _datas[newMonsterBehaviorID];
else
return null;
}
}
}
