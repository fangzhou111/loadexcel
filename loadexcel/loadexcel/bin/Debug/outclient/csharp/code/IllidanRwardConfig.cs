using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class IllidanRwardData
{
/*序号*/
public int ID; 
/*伊利丹个数*/
public int IllidanNum; 
/*伊利丹奖励物品ID1*/
public int IllidanRward1; 
/*奖励道具数量1*/
public int IllidanRwardNum1; 
/*伊利丹奖励物品ID2*/
public int IllidanRward2; 
/*奖励道具数量2*/
public int IllidanRwardNum2; 
/*伊利丹奖励物品ID3*/
public int IllidanRward3; 
/*奖励道具数量3*/
public int IllidanRwardNum3; 
}
public partial class IllidanRwardConfig : ConfigBase
{
private static IllidanRwardConfig _instance;
public Dictionary<int, IllidanRwardData> _datas;
public static IllidanRwardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new IllidanRwardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("IllidanRward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 6;i++)
{
IllidanRwardData data = new IllidanRwardData();
data.ID = br.ReadInt32();
data.IllidanNum = br.ReadInt32();
data.IllidanRward1 = br.ReadInt32();
data.IllidanRwardNum1 = br.ReadInt32();
data.IllidanRward2 = br.ReadInt32();
data.IllidanRwardNum2 = br.ReadInt32();
data.IllidanRward3 = br.ReadInt32();
data.IllidanRwardNum3 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, IllidanRwardData>();
_datas.Add(data.IllidanNum,data);
}
br.Close();
fs.Close();
}
public IllidanRwardData Get(int newIllidanNum)
{
if (_datas.ContainsKey(newIllidanNum))
return _datas[newIllidanNum];
else
return null;
}
}
}
