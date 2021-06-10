using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Shop_act1Data
{
/*商品编号*/
public int ID; 
/*商店类型*/
public int ShopType; 
/*商店子类*/
public int SubType; 
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
/*购买所需货币类型2*/
public int BuyType2; 
/*购买所需对应货币类型的数量2*/
public int BuyNum2; 
/*刷新商品的权重*/
public int Weight; 
/*购买次数限制
0表示无限制*/
public int BuyTimesLimit; 
/*购买限制时效
1每次2每日3永久*/
public int LimitType; 
/*购买条件:
荣誉商店为排名
装备商店为军团层数
公会商店为公会等级*/
public int Requirement; 
/*刷新最低等级*/
public int MinLevel; 
/*刷新最高等级*/
public int MaxLevel; 
/*折扣显示
0表示无折扣*/
public int Discount; 
}
public partial class Shop_act1Config : ConfigBase
{
private static Shop_act1Config _instance;
public Dictionary<int, Shop_act1Data> _datas;
public static Shop_act1Config Instance
{
get
{
if (_instance == null)
{
_instance = new Shop_act1Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Shop_act1.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5491;i++)
{
Shop_act1Data data = new Shop_act1Data();
data.ID = br.ReadInt32();
data.ShopType = br.ReadInt32();
data.SubType = br.ReadInt32();
data.Group = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.ItemNum = br.ReadInt32();
data.BuyType = br.ReadInt32();
data.BuyNum = br.ReadInt32();
data.BuyType2 = br.ReadInt32();
data.BuyNum2 = br.ReadInt32();
data.Weight = br.ReadInt32();
data.BuyTimesLimit = br.ReadInt32();
data.LimitType = br.ReadInt32();
data.Requirement = br.ReadInt32();
data.MinLevel = br.ReadInt32();
data.MaxLevel = br.ReadInt32();
data.Discount = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Shop_act1Data>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public Shop_act1Data Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
