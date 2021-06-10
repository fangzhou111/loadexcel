using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroBaseData
{
/*英雄ID*/
public int ID; 
/*英雄名*/
public string Name; 
/*是否英雄本体*/
public int Heroself; 
/*英雄描述*/
public string Desc; 
/*英雄模型*/
public string Model; 
/*英雄性别*/
public int HeroSex; 
/*阵营*/
public int HeroPhyle; 
/*英雄类型*/
public int HeroType; 
/*英灵殿分组*/
public int HeroGroup; 
/*英雄图标*/
public int Icon; 
/*英雄伤害类型*/
public int HeroDamageType; 
/*初始品质*/
public int HeroQuality; 
/*初始潜质*/
public int HeroStarStrength; 
/*潜质系数（技能用）*/
public double SkillHeroStarStrength; 
/*英雄职业*/
public int HeroJob; 
/*英雄初始先手值*/
public int HeroFirstHandValue; 
/*被吞噬提供经验*/
public int OfferExp; 
/*食物1*/
public int Item1; 
/*食物2*/
public int Item2; 
/*食物3*/
public int Item3; 
/*专属神器*/
public int OwnArtifact; 
}
public partial class HeroBaseConfig : ConfigBase
{
private static HeroBaseConfig _instance;
public Dictionary<int, HeroBaseData> _datas;
public static HeroBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 216;i++)
{
HeroBaseData data = new HeroBaseData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.Heroself = br.ReadInt32();
data.Desc = br.ReadString();
data.Model = br.ReadString();
data.HeroSex = br.ReadInt32();
data.HeroPhyle = br.ReadInt32();
data.HeroType = br.ReadInt32();
data.HeroGroup = br.ReadInt32();
data.Icon = br.ReadInt32();
data.HeroDamageType = br.ReadInt32();
data.HeroQuality = br.ReadInt32();
data.HeroStarStrength = br.ReadInt32();
data.SkillHeroStarStrength = (float)br.ReadDouble();
data.HeroJob = br.ReadInt32();
data.HeroFirstHandValue = br.ReadInt32();
data.OfferExp = br.ReadInt32();
data.Item1 = br.ReadInt32();
data.Item2 = br.ReadInt32();
data.Item3 = br.ReadInt32();
data.OwnArtifact = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, HeroBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public HeroBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
