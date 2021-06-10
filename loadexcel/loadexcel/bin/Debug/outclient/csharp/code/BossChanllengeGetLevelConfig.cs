using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChanllengeGetLevelData
{
/*玩家等级*/
public int PlayerLevel; 
/*触发怪物等级*/
public int GetMonsterLevel; 
}
public partial class BossChanllengeGetLevelConfig : ConfigBase
{
private static BossChanllengeGetLevelConfig _instance;
public Dictionary<int, BossChanllengeGetLevelData> _datas;
public static BossChanllengeGetLevelConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChanllengeGetLevelConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChanllengeGetLevel.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
BossChanllengeGetLevelData data = new BossChanllengeGetLevelData();
data.PlayerLevel = br.ReadInt32();
data.GetMonsterLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BossChanllengeGetLevelData>();
_datas.Add(data.PlayerLevel,data);
}
br.Close();
fs.Close();
}
public BossChanllengeGetLevelData Get(int newPlayerLevel)
{
if (_datas.ContainsKey(newPlayerLevel))
return _datas[newPlayerLevel];
else
return null;
}
}
}
