using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernEquipPreviewData
{
/*位置ID*/
public int ID; 
/*奖励ID*/
public int DropItemID; 
}
public partial class TavernEquipPreviewConfig : ConfigBase
{
private static TavernEquipPreviewConfig _instance;
public Dictionary<int, TavernEquipPreviewData> _datas;
public static TavernEquipPreviewConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TavernEquipPreviewConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TavernEquipPreview.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 49;i++)
{
TavernEquipPreviewData data = new TavernEquipPreviewData();
data.ID = br.ReadInt32();
data.DropItemID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TavernEquipPreviewData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TavernEquipPreviewData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
