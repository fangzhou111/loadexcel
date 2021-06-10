using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernPreviewData
{
/*位置ID*/
public int ID; 
/*奖励ID*/
public int DropItemID; 
/*类型*/
public int DropType; 
}
public partial class TavernPreviewConfig : ConfigBase
{
private static TavernPreviewConfig _instance;
public Dictionary<int, TavernPreviewData> _datas;
public static TavernPreviewConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TavernPreviewConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TavernPreview.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 134;i++)
{
TavernPreviewData data = new TavernPreviewData();
data.ID = br.ReadInt32();
data.DropItemID = br.ReadInt32();
data.DropType = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TavernPreviewData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TavernPreviewData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
