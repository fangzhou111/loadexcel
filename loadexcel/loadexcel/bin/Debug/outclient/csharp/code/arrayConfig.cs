using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class arrayData
{
/*行*/
public int row; 
/*列*/
public int cul; 
/*阵营*/
public int ctype; 
/*角色ID*/
public int chaid; 
}
public partial class arrayConfig : ConfigBase
{
private static arrayConfig _instance;
public Dictionary<int, Dictionary<int, arrayData>> _datas;
public static arrayConfig Instance
{
get
{
if (_instance == null)
{
_instance = new arrayConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("array.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 72;i++)
{
arrayData data = new arrayData();
data.row = br.ReadInt32();
data.cul = br.ReadInt32();
data.ctype = br.ReadInt32();
data.chaid = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, arrayData>>();
if (!_datas.ContainsKey(data.row))
{
Dictionary<int, arrayData> _dic = new Dictionary<int, arrayData>();
_datas.Add(data.row, _dic);
}
_datas[data.row].Add(data.cul,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, arrayData> Get(int newrow)
{
if (_datas.ContainsKey(newrow))
return _datas[newrow];
else
return null;
}
public arrayData Get(int newrow,int newcul)
{
if (_datas.ContainsKey(newrow) && _datas[newrow].ContainsKey(newcul))
return _datas[newrow][newcul];
else
return null;
}
}
}
