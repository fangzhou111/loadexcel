using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SkillBaseData
{
/*ID*/
public string ID; 
/*Name*/
public string Name; 
/*技能树名*/
public string TreeName; 
/*技能简介*/
public string Text; 
/*技能描述*/
public string Desc; 
/*技能类型*/
public string SkillType; 
/*主动类型*/
public string skillactivetype; 
/*添加类型*/
public string addtype; 
/*覆盖*/
public string coverbuffs; 
/*被覆盖*/
public string becoverbuffs; 
/*资源名*/
public string resname; 
/*技能CD*/
public double CD; 
/*技能入场CD*/
public double BeginCD; 
/*大招技能类型*/
public string SkillKind; 
/*技能图标*/
public string Icon; 
/*是否手动释放（1是，0否）*/
public int HandedSkill; 
/*buff图标*/
public int ShowBuffIcon; 
/*技能战斗力*/
public double FightingStrength; 
/*技能初始战斗力*/
public double FightingBeginStrength; 
}
public partial class SkillBaseConfig : ConfigBase
{
private static SkillBaseConfig _instance;
public Dictionary<string, SkillBaseData> _datas;
public static SkillBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SkillBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SkillBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1104;i++)
{
SkillBaseData data = new SkillBaseData();
data.ID = br.ReadString();
data.Name = br.ReadString();
data.TreeName = br.ReadString();
data.Text = br.ReadString();
data.Desc = br.ReadString();
data.SkillType = br.ReadString();
data.skillactivetype = br.ReadString();
data.addtype = br.ReadString();
data.coverbuffs = br.ReadString();
data.becoverbuffs = br.ReadString();
data.resname = br.ReadString();
data.CD = (float)br.ReadDouble();
data.BeginCD = (float)br.ReadDouble();
data.SkillKind = br.ReadString();
data.Icon = br.ReadString();
data.HandedSkill = br.ReadInt32();
data.ShowBuffIcon = br.ReadInt32();
data.FightingStrength = (float)br.ReadDouble();
data.FightingBeginStrength = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<string, SkillBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public SkillBaseData Get(string newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
