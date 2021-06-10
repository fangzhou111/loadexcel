using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BeginRankNoticeData
{
/*编号*/
public int id; 
/*小跑马灯描述*/
public string desc; 
}
public partial class BeginRankNoticeConfig : ConfigBase
{
private static BeginRankNoticeConfig _instance;
public Dictionary<int, BeginRankNoticeData> _datas;
public static BeginRankNoticeConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BeginRankNoticeConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BeginRankNotice.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
BeginRankNoticeData data = new BeginRankNoticeData();
data.id = br.ReadInt32();
data.desc = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, BeginRankNoticeData>();
_datas.Add(data.id,data);
}
br.Close();
fs.Close();
}
public BeginRankNoticeData Get(int newid)
{
if (_datas.ContainsKey(newid))
return _datas[newid];
else
return null;
}
}
}
