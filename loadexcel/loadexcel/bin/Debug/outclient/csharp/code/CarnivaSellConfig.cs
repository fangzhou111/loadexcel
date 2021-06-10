using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CarnivaSellData
{
/*主键ID*/
public int ID; 
/*开服第几天*/
public int OpenDay; 
/*分页名称*/
public string PageName; 
/*购买货币*/
public int SaleType; 
/*购买前价格*/
public int SaleValue1; 
/*实际购买价格*/
public int SaleValue2; 
/*道具ID*/
public int ItemID; 
/*道具数量*/
public int ItemNum; 
/*可购买次数*/
public int BuyNum; 
/*是否显示奖励预览*/
public int ShowItem; 
/*奖励预览*/
public string ShowItemID; 
}
public partial class CarnivaSellConfig : ConfigBase
{
private static CarnivaSellConfig _instance;
public Dictionary<int, Dictionary<int, CarnivaSellData>> _datas;
public static CarnivaSellConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CarnivaSellConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CarnivaSell.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 7;i++)
{
CarnivaSellData data = new CarnivaSellData();
data.ID = br.ReadInt32();
data.OpenDay = br.ReadInt32();
data.PageName = br.ReadString();
data.SaleType = br.ReadInt32();
data.SaleValue1 = br.ReadInt32();
data.SaleValue2 = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.ItemNum = br.ReadInt32();
data.BuyNum = br.ReadInt32();
data.ShowItem = br.ReadInt32();
data.ShowItemID = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, CarnivaSellData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, CarnivaSellData> _dic = new Dictionary<int, CarnivaSellData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.OpenDay,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, CarnivaSellData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public CarnivaSellData Get(int newID,int newOpenDay)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newOpenDay))
return _datas[newID][newOpenDay];
else
return null;
}
}
}
