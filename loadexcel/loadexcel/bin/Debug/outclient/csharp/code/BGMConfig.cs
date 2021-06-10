using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BGMData
{
/*场景名*/
public string CampaignSandID; 
/*音乐名*/
public string Music; 
}
public partial class BGMConfig : ConfigBase
{
private static BGMConfig _instance;
public Dictionary<string, BGMData> _datas;
public static BGMConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BGMConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BGM.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 96;i++)
{
BGMData data = new BGMData();
data.CampaignSandID = br.ReadString();
data.Music = br.ReadString();
if (_datas == null)
_datas = new Dictionary<string, BGMData>();
_datas.Add(data.CampaignSandID,data);
}
br.Close();
fs.Close();
}
public BGMData Get(string newCampaignSandID)
{
if (_datas.ContainsKey(newCampaignSandID))
return _datas[newCampaignSandID];
else
return null;
}
}
}
