using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DialogueData
{
/*对白ID*/
public int ID; 
/*对白顺序*/
public int index; 
/*对白模型*/
public string Model; 
/*对白名称
填1代表主角名称*/
public string Name; 
/*显示左右
1左2右*/
public int Side; 
/*对白内容*/
public string Dialogue; 
}
public partial class DialogueConfig : ConfigBase
{
private static DialogueConfig _instance;
public Dictionary<int, Dictionary<int, DialogueData>> _datas;
public static DialogueConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DialogueConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Dialogue.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 448;i++)
{
DialogueData data = new DialogueData();
data.ID = br.ReadInt32();
data.index = br.ReadInt32();
data.Model = br.ReadString();
data.Name = br.ReadString();
data.Side = br.ReadInt32();
data.Dialogue = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, DialogueData>>();
if (!_datas.ContainsKey(data.ID))
{
Dictionary<int, DialogueData> _dic = new Dictionary<int, DialogueData>();
_datas.Add(data.ID, _dic);
}
_datas[data.ID].Add(data.index,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, DialogueData> Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
public DialogueData Get(int newID,int newindex)
{
if (_datas.ContainsKey(newID) && _datas[newID].ContainsKey(newindex))
return _datas[newID][newindex];
else
return null;
}
}
}
