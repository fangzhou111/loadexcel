using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GuideDesData
{
/*功能*/
public int Function; 
/*功能值*/
public int Value; 
/*描述*/
public string Des; 
/*功能名*/
public string FunctionName; 
}
public partial class GuideDesConfig : ConfigBase
{
private static GuideDesConfig _instance;
public Dictionary<int, Dictionary<int, GuideDesData>> _datas;
public static GuideDesConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GuideDesConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GuideDes.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 47;i++)
{
GuideDesData data = new GuideDesData();
data.Function = br.ReadInt32();
data.Value = br.ReadInt32();
data.Des = br.ReadString();
data.FunctionName = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, GuideDesData>>();
if (!_datas.ContainsKey(data.Function))
{
Dictionary<int, GuideDesData> _dic = new Dictionary<int, GuideDesData>();
_datas.Add(data.Function, _dic);
}
_datas[data.Function].Add(data.Value,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, GuideDesData> Get(int newFunction)
{
if (_datas.ContainsKey(newFunction))
return _datas[newFunction];
else
return null;
}
public GuideDesData Get(int newFunction,int newValue)
{
if (_datas.ContainsKey(newFunction) && _datas[newFunction].ContainsKey(newValue))
return _datas[newFunction][newValue];
else
return null;
}
}
}
