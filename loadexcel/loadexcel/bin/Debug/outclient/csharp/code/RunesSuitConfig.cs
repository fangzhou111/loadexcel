using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RunesSuitData
{
/*套装ID*/
public int SuitID; 
/*套装名称*/
public string Name; 
/*激活需要的件数*/
public int SuitNeedNum; 
/*套装效果*/
public string EffectNum; 
/*增加怒气*/
public string Anger; 
/*触发器*/
public string trrigers; 
/*套装默认权重*/
public int weight; 
}
public partial class RunesSuitConfig : ConfigBase
{
private static RunesSuitConfig _instance;
public Dictionary<int, Dictionary<int, RunesSuitData>> _datas;
public static RunesSuitConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RunesSuitConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RunesSuit.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 24;i++)
{
RunesSuitData data = new RunesSuitData();
data.SuitID = br.ReadInt32();
data.Name = br.ReadString();
data.SuitNeedNum = br.ReadInt32();
data.EffectNum = br.ReadString();
data.Anger = br.ReadString();
data.trrigers = br.ReadString();
data.weight = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, RunesSuitData>>();
if (!_datas.ContainsKey(data.SuitID))
{
Dictionary<int, RunesSuitData> _dic = new Dictionary<int, RunesSuitData>();
_datas.Add(data.SuitID, _dic);
}
_datas[data.SuitID].Add(data.SuitNeedNum,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, RunesSuitData> Get(int newSuitID)
{
if (_datas.ContainsKey(newSuitID))
return _datas[newSuitID];
else
return null;
}
public RunesSuitData Get(int newSuitID,int newSuitNeedNum)
{
if (_datas.ContainsKey(newSuitID) && _datas[newSuitID].ContainsKey(newSuitNeedNum))
return _datas[newSuitID][newSuitNeedNum];
else
return null;
}
}
}
