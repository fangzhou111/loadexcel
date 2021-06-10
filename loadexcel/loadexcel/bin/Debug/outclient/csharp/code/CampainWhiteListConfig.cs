using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class CampainWhiteListData
{
/*关卡白名单ID*/
public int CampainID; 
/*表演关卡*/
public int ShowCampain; 
}
public partial class CampainWhiteListConfig : ConfigBase
{
private static CampainWhiteListConfig _instance;
public Dictionary<int, CampainWhiteListData> _datas;
public static CampainWhiteListConfig Instance
{
get
{
if (_instance == null)
{
_instance = new CampainWhiteListConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("CampainWhiteList.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 7;i++)
{
CampainWhiteListData data = new CampainWhiteListData();
data.CampainID = br.ReadInt32();
data.ShowCampain = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, CampainWhiteListData>();
_datas.Add(data.ShowCampain,data);
}
br.Close();
fs.Close();
}
public CampainWhiteListData Get(int newShowCampain)
{
if (_datas.ContainsKey(newShowCampain))
return _datas[newShowCampain];
else
return null;
}
}
}
