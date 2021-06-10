using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class VeinMapData
{
/*唯一ID*/
public int PitID; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class VeinMapConfig : ConfigBase
{
private static VeinMapConfig _instance;
public Dictionary<int, VeinMapData> _datas;
public static VeinMapConfig Instance
{
get
{
if (_instance == null)
{
_instance = new VeinMapConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("VeinMap.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
VeinMapData data = new VeinMapData();
data.PitID = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, VeinMapData>();
_datas.Add(data.PitID,data);
}
br.Close();
fs.Close();
}
public VeinMapData Get(int newPitID)
{
if (_datas.ContainsKey(newPitID))
return _datas[newPitID];
else
return null;
}
}
}
