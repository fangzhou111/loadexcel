using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroExpData
{
/*当前等级*/
public int Level; 
/*升到当前等级需要经验*/
public int BaseExp; 
/*进阶等级限制*/
public int StepLevel; 
/*英雄分解返还系数*/
public int ExperienceRatio; 
}
public partial class HeroExpConfig : ConfigBase
{
private static HeroExpConfig _instance;
public Dictionary<int, HeroExpData> _datas;
public static HeroExpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroExpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroExp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
HeroExpData data = new HeroExpData();
data.Level = br.ReadInt32();
data.BaseExp = br.ReadInt32();
data.StepLevel = br.ReadInt32();
data.ExperienceRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, HeroExpData>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public HeroExpData Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
