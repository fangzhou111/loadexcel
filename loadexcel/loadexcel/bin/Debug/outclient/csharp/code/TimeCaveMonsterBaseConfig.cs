using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TimeCaveMonsterBaseData
{
/*怪物ID*/
public int ID; 
/*怪物名称*/
public string Name; 
/*怪物职业*/
public string MonsterJob; 
/*备注*/
public string Desc; 
/*模型名称*/
public string Model; 
/*头像图标*/
public string Icon; 
/*怪物类型*/
public int MonsterType; 
/*怪物伤害类型*/
public int MonsterDamageType; 
/*贴图类型*/
public string ColorType; 
/*模型大小*/
public int Size; 
/*击杀获得怒气*/
public int RagePointByKill; 
}
public partial class TimeCaveMonsterBaseConfig : ConfigBase
{
private static TimeCaveMonsterBaseConfig _instance;
public Dictionary<int, TimeCaveMonsterBaseData> _datas;
public static TimeCaveMonsterBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TimeCaveMonsterBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TimeCaveMonsterBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 15;i++)
{
TimeCaveMonsterBaseData data = new TimeCaveMonsterBaseData();
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
if (_datas == null)
_datas = new Dictionary<int, TimeCaveMonsterBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TimeCaveMonsterBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
