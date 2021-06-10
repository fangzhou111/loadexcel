using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LeagueMatchMapData
{
/*关卡ID*/
public int ID; 
/*每天可挑战次数上限
此处无用*/
public int CampaignChallengeTime; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class LeagueMatchMapConfig : ConfigBase
{
private static LeagueMatchMapConfig _instance;
public Dictionary<int, LeagueMatchMapData> _datas;
public static LeagueMatchMapConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LeagueMatchMapConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LeagueMatchMap.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1;i++)
{
LeagueMatchMapData data = new LeagueMatchMapData();
data.ID = br.ReadInt32();
data.CampaignChallengeTime = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, LeagueMatchMapData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public LeagueMatchMapData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
