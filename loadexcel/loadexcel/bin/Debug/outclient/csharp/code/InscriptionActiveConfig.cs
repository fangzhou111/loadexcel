using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class InscriptionActiveData
{
/*节点id*/
public int NodeID; 
/*前置节点id*/
public int NeedNode; 
/*属性类型*/
public int AttributeType; 
/*所属职业*/
public int WorkID; 
/*英雄品质*/
public int HeroQuality; 
/*每次金币消耗*/
public int NeedMoney; 
/*每次雕文石消耗*/
public int NeedInscriptionStone; 
/*最低次数*/
public int SuccessMin; 
/*最高次数*/
public int SuccessMax; 
/*成功率*/
public int SuccessRate; 
/*首次失败祝福值*/
public int LuckyFirst; 
/*祝福值上限*/
public int LuckyMax; 
/*祝福步进值*/
public int LuckyStep; 
}
public partial class InscriptionActiveConfig : ConfigBase
{
private static InscriptionActiveConfig _instance;
public Dictionary<int, InscriptionActiveData> _datas;
public static InscriptionActiveConfig Instance
{
get
{
if (_instance == null)
{
_instance = new InscriptionActiveConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("InscriptionActive.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 66;i++)
{
InscriptionActiveData data = new InscriptionActiveData();
data.NodeID = br.ReadInt32();
data.NeedNode = br.ReadInt32();
data.AttributeType = br.ReadInt32();
data.WorkID = br.ReadInt32();
data.HeroQuality = br.ReadInt32();
data.NeedMoney = br.ReadInt32();
data.NeedInscriptionStone = br.ReadInt32();
data.SuccessMin = br.ReadInt32();
data.SuccessMax = br.ReadInt32();
data.SuccessRate = br.ReadInt32();
data.LuckyFirst = br.ReadInt32();
data.LuckyMax = br.ReadInt32();
data.LuckyStep = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, InscriptionActiveData>();
_datas.Add(data.NodeID,data);
}
br.Close();
fs.Close();
}
public InscriptionActiveData Get(int newNodeID)
{
if (_datas.ContainsKey(newNodeID))
return _datas[newNodeID];
else
return null;
}
}
}
