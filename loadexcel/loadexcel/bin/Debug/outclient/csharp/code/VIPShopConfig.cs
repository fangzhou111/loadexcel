using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class VIPShopData
{
/*商品编号*/
public int ID; 
/*类型（0，普通；1、金币；2、英雄经验；3、饰品经验）大于0的类型在欢乐制造机找数量和购买次数价格*/
public int Type; 
/*购买次数在VIP特权表Key*/
public string VIPPrivilegeID; 
/*刷新最低等级*/
public int MinLevel; 
/*刷新最高等级*/
public int MaxLevel; 
}
public partial class VIPShopConfig : ConfigBase
{
private static VIPShopConfig _instance;
public Dictionary<int, VIPShopData> _datas;
public static VIPShopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new VIPShopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("VIPShop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
VIPShopData data = new VIPShopData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.VIPPrivilegeID = br.ReadString();
data.MinLevel = br.ReadInt32();
data.MaxLevel = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, VIPShopData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public VIPShopData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
