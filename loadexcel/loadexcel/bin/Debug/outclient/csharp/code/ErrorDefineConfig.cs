using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ErrorDefineData
{
/*错误码ID*/
public int ID; 
/*错误码文字*/
public string String; 
}
public partial class ErrorDefineConfig : ConfigBase
{
private static ErrorDefineConfig _instance;
public Dictionary<int, ErrorDefineData> _datas;
public static ErrorDefineConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ErrorDefineConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ErrorDefine.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 660;i++)
{
ErrorDefineData data = new ErrorDefineData();
data.ID = br.ReadInt32();
data.String = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ErrorDefineData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ErrorDefineData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
