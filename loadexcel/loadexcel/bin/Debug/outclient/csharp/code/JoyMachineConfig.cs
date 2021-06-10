using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class JoyMachineData
{
/*主键ID*/
public int ID; 
/*类型*/
public string Type; 
/*类型名*/
public string Name; 
/*免费次数*/
public int FreeTimes; 
/*等级限制*/
public int NeedLevel; 
}
public partial class JoyMachineConfig : ConfigBase
{
private static JoyMachineConfig _instance;
public Dictionary<int, JoyMachineData> _datas;
public static JoyMachineConfig Instance
{
get
{
if (_instance == null)
{
_instance = new JoyMachineConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("JoyMachine.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
JoyMachineData data = new JoyMachineData();
data.ID = br.ReadInt32();
data.Type = br.ReadString();
data.Name = br.ReadString();
data.FreeTimes = br.ReadInt32();
data.NeedLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, JoyMachineData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public JoyMachineData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
