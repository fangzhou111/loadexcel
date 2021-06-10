using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LeagueMatchChestOrderData
{
/*主键
掉落顺序*/
public int ID; 
/*掉落宝箱*/
public int ChestID; 
}
public partial class LeagueMatchChestOrderConfig : ConfigBase
{
private static LeagueMatchChestOrderConfig _instance;
public Dictionary<int, LeagueMatchChestOrderData> _datas;
public static LeagueMatchChestOrderConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LeagueMatchChestOrderConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LeagueMatchChestOrder.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 240;i++)
{
LeagueMatchChestOrderData data = new LeagueMatchChestOrderData();
data.ID = br.ReadInt32();
data.ChestID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, LeagueMatchChestOrderData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public LeagueMatchChestOrderData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
