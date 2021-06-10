using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RunesUnlockData
{
/*符文解锁数量*/
public int UnlockNum; 
/*解锁需要等级*/
public int UnlockLevel; 
}
public partial class RunesUnlockConfig : ConfigBase
{
private static RunesUnlockConfig _instance;
public Dictionary<int, RunesUnlockData> _datas;
public static RunesUnlockConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RunesUnlockConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RunesUnlock.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 6;i++)
{
RunesUnlockData data = new RunesUnlockData();
data.UnlockNum = br.ReadInt32();
data.UnlockLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, RunesUnlockData>();
_datas.Add(data.UnlockNum,data);
}
br.Close();
fs.Close();
}
public RunesUnlockData Get(int newUnlockNum)
{
if (_datas.ContainsKey(newUnlockNum))
return _datas[newUnlockNum];
else
return null;
}
}
}
