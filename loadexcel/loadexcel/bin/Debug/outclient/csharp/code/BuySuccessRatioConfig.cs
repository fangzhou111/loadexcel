using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class BuySuccessRatioData
{
/*成功率*/
public int SuccessRatio; 
/*购买价格*/
public int Price; 
/*购买次数*/
public int BuyTimes; 
}
public partial class BuySuccessRatioConfig : ConfigBase
{
private static BuySuccessRatioConfig _instance;
public Dictionary<int, BuySuccessRatioData> _datas;
public static BuySuccessRatioConfig Instance
{
get
{
if (_instance == null)
{
_instance = new BuySuccessRatioConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("BuySuccessRatio.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 2;i++)
{
BuySuccessRatioData data = new BuySuccessRatioData();
data.SuccessRatio = br.ReadInt32();
data.Price = br.ReadInt32();
data.BuyTimes = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, BuySuccessRatioData>();
_datas.Add(data.SuccessRatio,data);
}
br.Close();
fs.Close();
}
public BuySuccessRatioData Get(int newSuccessRatio)
{
if (_datas.ContainsKey(newSuccessRatio))
return _datas[newSuccessRatio];
else
return null;
}
}
}
