using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CruasdeBloodLoopData
{
/*主键ID*/
public int ID; 
/*次数*/
public int Times; 
/*分组*/
public int Order; 
/*血量*/
public int Blood; 
}
public partial class CruasdeBloodLoopConfig : ConfigBase
{
private static CruasdeBloodLoopConfig _instance;
public Dictionary<int, CruasdeBloodLoopData> _datas;
public static CruasdeBloodLoopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CruasdeBloodLoopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CruasdeBloodLoop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
CruasdeBloodLoopData data = new CruasdeBloodLoopData();
data.ID = br.ReadInt32();
data.Times = br.ReadInt32();
data.Order = br.ReadInt32();
data.Blood = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, CruasdeBloodLoopData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public CruasdeBloodLoopData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
