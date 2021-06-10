using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SkillExpData
{
/*当前等级*/
public int Level; 
/*升到当前等级需要经验*/
public int NeedExp; 
/*升到当前等级需要金币*/
public int NeedGold; 
/*升级所需技能点*/
public int NeedSkillPoint; 
/*英雄分解返还系数*/
public int SkillRatio; 
}
public partial class SkillExpConfig : ConfigBase
{
private static SkillExpConfig _instance;
public Dictionary<int, SkillExpData> _datas;
public static SkillExpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SkillExpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SkillExp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
SkillExpData data = new SkillExpData();
data.Level = br.ReadInt32();
data.NeedExp = br.ReadInt32();
data.NeedGold = br.ReadInt32();
data.NeedSkillPoint = br.ReadInt32();
data.SkillRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, SkillExpData>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public SkillExpData Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
