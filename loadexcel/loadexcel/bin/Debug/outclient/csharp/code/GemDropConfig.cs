using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GemDropData
{
/*奖励ID*/
public int RewardID; 
/*奖励分组*/
public int Order; 
/*奖励类型*/
public int RewardCondition; 
/*掉落物品ID*/
public int RewardItemID; 
/*掉落物品数量*/
public int RewardItemNum; 
/*概率或权重*/
public int RewardProbability; 
/*奖励预览*/
public int RewardPreview; 
}
public partial class GemDropConfig : ConfigBase
{
private static GemDropConfig _instance;
public Dictionary<int, GemDropData> _datas;
public static GemDropConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GemDropConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GemDrop.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 198;i++)
{
GemDropData data = new GemDropData();
data.RewardID = br.ReadInt32();
data.Order = br.ReadInt32();
data.RewardCondition = br.ReadInt32();
data.RewardItemID = br.ReadInt32();
data.RewardItemNum = br.ReadInt32();
data.RewardProbability = br.ReadInt32();
data.RewardPreview = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GemDropData>();
_datas.Add(data.RewardID,data);
}
br.Close();
fs.Close();
}
public GemDropData Get(int newRewardID)
{
if (_datas.ContainsKey(newRewardID))
return _datas[newRewardID];
else
return null;
}
}
}
