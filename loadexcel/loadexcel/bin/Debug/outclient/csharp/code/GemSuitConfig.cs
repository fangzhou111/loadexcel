using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GemSuitData
{
/*宝石套装ID*/
public int SuitID; 
/*套装类型*/
public int Type; 
/*参数1*/
public int Para1; 
/*效果ID*/
public int EffectID; 
}
public partial class GemSuitConfig : ConfigBase
{
private static GemSuitConfig _instance;
public Dictionary<int, GemSuitData> _datas;
public static GemSuitConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GemSuitConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GemSuit.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
GemSuitData data = new GemSuitData();
data.SuitID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Para1 = br.ReadInt32();
data.EffectID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GemSuitData>();
_datas.Add(data.SuitID,data);
}
br.Close();
fs.Close();
}
public GemSuitData Get(int newSuitID)
{
if (_datas.ContainsKey(newSuitID))
return _datas[newSuitID];
else
return null;
}
}
}
