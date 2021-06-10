using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernLoopData
{
/*主键ID*/
public int ID; 
/*掉落包ID*/
public int Order; 
/*对应Tacern主键ID*/
public int TavernID; 
/*掉落类型*/
public int item_type; 
/*掉落ID*/
public int item_id; 
}
public partial class TavernLoopConfig : ConfigBase
{
private static TavernLoopConfig _instance;
public Dictionary<int, Dictionary<int, TavernLoopData>> _datas;
public static TavernLoopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TavernLoopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TavernLoop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 198;i++)
{
TavernLoopData data = new TavernLoopData();
data.ID = br.ReadInt32();
data.Order = br.ReadInt32();
data.TavernID = br.ReadInt32();
data.item_type = br.ReadInt32();
data.item_id = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, TavernLoopData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, TavernLoopData> _dic = new Dictionary<int, TavernLoopData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.Order,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, TavernLoopData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public TavernLoopData Get(int newID,int newOrder)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newOrder))
return _datas[newID][newOrder];
else
return null;
}
}
}
