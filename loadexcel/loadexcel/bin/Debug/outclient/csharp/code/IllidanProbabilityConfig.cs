using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class IllidanProbabilityData
{
/*伊利丹个数*/
public int IllidanNum; 
/*0个伊利丹出现概率*/
public int IllidanProbability0; 
/*1个伊利丹出现概率*/
public int IllidanProbability1; 
/*2个伊利丹出现概率*/
public int IllidanProbability2; 
/*3个伊利丹出现概率*/
public int IllidanProbability3; 
/*4个伊利丹出现概率*/
public int IllidanProbability4; 
/*5个伊利丹出现概率*/
public int IllidanProbability5; 
/*6个伊利丹出现概率*/
public int IllidanProbability6; 
}
public partial class IllidanProbabilityConfig : ConfigBase
{
private static IllidanProbabilityConfig _instance;
public Dictionary<int, IllidanProbabilityData> _datas;
public static IllidanProbabilityConfig Instance
{
get
{
if (_instance == null)
{
_instance = new IllidanProbabilityConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("IllidanProbability.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
IllidanProbabilityData data = new IllidanProbabilityData();
data.IllidanNum = br.ReadInt32();
data.IllidanProbability0 = br.ReadInt32();
data.IllidanProbability1 = br.ReadInt32();
data.IllidanProbability2 = br.ReadInt32();
data.IllidanProbability3 = br.ReadInt32();
data.IllidanProbability4 = br.ReadInt32();
data.IllidanProbability5 = br.ReadInt32();
data.IllidanProbability6 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, IllidanProbabilityData>();
_datas.Add(data.IllidanNum,data);
}
br.Close();
fs.Close();
}
public IllidanProbabilityData Get(int newIllidanNum)
{
if (_datas.ContainsKey(newIllidanNum))
return _datas[newIllidanNum];
else
return null;
}
}
}
