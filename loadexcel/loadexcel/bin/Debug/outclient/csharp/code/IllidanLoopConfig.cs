using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class IllidanLoopData
{
/*主键ID*/
public int ID; 
/*首轮的次数*/
public int Times; 
/*分组*/
public int Order; 
/*一粒蛋面数*/
public int Number; 
}
public partial class IllidanLoopConfig : ConfigBase
{
private static IllidanLoopConfig _instance;
public Dictionary<int, IllidanLoopData> _datas;
public static IllidanLoopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new IllidanLoopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("IllidanLoop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 240;i++)
{
IllidanLoopData data = new IllidanLoopData();
data.ID = br.ReadInt32();
data.Times = br.ReadInt32();
data.Order = br.ReadInt32();
data.Number = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, IllidanLoopData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public IllidanLoopData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
