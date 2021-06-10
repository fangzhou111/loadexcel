using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class VIPDescData
{
/*特权编号*/
public int ID; 
/*VIP0特权*/
public string VIP0; 
/*VIP1特权*/
public string VIP1; 
/*VIP2特权*/
public string VIP2; 
/*VIP3特权*/
public string VIP3; 
/*VIP4特权*/
public string VIP4; 
/*VIP5特权*/
public string VIP5; 
/*VIP6特权*/
public string VIP6; 
/*VIP7特权*/
public string VIP7; 
/*VIP8特权*/
public string VIP8; 
/*VIP9特权*/
public string VIP9; 
/*VIP10特权*/
public string VIP10; 
/*VIP11特权*/
public string VIP11; 
/*VIP12特权*/
public string VIP12; 
/*VIP13特权*/
public string VIP13; 
/*VIP14特权*/
public string VIP14; 
/*VIP15特权*/
public string VIP15; 
/*VIP16特权*/
public string VIP16; 
}
public partial class VIPDescConfig : ConfigBase
{
private static VIPDescConfig _instance;
public Dictionary<int, VIPDescData> _datas;
public static VIPDescConfig Instance
{
get
{
if (_instance == null)
{
_instance = new VIPDescConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("VIPDesc.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 21;i++)
{
VIPDescData data = new VIPDescData();
data.ID = br.ReadInt32();
data.VIP0 = br.ReadString();
data.VIP1 = br.ReadString();
data.VIP2 = br.ReadString();
data.VIP3 = br.ReadString();
data.VIP4 = br.ReadString();
data.VIP5 = br.ReadString();
data.VIP6 = br.ReadString();
data.VIP7 = br.ReadString();
data.VIP8 = br.ReadString();
data.VIP9 = br.ReadString();
data.VIP10 = br.ReadString();
data.VIP11 = br.ReadString();
data.VIP12 = br.ReadString();
data.VIP13 = br.ReadString();
data.VIP14 = br.ReadString();
data.VIP15 = br.ReadString();
data.VIP16 = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, VIPDescData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public VIPDescData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
