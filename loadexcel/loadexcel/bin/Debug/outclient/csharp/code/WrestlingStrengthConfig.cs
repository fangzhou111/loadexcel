using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WrestlingStrengthData
{
/*等级下限*/
public int MinGrade; 
/*等级上限*/
public int MaxGrade; 
/*名次*/
public int Rank; 
/*强度系数下限(100为100%)*/
public int MinStrength; 
/*强度系数上限(100为100%)*/
public int MaxStrength; 
/*对应掉落宝箱类型*/
public int Type; 
/*对应掉落*/
public int Order; 
}
public partial class WrestlingStrengthConfig : ConfigBase
{
private static WrestlingStrengthConfig _instance;
public Dictionary<int, WrestlingStrengthData> _datas;
public static WrestlingStrengthConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WrestlingStrengthConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("WrestlingStrength.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
WrestlingStrengthData data = new WrestlingStrengthData();
data.MinGrade = br.ReadInt32();
data.MaxGrade = br.ReadInt32();
data.Rank = br.ReadInt32();
data.MinStrength = br.ReadInt32();
data.MaxStrength = br.ReadInt32();
data.Type = br.ReadInt32();
data.Order = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, WrestlingStrengthData>();
_datas.Add(data.Rank,data);
}
br.Close();
fs.Close();
}
public WrestlingStrengthData Get(int newRank)
{
if (_datas.ContainsKey(newRank))
return _datas[newRank];
else
return null;
}
}
}
