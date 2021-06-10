using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CupSupportRewardData
{
/*领主等级段*/
public int Level; 
/*奖励金币*/
public int GoldReward; 
}
public partial class CupSupportRewardConfig : ConfigBase
{
private static CupSupportRewardConfig _instance;
public Dictionary<int, CupSupportRewardData> _datas;
public static CupSupportRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CupSupportRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CupSupportReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 6;i++)
{
CupSupportRewardData data = new CupSupportRewardData();
data.Level = br.ReadInt32();
data.GoldReward = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, CupSupportRewardData>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public CupSupportRewardData Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
