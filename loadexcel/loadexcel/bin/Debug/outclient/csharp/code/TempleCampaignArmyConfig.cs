using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class TempleCampaignArmyData
{
/*关卡ID*/
public int CampaignID; 
/*关卡内怪物序号*/
public int Index; 
/*怪物阵营*/
public int MonsterSide; 
/*怪物类型1*/
public int Type1; 
/*当前序号调用怪物基础ID/英雄ID*/
public int MonsterBaseID; 
/*怪物等级/英雄等级*/
public int Level; 
/*怪物类型/英雄阶数*/
public int Type; 
/*怪物强度系数ID*/
public int ID; 
/*当前序号调用怪物行为的ID*/
public int MonsterBehaviorID; 
}
public partial class TempleCampaignArmyConfig : ConfigBase
{
private static TempleCampaignArmyConfig _instance;
public Dictionary<int, Dictionary<int, TempleCampaignArmyData>> _datas;
public static TempleCampaignArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new TempleCampaignArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("TempleCampaignArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 120;i++)
{
TempleCampaignArmyData data = new TempleCampaignArmyData();
data.CampaignID = br.ReadInt32();
data.Index = br.ReadInt32();
data.MonsterSide = br.ReadInt32();
data.Type1 = br.ReadInt32();
data.MonsterBaseID = br.ReadInt32();
data.Level = br.ReadInt32();
data.Type = br.ReadInt32();
data.ID = br.ReadInt32();
data.MonsterBehaviorID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, TempleCampaignArmyData>>();
if (!_datas.ContainsKey(data.CampaignID))
{
Dictionary<int, TempleCampaignArmyData> _dic = new Dictionary<int, TempleCampaignArmyData>();
_datas.Add(data.CampaignID, _dic);
}
_datas[data.CampaignID].Add(data.Index,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, TempleCampaignArmyData> Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
public TempleCampaignArmyData Get(int newCampaignID,int newIndex)
{
if (_datas.ContainsKey(newCampaignID) && _datas[newCampaignID].ContainsKey(newIndex))
return _datas[newCampaignID][newIndex];
else
return null;
}
}
}
