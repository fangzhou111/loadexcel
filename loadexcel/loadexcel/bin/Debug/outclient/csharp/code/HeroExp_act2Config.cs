using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroExp_act2Data
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
public partial class HeroExp_act2Config : ConfigBase
{
private static HeroExp_act2Config _instance;
public Dictionary<int, HeroExp_act2Data> _datas;
public static HeroExp_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new HeroExp_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroExp_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
HeroExp_act2Data data = new HeroExp_act2Data();
data.Level = br.ReadInt32();
data.BaseExp = br.ReadInt32();
data.StepLevel = br.ReadInt32();
data.ExperienceRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, HeroExp_act2Data>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public HeroExp_act2Data Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
