using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LeagueMatchRankLevelData
{
/*军衔等级*/
public int RankLevel; 
/*名称*/
public string Name; 
/*需要积分*/
public int RankScore; 
/*需要排名*/
public int Grade; 
/*图标*/
public string Icon; 
}
public partial class LeagueMatchRankLevelConfig : ConfigBase
{
private static LeagueMatchRankLevelConfig _instance;
public Dictionary<int, LeagueMatchRankLevelData> _datas;
public static LeagueMatchRankLevelConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LeagueMatchRankLevelConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LeagueMatchRankLevel.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 17;i++)
{
LeagueMatchRankLevelData data = new LeagueMatchRankLevelData();
data.RankLevel = br.ReadInt32();
data.Name = br.ReadString();
data.RankScore = br.ReadInt32();
data.Grade = br.ReadInt32();
data.Icon = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, LeagueMatchRankLevelData>();
_datas.Add(data.RankLevel,data);
}
br.Close();
fs.Close();
}
public LeagueMatchRankLevelData Get(int newRankLevel)
{
if (_datas.ContainsKey(newRankLevel))
return _datas[newRankLevel];
else
return null;
}
}
}
