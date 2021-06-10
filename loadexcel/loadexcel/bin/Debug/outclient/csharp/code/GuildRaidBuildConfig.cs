using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuildRaidBuildData
{
/*公会等级*/
public int RaidLevel; 
/*升级所需经验*/
public int RaidNeedEXP; 
/*开启副本章节*/
public string RaidOpen; 
/*挑战次数*/
public int RaidFight; 
/*重置次数*/
public int RaidNum; 
/*捐献金币*/
public int Money; 
/*捐献金币可获经验*/
public int MoneyExp; 
/*捐金币功勋*/
public int MoneyContribution; 
/*捐献钻石*/
public int Gold; 
/*捐献钻石可获经验*/
public int GoldExp; 
/*捐钻石功勋*/
public int GoldContribution; 
}
public partial class GuildRaidBuildConfig : ConfigBase
{
private static GuildRaidBuildConfig _instance;
public Dictionary<int, GuildRaidBuildData> _datas;
public static GuildRaidBuildConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuildRaidBuildConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GuildRaidBuild.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
GuildRaidBuildData data = new GuildRaidBuildData();
data.RaidLevel = br.ReadInt32();
data.RaidNeedEXP = br.ReadInt32();
data.RaidOpen = br.ReadString();
data.RaidFight = br.ReadInt32();
data.RaidNum = br.ReadInt32();
data.Money = br.ReadInt32();
data.MoneyExp = br.ReadInt32();
data.MoneyContribution = br.ReadInt32();
data.Gold = br.ReadInt32();
data.GoldExp = br.ReadInt32();
data.GoldContribution = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GuildRaidBuildData>();
_datas.Add(data.RaidLevel,data);
}
br.Close();
fs.Close();
}
public GuildRaidBuildData Get(int newRaidLevel)
{
if (_datas.ContainsKey(newRaidLevel))
return _datas[newRaidLevel];
else
return null;
}
}
}
