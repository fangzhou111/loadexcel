using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BuyTimes_act2Data
{
/*模块*/
public string Type; 
/*次数*/
public int Times; 
/*购买道具类型*/
public int ItemID; 
/*数量*/
public int Num; 
/*消耗道具ID1*/
public int ItemID1; 
/*消耗道具数量1*/
public int ItemNum1; 
/*折扣显示1*/
public int Discount; 
/*消耗道具ID2*/
public int ItemID2; 
/*消耗道具数量2*/
public int ItemNum2; 
}
public partial class BuyTimes_act2Config : ConfigBase
{
private static BuyTimes_act2Config _instance;
public Dictionary<string, Dictionary<int, BuyTimes_act2Data>> _datas;
public static BuyTimes_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new BuyTimes_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BuyTimes_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 736;i++)
{
BuyTimes_act2Data data = new BuyTimes_act2Data();
data.Type = br.ReadString();
data.Times = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.Num = br.ReadInt32();
data.ItemID1 = br.ReadInt32();
data.ItemNum1 = br.ReadInt32();
data.Discount = br.ReadInt32();
data.ItemID2 = br.ReadInt32();
data.ItemNum2 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, Dictionary<int, BuyTimes_act2Data>>();
if (!_datas.ContainsKey(data.Type))
{
Dictionary<int, BuyTimes_act2Data> _dic = new Dictionary<int, BuyTimes_act2Data>();
_datas.Add(data.Type, _dic);
}
_datas[data.Type].Add(data.Times,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, BuyTimes_act2Data> Get(string newType)
{
if (_datas.ContainsKey(newType))
return _datas[newType];
else
return null;
}
public BuyTimes_act2Data Get(string newType,int newTimes)
{
if (_datas.ContainsKey(newType) && _datas[newType].ContainsKey(newTimes))
return _datas[newType][newTimes];
else
return null;
}
}
}
