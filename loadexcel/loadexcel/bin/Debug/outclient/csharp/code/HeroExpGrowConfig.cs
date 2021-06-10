using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroExpGrowData
{
/*参数ID*/
public int ID; 
/*参数类型*/
public int Type; 
/*参数对应的值*/
public int Idvalue; 
/*经验系数*/
public double ExpGrow; 
}
public partial class HeroExpGrowConfig : ConfigBase
{
private static HeroExpGrowConfig _instance;
public Dictionary<int, Dictionary<int, HeroExpGrowData>> _datas;
public static HeroExpGrowConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroExpGrowConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroExpGrow.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 34;i++)
{
HeroExpGrowData data = new HeroExpGrowData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Idvalue = br.ReadInt32();
data.ExpGrow = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroExpGrowData>>();
if (!_datas.ContainsKey(data.Type))
{
Dictionary<int, HeroExpGrowData> _dic = new Dictionary<int, HeroExpGrowData>();
_datas.Add(data.Type, _dic);
}
_datas[data.Type].Add(data.Idvalue,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroExpGrowData> Get(int newType)
{
if (_datas.ContainsKey(newType))
return _datas[newType];
else
return null;
}
public HeroExpGrowData Get(int newType,int newIdvalue)
{
if (_datas.ContainsKey(newType) && _datas[newType].ContainsKey(newIdvalue))
return _datas[newType][newIdvalue];
else
return null;
}
}
}
