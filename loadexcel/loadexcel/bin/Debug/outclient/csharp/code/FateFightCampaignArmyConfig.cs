using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FateFightCampaignArmyData
{
/*关卡ID*/
public int CampaignID; 
/*关卡内怪物序号*/
public int Index; 
/*当前序号调用怪物基础ID*/
public int MonsterBaseID; 
/*怪物等级*/
public int Level; 
/*怪物类型*/
public int Type; 
/*怪物强度系数ID*/
public int ID; 
/*当前序号调用怪物行为的ID*/
public int MonsterBehaviorID; 
}
public partial class FateFightCampaignArmyConfig : ConfigBase
{
private static FateFightCampaignArmyConfig _instance;
public Dictionary<int, Dictionary<int, FateFightCampaignArmyData>> _datas;
public static FateFightCampaignArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FateFightCampaignArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FateFightCampaignArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 15;i++)
{
FateFightCampaignArmyData data = new FateFightCampaignArmyData();
data.CampaignID = br.ReadInt32();
data.Index = br.ReadInt32();
data.MonsterBaseID = br.ReadInt32();
data.Level = br.ReadInt32();
data.Type = br.ReadInt32();
data.ID = br.ReadInt32();
data.MonsterBehaviorID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, FateFightCampaignArmyData>>();
if (!_datas.ContainsKey(data.CampaignID))
{
Dictionary<int, FateFightCampaignArmyData> _dic = new Dictionary<int, FateFightCampaignArmyData>();
_datas.Add(data.CampaignID, _dic);
}
_datas[data.CampaignID].Add(data.Index,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, FateFightCampaignArmyData> Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
public FateFightCampaignArmyData Get(int newCampaignID,int newIndex)
{
if (_datas.ContainsKey(newCampaignID) && _datas[newCampaignID].ContainsKey(newIndex))
return _datas[newCampaignID][newIndex];
else
return null;
}
}
}
