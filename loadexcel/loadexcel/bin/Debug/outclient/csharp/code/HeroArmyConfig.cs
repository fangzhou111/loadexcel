using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroArmyData
{
/*英雄ID*/
public int ID; 
/*推荐阵容英雄1*/
public int ID1; 
/*推荐阵容英雄2*/
public int ID2; 
/*推荐阵容英雄3*/
public int ID3; 
/*推荐阵容英雄4*/
public int ID4; 
/*推荐阵容英雄5*/
public int ID5; 
}
public partial class HeroArmyConfig : ConfigBase
{
private static HeroArmyConfig _instance;
public Dictionary<int, HeroArmyData> _datas;
public static HeroArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
HeroArmyData data = new HeroArmyData();
data.ID = br.ReadInt32();
data.ID1 = br.ReadInt32();
data.ID2 = br.ReadInt32();
data.ID3 = br.ReadInt32();
data.ID4 = br.ReadInt32();
data.ID5 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, HeroArmyData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public HeroArmyData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
