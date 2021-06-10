using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TitleShowData
{
/*主键ID，唯一不可重复*/
public int ID; 
/*显示用序列*/
public int ShowID; 
/*名称*/
public string Name; 
/*任务达成条件*/
public int Condition; 
/*任务参数1*/
public int Param1; 
/*任务参数2*/
public int Param2; 
/*任务参数3*/
public int Param3; 
/*是否显示进度*/
public int Schedule; 
/*任务ICON*/
public string Icon; 
/*任务目标描述*/
public string Desc; 
/*属性类型*/
public int AttriType; 
/*先手值*/
public int FirstHandValue; 
/*物攻*/
public double PhysicsAtk; 
/*魔攻*/
public double MagicAtk; 
/*物防*/
public double PhysicsDef; 
/*魔防*/
public double MagicDef; 
/*血量*/
public double HP; 
/*命中*/
public double HitRate; 
/*闪避*/
public double DodgeRate; 
/*暴击*/
public double CritRate; 
/*韧性*/
public double Toughness; 
}
public partial class TitleShowConfig : ConfigBase
{
private static TitleShowConfig _instance;
public Dictionary<int, TitleShowData> _datas;
public static TitleShowConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TitleShowConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TitleShow.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 18;i++)
{
TitleShowData data = new TitleShowData();
data.ID = br.ReadInt32();
data.ShowID = br.ReadInt32();
data.Name = br.ReadString();
data.Condition = br.ReadInt32();
data.Param1 = br.ReadInt32();
data.Param2 = br.ReadInt32();
data.Param3 = br.ReadInt32();
data.Schedule = br.ReadInt32();
data.Icon = br.ReadString();
data.Desc = br.ReadString();
data.AttriType = br.ReadInt32();
data.FirstHandValue = br.ReadInt32();
data.PhysicsAtk = (float)br.ReadDouble();
data.MagicAtk = (float)br.ReadDouble();
data.PhysicsDef = (float)br.ReadDouble();
data.MagicDef = (float)br.ReadDouble();
data.HP = (float)br.ReadDouble();
data.HitRate = (float)br.ReadDouble();
data.DodgeRate = (float)br.ReadDouble();
data.CritRate = (float)br.ReadDouble();
data.Toughness = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, TitleShowData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TitleShowData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
