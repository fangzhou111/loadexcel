using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ActiveRewardData
{
/*主键*/
public int ID; 
/*需要活跃度*/
public int ActiveValue; 
/*奖励
对应QuestRward中的Order*/
public int Order; 
}
public partial class ActiveRewardConfig : ConfigBase
{
private static ActiveRewardConfig _instance;
public Dictionary<int, ActiveRewardData> _datas;
public static ActiveRewardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ActiveRewardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ActiveReward.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 4;i++)
{
ActiveRewardData data = new ActiveRewardData();
data.ID = br.ReadInt32();
data.ActiveValue = br.ReadInt32();
data.Order = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ActiveRewardData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public ActiveRewardData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
