using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ConvoyStarProbabilityData
{
/*星级*/
public int Star; 
/*1星概率*/
public int StarProbability1; 
/*2星概率*/
public int StarProbability2; 
/*3星概率*/
public int StarProbability3; 
/*4星概率*/
public int StarProbability4; 
/*5星概率*/
public int StarProbability5; 
/*金币奖励系数*/
public double GoldGrow; 
/*征服点数奖励系数*/
public double ConquerGrow; 
/*护送时间(分钟）*/
public int ConvoyTime; 
/*护送战力百分比加成*/
public int AddPowerRate; 
}
public partial class ConvoyStarProbabilityConfig : ConfigBase
{
private static ConvoyStarProbabilityConfig _instance;
public Dictionary<int, ConvoyStarProbabilityData> _datas;
public static ConvoyStarProbabilityConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ConvoyStarProbabilityConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ConvoyStarProbability.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
ConvoyStarProbabilityData data = new ConvoyStarProbabilityData();
data.Star = br.ReadInt32();
data.StarProbability1 = br.ReadInt32();
data.StarProbability2 = br.ReadInt32();
data.StarProbability3 = br.ReadInt32();
data.StarProbability4 = br.ReadInt32();
data.StarProbability5 = br.ReadInt32();
data.GoldGrow = (float)br.ReadDouble();
data.ConquerGrow = (float)br.ReadDouble();
data.ConvoyTime = br.ReadInt32();
data.AddPowerRate = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ConvoyStarProbabilityData>();
_datas.Add(data.Star,data);
}
br.Close();
fs.Close();
}
public ConvoyStarProbabilityData Get(int newStar)
{
if (_datas.ContainsKey(newStar))
return _datas[newStar];
else
return null;
}
}
}
