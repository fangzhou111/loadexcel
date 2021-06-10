using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GlyphsComposeData
{
/*雕文*/
public int GlyphsID; 
/*碎片ID*/
public int ItemID; 
/*合成所需数量*/
public int Count; 
}
public partial class GlyphsComposeConfig : ConfigBase
{
private static GlyphsComposeConfig _instance;
public Dictionary<int, GlyphsComposeData> _datas;
public static GlyphsComposeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GlyphsComposeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GlyphsCompose.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 44;i++)
{
GlyphsComposeData data = new GlyphsComposeData();
data.GlyphsID = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.Count = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GlyphsComposeData>();
_datas.Add(data.ItemID,data);
}
br.Close();
fs.Close();
}
public GlyphsComposeData Get(int newItemID)
{
if (_datas.ContainsKey(newItemID))
return _datas[newItemID];
else
return null;
}
}
}
