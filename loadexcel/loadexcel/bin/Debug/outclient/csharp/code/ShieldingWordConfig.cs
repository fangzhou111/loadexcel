using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ShieldingWordData
{
/*唯一ID*/
public int ID; 
/*关键字*/
public string Word; 
}
public partial class ShieldingWordConfig : ConfigBase
{
private static ShieldingWordConfig _instance;
public Dictionary<int, ShieldingWordData> _datas;
public static ShieldingWordConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ShieldingWordConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ShieldingWord.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3178;i++)
{
ShieldingWordData data = new ShieldingWordData();
data.ID = br.ReadInt32();
data.Word = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ShieldingWordData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ShieldingWordData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
