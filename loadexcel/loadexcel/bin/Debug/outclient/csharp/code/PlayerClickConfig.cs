using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PlayerClickData
{
/*编号ID*/
public int ID; 
/*类型*/
public int type; 
/*参数编号*/
public int value; 
}
public partial class PlayerClickConfig : ConfigBase
{
private static PlayerClickConfig _instance;
public Dictionary<int, Dictionary<int, PlayerClickData>> _datas;
public static PlayerClickConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PlayerClickConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PlayerClick.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 48;i++)
{
PlayerClickData data = new PlayerClickData();
data.ID = br.ReadInt32();
data.type = br.ReadInt32();
data.value = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, PlayerClickData>>();
if (!_datas.ContainsKey(data.type))
{
Dictionary<int, PlayerClickData> _dic = new Dictionary<int, PlayerClickData>();
_datas.Add(data.type, _dic);
}
_datas[data.type].Add(data.value,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, PlayerClickData> Get(int newtype)
{
if (_datas.ContainsKey(newtype))
return _datas[newtype];
else
return null;
}
public PlayerClickData Get(int newtype,int newvalue)
{
if (_datas.ContainsKey(newtype) && _datas[newtype].ContainsKey(newvalue))
return _datas[newtype][newvalue];
else
return null;
}
}
}
