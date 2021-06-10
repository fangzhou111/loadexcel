using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class audioData
{
/*编号*/
public int Index; 
/*音频名称*/
public string Name; 
/*音量大小*/
public int Db; 
}
public partial class audioConfig : ConfigBase
{
private static audioConfig _instance;
public Dictionary<string, audioData> _datas;
public static audioConfig Instance
{
get
{
if (_instance == null)
{
_instance = new audioConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("audio.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 478;i++)
{
audioData data = new audioData();
data.Index = br.ReadInt32();
data.Name = br.ReadString();
data.Db = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, audioData>();
_datas.Add(data.Name,data);
}
br.Close();
fs.Close();
}
public audioData Get(string newName)
{
if (_datas.ContainsKey(newName))
return _datas[newName];
else
return null;
}
}
}
