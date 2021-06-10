using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuildData
{
/*等级*/
public int GuildLevel; 
/*需要经验值*/
public int GuildExp; 
/*普通建设消耗金币*/
public int Money; 
/*普通建设增加公会经验*/
public int MoneyExp; 
/*普通建设获得贡献*/
public int MoneyContribution; 
/*普通建设增加进度*/
public int MoneyProgress; 
/*中级建设消耗钻石*/
public int Gold; 
/*中级建设公会经验*/
public int GoldExp; 
/*中级建设个人贡献*/
public int GoldContribution; 
/*中级建设进度*/
public int GoldProgress; 
/*高级建设消耗钻石*/
public int Diamond; 
/*高级建设公会经验*/
public int DiamondEXP; 
/*高级建设个人贡献*/
public int DiamondContribution; 
/*高级建设增加进度*/
public int DiamondProgress; 
/*公会成员上限*/
public int GuildPlayer; 
/*公会官员上限*/
public int GuildLeader; 
/*公会捐献次数*/
public int GuildBuild; 
}
public partial class GuildConfig : ConfigBase
{
private static GuildConfig _instance;
public Dictionary<int, GuildData> _datas;
public static GuildConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuildConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Guild.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 10;i++)
{
GuildData data = new GuildData();
data.GuildLevel = br.ReadInt32();
data.GuildExp = br.ReadInt32();
data.Money = br.ReadInt32();
data.MoneyExp = br.ReadInt32();
data.MoneyContribution = br.ReadInt32();
data.MoneyProgress = br.ReadInt32();
data.Gold = br.ReadInt32();
data.GoldExp = br.ReadInt32();
data.GoldContribution = br.ReadInt32();
data.GoldProgress = br.ReadInt32();
data.Diamond = br.ReadInt32();
data.DiamondEXP = br.ReadInt32();
data.DiamondContribution = br.ReadInt32();
data.DiamondProgress = br.ReadInt32();
data.GuildPlayer = br.ReadInt32();
data.GuildLeader = br.ReadInt32();
data.GuildBuild = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GuildData>();
_datas.Add(data.GuildLevel,data);
}
br.Close();
fs.Close();
}
public GuildData Get(int newGuildLevel)
{
if (_datas.ContainsKey(newGuildLevel))
return _datas[newGuildLevel];
else
return null;
}
}
}
