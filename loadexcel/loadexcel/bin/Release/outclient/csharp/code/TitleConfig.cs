using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TitleData
{
/*主键ID*/
public int TitleID; 
/*称号名*/
public string TitleName; 
/*称号描述*/
public string Desc; 
/*称号图标*/
public string Icon; 
/*称号优先级*/
public int Priority; 
}
public partial class TitleConfig : ConfigBase
{
private static TitleConfig _instance;
public Dictionary<int, TitleData> _datas;
public static TitleConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TitleConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Title.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
TitleData data = new TitleData();
data.TitleID = br.ReadInt32();
data.TitleName = br.ReadString();
data.Desc = br.ReadString();
data.Icon = br.ReadString();
data.Priority = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TitleData>();
_datas.Add(data.TitleID,data);
}
br.Close();
fs.Close();
}
public TitleData Get(int newTitleID)
{
if (_datas.ContainsKey(newTitleID))
return _datas[newTitleID];
else
return null;
}
public override void Dispose()
{
_datas = null;
base.Dispose();
}
}
}
