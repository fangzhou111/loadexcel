using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainMineMonsterBehaviorData
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
public partial class DomainMineMonsterBehaviorConfig : ConfigBase
{
private static DomainMineMonsterBehaviorConfig _instance;
public Dictionary<int, DomainMineMonsterBehaviorData> _datas;
public static DomainMineMonsterBehaviorConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainMineMonsterBehaviorConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainMineMonsterBehavior.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 288;i++)
{
DomainMineMonsterBehaviorData data = new DomainMineMonsterBehaviorData();
data.MonsterBehaviorID = br.ReadInt32();
data.AIs = br.ReadString();
data.SkillIDs = br.ReadString();
data.BaseFindEnemyAIs = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, DomainMineMonsterBehaviorData>();
_datas.Add(data.MonsterBehaviorID,data);
}
br.Close();
fs.Close();
}
public DomainMineMonsterBehaviorData Get(int newMonsterBehaviorID)
{
if (_datas.ContainsKey(newMonsterBehaviorID))
return _datas[newMonsterBehaviorID];
else
return null;
}
}
}
