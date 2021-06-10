using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class JoyMachineOutputData
{
/*等级*/
public int Grade; 
/*金币产出*/
public int GoldOutput; 
/*经验英雄产出ID*/
public int HeroExpOutput; 
/*经验英雄产出数量*/
public int HeroExpOutputNum; 
/*经验装备产出ID*/
public int EquipmentExpOutput; 
/*经验装备产出数量*/
public int EquipmentExpOutputNum; 
/*技能经验产出*/
public int SkillExpOutput; 
/*雕文经验产出ID*/
public int TalentExpOutput; 
/*雕文经验产出数量*/
public int TalentExpOutputNum; 
}
public partial class JoyMachineOutputConfig : ConfigBase
{
private static JoyMachineOutputConfig _instance;
public Dictionary<int, JoyMachineOutputData> _datas;
public static JoyMachineOutputConfig Instance
{
get
{
if (_instance == null)
{
_instance = new JoyMachineOutputConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("JoyMachineOutput.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 150;i++)
{
JoyMachineOutputData data = new JoyMachineOutputData();
data.Grade = br.ReadInt32();
data.GoldOutput = br.ReadInt32();
data.HeroExpOutput = br.ReadInt32();
data.HeroExpOutputNum = br.ReadInt32();
data.EquipmentExpOutput = br.ReadInt32();
data.EquipmentExpOutputNum = br.ReadInt32();
data.SkillExpOutput = br.ReadInt32();
data.TalentExpOutput = br.ReadInt32();
data.TalentExpOutputNum = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, JoyMachineOutputData>();
_datas.Add(data.Grade,data);
}
br.Close();
fs.Close();
}
public JoyMachineOutputData Get(int newGrade)
{
if (_datas.ContainsKey(newGrade))
return _datas[newGrade];
else
return null;
}
}
}
