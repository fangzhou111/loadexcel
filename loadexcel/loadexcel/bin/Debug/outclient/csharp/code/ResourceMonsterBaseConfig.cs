using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ResourceMonsterBaseData
{
/*ee*/
public int ID; 
/*ee*/
public string Name; 
/*ee*/
public string MonsterJob; 
/*ee*/
public string Desc; 
/*ee*/
public string MonsterDesc; 
/*ee*/
public string Model; 
/*dd*/
public string Icon; 
/*ee*/
public int MonsterType; 
/*ff*/
public int MonsterDamageType; 
/*贴图类型*/
public string ColorType; 
/*模型大小*/
public int Size; 
/*击杀获得怒气*/
public int RagePointByKill; 
/*初始怒气*/
public int BeginArg; 
}
public partial class ResourceMonsterBaseConfig : ConfigBase
{
private static ResourceMonsterBaseConfig _instance;
public Dictionary<int, ResourceMonsterBaseData> _datas;
public static ResourceMonsterBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ResourceMonsterBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ResourceMonsterBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 290;i++)
{
ResourceMonsterBaseData data = new ResourceMonsterBaseData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.MonsterJob = br.ReadString();
data.Desc = br.ReadString();
data.MonsterDesc = br.ReadString();
data.Model = br.ReadString();
data.Icon = br.ReadString();
data.MonsterType = br.ReadInt32();
data.MonsterDamageType = br.ReadInt32();
data.ColorType = br.ReadString();
data.Size = br.ReadInt32();
data.RagePointByKill = br.ReadInt32();
data.BeginArg = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ResourceMonsterBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ResourceMonsterBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
