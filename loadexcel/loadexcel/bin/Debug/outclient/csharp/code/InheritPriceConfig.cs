using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class InheritPriceData
{
/*道具ID*/
public int Item; 
/*传承价格（钻）*/
public int Price; 
}
public partial class InheritPriceConfig : ConfigBase
{
private static InheritPriceConfig _instance;
public Dictionary<int, InheritPriceData> _datas;
public static InheritPriceConfig Instance
{
get
{
if (_instance == null)
{
_instance = new InheritPriceConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("InheritPrice.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 123;i++)
{
InheritPriceData data = new InheritPriceData();
data.Item = br.ReadInt32();
data.Price = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, InheritPriceData>();
_datas.Add(data.Item,data);
}
br.Close();
fs.Close();
}
public InheritPriceData Get(int newItem)
{
if (_datas.ContainsKey(newItem))
return _datas[newItem];
else
return null;
}
}
}
