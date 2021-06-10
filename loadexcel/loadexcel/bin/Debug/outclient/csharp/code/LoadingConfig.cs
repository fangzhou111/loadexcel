using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LoadingData
{
/*主键ID*/
public int ID; 
/*背景图名字*/
public string NAME; 
/*显示*/
public int SHOW; 
}
public partial class LoadingConfig : ConfigBase
{
private static LoadingConfig _instance;
public Dictionary<int, LoadingData> _datas;
public static LoadingConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LoadingConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Loading.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
LoadingData data = new LoadingData();
data.ID = br.ReadInt32();
data.NAME = br.ReadString();
data.SHOW = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, LoadingData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public LoadingData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
