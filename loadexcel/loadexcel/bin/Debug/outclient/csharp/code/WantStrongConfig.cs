using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WantStrongData
{
/*编号*/
public int ID; 
/*功能类型*/
public int FunctionType; 
/*名称*/
public string FunctionName; 
/*图标ID*/
public string Icon; 
}
public partial class WantStrongConfig : ConfigBase
{
private static WantStrongConfig _instance;
public Dictionary<int, WantStrongData> _datas;
public static WantStrongConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WantStrongConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WantStrong.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
WantStrongData data = new WantStrongData();
data.ID = br.ReadInt32();
data.FunctionType = br.ReadInt32();
data.FunctionName = br.ReadString();
data.Icon = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, WantStrongData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public WantStrongData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
