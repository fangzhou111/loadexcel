using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainMonsterData
{
/*对应任务品质*/
public int DomainQuestType; 
/*怪物头像ICON*/
public string Icon; 
}
public partial class DomainMonsterConfig : ConfigBase
{
private static DomainMonsterConfig _instance;
public Dictionary<int, Dictionary<string, DomainMonsterData>> _datas;
public static DomainMonsterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainMonsterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainMonster.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 105;i++)
{
DomainMonsterData data = new DomainMonsterData();
data.DomainQuestType = br.ReadInt32();
data.Icon = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<string, DomainMonsterData>>();
if (!_datas.ContainsKey(data.DomainQuestType))
{
Dictionary<string, DomainMonsterData> _dic = new Dictionary<string, DomainMonsterData>();
_datas.Add(data.DomainQuestType, _dic);
}
_datas[data.DomainQuestType].Add(data.Icon,data);
}
br.Close();
fs.Close();
}
public Dictionary<string, DomainMonsterData> Get(int newDomainQuestType)
{
if (_datas.ContainsKey(newDomainQuestType))
return _datas[newDomainQuestType];
else
return null;
}
public DomainMonsterData Get(int newDomainQuestType,string newIcon)
{
if (_datas.ContainsKey(newDomainQuestType) && _datas[newDomainQuestType].ContainsKey(newIcon))
return _datas[newDomainQuestType][newIcon];
else
return null;
}
}
}
