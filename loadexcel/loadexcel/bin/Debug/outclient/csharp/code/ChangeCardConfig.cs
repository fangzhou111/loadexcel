using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class ChangeCardData
{
/*主键ID*/
public int ID; 
/*万能碎片ID*/
public int ItemID; 
/*需要数量*/
public int ItemNum; 
/*可转换碎片*/
public int ChangeItemID; 
}
public partial class ChangeCardConfig : ConfigBase
{
private static ChangeCardConfig _instance;
public Dictionary<int, ChangeCardData> _datas;
public static ChangeCardConfig Instance
{
get
{
if (_instance == null)
{
_instance = new ChangeCardConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("ChangeCard.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 61;i++)
{
ChangeCardData data = new ChangeCardData();
data.ID = br.ReadInt32();
data.ItemID = br.ReadInt32();
data.ItemNum = br.ReadInt32();
data.ChangeItemID = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, ChangeCardData>();
_datas.Add(data.ChangeItemID,data);
}
br.Close();
fs.Close();
}
public ChangeCardData Get(int newChangeItemID)
{
if (_datas.ContainsKey(newChangeItemID))
return _datas[newChangeItemID];
else
return null;
}
}
}
