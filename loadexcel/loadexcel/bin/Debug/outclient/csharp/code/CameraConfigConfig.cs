using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CameraConfigData
{
/*唯一标示*/
public int ID; 
/*名字描述*/
public string Name; 
/*镜头高度*/
public int Hight; 
/*镜头纵向百分比位置*/
public int Percent; 
/*镜头角度*/
public int Angle; 
/*镜头旋转*/
public int Rotate; 
}
public partial class CameraConfigConfig : ConfigBase
{
private static CameraConfigConfig _instance;
public Dictionary<int, CameraConfigData> _datas;
public static CameraConfigConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CameraConfigConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CameraConfig.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 483;i++)
{
CameraConfigData data = new CameraConfigData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
data.Hight = br.ReadInt32();
data.Percent = br.ReadInt32();
data.Angle = br.ReadInt32();
data.Rotate = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, CameraConfigData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public CameraConfigData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
