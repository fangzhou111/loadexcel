using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DomainMineArmyData
{
/*怪物组合ID*/
public int CampaignID; 
/*关卡内怪物序号*/
public int Index; 
/*适用玩家最小区间*/
public int CampaignPlayerLevel; 
/*适用玩家最大区间*/
public int CampaignPlayerLevelMax; 
/*当前序号调用怪物基础ID*/
public int MonsterBaseID; 
/*怪物类型*/
public int Type; 
/*怪物强度系数ID*/
public int ID; 
/*当前序号调用怪物行为的ID*/
public int MonsterBehaviorID; 
/*交换攻守增加强度*/
public int StrengthUp; 
}
public partial class DomainMineArmyConfig : ConfigBase
{
private static DomainMineArmyConfig _instance;
public Dictionary<int, Dictionary<int, DomainMineArmyData>> _datas;
public static DomainMineArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DomainMineArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DomainMineArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 195;i++)
{
DomainMineArmyData data = new DomainMineArmyData();
data.CampaignID = br.ReadInt32();
data.Index = br.ReadInt32();
data.CampaignPlayerLevel = br.ReadInt32();
data.CampaignPlayerLevelMax = br.ReadInt32();
data.MonsterBaseID = br.ReadInt32();
data.Type = br.ReadInt32();
data.ID = br.ReadInt32();
data.MonsterBehaviorID = br.ReadInt32();
data.StrengthUp = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, DomainMineArmyData>>();
if (!_datas.ContainsKey(data.CampaignID))
{
Dictionary<int, DomainMineArmyData> _dic = new Dictionary<int, DomainMineArmyData>();
_datas.Add(data.CampaignID, _dic);
}
_datas[data.CampaignID].Add(data.Index,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, DomainMineArmyData> Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
public DomainMineArmyData Get(int newCampaignID,int newIndex)
{
if (_datas.ContainsKey(newCampaignID) && _datas[newCampaignID].ContainsKey(newIndex))
return _datas[newCampaignID][newIndex];
else
return null;
}
}
}
