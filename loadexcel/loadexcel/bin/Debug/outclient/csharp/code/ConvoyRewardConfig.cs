using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ConvoyRewardData
{
/*等级*/
public int Lv; 
/*金币奖励数量*/
public int RewardItemNum1; 
/*征服点数奖励数量*/
public int RewardItemNum2; 
}
public partial class ConvoyRewardConfig : ConfigBase
{
private static ConvoyRewardConfig _instance;
public Dictionary<int, ConvoyRewardData> _datas;
public static ConvoyRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ConvoyRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ConvoyReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 71;i++)
{
ConvoyRewardData data = new ConvoyRewardData();
data.Lv = br.ReadInt32();
data.RewardItemNum1 = br.ReadInt32();
data.RewardItemNum2 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ConvoyRewardData>();
_datas.Add(data.Lv,data);
}
br.Close();
fs.Close();
}
public ConvoyRewardData Get(int newLv)
{
if (_datas.ContainsKey(newLv))
return _datas[newLv];
else
return null;
}
}
}
