using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WorldBossMonsterBaseData
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
/*击杀增加属性*/
public int KillAttribute; 
/*增加值*/
public int AttributeValue; 
/*初始怒气*/
public int BeginArg; 
}
public partial class WorldBossMonsterBaseConfig : ConfigBase
{
private static WorldBossMonsterBaseConfig _instance;
public Dictionary<int, WorldBossMonsterBaseData> _datas;
public static WorldBossMonsterBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WorldBossMonsterBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WorldBossMonsterBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 12;i++)
{
WorldBossMonsterBaseData data = new WorldBossMonsterBaseData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.MonsterJob = br.ReadString();
data.Desc = br.ReadString();
data.Model = br.ReadString();
data.Icon = br.ReadString();
data.MonsterType = br.ReadInt32();
data.MonsterDamageType = br.ReadInt32();
data.ColorType = br.ReadString();
data.Size = br.ReadInt32();
data.RagePointByKill = br.ReadInt32();
data.KillAttribute = br.ReadInt32();
data.AttributeValue = br.ReadInt32();
data.BeginArg = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, WorldBossMonsterBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public WorldBossMonsterBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
