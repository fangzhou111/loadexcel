using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GrowthFundData
{
/*主键*/
public int ID; 
/*等级*/
public int level; 
/*奖励ID*/
public int item_id; 
/*奖励数量*/
public int item_num; 
/*价值对比*/
public int rmb; 
/*图标*/
public string icon; 
}
public partial class GrowthFundConfig : ConfigBase
{
private static GrowthFundConfig _instance;
public Dictionary<int, GrowthFundData> _datas;
public static GrowthFundConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GrowthFundConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GrowthFund.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 9;i++)
{
GrowthFundData data = new GrowthFundData();
data.ID = br.ReadInt32();
data.level = br.ReadInt32();
data.item_id = br.ReadInt32();
data.item_num = br.ReadInt32();
data.rmb = br.ReadInt32();
data.icon = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, GrowthFundData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public GrowthFundData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
