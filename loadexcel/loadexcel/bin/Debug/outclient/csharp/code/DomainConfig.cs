using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainData
{
/*地图节点编号*/
public int ID; 
/*据点类型
1普通点2资源点3宝箱*/
public int DomainType; 
/*所属区域*/
public int Area; 
/*初始是否被占领*/
public int IsOccupation; 
}
public partial class DomainConfig : ConfigBase
{
private static DomainConfig _instance;
public Dictionary<int, DomainData> _datas;
public static DomainConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Domain.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 92;i++)
{
DomainData data = new DomainData();
data.ID = br.ReadInt32();
data.DomainType = br.ReadInt32();
data.Area = br.ReadInt32();
data.IsOccupation = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, DomainData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public DomainData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
