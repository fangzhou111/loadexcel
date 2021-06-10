using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LegionInvasionData
{
/*军团ID，主键唯一不可重复*/
public int LegionID; 
/*军团名称*/
public string LegionName; 
/*每日可挑战次数(重置次数)*/
public int LegionChallengeTime; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class LegionInvasionConfig : ConfigBase
{
private static LegionInvasionConfig _instance;
public Dictionary<int, LegionInvasionData> _datas;
public static LegionInvasionConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LegionInvasionConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LegionInvasion.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 2;i++)
{
LegionInvasionData data = new LegionInvasionData();
data.LegionID = br.ReadInt32();
data.LegionName = br.ReadString();
data.LegionChallengeTime = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, LegionInvasionData>();
_datas.Add(data.LegionID,data);
}
br.Close();
fs.Close();
}
public LegionInvasionData Get(int newLegionID)
{
if (_datas.ContainsKey(newLegionID))
return _datas[newLegionID];
else
return null;
}
}
}
