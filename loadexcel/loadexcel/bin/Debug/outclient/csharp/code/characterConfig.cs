using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class characterData
{
/*ID*/
public int id; 
/*模型*/
public string model; 
/*职业*/
public int job; 
/*攻击*/
public float atk; 
/*防御*/
public float def; 
/*血量*/
public float hp; 
/*减员底线*/
public float minuspecent; 
/*军团士兵数*/
public int sodnum; 
/*攻击距离*/
public float atkdis; 
/*攻击间隔*/
public float atkinterval; 
/*移动速度*/
public float speed; 
/*3D模型名称*/
public string childmodelname; 
/*主动技能(#分割)*/
public string skillnames; 
/*默认平A*/
public string atkname; 
}
public partial class characterConfig : ConfigBase
{
private static characterConfig _instance;
public Dictionary<int, characterData> _datas;
public static characterConfig Instance
{
get
{
if (_instance == null)
{
_instance = new characterConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("character.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 7;i++)
{
characterData data = new characterData();
data.id = br.ReadInt32();
data.model = br.ReadString();
data.job = br.ReadInt32();
data.atk = (float)br.ReadDouble();
data.def = (float)br.ReadDouble();
data.hp = (float)br.ReadDouble();
data.minuspecent = (float)br.ReadDouble();
data.sodnum = br.ReadInt32();
data.atkdis = (float)br.ReadDouble();
data.atkinterval = (float)br.ReadDouble();
data.speed = (float)br.ReadDouble();
data.childmodelname = br.ReadString();
data.skillnames = br.ReadString();
data.atkname = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, characterData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public characterData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
