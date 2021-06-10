using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WelfareData
{
/*主键ID*/
public int ID; 
/*类型*/
public int Type; 
/*领奖条件1*/
public int Condition1; 
/*领奖条件2*/
public int Condition2; 
/*额外参数*/
public int Param1; 
/*额外参数*/
public int Param2; 
/*序列*/
public int Order; 
/*开始时间*/
public int star_time; 
/*结束时间*/
public int end_time; 
/*掉落包ID*/
public int DropID; 
/*描述*/
public string desc; 
/*条目描述*/
public string desc1; 
/*活动名字*/
public string name; 
}
public partial class WelfareConfig : ConfigBase
{
private static WelfareConfig _instance;
public Dictionary<int, WelfareData> _datas;
public static WelfareConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WelfareConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Welfare.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1;i++)
{
WelfareData data = new WelfareData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Condition1 = br.ReadInt32();
data.Condition2 = br.ReadInt32();
data.Param1 = br.ReadInt32();
data.Param2 = br.ReadInt32();
data.Order = br.ReadInt32();
data.star_time = br.ReadInt32();
data.end_time = br.ReadInt32();
data.DropID = br.ReadInt32();
data.desc = br.ReadString();
data.desc1 = br.ReadString();
data.name = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, WelfareData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public WelfareData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
