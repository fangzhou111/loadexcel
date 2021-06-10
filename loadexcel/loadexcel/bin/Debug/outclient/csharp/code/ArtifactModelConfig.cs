using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ArtifactModelData
{
/*神器类型（1.坦克2.近战3.远程4.治疗）*/
public int ArtifactType; 
/*神器模型名*/
public string ArtifactName; 
}
public partial class ArtifactModelConfig : ConfigBase
{
private static ArtifactModelConfig _instance;
public Dictionary<int, ArtifactModelData> _datas;
public static ArtifactModelConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ArtifactModelConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ArtifactModel.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
ArtifactModelData data = new ArtifactModelData();
data.ArtifactType = br.ReadInt32();
data.ArtifactName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, ArtifactModelData>();
_datas.Add(data.ArtifactType,data);
}
br.Close();
fs.Close();
}
public ArtifactModelData Get(int newArtifactType)
{
if (_datas.ContainsKey(newArtifactType))
return _datas[newArtifactType];
else
return null;
}
}
}
