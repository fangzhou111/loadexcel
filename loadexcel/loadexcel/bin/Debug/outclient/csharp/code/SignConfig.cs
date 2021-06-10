using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SignData
{
/*天数*/
public int ID; 
/*道具编号*/
public int Item; 
/*数量*/
public int Num; 
/*双倍要求VIP等级*/
public int Vip; 
}
public partial class SignConfig : ConfigBase
{
private static SignConfig _instance;
public Dictionary<int, SignData> _datas;
public static SignConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SignConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Sign.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 31;i++)
{
SignData data = new SignData();
data.ID = br.ReadInt32();
data.Item = br.ReadInt32();
data.Num = br.ReadInt32();
data.Vip = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, SignData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public SignData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
