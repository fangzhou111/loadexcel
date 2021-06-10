using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SVIPConfigData
{
/*服务器ID*/
public int real_server_id; 
/*限制开服时间，单位：天*/
public int time_limit; 
/*累计金额，单位：元*/
public int rmb_amount; 
/*GM客服名称*/
public string gm_name; 
/*GM客服联系方式*/
public string gm_contact; 
/*GM客服照片*/
public string gm_photo; 
/*是否开启*/
public int enable; 
}
public partial class SVIPConfigConfig : ConfigBase
{
private static SVIPConfigConfig _instance;
public Dictionary<int, SVIPConfigData> _datas;
public static SVIPConfigConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SVIPConfigConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SVIPConfig.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1;i++)
{
SVIPConfigData data = new SVIPConfigData();
data.real_server_id = br.ReadInt32();
data.time_limit = br.ReadInt32();
data.rmb_amount = br.ReadInt32();
data.gm_name = br.ReadString();
data.gm_contact = br.ReadString();
data.gm_photo = br.ReadString();
data.enable = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, SVIPConfigData>();
_datas.Add(data.real_server_id,data);
}
br.Close();
fs.Close();
}
public SVIPConfigData Get(int newreal_server_id)
{
if (_datas.ContainsKey(newreal_server_id))
return _datas[newreal_server_id];
else
return null;
}
}
}
