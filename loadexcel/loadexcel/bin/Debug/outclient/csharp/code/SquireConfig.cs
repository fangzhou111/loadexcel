using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SquireData
{
/*主键ID*/
public int ID; 
/*侍从栏位*/
public int SquireSlot; 
/*开放领主等级*/
public int OpenLevel; 
/*栏位等级*/
public int SlotLevel; 
/*需要侍从等级*/
public int SquireLevel; 
/*需要侍从的阶*/
public int SquireStep; 
/*需要侍从的觉醒*/
public int SquireAwake; 
/*物攻百分比加成*/
public double PhysicsAtkAdd; 
/*魔攻百分比加成*/
public double MagicAtkAdd; 
/*物防百分比加成*/
public double PhysicsDefAdd; 
/*魔防百分比加成*/
public double MagicDefAdd; 
/*血量百分比加成*/
public double HPAdd; 
}
public partial class SquireConfig : ConfigBase
{
private static SquireConfig _instance;
public Dictionary<int, Dictionary<int, SquireData>> _datas;
public static SquireConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SquireConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Squire.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
SquireData data = new SquireData();
data.ID = br.ReadInt32();
data.SquireSlot = br.ReadInt32();
data.OpenLevel = br.ReadInt32();
data.SlotLevel = br.ReadInt32();
data.SquireLevel = br.ReadInt32();
data.SquireStep = br.ReadInt32();
data.SquireAwake = br.ReadInt32();
data.PhysicsAtkAdd = (float)br.ReadDouble();
data.MagicAtkAdd = (float)br.ReadDouble();
data.PhysicsDefAdd = (float)br.ReadDouble();
data.MagicDefAdd = (float)br.ReadDouble();
data.HPAdd = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, SquireData>>();
if (!_datas.ContainsKey(data.SquireSlot))
{
Dictionary<int, SquireData> _dic = new Dictionary<int, SquireData>();
_datas.Add(data.SquireSlot, _dic);
}
_datas[data.SquireSlot].Add(data.SlotLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, SquireData> Get(int newSquireSlot)
{
if (_datas.ContainsKey(newSquireSlot))
return _datas[newSquireSlot];
else
return null;
}
public SquireData Get(int newSquireSlot,int newSlotLevel)
{
if (_datas.ContainsKey(newSquireSlot) && _datas[newSquireSlot].ContainsKey(newSlotLevel))
return _datas[newSquireSlot][newSlotLevel];
else
return null;
}
}
}
