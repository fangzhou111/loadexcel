using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class IntimacyEXPData
{
/*好感度阶段*/
public int IntimacyStep; 
/*等级*/
public int IntimacyLevel; 
/*升级到该级所需经验*/
public int IntimacyEXP; 
/*升到该级获得先手值*/
public int IntimacyFirstHandValue; 
}
public partial class IntimacyEXPConfig : ConfigBase
{
private static IntimacyEXPConfig _instance;
public Dictionary<int, Dictionary<int, IntimacyEXPData>> _datas;
public static IntimacyEXPConfig Instance
{
get
{
if (_instance == null)
{
_instance = new IntimacyEXPConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("IntimacyEXP.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 385;i++)
{
IntimacyEXPData data = new IntimacyEXPData();
data.IntimacyStep = br.ReadInt32();
data.IntimacyLevel = br.ReadInt32();
data.IntimacyEXP = br.ReadInt32();
data.IntimacyFirstHandValue = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, IntimacyEXPData>>();
if (!_datas.ContainsKey(data.IntimacyStep))
{
Dictionary<int, IntimacyEXPData> _dic = new Dictionary<int, IntimacyEXPData>();
_datas.Add(data.IntimacyStep, _dic);
}
_datas[data.IntimacyStep].Add(data.IntimacyLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, IntimacyEXPData> Get(int newIntimacyStep)
{
if (_datas.ContainsKey(newIntimacyStep))
return _datas[newIntimacyStep];
else
return null;
}
public IntimacyEXPData Get(int newIntimacyStep,int newIntimacyLevel)
{
if (_datas.ContainsKey(newIntimacyStep) && _datas[newIntimacyStep].ContainsKey(newIntimacyLevel))
return _datas[newIntimacyStep][newIntimacyLevel];
else
return null;
}
}
}
