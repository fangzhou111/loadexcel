using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LegionArmyData
{
/*波次ID*/
public int WaveID; 
/*波次内怪物序号*/
public int Index; 
/*当前序号调用怪物基础ID/英雄ID*/
public int MonsterBaseID; 
/*怪物等级/英雄等级*/
public int Level; 
/*怪物类型/阶数*/
public int Type; 
/*怪物强度系数ID*/
public int ID; 
/*怪物体型*/
public int MonsterSize; 
}
public partial class LegionArmyConfig : ConfigBase
{
private static LegionArmyConfig _instance;
public Dictionary<int, LegionArmyData> _datas;
public static LegionArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LegionArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LegionArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 720;i++)
{
LegionArmyData data = new LegionArmyData();
data.WaveID = br.ReadInt32();
data.Index = br.ReadInt32();
data.MonsterBaseID = br.ReadInt32();
data.Level = br.ReadInt32();
data.Type = br.ReadInt32();
data.ID = br.ReadInt32();
data.MonsterSize = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, LegionArmyData>();
_datas.Add(data.WaveID,data);
}
br.Close();
fs.Close();
}
public LegionArmyData Get(int newWaveID)
{
if (_datas.ContainsKey(newWaveID))
return _datas[newWaveID];
else
return null;
}
}
}
