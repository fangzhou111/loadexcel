using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ArtifactCostData
{
/*神器等级*/
public int ArtifactLv; 
/*消耗神器能量*/
public int EnergyCost; 
}
public partial class ArtifactCostConfig : ConfigBase
{
private static ArtifactCostConfig _instance;
public Dictionary<int, ArtifactCostData> _datas;
public static ArtifactCostConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ArtifactCostConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ArtifactCost.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 45;i++)
{
ArtifactCostData data = new ArtifactCostData();
data.ArtifactLv = br.ReadInt32();
data.EnergyCost = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ArtifactCostData>();
_datas.Add(data.ArtifactLv,data);
}
br.Close();
fs.Close();
}
public ArtifactCostData Get(int newArtifactLv)
{
if (_datas.ContainsKey(newArtifactLv))
return _datas[newArtifactLv];
else
return null;
}
}
}
