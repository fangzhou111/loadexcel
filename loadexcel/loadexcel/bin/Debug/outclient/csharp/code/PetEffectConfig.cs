using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PetEffectData
{
/*宠物ID*/
public int PetID; 
/*激活需要的等级*/
public int EffectNeedStar; 
/*升星激活效果*/
public int EffectNum; 
/*效果图标*/
public string Icon; 
/*增加怒气*/
public int Anger; 
/*触发器*/
public string trrigers; 
}
public partial class PetEffectConfig : ConfigBase
{
private static PetEffectConfig _instance;
public Dictionary<int, Dictionary<int, PetEffectData>> _datas;
public static PetEffectConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PetEffectConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PetEffect.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 63;i++)
{
PetEffectData data = new PetEffectData();
data.PetID = br.ReadInt32();
data.EffectNeedStar = br.ReadInt32();
data.EffectNum = br.ReadInt32();
data.Icon = br.ReadString();
data.Anger = br.ReadInt32();
data.trrigers = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, PetEffectData>>();
if (!_datas.ContainsKey(data.PetID))
{
Dictionary<int, PetEffectData> _dic = new Dictionary<int, PetEffectData>();
_datas.Add(data.PetID, _dic);
}
_datas[data.PetID].Add(data.EffectNeedStar,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, PetEffectData> Get(int newPetID)
{
if (_datas.ContainsKey(newPetID))
return _datas[newPetID];
else
return null;
}
public PetEffectData Get(int newPetID,int newEffectNeedStar)
{
if (_datas.ContainsKey(newPetID) && _datas[newPetID].ContainsKey(newEffectNeedStar))
return _datas[newPetID][newEffectNeedStar];
else
return null;
}
}
}
