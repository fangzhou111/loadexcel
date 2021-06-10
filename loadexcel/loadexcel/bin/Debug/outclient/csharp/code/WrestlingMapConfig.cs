using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WrestlingMapData
{
/*关卡ID*/
public int WrestlingID; 
/*每天可挑战次数上限*/
public int CampaignChallengeTime; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class WrestlingMapConfig : ConfigBase
{
private static WrestlingMapConfig _instance;
public Dictionary<int, WrestlingMapData> _datas;
public static WrestlingMapConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WrestlingMapConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WrestlingMap.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1;i++)
{
WrestlingMapData data = new WrestlingMapData();
data.WrestlingID = br.ReadInt32();
data.CampaignChallengeTime = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, WrestlingMapData>();
_datas.Add(data.WrestlingID,data);
}
br.Close();
fs.Close();
}
public WrestlingMapData Get(int newWrestlingID)
{
if (_datas.ContainsKey(newWrestlingID))
return _datas[newWrestlingID];
else
return null;
}
}
}
