using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class InscriptionLevelUpData
{
/*节点ID*/
public int NodeID; 
/*专精级别*/
public int Level; 
/*属性数值*/
public int AttributeValue; 
/*雕文经验消耗*/
public int NeedInscriptionExp; 
/*金币消耗*/
public int NeedMoney; 
}
public partial class InscriptionLevelUpConfig : ConfigBase
{
private static InscriptionLevelUpConfig _instance;
public Dictionary<int, Dictionary<int, InscriptionLevelUpData>> _datas;
public static InscriptionLevelUpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new InscriptionLevelUpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("InscriptionLevelUp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 462;i++)
{
InscriptionLevelUpData data = new InscriptionLevelUpData();
data.NodeID = br.ReadInt32();
data.Level = br.ReadInt32();
data.AttributeValue = br.ReadInt32();
data.NeedInscriptionExp = br.ReadInt32();
data.NeedMoney = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, InscriptionLevelUpData>>();
if (!_datas.ContainsKey(data.NodeID))
{
Dictionary<int, InscriptionLevelUpData> _dic = new Dictionary<int, InscriptionLevelUpData>();
_datas.Add(data.NodeID, _dic);
}
_datas[data.NodeID].Add(data.Level,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, InscriptionLevelUpData> Get(int newNodeID)
{
if (_datas.ContainsKey(newNodeID))
return _datas[newNodeID];
else
return null;
}
public InscriptionLevelUpData Get(int newNodeID,int newLevel)
{
if (_datas.ContainsKey(newNodeID) && _datas[newNodeID].ContainsKey(newLevel))
return _datas[newNodeID][newLevel];
else
return null;
}
}
}
