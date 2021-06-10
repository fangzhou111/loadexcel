using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class randnameData
{
/*唯一ID*/
public int ID; 
/*姓*/
public string firstname; 
/*分隔符*/
public string midname; 
/*名*/
public string lastname; 
}
public partial class randnameConfig : ConfigBase
{
private static randnameConfig _instance;
public Dictionary<int, randnameData> _datas;
public static randnameConfig Instance
{
get
{
if (_instance == null)
{
_instance = new randnameConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("randname.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 150;i++)
{
randnameData data = new randnameData();
data.ID = br.ReadInt32();
data.firstname = br.ReadString();
data.midname = br.ReadString();
data.lastname = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, randnameData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public randnameData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
