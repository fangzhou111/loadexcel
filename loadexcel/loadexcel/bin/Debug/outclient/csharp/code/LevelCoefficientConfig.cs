using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LevelCoefficientData
{
/*等级*/
public int level; 
/*命中闪避系数*/
public double HitDodge
; 
/*暴击韧性系数*/
public double CritToughness; 
/*招架精准系数*/
public double ParryPrecision; 
}
public partial class LevelCoefficientConfig : ConfigBase
{
private static LevelCoefficientConfig _instance;
public Dictionary<int, LevelCoefficientData> _datas;
public static LevelCoefficientConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LevelCoefficientConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LevelCoefficient.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 150;i++)
{
LevelCoefficientData data = new LevelCoefficientData();
data.level = br.ReadInt32();
data.HitDodge
 = (float)br.ReadDouble();
data.CritToughness = (float)br.ReadDouble();
data.ParryPrecision = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, LevelCoefficientData>();
_datas.Add(data.level,data);
}
br.Close();
fs.Close();
}
public LevelCoefficientData Get(int newlevel)
{
if (_datas.ContainsKey(newlevel))
return _datas[newlevel];
else
return null;
}
}
}
