using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SignNumData
{
/*编号*/
public int ID; 
/*累签天数
永久累积，达到最高天数每签七天*/
public int SignNum; 
/*奖励1*/
public int Item1; 
/*数量1*/
public int Num1; 
/*奖励2*/
public int Item2; 
/*数量2*/
public int Num2; 
/*奖励3*/
public int Item3; 
/*数量3*/
public int Num3; 
}
public partial class SignNumConfig : ConfigBase
{
private static SignNumConfig _instance;
public Dictionary<int, SignNumData> _datas;
public static SignNumConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SignNumConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SignNum.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
SignNumData data = new SignNumData();
data.ID = br.ReadInt32();
data.SignNum = br.ReadInt32();
data.Item1 = br.ReadInt32();
data.Num1 = br.ReadInt32();
data.Item2 = br.ReadInt32();
data.Num2 = br.ReadInt32();
data.Item3 = br.ReadInt32();
data.Num3 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, SignNumData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public SignNumData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
