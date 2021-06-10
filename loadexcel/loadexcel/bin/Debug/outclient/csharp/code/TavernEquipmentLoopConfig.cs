using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernEquipmentLoopData
{
/*次数*/
public int time; 
/*类型*/
public int type; 
/*掉落类型*/
public int item_type1; 
/*掉落ID1*/
public int item_id1; 
/*掉落数量1*/
public int item_num1; 
/*掉落类型*/
public int item_type2; 
/*掉落ID2*/
public int item_id2; 
/*掉落数量2*/
public int item_num2; 
/*解锁装备碎片*/
public int unlock; 
}
public partial class TavernEquipmentLoopConfig : ConfigBase
{
private static TavernEquipmentLoopConfig _instance;
public Dictionary<int, TavernEquipmentLoopData> _datas;
public static TavernEquipmentLoopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TavernEquipmentLoopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TavernEquipmentLoop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 27;i++)
{
TavernEquipmentLoopData data = new TavernEquipmentLoopData();
data.time = br.ReadInt32();
data.type = br.ReadInt32();
data.item_type1 = br.ReadInt32();
data.item_id1 = br.ReadInt32();
data.item_num1 = br.ReadInt32();
data.item_type2 = br.ReadInt32();
data.item_id2 = br.ReadInt32();
data.item_num2 = br.ReadInt32();
data.unlock = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TavernEquipmentLoopData>();
_datas.Add(data.time,data);
}
br.Close();
fs.Close();
}
public TavernEquipmentLoopData Get(int newtime)
{
if (_datas.ContainsKey(newtime))
return _datas[newtime];
else
return null;
}
}
}
