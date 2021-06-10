using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BeginRankData
{
/*唯一标识*/
public int id; 
/*功能id*/
public int FunctionId; 
/*子功能要求*/
public int SubFunctionValue1; 
/*子功能要求2*/
public int SubFunctionValue2; 
/*奖励id*/
public int RewardId; 
}
public partial class BeginRankConfig : ConfigBase
{
private static BeginRankConfig _instance;
public Dictionary<int, BeginRankData> _datas;
public static BeginRankConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BeginRankConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BeginRank.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 16;i++)
{
BeginRankData data = new BeginRankData();
data.id = br.ReadInt32();
data.FunctionId = br.ReadInt32();
data.SubFunctionValue1 = br.ReadInt32();
data.SubFunctionValue2 = br.ReadInt32();
data.RewardId = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BeginRankData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public BeginRankData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
