using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BossChallengeDamageGrowData
{
/*奖励序号*/
public int ID; 
/*伤害要求系数*/
public double DamageRatio; 
/*奖励类型*/
public int Type; 
/*其他道具奖励ID*/
public int ItemID; 
/*道具数量*/
public double Number; 
}
public partial class BossChallengeDamageGrowConfig : ConfigBase
{
private static BossChallengeDamageGrowConfig _instance;
public Dictionary<int, BossChallengeDamageGrowData> _datas;
public static BossChallengeDamageGrowConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BossChallengeDamageGrowConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BossChallengeDamageGrow.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 40;i++)
{
BossChallengeDamageGrowData data = new BossChallengeDamageGrowData();
data.ID = br.ReadInt32();
data.DamageRatio = (float)br.ReadDouble();
data.Type = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.Number = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, BossChallengeDamageGrowData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public BossChallengeDamageGrowData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
