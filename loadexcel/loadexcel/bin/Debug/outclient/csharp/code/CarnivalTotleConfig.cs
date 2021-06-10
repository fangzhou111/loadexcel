using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CarnivalTotleData
{
/*领取所需完成条数*/
public int GetCount; 
/*奖励编号*/
public int RewardId; 
}
public partial class CarnivalTotleConfig : ConfigBase
{
private static CarnivalTotleConfig _instance;
public Dictionary<int, CarnivalTotleData> _datas;
public static CarnivalTotleConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CarnivalTotleConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CarnivalTotle.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
CarnivalTotleData data = new CarnivalTotleData();
data.GetCount = br.ReadInt32();
data.RewardId = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, CarnivalTotleData>();
_datas.Add(data.GetCount,data);
}
br.Close();
fs.Close();
}
public CarnivalTotleData Get(int newGetCount)
{
if (_datas.ContainsKey(newGetCount))
return _datas[newGetCount];
else
return null;
}
}
}
