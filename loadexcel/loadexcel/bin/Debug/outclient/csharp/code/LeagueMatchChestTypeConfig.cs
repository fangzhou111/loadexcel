using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class LeagueMatchChestTypeData
{
/*主键ID*/
public int ID; 
/*宝箱编号*/
public int ChestID; 
/*宝箱开启价格
（钻/10分钟）*/
public int ChestPrice; 
/*宝箱开启时限*/
public int ChestTime; 
/*宝箱模型*/
public string ChestModel; 
/*宝箱名称*/
public string name; 
/*宝箱描述*/
public string Dec; 
}
public partial class LeagueMatchChestTypeConfig : ConfigBase
{
private static LeagueMatchChestTypeConfig _instance;
public Dictionary<int, LeagueMatchChestTypeData> _datas;
public static LeagueMatchChestTypeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new LeagueMatchChestTypeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("LeagueMatchChestType.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 5;i++)
{
LeagueMatchChestTypeData data = new LeagueMatchChestTypeData();
data.ID = br.ReadInt32();
data.ChestID = br.ReadInt32();
data.ChestPrice = br.ReadInt32();
data.ChestTime = br.ReadInt32();
data.ChestModel = br.ReadString();
data.name = br.ReadString();
data.Dec = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, LeagueMatchChestTypeData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public LeagueMatchChestTypeData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
