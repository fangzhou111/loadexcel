using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeDamageData
{
/*等级*/
public int Level; 
/*伤害要求基础值*/
public int DamageBase; 
/*金币奖励基础值*/
public int Reward1; 
/*宝物进阶石奖励基础值*/
public int Reward2; 
/*徽章奖励基础*/
public int Reward3; 
}
public partial class BossChallengeDamageConfig : ConfigBase
{
private static BossChallengeDamageConfig _instance;
public Dictionary<int, BossChallengeDamageData> _datas;
public static BossChallengeDamageConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeDamageConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeDamage.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 73;i++)
{
BossChallengeDamageData data = new BossChallengeDamageData();
data.Level = br.ReadInt32();
data.DamageBase = br.ReadInt32();
data.Reward1 = br.ReadInt32();
data.Reward2 = br.ReadInt32();
data.Reward3 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BossChallengeDamageData>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public BossChallengeDamageData Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
