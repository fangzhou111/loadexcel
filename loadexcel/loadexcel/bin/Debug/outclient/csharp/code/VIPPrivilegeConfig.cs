using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class VIPPrivilegeData
{
/*VIP特权ID*/
public string ID; 
/*VIP特权描述*/
public string Desc; 
/*特权类型
1开启2次数*/
public int PrivilegeType; 
/*免费用户*/
public int VIP0; 
/*VIP1特权*/
public int VIP1; 
/*VIP2特权*/
public int VIP2; 
/*VIP3特权*/
public int VIP3; 
/*VIP4特权*/
public int VIP4; 
/*VIP5特权*/
public int VIP5; 
/*VIP6特权*/
public int VIP6; 
/*VIP7特权*/
public int VIP7; 
/*VIP8特权*/
public int VIP8; 
/*VIP9特权*/
public int VIP9; 
/*VIP10特权*/
public int VIP10; 
/*VIP11特权*/
public int VIP11; 
/*VIP12特权*/
public int VIP12; 
/*VIP13特权*/
public int VIP13; 
/*VIP14特权*/
public int VIP14; 
/*VIP15特权*/
public int VIP15; 
/*VIP16特权*/
public int VIP16; 
}
public partial class VIPPrivilegeConfig : ConfigBase
{
private static VIPPrivilegeConfig _instance;
public Dictionary<string, VIPPrivilegeData> _datas;
public static VIPPrivilegeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new VIPPrivilegeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("VIPPrivilege.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 56;i++)
{
VIPPrivilegeData data = new VIPPrivilegeData();
data.ID = br.ReadString();
data.Desc = br.ReadString();
data.PrivilegeType = br.ReadInt32();
data.VIP0 = br.ReadInt32();
data.VIP1 = br.ReadInt32();
data.VIP2 = br.ReadInt32();
data.VIP3 = br.ReadInt32();
data.VIP4 = br.ReadInt32();
data.VIP5 = br.ReadInt32();
data.VIP6 = br.ReadInt32();
data.VIP7 = br.ReadInt32();
data.VIP8 = br.ReadInt32();
data.VIP9 = br.ReadInt32();
data.VIP10 = br.ReadInt32();
data.VIP11 = br.ReadInt32();
data.VIP12 = br.ReadInt32();
data.VIP13 = br.ReadInt32();
data.VIP14 = br.ReadInt32();
data.VIP15 = br.ReadInt32();
data.VIP16 = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, VIPPrivilegeData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public VIPPrivilegeData Get(string newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
