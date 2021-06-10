using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GlyphsBaseData
{
/*雕文编号*/
public int ID; 
/*名称*/
public string Name; 
/*图标*/
public int icon; 
/*类型*/
public int Type; 
/*星级*/
public int Star; 
/*品质*/
public int Quality; 
/*产出经验*/
public int OfferExp; 
}
public partial class GlyphsBaseConfig : ConfigBase
{
private static GlyphsBaseConfig _instance;
public Dictionary<int, GlyphsBaseData> _datas;
public static GlyphsBaseConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GlyphsBaseConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GlyphsBase.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 45;i++)
{
GlyphsBaseData data = new GlyphsBaseData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.icon = br.ReadInt32();
data.Type = br.ReadInt32();
data.Star = br.ReadInt32();
data.Quality = br.ReadInt32();
data.OfferExp = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GlyphsBaseData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public GlyphsBaseData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
