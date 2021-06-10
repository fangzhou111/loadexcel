using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class NPCBaseData
{
/*NPC编号*/
public int ID; 
/*类型*/
public int  Type; 
/*名称*/
public string name; 
/*称号*/
public string Title; 
/*名字高度*/
public int nameHeigth; 
/*不带颜色名字*/
public string defaultName; 
/*角度*/
public int Angle; 
/*体型大小*/
public int Shape; 
/*模型*/
public string model; 
/*默认对白*/
public string Dialogue; 
/*对话语音*/
public string Audio; 
}
public partial class NPCBaseConfig : ConfigBase
{
private static NPCBaseConfig _instance;
public Dictionary<int, NPCBaseData> _datas;
public static NPCBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new NPCBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("NPCBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 15;i++)
{
NPCBaseData data = new NPCBaseData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.name = br.ReadString();
data.Title = br.ReadString();
data.nameHeigth = br.ReadInt32();
data.defaultName = br.ReadString();
data.Angle = br.ReadInt32();
data.Shape = br.ReadInt32();
data.model = br.ReadString();
data.Dialogue = br.ReadString();
data.Audio = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, NPCBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public NPCBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
