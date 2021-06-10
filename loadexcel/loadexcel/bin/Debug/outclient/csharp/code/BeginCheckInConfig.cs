using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BeginCheckInData
{
/*签到天数*/
public int OpenDay; 
/*奖励id*/
public int RewardID; 
}
public partial class BeginCheckInConfig : ConfigBase
{
private static BeginCheckInConfig _instance;
public Dictionary<int, BeginCheckInData> _datas;
public static BeginCheckInConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BeginCheckInConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BeginCheckIn.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
BeginCheckInData data = new BeginCheckInData();
data.OpenDay = br.ReadInt32();
data.RewardID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BeginCheckInData>();
_datas.Add(data.OpenDay,data);
}
br.Close();
fs.Close();
}
public BeginCheckInData Get(int newOpenDay)
{
if (_datas.ContainsKey(newOpenDay))
return _datas[newOpenDay];
else
return null;
}
}
}
