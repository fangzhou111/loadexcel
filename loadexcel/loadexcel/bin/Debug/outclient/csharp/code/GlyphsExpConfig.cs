using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GlyphsExpData
{
/*等级*/
public int Level; 
/*星级*/
public int Star; 
/*本级需要经验*/
public int NeedExp; 
}
public partial class GlyphsExpConfig : ConfigBase
{
private static GlyphsExpConfig _instance;
public Dictionary<int, Dictionary<int, GlyphsExpData>> _datas;
public static GlyphsExpConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GlyphsExpConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GlyphsExp.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 120;i++)
{
GlyphsExpData data = new GlyphsExpData();
data.Level = br.ReadInt32();
data.Star = br.ReadInt32();
data.NeedExp = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, GlyphsExpData>>();
if (!_datas.ContainsKey(data.Level))
{
Dictionary<int, GlyphsExpData> _dic = new Dictionary<int, GlyphsExpData>();
_datas.Add(data.Level, _dic);
}
_datas[data.Level].Add(data.Star,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, GlyphsExpData> Get(int newLevel)
{
if (_datas.ContainsKey(newLevel))
return _datas[newLevel];
else
return null;
}
public GlyphsExpData Get(int newLevel,int newStar)
{
if (_datas.ContainsKey(newLevel) && _datas[newLevel].ContainsKey(newStar))
return _datas[newLevel][newStar];
else
return null;
}
}
}
