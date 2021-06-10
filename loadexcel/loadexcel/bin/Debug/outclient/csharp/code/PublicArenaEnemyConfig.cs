using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class PublicArenaEnemyData
{
/*对手编号*/
public int ID; 
/*对手最低战力
百分比*/
public int PowMin; 
/*对手最高战力
百分比*/
public int PowMax; 
}
public partial class PublicArenaEnemyConfig : ConfigBase
{
private static PublicArenaEnemyConfig _instance;
public Dictionary<int, PublicArenaEnemyData> _datas;
public static PublicArenaEnemyConfig Instance
{
get
{
if (_instance == null)
{
_instance = new PublicArenaEnemyConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("PublicArenaEnemy.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 3;i++)
{
PublicArenaEnemyData data = new PublicArenaEnemyData();
data.ID = br.ReadInt32();
data.PowMin = br.ReadInt32();
data.PowMax = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, PublicArenaEnemyData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public PublicArenaEnemyData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
