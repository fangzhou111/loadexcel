using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class IllidanSpendData
{
/*次数*/
public int SpendNum; 
/*钻石*/
public int SpendDiamond; 
}
public partial class IllidanSpendConfig : ConfigBase
{
private static IllidanSpendConfig _instance;
public Dictionary<int, IllidanSpendData> _datas;
public static IllidanSpendConfig Instance
{
get
{
if (_instance == null)
{
_instance = new IllidanSpendConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("IllidanSpend.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 15;i++)
{
IllidanSpendData data = new IllidanSpendData();
data.SpendNum = br.ReadInt32();
data.SpendDiamond = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, IllidanSpendData>();
_datas.Add(data.SpendNum,data);
}
br.Close();
fs.Close();
}
public IllidanSpendData Get(int newSpendNum)
{
if (_datas.ContainsKey(newSpendNum))
return _datas[newSpendNum];
else
return null;
}
}
}
