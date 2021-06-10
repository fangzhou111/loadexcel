using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class WaresData
{
/*商品排序*/
public int index; 
/*商品ID*/
public int ID; 
/*名称*/
public string name; 
/*描述*/
public string description; 
/*图标*/
public string icon; 
/*价值钻石*/
public int gold; 
/*赠送额外钻石*/
public int gold_ex; 
/*首充额外奖励*/
public int gold_first; 
/*购买所需人民币，单位（元）*/
public int rmb; 
/*商品类型：
1为普通商品，2为月卡，3为成长基金*/
public int wares_type; 
/*月卡持续时间*/
public int month_card_days; 
/*月卡每次返还金额*/
public int month_card_gold; 
/*vip经验*/
public int vip_exp; 
/*商品SDK描述*/
public string sdk_des; 
/*联想平台商品ID*/
public string lenovo_id; 
/*苹果ID*/
public string apple_id; 
}
public partial class WaresConfig : ConfigBase
{
private static WaresConfig _instance;
public Dictionary<int, WaresData> _datas;
public static WaresConfig Instance
{
get
{
if (_instance == null)
{
_instance = new WaresConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Wares.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
WaresData data = new WaresData();
data.index = br.ReadInt32();
data.ID = br.ReadInt32();
data.name = br.ReadString();
data.description = br.ReadString();
data.icon = br.ReadString();
data.gold = br.ReadInt32();
data.gold_ex = br.ReadInt32();
data.gold_first = br.ReadInt32();
data.rmb = br.ReadInt32();
data.wares_type = br.ReadInt32();
data.month_card_days = br.ReadInt32();
data.month_card_gold = br.ReadInt32();
data.vip_exp = br.ReadInt32();
data.sdk_des = br.ReadString();
data.lenovo_id = br.ReadString();
data.apple_id = br.ReadString();
if (_datas == null)
_datas = new Dictionary<int, WaresData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public WaresData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
