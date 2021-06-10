using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class IllidanData
{
/*我要伊利丹等级*/
public int NeedIllidan; 
/*升级经验*/
public int NeedIllidanExp; 
/*可玩次数*/
public int GameTimeUp; 
/*免费次数*/
public int FreePlayNum; 
/*捐献金币*/
public int Money; 
/*捐献金币可获经验*/
public int MoneyExp; 
/*捐金币功勋*/
public int MoneyContribution; 
/*捐献钻石*/
public int Gold; 
/*捐献钻石可获经验*/
public int GoldExp; 
/*捐钻石功勋*/
public int GoldContribution; 
}
public partial class IllidanConfig : ConfigBase
{
private static IllidanConfig _instance;
public Dictionary<int, IllidanData> _datas;
public static IllidanConfig Instance
{
get
{
if (_instance == null)
{
_instance = new IllidanConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Illidan.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
IllidanData data = new IllidanData();
data.NeedIllidan = br.ReadInt32();
data.NeedIllidanExp = br.ReadInt32();
data.GameTimeUp = br.ReadInt32();
data.FreePlayNum = br.ReadInt32();
data.Money = br.ReadInt32();
data.MoneyExp = br.ReadInt32();
data.MoneyContribution = br.ReadInt32();
data.Gold = br.ReadInt32();
data.GoldExp = br.ReadInt32();
data.GoldContribution = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, IllidanData>();
_datas.Add(data.NeedIllidan,data);
}
br.Close();
fs.Close();
}
public IllidanData Get(int newNeedIllidan)
{
if (_datas.ContainsKey(newNeedIllidan))
return _datas[newNeedIllidan];
else
return null;
}
}
}
