using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainBaseData
{
/*任务品质*/
public int DomainQuestType; 
/*刷新概率*/
public int Probability; 
/*任务时长*/
public int Time; 
/*职业限制个数*/
public int HeroJob; 
/*英雄经验奖励*/
public int HeroExpOrder; 
/*奖励分组*/
public int Order; 
/*符合要求英雄的成功率*/
public int HeroSuccessRatio; 
}
public partial class DomainBaseConfig : ConfigBase
{
private static DomainBaseConfig _instance;
public Dictionary<int, DomainBaseData> _datas;
public static DomainBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
DomainBaseData data = new DomainBaseData();
data.DomainQuestType = br.ReadInt32();
data.Probability = br.ReadInt32();
data.Time = br.ReadInt32();
data.HeroJob = br.ReadInt32();
data.HeroExpOrder = br.ReadInt32();
data.Order = br.ReadInt32();
data.HeroSuccessRatio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, DomainBaseData>();
_datas.Add(data.DomainQuestType,data);
}
br.Close();
fs.Close();
}
public DomainBaseData Get(int newDomainQuestType)
{
if (_datas.ContainsKey(newDomainQuestType))
return _datas[newDomainQuestType];
else
return null;
}
}
}
