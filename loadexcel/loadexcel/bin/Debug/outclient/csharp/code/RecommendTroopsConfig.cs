using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RecommendTroopsData
{
/*ID*/
public int NameID; 
/*阵营*/
public int HeroPhyle; 
/*组数*/
public int GroupCount; 
/*名称*/
public string Name; 
/*英雄1*/
public int Hero1; 
/*英雄2*/
public int Hero2; 
/*英雄3*/
public int Hero3; 
/*英雄4*/
public int Hero4; 
/*英雄5*/
public int Hero5; 
/*说明*/
public string Explain; 
}
public partial class RecommendTroopsConfig : ConfigBase
{
private static RecommendTroopsConfig _instance;
public Dictionary<int, Dictionary<int, RecommendTroopsData>> _datas;
public static RecommendTroopsConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RecommendTroopsConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RecommendTroops.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
RecommendTroopsData data = new RecommendTroopsData();
data.NameID = br.ReadInt32();
data.HeroPhyle = br.ReadInt32();
data.GroupCount = br.ReadInt32();
data.Name = br.ReadString();
data.Hero1 = br.ReadInt32();
data.Hero2 = br.ReadInt32();
data.Hero3 = br.ReadInt32();
data.Hero4 = br.ReadInt32();
data.Hero5 = br.ReadInt32();
data.Explain = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, RecommendTroopsData>>();
if (!_datas.ContainsKey(data.HeroPhyle))
{
Dictionary<int, RecommendTroopsData> _dic = new Dictionary<int, RecommendTroopsData>();
_datas.Add(data.HeroPhyle, _dic);
}
_datas[data.HeroPhyle].Add(data.GroupCount,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, RecommendTroopsData> Get(int newHeroPhyle)
{
if (_datas.ContainsKey(newHeroPhyle))
return _datas[newHeroPhyle];
else
return null;
}
public RecommendTroopsData Get(int newHeroPhyle,int newGroupCount)
{
if (_datas.ContainsKey(newHeroPhyle) && _datas[newHeroPhyle].ContainsKey(newGroupCount))
return _datas[newHeroPhyle][newGroupCount];
else
return null;
}
}
}
