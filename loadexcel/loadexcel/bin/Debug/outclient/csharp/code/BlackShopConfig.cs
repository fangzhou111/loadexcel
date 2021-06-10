using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BlackShopData
{
/*商品编号*/
public int ID; 
/*商品分组/排序*/
public int Group; 
/*商品的物品模板*/
public int ItemID; 
/*出售商品的数量*/
public int ItemNum; 
/*购买所需货币类型*/
public int BuyType; 
/*购买所需对应货币类型的数量*/
public int BuyNum; 
/*刷新商品的权重*/
public int Weight; 
/*刷新最低等级*/
public int MinLevel; 
/*刷新最高等级*/
public int MaxLevel; 
}
public partial class BlackShopConfig : ConfigBase
{
private static BlackShopConfig _instance;
public Dictionary<int, BlackShopData> _datas;
public static BlackShopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BlackShopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BlackShop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 47;i++)
{
BlackShopData data = new BlackShopData();
data.ID = br.ReadInt32();
data.Group = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.ItemNum = br.ReadInt32();
data.BuyType = br.ReadInt32();
data.BuyNum = br.ReadInt32();
data.Weight = br.ReadInt32();
data.MinLevel = br.ReadInt32();
data.MaxLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BlackShopData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public BlackShopData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
