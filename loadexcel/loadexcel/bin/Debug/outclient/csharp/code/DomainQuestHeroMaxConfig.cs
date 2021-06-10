using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainQuestHeroMaxData
{
/*领主等级*/
public int PlayLevel; 
/*最大英雄派遣数量*/
public int DomainQuestHeroMax; 
}
public partial class DomainQuestHeroMaxConfig : ConfigBase
{
private static DomainQuestHeroMaxConfig _instance;
public Dictionary<int, DomainQuestHeroMaxData> _datas;
public static DomainQuestHeroMaxConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainQuestHeroMaxConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainQuestHeroMax.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
DomainQuestHeroMaxData data = new DomainQuestHeroMaxData();
data.PlayLevel = br.ReadInt32();
data.DomainQuestHeroMax = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, DomainQuestHeroMaxData>();
_datas.Add(data.PlayLevel,data);
}
br.Close();
fs.Close();
}
public DomainQuestHeroMaxData Get(int newPlayLevel)
{
if (_datas.ContainsKey(newPlayLevel))
return _datas[newPlayLevel];
else
return null;
}
}
}
