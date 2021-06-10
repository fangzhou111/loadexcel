using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GlobalConfigData
{
/*功能名称*/
public string NameID; 
/*功能值*/
public int Value; 
}
public partial class GlobalConfigConfig : ConfigBase
{
private static GlobalConfigConfig _instance;
public Dictionary<string, GlobalConfigData> _datas;
public static GlobalConfigConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GlobalConfigConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GlobalConfig.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 289;i++)
{
GlobalConfigData data = new GlobalConfigData();
data.NameID = br.ReadString();
data.Value = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, GlobalConfigData>();
_datas.Add(data.NameID,data);
}
br.Close();
fs.Close();
}
public GlobalConfigData Get(string newNameID)
{
if (_datas.ContainsKey(newNameID))
return _datas[newNameID];
else
return null;
}
}
}
