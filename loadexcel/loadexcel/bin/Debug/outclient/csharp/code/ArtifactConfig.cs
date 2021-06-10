using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ArtifactData
{
/*职业类型（1.坦克，2近战，3.远程，4.治疗）*/
public int JobType; 
/*序号ID*/
public int JobId; 
/*节点名称*/
public string ArtifactName; 
/*属性点类型（1.属性，2技能）*/
public int AttributeType; 
/*技能ID/增加属性类型（1.生命，2，物攻，3法攻，4物防，5魔防，6暴击，7韧性，8命中，9闪避，10精准，11招架*/
public string AddAttributeType; 
/*前置点*/
public string FrontPoint; 
/*激活条件*/
public int ActivationCondition; 
/*等级*/
public int PointMaxLv; 
/*1级增加属性*/
public int Lv1AddAttribute; 
/*2级增加属性*/
public int Lv2AddAttribute; 
/*3级增加属性*/
public int Lv3AddAttribute; 
/*4级增加属性*/
public int Lv4AddAttribute; 
/*5级增加属性*/
public int Lv5AddAttribute; 
/*6级增加属性*/
public int Lv6AddAttribute; 
/*7级增加属性*/
public int Lv7AddAttribute; 
/*8级增加属性*/
public int Lv8AddAttribute; 
/*9级增加属性*/
public int Lv9AddAttribute; 
/*10级增加属性*/
public int Lv10AddAttribute; 
/*描述*/
public string ArtifactDes; 
/*图标*/
public string ArtifactIcon; 
}
public partial class ArtifactConfig : ConfigBase
{
private static ArtifactConfig _instance;
public Dictionary<int, Dictionary<int, ArtifactData>> _datas;
public static ArtifactConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ArtifactConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Artifact.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 52;i++)
{
ArtifactData data = new ArtifactData();
data.JobType = br.ReadInt32();
data.JobId = br.ReadInt32();
data.ArtifactName = br.ReadString();
data.AttributeType = br.ReadInt32();
data.AddAttributeType = br.ReadString();
data.FrontPoint = br.ReadString();
data.ActivationCondition = br.ReadInt32();
data.PointMaxLv = br.ReadInt32();
data.Lv1AddAttribute = br.ReadInt32();
data.Lv2AddAttribute = br.ReadInt32();
data.Lv3AddAttribute = br.ReadInt32();
data.Lv4AddAttribute = br.ReadInt32();
data.Lv5AddAttribute = br.ReadInt32();
data.Lv6AddAttribute = br.ReadInt32();
data.Lv7AddAttribute = br.ReadInt32();
data.Lv8AddAttribute = br.ReadInt32();
data.Lv9AddAttribute = br.ReadInt32();
data.Lv10AddAttribute = br.ReadInt32();
data.ArtifactDes = br.ReadString();
data.ArtifactIcon = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, ArtifactData>>();
if (!_datas.ContainsKey(data.JobType))
{
Dictionary<int, ArtifactData> _dic = new Dictionary<int, ArtifactData>();
_datas.Add(data.JobType, _dic);
}
_datas[data.JobType].Add(data.JobId,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ArtifactData> Get(int newJobType)
{
if (_datas.ContainsKey(newJobType))
return _datas[newJobType];
else
return null;
}
public ArtifactData Get(int newJobType,int newJobId)
{
if (_datas.ContainsKey(newJobType) && _datas[newJobType].ContainsKey(newJobId))
return _datas[newJobType][newJobId];
else
return null;
}
}
}
