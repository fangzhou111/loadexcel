using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class DailyActivitiesData
{
/*活动编号,唯一主键*/
public int ActivityID; 
/*活动类型*/
public string ActivityType; 
/*活动名称*/
public string Name; 
/*活动说明*/
public string Description; 
/*周一*/
public int Monday; 
/*周二*/
public int Tuesday; 
/*周三*/
public int Wednesday; 
/*周四*/
public int Thursday; 
/*周五*/
public int Friday; 
/*周六*/
public int Saturday; 
/*周日*/
public int Sunday; 
/*活动开启时间（分）
如20点即：20x60=1200*/
public int OpenTime; 
/*活动持续时间(分）*/
public int Duration; 
}
public partial class DailyActivitiesConfig : ConfigBase
{
private static DailyActivitiesConfig _instance;
public Dictionary<string, DailyActivitiesData> _datas;
public static DailyActivitiesConfig Instance
{
get
{
if (_instance == null)
{
_instance = new DailyActivitiesConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("DailyActivities.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 2;i++)
{
DailyActivitiesData data = new DailyActivitiesData();
data.ActivityID = br.ReadInt32();
data.ActivityType = br.ReadString();
data.Name = br.ReadString();
data.Description = br.ReadString();
data.Monday = br.ReadInt32();
data.Tuesday = br.ReadInt32();
data.Wednesday = br.ReadInt32();
data.Thursday = br.ReadInt32();
data.Friday = br.ReadInt32();
data.Saturday = br.ReadInt32();
data.Sunday = br.ReadInt32();
data.OpenTime = br.ReadInt32();
data.Duration = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<string, DailyActivitiesData>();
_datas.Add(data.ActivityType,data);
}
br.Close();
fs.Close();
}
public DailyActivitiesData Get(string newActivityType)
{
if (_datas.ContainsKey(newActivityType))
return _datas[newActivityType];
else
return null;
}
}
}
