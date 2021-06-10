using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Carnival2SaleData
{
/*唯一标识*/
public int ID; 
/*商品ID*/
public int ItemID; 
/*商品数量*/
public int ItemNum; 
/*出售货币*/
public int SaleType; 
/*出售价格*/
public int SaleValue; 
/*限购数量*/
public int SaleLimit; 
/*折扣显示*/
public int Discount; 
}
public partial class Carnival2SaleConfig : ConfigBase
{
private static Carnival2SaleConfig _instance;
public Dictionary<int, Carnival2SaleData> _datas;
public static Carnival2SaleConfig Instance
{
get
{
if (_instance == null)
{
_instance = new Carnival2SaleConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Carnival2Sale.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 51;i++)
{
Carnival2SaleData data = new Carnival2SaleData();
data.ID = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.ItemNum = br.ReadInt32();
data.SaleType = br.ReadInt32();
data.SaleValue = br.ReadInt32();
data.SaleLimit = br.ReadInt32();
data.Discount = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Carnival2SaleData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public Carnival2SaleData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
