using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernHeroBlessingData
{
/*主键编号*/
public int ID; 
/*召唤类型
1高级召唤
101~103对应传奇召唤热点英雄*/
public int Type; 
/*奖励分组*/
public int Order; 
/*需要积分*/
public int NeedBlessing; 
/*英雄或英雄碎片编号*/
public int HeroPieceID; 
/*数量*/
public int Num; 
}
public partial class TavernHeroBlessingConfig : ConfigBase
{
private static TavernHeroBlessingConfig _instance;
public Dictionary<int, TavernHeroBlessingData> _datas;
public static TavernHeroBlessingConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TavernHeroBlessingConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TavernHeroBlessing.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 55;i++)
{
TavernHeroBlessingData data = new TavernHeroBlessingData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Order = br.ReadInt32();
data.NeedBlessing = br.ReadInt32();
data.HeroPieceID = br.ReadInt32();
data.Num = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TavernHeroBlessingData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TavernHeroBlessingData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
