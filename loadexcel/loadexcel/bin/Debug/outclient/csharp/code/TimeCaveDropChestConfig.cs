using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TimeCaveDropChestData
{
/*主键，ID唯一不可更改*/
public int ID; 
/*关卡ID*/
public int CampaignID; 
/*商品分组/排序*/
public int Group; 
/*道具ID*/
public int ItemID; 
/*道具数量*/
public int ItemNum; 
/*组内权重*/
public int Weight; 
/*分组权重*/
public int GroupWeight; 
}
public partial class TimeCaveDropChestConfig : ConfigBase
{
private static TimeCaveDropChestConfig _instance;
public Dictionary<int, TimeCaveDropChestData> _datas;
public static TimeCaveDropChestConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TimeCaveDropChestConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TimeCaveDropChest.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 380;i++)
{
TimeCaveDropChestData data = new TimeCaveDropChestData();
data.ID = br.ReadInt32();
data.CampaignID = br.ReadInt32();
data.Group = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.ItemNum = br.ReadInt32();
data.Weight = br.ReadInt32();
data.GroupWeight = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TimeCaveDropChestData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TimeCaveDropChestData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
