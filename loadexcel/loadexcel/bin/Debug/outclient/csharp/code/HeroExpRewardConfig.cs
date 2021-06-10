using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroExpRewardData
{
/*英雄经验奖励分组*/
public int HeroExpOrder; 
/*等级分组*/
public int PlayerLevel; 
/*掉落物品数量*/
public int RewardItemNum; 
}
public partial class HeroExpRewardConfig : ConfigBase
{
private static HeroExpRewardConfig _instance;
public Dictionary<int, Dictionary<int, HeroExpRewardData>> _datas;
public static HeroExpRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroExpRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroExpReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 35;i++)
{
HeroExpRewardData data = new HeroExpRewardData();
data.HeroExpOrder = br.ReadInt32();
data.PlayerLevel = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, HeroExpRewardData>>();
if (!_datas.ContainsKey(data.HeroExpOrder))
{
Dictionary<int, HeroExpRewardData> _dic = new Dictionary<int, HeroExpRewardData>();
_datas.Add(data.HeroExpOrder, _dic);
}
_datas[data.HeroExpOrder].Add(data.PlayerLevel,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, HeroExpRewardData> Get(int newHeroExpOrder)
{
if (_datas.ContainsKey(newHeroExpOrder))
return _datas[newHeroExpOrder];
else
return null;
}
public HeroExpRewardData Get(int newHeroExpOrder,int newPlayerLevel)
{
if (_datas.ContainsKey(newHeroExpOrder) && _datas[newHeroExpOrder].ContainsKey(newPlayerLevel))
return _datas[newHeroExpOrder][newPlayerLevel];
else
return null;
}
}
}
