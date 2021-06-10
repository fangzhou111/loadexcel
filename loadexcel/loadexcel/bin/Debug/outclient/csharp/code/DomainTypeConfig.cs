using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainTypeData
{
/*主键编号*/
public int ID; 
/*据点类型*/
public int DomainType; 
/*占领状态*/
public int OccupationType; 
/*可占领时长*/
public int OccupationTime ; 
/*刷新间隔(秒）*/
public int ResetTime; 
/*被占最大比例*/
public int EnemyRatio; 
/*占领奖励*/
public int Reward; 
}
public partial class DomainTypeConfig : ConfigBase
{
private static DomainTypeConfig _instance;
public Dictionary<int, DomainTypeData> _datas;
public static DomainTypeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainTypeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainType.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
DomainTypeData data = new DomainTypeData();
data.ID = br.ReadInt32();
data.DomainType = br.ReadInt32();
data.OccupationType = br.ReadInt32();
data.OccupationTime  = br.ReadInt32();
data.ResetTime = br.ReadInt32();
data.EnemyRatio = br.ReadInt32();
data.Reward = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, DomainTypeData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public DomainTypeData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
