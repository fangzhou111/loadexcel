using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TavernData
{
/*主键ID*/
public int ID; 
/*抽取类型*/
public int Type; 
/*类型描述*/
public string Desc; 
/*按钮*/
public int Button; 
/*英雄包ID*/
public int Order; 
/*道具包id*/
public int ItemOrder; 
/*10次抽取后额外掉落包ID*/
public int TenthExtraDropID; 
/*高级十连抽额外获得掉落包ID*/
public int TenExtraDropID; 
}
public partial class TavernConfig : ConfigBase
{
private static TavernConfig _instance;
public Dictionary<int, TavernData> _datas;
public static TavernConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TavernConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Tavern.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 14;i++)
{
TavernData data = new TavernData();
data.ID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Desc = br.ReadString();
data.Button = br.ReadInt32();
data.Order = br.ReadInt32();
data.ItemOrder = br.ReadInt32();
data.TenthExtraDropID = br.ReadInt32();
data.TenExtraDropID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, TavernData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public TavernData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
