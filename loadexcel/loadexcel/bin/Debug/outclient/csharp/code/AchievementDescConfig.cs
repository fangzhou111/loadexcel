using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class AchievementDescData
{
/*描述ID*/
public int ID; 
/*描述内容*/
public string Desc; 
}
public partial class AchievementDescConfig : ConfigBase
{
private static AchievementDescConfig _instance;
public Dictionary<int, AchievementDescData> _datas;
public static AchievementDescConfig Instance
{
get
{
if (_instance == null)
{
_instance = new AchievementDescConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("AchievementDesc.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 14;i++)
{
AchievementDescData data = new AchievementDescData();
data.ID = br.ReadInt32();
data.Desc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, AchievementDescData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public AchievementDescData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
