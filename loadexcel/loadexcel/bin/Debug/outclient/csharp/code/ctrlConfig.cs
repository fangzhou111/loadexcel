using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ctrlData
{
/*ID*/
public int id; 
/*职业*/
public int job; 
/*被克制职业*/
public int bejob; 
/*克制加成*/
public float atkv1; 
/*被克制衰减*/
public float atkv2; 
}
public partial class ctrlConfig : ConfigBase
{
private static ctrlConfig _instance;
public Dictionary<int, ctrlData> _datas;
public static ctrlConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ctrlConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ctrl.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 14;i++)
{
ctrlData data = new ctrlData();
data.id = br.ReadInt32();
data.job = br.ReadInt32();
data.bejob = br.ReadInt32();
data.atkv1 = (float)br.ReadDouble();
data.atkv2 = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, ctrlData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public ctrlData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
