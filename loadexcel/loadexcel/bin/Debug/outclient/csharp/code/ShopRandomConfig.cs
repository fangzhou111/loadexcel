using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ShopRandomData
{
/*碎片获得率*/
public int Share; 
/*碎片类型*/
public int Type; 
/*1正2负*/
public int PlusMinus; 
/*权重增减量*/
public int WeightInc; 
/*index*/
public int index; 
}
public partial class ShopRandomConfig : ConfigBase
{
private static ShopRandomConfig _instance;
public Dictionary<int, ShopRandomData> _datas;
public static ShopRandomConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ShopRandomConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ShopRandom.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
ShopRandomData data = new ShopRandomData();
data.Share = br.ReadInt32();
data.Type = br.ReadInt32();
data.PlusMinus = br.ReadInt32();
data.WeightInc = br.ReadInt32();
data.index = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ShopRandomData>();
_datas.Add(data.index,data);
}
br.Close();
fs.Close();
}
public ShopRandomData Get(int newindex)
{
if (_datas.ContainsKey(newindex))
return _datas[newindex];
else
return null;
}
}
}
