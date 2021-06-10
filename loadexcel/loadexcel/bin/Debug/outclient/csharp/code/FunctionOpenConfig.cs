using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FunctionOpenData
{
/*编号*/
public int ID; 
/*功能类型*/
public int FunctionType; 
/*开放条件类型*/
public int OpenType; 
/*条件参数*/
public int OpenLevel; 
/*等级描述*/
public string LevelDescription; 
/*预告图片名称*/
public string ReviewName; 
/*预告描述*/
public string ReviewDes; 
/*显否显示预告*/
public int isShow; 
/*功能说明*/
public string Des; 
}
public partial class FunctionOpenConfig : ConfigBase
{
private static FunctionOpenConfig _instance;
public Dictionary<int, FunctionOpenData> _datas;
public static FunctionOpenConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FunctionOpenConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FunctionOpen.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 88;i++)
{
FunctionOpenData data = new FunctionOpenData();
data.ID = br.ReadInt32();
data.FunctionType = br.ReadInt32();
data.OpenType = br.ReadInt32();
data.OpenLevel = br.ReadInt32();
data.LevelDescription = br.ReadString();
data.ReviewName = br.ReadString();
data.ReviewDes = br.ReadString();
data.isShow = br.ReadInt32();
data.Des = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, FunctionOpenData>();
_datas.Add(data.FunctionType,data);
}
br.Close();
fs.Close();
}
public FunctionOpenData Get(int newFunctionType)
{
if (_datas.ContainsKey(newFunctionType))
return _datas[newFunctionType];
else
return null;
}
}
}
