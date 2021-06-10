using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TimeCaveMonsterBehaviorData
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
public partial class TimeCaveMonsterBehaviorConfig : ConfigBase
{
private static TimeCaveMonsterBehaviorConfig _instance;
public Dictionary<int, TimeCaveMonsterBehaviorData> _datas;
public static TimeCaveMonsterBehaviorConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TimeCaveMonsterBehaviorConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TimeCaveMonsterBehavior.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 15;i++)
{
TimeCaveMonsterBehaviorData data = new TimeCaveMonsterBehaviorData();
data.MonsterBehaviorID = br.ReadInt32();
data.AIs = br.ReadString();
data.SkillIDs = br.ReadString();
data.BaseFindEnemyAIs = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, TimeCaveMonsterBehaviorData>();
_datas.Add(data.MonsterBehaviorID,data);
}
br.Close();
fs.Close();
}
public TimeCaveMonsterBehaviorData Get(int newMonsterBehaviorID)
{
if (_datas.ContainsKey(newMonsterBehaviorID))
return _datas[newMonsterBehaviorID];
else
return null;
}
}
}
