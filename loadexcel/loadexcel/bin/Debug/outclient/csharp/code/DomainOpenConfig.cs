using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainOpenData
{
/*区域ID*/
public int AreaID; 
/*开启需要领主等级*/
public int OpenLevel; 
/*消耗金币*/
public int GoldCost; 
/*区配值系数
匹配值=当前活跃度*匹配系数/100*/
public float MatchRatio; 
}
public partial class DomainOpenConfig : ConfigBase
{
private static DomainOpenConfig _instance;
public Dictionary<int, DomainOpenData> _datas;
public static DomainOpenConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainOpenConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainOpen.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
DomainOpenData data = new DomainOpenData();
data.AreaID = br.ReadInt32();
data.OpenLevel = br.ReadInt32();
data.GoldCost = br.ReadInt32();
data.MatchRatio = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<int, DomainOpenData>();
_datas.Add(data.AreaID,data);
}
br.Close();
fs.Close();
}
public DomainOpenData Get(int newAreaID)
{
if (_datas.ContainsKey(newAreaID))
return _datas[newAreaID];
else
return null;
}
}
}
