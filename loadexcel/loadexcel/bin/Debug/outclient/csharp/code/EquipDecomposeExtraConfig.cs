using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class EquipDecomposeExtraData
{
/*唯一id*/
public int id; 
/*装备星级*/
public int star; 
/*装备等级*/
public int gs; 
/*物品id*/
public int item_id; 
/*数量*/
public int num; 
}
public partial class EquipDecomposeExtraConfig : ConfigBase
{
private static EquipDecomposeExtraConfig _instance;
public Dictionary<int, EquipDecomposeExtraData> _datas;
public static EquipDecomposeExtraConfig Instance
{
get
{
if (_instance == null)
{
_instance = new EquipDecomposeExtraConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("EquipDecomposeExtra.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 12;i++)
{
EquipDecomposeExtraData data = new EquipDecomposeExtraData();
data.id = br.ReadInt32();
data.star = br.ReadInt32();
data.gs = br.ReadInt32();
data.item_id = br.ReadInt32();
data.num = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, EquipDecomposeExtraData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public EquipDecomposeExtraData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
