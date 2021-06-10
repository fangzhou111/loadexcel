using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TutorialData
{
/*排序*/
public int Index; 
/*引导标识*/
public int ServerID; 
/*是否强制
0否1是*/
public int IsForce; 
/*给道具标识*/
public int ItemListID; 
/*触发类型*/
public int TriggerType; 
/*触发参数*/
public string TriggerParam; 
/*场景*/
public int Scene; 
/*UI*/
public string UI; 
/*完成条件*/
public int EndType; 
/*完成参数1*/
public int EndValue; 
/*完成参数2*/
public int EndValue1; 
/*特殊处理标记*/
public int SpecialTag; 
/*是否废除*/
public int abolish; 
}
public partial class TutorialConfig : ConfigBase
{
private static TutorialConfig _instance;
public Dictionary<int, TutorialData> _datas;
public static TutorialConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TutorialConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Tutorial.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 43;i++)
{
TutorialData data = new TutorialData();
data.Index = br.ReadInt32();
data.ServerID = br.ReadInt32();
data.IsForce = br.ReadInt32();
data.ItemListID = br.ReadInt32();
data.TriggerType = br.ReadInt32();
data.TriggerParam = br.ReadString();
data.Scene = br.ReadInt32();
data.UI = br.ReadString();
data.EndType = br.ReadInt32();
data.EndValue = br.ReadInt32();
data.EndValue1 = br.ReadInt32();
data.SpecialTag = br.ReadInt32();
data.abolish = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TutorialData>();
_datas.Add(data.ServerID,data);
}
br.Close();
fs.Close();
}
public TutorialData Get(int newServerID)
{
if (_datas.ContainsKey(newServerID))
return _datas[newServerID];
else
return null;
}
}
}
