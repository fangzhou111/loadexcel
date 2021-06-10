using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class KnowledgeStepData
{
/*阶段*/
public int Step; 
/*名称*/
public string Name; 
/*图标*/
public int Icon; 
/*激活类型
1升品（升资质）
2效果
3解锁缘分*/
public int OpenType; 
/*激活参数1*/
public int Param1; 
/*激活参数2*/
public int Param2; 
/*激活参数3*/
public int Param3; 
/*激活参数4*/
public int Param4; 
/*激活参数5*/
public int Param5; 
/*激活参数6*/
public int Param6; 
/*激活描述*/
public string Des; 
}
public partial class KnowledgeStepConfig : ConfigBase
{
private static KnowledgeStepConfig _instance;
public Dictionary<int, KnowledgeStepData> _datas;
public static KnowledgeStepConfig Instance
{
get
{
if (_instance == null)
{
_instance = new KnowledgeStepConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("KnowledgeStep.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 17;i++)
{
KnowledgeStepData data = new KnowledgeStepData();
data.Step = br.ReadInt32();
data.Name = br.ReadString();
data.Icon = br.ReadInt32();
data.OpenType = br.ReadInt32();
data.Param1 = br.ReadInt32();
data.Param2 = br.ReadInt32();
data.Param3 = br.ReadInt32();
data.Param4 = br.ReadInt32();
data.Param5 = br.ReadInt32();
data.Param6 = br.ReadInt32();
data.Des = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, KnowledgeStepData>();
_datas.Add(data.Step,data);
}
br.Close();
fs.Close();
}
public KnowledgeStepData Get(int newStep)
{
if (_datas.ContainsKey(newStep))
return _datas[newStep];
else
return null;
}
}
}
