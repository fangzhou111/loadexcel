using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RunesOutputData
{
/*序号*/
public int OutputOrder; 
/*掉落包ID*/
public int Order; 
/*消耗道具*/
public int NeedItem; 
/*消耗道具数量*/
public int NeedNum; 
/*消耗道具2*/
public int NeedItem1; 
/*消耗道具2数量*/
public int NeedNum1; 
/*可跳序号*/
public int TurnOutputOrder; 
/*跳转概率*/
public int TurnProbability; 
/*是否提醒*/
public int Bulletin; 
/*名字*/
public string Name; 
/*名字品质*/
public int Profile; 
/*模型*/
public string Model; 
/*战斗力限制*/
public int CombatNum; 
}
public partial class RunesOutputConfig : ConfigBase
{
private static RunesOutputConfig _instance;
public Dictionary<int, RunesOutputData> _datas;
public static RunesOutputConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RunesOutputConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RunesOutput.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
RunesOutputData data = new RunesOutputData();
data.OutputOrder = br.ReadInt32();
data.Order = br.ReadInt32();
data.NeedItem = br.ReadInt32();
data.NeedNum = br.ReadInt32();
data.NeedItem1 = br.ReadInt32();
data.NeedNum1 = br.ReadInt32();
data.TurnOutputOrder = br.ReadInt32();
data.TurnProbability = br.ReadInt32();
data.Bulletin = br.ReadInt32();
data.Name = br.ReadString();
data.Profile = br.ReadInt32();
data.Model = br.ReadString();
data.CombatNum = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, RunesOutputData>();
_datas.Add(data.OutputOrder,data);
}
br.Close();
fs.Close();
}
public RunesOutputData Get(int newOutputOrder)
{
if (_datas.ContainsKey(newOutputOrder))
return _datas[newOutputOrder];
else
return null;
}
}
}
