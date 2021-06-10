using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ShopItemResetTimeData
{
/*编号ID*/
public int ID; 
/*商店类型*/
public int ShopType; 
/*刷新时间*/
public int ResetTime; 
}
public partial class ShopItemResetTimeConfig : ConfigBase
{
private static ShopItemResetTimeConfig _instance;
public Dictionary<int, ShopItemResetTimeData> _datas;
public static ShopItemResetTimeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ShopItemResetTimeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ShopItemResetTime.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 7;i++)
{
ShopItemResetTimeData data = new ShopItemResetTimeData();
data.ID = br.ReadInt32();
data.ShopType = br.ReadInt32();
data.ResetTime = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ShopItemResetTimeData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ShopItemResetTimeData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
