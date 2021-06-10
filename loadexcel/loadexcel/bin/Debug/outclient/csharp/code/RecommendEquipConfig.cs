using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class RecommendEquipData
{
/*装备ID*/
public int ID; 
/*装备名称*/
public string Name; 
/*推荐等级*/
public int RecommendEquipLv; 
}
public partial class RecommendEquipConfig : ConfigBase
{
private static RecommendEquipConfig _instance;
public Dictionary<int, RecommendEquipData> _datas;
public static RecommendEquipConfig Instance
{
get
{
if (_instance == null)
{
_instance = new RecommendEquipConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("RecommendEquip.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 16;i++)
{
RecommendEquipData data = new RecommendEquipData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.RecommendEquipLv = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, RecommendEquipData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public RecommendEquipData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
