using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FrameShopData
{
/*头像框ID*/
public int FrameID; 
/*类型*/
public int Type; 
/*类型值*/
public int Value; 
/*头像框资源ID*/
public int ICONID; 
/*头像框名字*/
public string FrameName; 
/*头像框描述*/
public string FrameDesc; 
}
public partial class FrameShopConfig : ConfigBase
{
private static FrameShopConfig _instance;
public Dictionary<int, FrameShopData> _datas;
public static FrameShopConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FrameShopConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FrameShop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
FrameShopData data = new FrameShopData();
data.FrameID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Value = br.ReadInt32();
data.ICONID = br.ReadInt32();
data.FrameName = br.ReadString();
data.FrameDesc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, FrameShopData>();
_datas.Add(data.FrameID,data);
}
br.Close();
fs.Close();
}
public FrameShopData Get(int newFrameID)
{
if (_datas.ContainsKey(newFrameID))
return _datas[newFrameID];
else
return null;
}
}
}
