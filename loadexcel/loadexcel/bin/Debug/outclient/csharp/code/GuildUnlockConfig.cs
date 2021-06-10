using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuildUnlockData
{
/*公会等级*/
public int GuildLevel; 
/*我要伊利丹*/
public int GuildTechnology1; 
/*公会副本*/
public int GuildTechnology2; 
/*怪物消消乐*/
public int GuildTechnology3; 
/*公会商店*/
public int GuildTechnology4; 
/*公会熔炉*/
public int GuildTechnology5; 
/*公会领地*/
public int GuildTechnology6; 
}
public partial class GuildUnlockConfig : ConfigBase
{
private static GuildUnlockConfig _instance;
public Dictionary<int, GuildUnlockData> _datas;
public static GuildUnlockConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuildUnlockConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GuildUnlock.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
GuildUnlockData data = new GuildUnlockData();
data.GuildLevel = br.ReadInt32();
data.GuildTechnology1 = br.ReadInt32();
data.GuildTechnology2 = br.ReadInt32();
data.GuildTechnology3 = br.ReadInt32();
data.GuildTechnology4 = br.ReadInt32();
data.GuildTechnology5 = br.ReadInt32();
data.GuildTechnology6 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GuildUnlockData>();
_datas.Add(data.GuildLevel,data);
}
br.Close();
fs.Close();
}
public GuildUnlockData Get(int newGuildLevel)
{
if (_datas.ContainsKey(newGuildLevel))
return _datas[newGuildLevel];
else
return null;
}
}
}
