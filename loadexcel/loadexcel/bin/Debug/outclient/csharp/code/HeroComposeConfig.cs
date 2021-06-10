using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class HeroComposeData
{
/*英雄ID*/
public int HeroID; 
/*英雄碎片ID*/
public int ItemID; 
/*合成所需数量*/
public int Count; 
/*是否需要显示*/
public int ShowHero; 
/*要塞兑换所需友好度*/
public int FortressFriendPoint; 
}
public partial class HeroComposeConfig : ConfigBase
{
private static HeroComposeConfig _instance;
public Dictionary<int, HeroComposeData> _datas;
public static HeroComposeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new HeroComposeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("HeroCompose.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 106;i++)
{
HeroComposeData data = new HeroComposeData();
data.HeroID = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.Count = br.ReadInt32();
data.ShowHero = br.ReadInt32();
data.FortressFriendPoint = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, HeroComposeData>();
_datas.Add(data.HeroID,data);
}
br.Close();
fs.Close();
}
public HeroComposeData Get(int newHeroID)
{
if (_datas.ContainsKey(newHeroID))
return _datas[newHeroID];
else
return null;
}
}
}
