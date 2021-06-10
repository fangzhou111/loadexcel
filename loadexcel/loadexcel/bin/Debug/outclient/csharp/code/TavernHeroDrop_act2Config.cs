using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernHeroDrop_act2Data
{
/*主键ID*/
public int ID; 
/*掉落包*/
public int Order; 
/*掉落类型*/
public int DropCondition; 
/*掉落物品ID*/
public int DropItemID; 
/*掉落物品数量*/
public int DropItemNum; 
/*概率或权重*/
public int DropProbability; 
/*子分组*/
public int SubOrder; 
/*刷新最低等级*/
public int MinLevel; 
/*刷新最高等级*/
public int MaxLevel; 
}
public partial class TavernHeroDrop_act2Config : ConfigBase
{
private static TavernHeroDrop_act2Config _instance;
public Dictionary<int, Dictionary<int, TavernHeroDrop_act2Data>> _datas;
public static TavernHeroDrop_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new TavernHeroDrop_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TavernHeroDrop_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1330;i++)
{
TavernHeroDrop_act2Data data = new TavernHeroDrop_act2Data();
data.ID = br.ReadInt32();
data.Order = br.ReadInt32();
data.DropCondition = br.ReadInt32();
data.DropItemID = br.ReadInt32();
data.DropItemNum = br.ReadInt32();
data.DropProbability = br.ReadInt32();
data.SubOrder = br.ReadInt32();
data.MinLevel = br.ReadInt32();
data.MaxLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, TavernHeroDrop_act2Data>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, TavernHeroDrop_act2Data> _dic = new Dictionary<int, TavernHeroDrop_act2Data>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.Order,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, TavernHeroDrop_act2Data> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public TavernHeroDrop_act2Data Get(int newID,int newOrder)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newOrder))
return _datas[newID][newOrder];
else
return null;
}
}
}
