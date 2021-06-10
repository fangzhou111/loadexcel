using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PushData
{
/*推送id*/
public int id; 
/*推送类型*/
public int PushType; 
/*推送参数*/
public int PushParam; 
/*标题*/
public string PushTitle; 
/*推送文字*/
public string PushText; 
/*声音*/
public string PushSound; 
}
public partial class PushConfig : ConfigBase
{
private static PushConfig _instance;
public Dictionary<int, PushData> _datas;
public static PushConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PushConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Push.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
PushData data = new PushData();
data.id = br.ReadInt32();
data.PushType = br.ReadInt32();
data.PushParam = br.ReadInt32();
data.PushTitle = br.ReadString();
data.PushText = br.ReadString();
data.PushSound = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, PushData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public PushData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
