using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GoldPriceData
{
/*等级*/
public int Level; 
/*金币价*/
public int GoldPrice; 
}
public partial class GoldPriceConfig : ConfigBase
{
private static GoldPriceConfig _instance;
public Dictionary<int, GoldPriceData> _datas;
public static GoldPriceConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GoldPriceConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GoldPrice.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 100;i++)
{
GoldPriceData data = new GoldPriceData();
data.Level = br.ReadInt32();
data.GoldPrice = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GoldPriceData>();
_datas.Add(data.Level,data);
}
br.Close();
fs.Close();
}
public GoldPriceData Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
}
}
