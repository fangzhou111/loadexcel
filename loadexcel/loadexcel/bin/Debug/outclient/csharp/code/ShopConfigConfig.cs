using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ShopConfigData
{
/*商店类型*/
public int ShopType; 
/*货柜总数*/
public int CellNum; 
/*随机类型*/
public int RandomType; 
/*分组*/
public int Group; 
/*形象*/
public string Model; 
/*能否刷新*/
public int Refresh; 
}
public partial class ShopConfigConfig : ConfigBase
{
private static ShopConfigConfig _instance;
public Dictionary<int, ShopConfigData> _datas;
public static ShopConfigConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ShopConfigConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ShopConfig.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 11;i++)
{
ShopConfigData data = new ShopConfigData();
data.ShopType = br.ReadInt32();
data.CellNum = br.ReadInt32();
data.RandomType = br.ReadInt32();
data.Group = br.ReadInt32();
data.Model = br.ReadString();
data.Refresh = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ShopConfigData>();
_datas.Add(data.ShopType,data);
}
br.Close();
fs.Close();
}
public ShopConfigData Get(int newShopType)
{
if (_datas.ContainsKey(newShopType))
return _datas[newShopType];
else
return null;
}
}
}
