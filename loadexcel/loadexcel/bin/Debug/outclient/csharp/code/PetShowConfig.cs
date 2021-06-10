using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PetShowData
{
/*显示顺序*/
public int ID; 
/*宠物ID*/
public int PetID; 
/*名称*/
public string Name; 
/*图鉴里的大小*/
public int ChartShow; 
/*场景里的大小*/
public int SceneShow; 
}
public partial class PetShowConfig : ConfigBase
{
private static PetShowConfig _instance;
public Dictionary<int, PetShowData> _datas;
public static PetShowConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PetShowConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PetShow.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 17;i++)
{
PetShowData data = new PetShowData();
data.ID = br.ReadInt32();
data.PetID = br.ReadInt32();
data.Name = br.ReadString();
data.ChartShow = br.ReadInt32();
data.SceneShow = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, PetShowData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public PetShowData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
