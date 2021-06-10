using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PrisonCampaignArmyData
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
/*怪物等级/英雄等级（不用）*/
public int Level; 
/*怪物类型/英雄阶数*/
public int Type; 
/*怪物强度系数ID*/
public int ID; 
/*当前序号调用怪物行为的ID*/
public int MonsterBehaviorID; 
}
public partial class PrisonCampaignArmyConfig : ConfigBase
{
private static PrisonCampaignArmyConfig _instance;
public Dictionary<int, PrisonCampaignArmyData> _datas;
public static PrisonCampaignArmyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PrisonCampaignArmyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PrisonCampaignArmy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 8;i++)
{
PrisonCampaignArmyData data = new PrisonCampaignArmyData();
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
_datas = new Dictionary<int, PrisonCampaignArmyData>();
_datas.Add(data.CampaignID,data);
}
br.Close();
fs.Close();
}
public PrisonCampaignArmyData Get(int newCampaignID)
{
if (_datas.ContainsKey(newCampaignID))
return _datas[newCampaignID];
else
return null;
}
}
}
