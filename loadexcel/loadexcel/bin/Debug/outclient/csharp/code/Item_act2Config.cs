using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class Item_act2Data
{
/*唯一ID*/
public int ID; 
/*名称*/
public string Name; 
/*描述*/
public string Desc; 
/*最大堆叠数*/
public int Max_Amount; 
/*物品使用等级*/
public int ItemUsedGrade; 
/*有效时间(单位秒)*/
public int Timeout; 
/*物品类型*/
public int Type; 
/*物品子类型*/
public int Detail_Type; 
/*物品品质*/
public int Profile; 
/*道具图标*/
public string Icon; 
/*是否可出售*/
public int ItemSellType; 
/*出售可获得金钱*/
public int GainGoldSell; 
/*扩展参数1(数字)*/
public int Param1; 
/*扩展参数2(数字)*/
public int Param2; 
/*扩展参数3(字符)*/
public string Param3; 
/*扩展参数4(字符)*/
public string Param4; 
}
public partial class Item_act2Config : ConfigBase
{
private static Item_act2Config _instance;
public Dictionary<int, Item_act2Data> _datas;
public static Item_act2Config Instance
{
get
{
if (_instance == null)
{
_instance = new Item_act2Config();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Item_act2.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1245;i++)
{
Item_act2Data data = new Item_act2Data();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.Desc = br.ReadString();
data.Max_Amount = br.ReadInt32();
data.ItemUsedGrade = br.ReadInt32();
data.Timeout = br.ReadInt32();
data.Type = br.ReadInt32();
data.Detail_Type = br.ReadInt32();
data.Profile = br.ReadInt32();
data.Icon = br.ReadString();
data.ItemSellType = br.ReadInt32();
data.GainGoldSell = br.ReadInt32();
data.Param1 = br.ReadInt32();
data.Param2 = br.ReadInt32();
data.Param3 = br.ReadString();
data.Param4 = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Item_act2Data>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public Item_act2Data Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
