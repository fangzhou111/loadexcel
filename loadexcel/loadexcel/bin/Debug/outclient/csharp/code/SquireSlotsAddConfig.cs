using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SquireSlotsAddData
{
/*栏位加成索引*/
public int SlotAdd; 
/*栏位等级*/
public int SlotLevel; 
/*effect表效果编号*/
public int EffectID; 
/*升级最低次数
该次数以下必定失败*/
public int NumMin; 
/*升级最高次数
达到该次数必定成功*/
public int NumMax; 
/*实际成功率(百万分比)
达到最低次数后的成功率*/
public int SuccessRate; 
/*首次失败祝福值*/
public int LuckyFirst; 
/*祝福值上限
不得小于最高次数*10+首次失败祝福值
每次升级失败祝福值+10*/
public int LuckyMax; 
/*升级道具1编号*/
public int Item1; 
/*升级道具1数量*/
public int Num1; 
/*升级道具2编号*/
public int Item2; 
/*升级道具2数量*/
public int Num2; 
/*升级道具3编号*/
public int Item3; 
/*升级道具3数量*/
public int Num3; 
}
public partial class SquireSlotsAddConfig : ConfigBase
{
private static SquireSlotsAddConfig _instance;
public Dictionary<int, Dictionary<int, SquireSlotsAddData>> _datas;
public static SquireSlotsAddConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SquireSlotsAddConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SquireSlotsAdd.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 20;i++)
{
SquireSlotsAddData data = new SquireSlotsAddData();
data.SlotAdd = br.ReadInt32();
data.SlotLevel = br.ReadInt32();
data.EffectID = br.ReadInt32();
data.NumMin = br.ReadInt32();
data.NumMax = br.ReadInt32();
data.SuccessRate = br.ReadInt32();
data.LuckyFirst = br.ReadInt32();
data.LuckyMax = br.ReadInt32();
data.Item1 = br.ReadInt32();
data.Num1 = br.ReadInt32();
data.Item2 = br.ReadInt32();
data.Num2 = br.ReadInt32();
data.Item3 = br.ReadInt32();
data.Num3 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, SquireSlotsAddData>>();
if (!_datas.ContainsKey(data.SlotAdd))
{
Dictionary<int, SquireSlotsAddData> _dic = new Dictionary<int, SquireSlotsAddData>();
_datas.Add(data.SlotAdd, _dic);
}
_datas[data.SlotAdd].Add(data.SlotLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, SquireSlotsAddData> Get(int newSlotAdd)
{
if (_datas.ContainsKey(newSlotAdd))
return _datas[newSlotAdd];
else
return null;
}
public SquireSlotsAddData Get(int newSlotAdd,int newSlotLevel)
{
if (_datas.ContainsKey(newSlotAdd) && _datas[newSlotAdd].ContainsKey(newSlotLevel))
return _datas[newSlotAdd][newSlotLevel];
else
return null;
}
}
}
