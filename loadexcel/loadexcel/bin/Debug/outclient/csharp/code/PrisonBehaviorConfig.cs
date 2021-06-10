using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PrisonBehaviorData
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
public partial class PrisonBehaviorConfig : ConfigBase
{
private static PrisonBehaviorConfig _instance;
public Dictionary<int, PrisonBehaviorData> _datas;
public static PrisonBehaviorConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PrisonBehaviorConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PrisonBehavior.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 54;i++)
{
PrisonBehaviorData data = new PrisonBehaviorData();
data.MonsterBehaviorID = br.ReadInt32();
data.AIs = br.ReadString();
data.SkillIDs = br.ReadString();
data.BaseFindEnemyAIs = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, PrisonBehaviorData>();
_datas.Add(data.MonsterBehaviorID,data);
}
br.Close();
fs.Close();
}
public PrisonBehaviorData Get(int newMonsterBehaviorID)
{
if (_datas.ContainsKey(newMonsterBehaviorID))
return _datas[newMonsterBehaviorID];
else
return null;
}
}
}
