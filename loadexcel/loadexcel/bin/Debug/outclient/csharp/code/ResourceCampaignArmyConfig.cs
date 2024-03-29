﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ResourceCampaignArmyData
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
/*怪物体型*/
public int MonsterSize; 
/*BOSS展示*/
public int BossShow; 
/*boss血条*/
public int MonsterType; 
}
public partial class ResourceCampaignArmyConfig : ConfigBase
{
private static ResourceCampaignArmyConfig _instance;
public Dictionary<int, Dictionary<int, ResourceCampaignArmyData>> _datas;
public static ResourceCampaignArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ResourceCampaignArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ResourceCampaignArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 270;i++)
{
ResourceCampaignArmyData data = new ResourceCampaignArmyData();
data.CampaignID = br.ReadInt32();
data.Index = br.ReadInt32();
data.MonsterBaseID = br.ReadInt32();
data.Level = br.ReadInt32();
data.Type = br.ReadInt32();
data.ID = br.ReadInt32();
data.MonsterSize = br.ReadInt32();
data.BossShow = br.ReadInt32();
data.MonsterType = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, ResourceCampaignArmyData>>();
if (!_datas.ContainsKey(data.CampaignID))
{
Dictionary<int, ResourceCampaignArmyData> _dic = new Dictionary<int, ResourceCampaignArmyData>();
_datas.Add(data.CampaignID, _dic);
}
_datas[data.CampaignID].Add(data.Index,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, ResourceCampaignArmyData> Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
public ResourceCampaignArmyData Get(int newCampaignID,int newIndex)
{
if (_datas.ContainsKey(newCampaignID) && _datas[newCampaignID].ContainsKey(newIndex))
return _datas[newCampaignID][newIndex];
else
return null;
}
}
}
