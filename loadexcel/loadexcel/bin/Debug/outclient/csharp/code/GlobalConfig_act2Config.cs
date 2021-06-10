using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GlobalConfig_act2Data
{
/*功能名称*/
public string NameID; 
/*功能值*/
public int Value; 
}
public partial class GlobalConfig_act2Config : ConfigBase
{
private static GlobalConfig_act2Config _instance;
public Dictionary<string, GlobalConfig_act2Data> _datas;
public static GlobalConfig_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new GlobalConfig_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GlobalConfig_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 187;i++)
{
GlobalConfig_act2Data data = new GlobalConfig_act2Data();
data.NameID = br.ReadString();
data.Value = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, GlobalConfig_act2Data>();
_datas.Add(data.NameID,data);
}
br.Close();
fs.Close();
}
public GlobalConfig_act2Data Get(string newNameID)
{
if (_datas.ContainsKey(newNameID))
return _datas[newNameID];
else
return null;
}
}
}
