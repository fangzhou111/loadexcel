using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SeverStringData
{
/*标识*/
public string Tag; 
/*文本*/
public string Text; 
}
public partial class SeverStringConfig : ConfigBase
{
private static SeverStringConfig _instance;
public Dictionary<string, SeverStringData> _datas;
public static SeverStringConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SeverStringConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SeverString.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 123;i++)
{
SeverStringData data = new SeverStringData();
data.Tag = br.ReadString();
data.Text = br.ReadString();
if (_datas == null)
_datas = new Dictionary<string, SeverStringData>();
_datas.Add(data.Tag,data);
}
br.Close();
fs.Close();
}
public SeverStringData Get(string newTag)
{
if (_datas.ContainsKey(newTag))
return _datas[newTag];
else
return null;
}
}
}
