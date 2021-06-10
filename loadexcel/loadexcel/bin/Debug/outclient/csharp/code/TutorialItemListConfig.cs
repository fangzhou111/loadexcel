using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TutorialItemListData
{
/*奖励道具列表*/
public int ItemListID; 
/*道具1编号*/
public int ItemID1; 
/*道具1数量*/
public int ItemNum1; 
/*道具2编号*/
public int ItemID2; 
/*道具2数量*/
public int ItemNum2; 
/*道具3编号*/
public int ItemID3; 
/*道具3数量*/
public int ItemNum3; 
/*道具4编号*/
public int ItemID4; 
/*道具4数量*/
public int ItemNum4; 
/*道具5编号*/
public int ItemID5; 
/*道具5数量*/
public int ItemNum5; 
/*道具6编号*/
public int ItemID6; 
/*道具6数量*/
public int ItemNum6; 
}
public partial class TutorialItemListConfig : ConfigBase
{
private static TutorialItemListConfig _instance;
public Dictionary<int, TutorialItemListData> _datas;
public static TutorialItemListConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TutorialItemListConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TutorialItemList.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
TutorialItemListData data = new TutorialItemListData();
data.ItemListID = br.ReadInt32();
data.ItemID1 = br.ReadInt32();
data.ItemNum1 = br.ReadInt32();
data.ItemID2 = br.ReadInt32();
data.ItemNum2 = br.ReadInt32();
data.ItemID3 = br.ReadInt32();
data.ItemNum3 = br.ReadInt32();
data.ItemID4 = br.ReadInt32();
data.ItemNum4 = br.ReadInt32();
data.ItemID5 = br.ReadInt32();
data.ItemNum5 = br.ReadInt32();
data.ItemID6 = br.ReadInt32();
data.ItemNum6 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TutorialItemListData>();
_datas.Add(data.ItemListID,data);
}
br.Close();
fs.Close();
}
public TutorialItemListData Get(int newItemListID)
{
if (_datas.ContainsKey(newItemListID))
return _datas[newItemListID];
else
return null;
}
}
}
