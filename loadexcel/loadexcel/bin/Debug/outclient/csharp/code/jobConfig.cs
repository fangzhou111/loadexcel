using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class jobData
{
/*ID*/
public int id; 
/*名字*/
public string name; 
/*AI*/
public string tree; 
/*所占单位*/
public int population; 
/*阻敌数量*/
public int atkerscount; 
/*被近身受到克制*/
public int isbeingatkweak; 
/*近身受克制比例*/
public float beingatkweakparent; 
/*近战or远程*/
public int islongrange; 
}
public partial class jobConfig : ConfigBase
{
private static jobConfig _instance;
public Dictionary<int, jobData> _datas;
public static jobConfig Instance
{
get
{
if (_instance == null)
{
_instance = new jobConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("job.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 7;i++)
{
jobData data = new jobData();
data.id = br.ReadInt32();
data.name = br.ReadString();
data.tree = br.ReadString();
data.population = br.ReadInt32();
data.atkerscount = br.ReadInt32();
data.isbeingatkweak = br.ReadInt32();
data.beingatkweakparent = (float)br.ReadDouble();
data.islongrange = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, jobData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public jobData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
