using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class GemOutputData
{
/*熔炉序号*/
public int OutputOrder; 
/*掉落ID*/
public int Order; 
/*消耗钻石*/
public int NeedDiamond; 
/*可跳转熔炉序号*/
public int TurnOutputOrder; 
/*跳转熔炉概率*/
public int TurnProbability; 
}
public partial class GemOutputConfig : ConfigBase
{
private static GemOutputConfig _instance;
public Dictionary<int, GemOutputData> _datas;
public static GemOutputConfig Instance
{
get
{
if (_instance == null)
{
_instance = new GemOutputConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("GemOutput.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 6;i++)
{
GemOutputData data = new GemOutputData();
data.OutputOrder = br.ReadInt32();
data.Order = br.ReadInt32();
data.NeedDiamond = br.ReadInt32();
data.TurnOutputOrder = br.ReadInt32();
data.TurnProbability = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, GemOutputData>();
_datas.Add(data.OutputOrder,data);
}
br.Close();
fs.Close();
}
public GemOutputData Get(int newOutputOrder)
{
if (_datas.ContainsKey(newOutputOrder))
return _datas[newOutputOrder];
else
return null;
}
}
}
