using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ConvoyMapData
{
/*关卡ID*/
public int CampaignID; 
/*地图名，调用资源用*/
public string MapName; 
/*地图配置名，场景编辑器生成的配置文件名*/
public string MapEditorName; 
}
public partial class ConvoyMapConfig : ConfigBase
{
private static ConvoyMapConfig _instance;
public Dictionary<int, ConvoyMapData> _datas;
public static ConvoyMapConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ConvoyMapConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ConvoyMap.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1;i++)
{
ConvoyMapData data = new ConvoyMapData();
data.CampaignID = br.ReadInt32();
data.MapName = br.ReadString();
data.MapEditorName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ConvoyMapData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public ConvoyMapData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
