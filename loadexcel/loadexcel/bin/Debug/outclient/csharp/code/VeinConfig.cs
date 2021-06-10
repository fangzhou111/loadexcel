using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class VeinData
{
/*矿点索引*/
public int PitID; 
/*矿图*/
public int Vein; 
/*矿图数量*/
public int VeinNum; 
/*矿点等级*/
public int PitLevel; 
/*矿点数量*/
public int PitNum; 
/*矿点累积资源*/
public int PitResources; 
/*资源累积时间（秒）*/
public int PitTime; 
/*矿图名称*/
public string VeinName; 
}
public partial class VeinConfig : ConfigBase
{
private static VeinConfig _instance;
public Dictionary<int, VeinData> _datas;
public static VeinConfig Instance
{
get
{
if (_instance == null)
{
_instance = new VeinConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Vein.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
VeinData data = new VeinData();
data.PitID = br.ReadInt32();
data.Vein = br.ReadInt32();
data.VeinNum = br.ReadInt32();
data.PitLevel = br.ReadInt32();
data.PitNum = br.ReadInt32();
data.PitResources = br.ReadInt32();
data.PitTime = br.ReadInt32();
data.VeinName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, VeinData>();
_datas.Add(data.PitID,data);
}
br.Close();
fs.Close();
}
public VeinData Get(int newPitID)
{
if (_datas.ContainsKey(newPitID))
return _datas[newPitID];
else
return null;
}
}
}
