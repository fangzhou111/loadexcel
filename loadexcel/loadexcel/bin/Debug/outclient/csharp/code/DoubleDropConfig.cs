using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DoubleDropData
{
/*主键*/
public int ID; 
/*活动图片*/
public string Icon; 
/*跳转功能*/
public int SwitchToFunction; 
/*描述*/
public string Dec; 
}
public partial class DoubleDropConfig : ConfigBase
{
private static DoubleDropConfig _instance;
public Dictionary<int, DoubleDropData> _datas;
public static DoubleDropConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DoubleDropConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DoubleDrop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 13;i++)
{
DoubleDropData data = new DoubleDropData();
data.ID = br.ReadInt32();
data.Icon = br.ReadString();
data.SwitchToFunction = br.ReadInt32();
data.Dec = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, DoubleDropData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public DoubleDropData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
