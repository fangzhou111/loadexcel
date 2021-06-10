using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainMapData
{
/*主键，地图ID*/
public int ID; 
/*战斗类型
1机器人2玩家3资源点*/
public int BattleType; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class DomainMapConfig : ConfigBase
{
private static DomainMapConfig _instance;
public Dictionary<int, DomainMapData> _datas;
public static DomainMapConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainMapConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainMap.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
DomainMapData data = new DomainMapData();
data.ID = br.ReadInt32();
data.BattleType = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, DomainMapData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public DomainMapData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
