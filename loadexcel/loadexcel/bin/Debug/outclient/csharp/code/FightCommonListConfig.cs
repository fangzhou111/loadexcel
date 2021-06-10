using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FightCommonListData
{
/*ee*/
public int ID; 
/*ee*/
public string Name; 
}
public partial class FightCommonListConfig : ConfigBase
{
private static FightCommonListConfig _instance;
public Dictionary<int, FightCommonListData> _datas;
public static FightCommonListConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FightCommonListConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FightCommonList.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 27;i++)
{
FightCommonListData data = new FightCommonListData();
data.ID = br.ReadInt32();
data.Name = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, FightCommonListData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public FightCommonListData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
