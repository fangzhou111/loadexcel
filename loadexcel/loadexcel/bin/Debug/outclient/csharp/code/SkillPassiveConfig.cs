using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SkillPassiveData
{
/*被动技能ID*/
public string ID; 
/*技能名*/
public string Name; 
/*引用的公式*/
public int Formula; 
/*增加的属性*/
public int AttributeUp; 
}
public partial class SkillPassiveConfig : ConfigBase
{
private static SkillPassiveConfig _instance;
public Dictionary<string, SkillPassiveData> _datas;
public static SkillPassiveConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SkillPassiveConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SkillPassive.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 0;i++)
{
SkillPassiveData data = new SkillPassiveData();
data.ID = br.ReadString();
data.Name = br.ReadString();
data.Formula = br.ReadInt32();
data.AttributeUp = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, SkillPassiveData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public SkillPassiveData Get(string newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
