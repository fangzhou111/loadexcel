using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class SkillStrengthData
{
/*技能ID*/
public string SkillID; 
/*技能名*/
public string TemplateName; 
/*主动技能释放获得怒气*/
public int GainRagePoint; 
/*A*/
public double A; 
/*B*/
public double B; 
/*C*/
public double C; 
/*D*/
public double D; 
/*E（概率1）*/
public double E; 
/*F（概率2）*/
public double F; 
/*G*/
public double G; 
/*H*/
public double H; 
/*I*/
public double I; 
/*J*/
public double J; 
/*K*/
public double K; 
/*L*/
public double L; 
/*M*/
public double M; 
/*N*/
public double N; 
/*O*/
public double O; 
/*P*/
public double P; 
/*Q*/
public double Q; 
/*R*/
public double R; 
/*S*/
public double S; 
/*T*/
public double T; 
/*U*/
public double U; 
/*V*/
public double V; 
/*W*/
public double W; 
/*X*/
public double X; 
/*Y*/
public double Y; 
/*Z*/
public double Z; 
}
public partial class SkillStrengthConfig : ConfigBase
{
private static SkillStrengthConfig _instance;
public Dictionary<string, SkillStrengthData> _datas;
public static SkillStrengthConfig Instance
{
get
{
if (_instance == null)
{
_instance = new SkillStrengthConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("SkillStrength.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 1104;i++)
{
SkillStrengthData data = new SkillStrengthData();
data.SkillID = br.ReadString();
data.TemplateName = br.ReadString();
data.GainRagePoint = br.ReadInt32();
data.A = (float)br.ReadDouble();
data.B = (float)br.ReadDouble();
data.C = (float)br.ReadDouble();
data.D = (float)br.ReadDouble();
data.E = (float)br.ReadDouble();
data.F = (float)br.ReadDouble();
data.G = (float)br.ReadDouble();
data.H = (float)br.ReadDouble();
data.I = (float)br.ReadDouble();
data.J = (float)br.ReadDouble();
data.K = (float)br.ReadDouble();
data.L = (float)br.ReadDouble();
data.M = (float)br.ReadDouble();
data.N = (float)br.ReadDouble();
data.O = (float)br.ReadDouble();
data.P = (float)br.ReadDouble();
data.Q = (float)br.ReadDouble();
data.R = (float)br.ReadDouble();
data.S = (float)br.ReadDouble();
data.T = (float)br.ReadDouble();
data.U = (float)br.ReadDouble();
data.V = (float)br.ReadDouble();
data.W = (float)br.ReadDouble();
data.X = (float)br.ReadDouble();
data.Y = (float)br.ReadDouble();
data.Z = (float)br.ReadDouble();
if (_datas == null)
_datas = new Dictionary<string, SkillStrengthData>();
_datas.Add(data.SkillID,data);
}
br.Close();
fs.Close();
}
public SkillStrengthData Get(string newSkillID)
{
if (_datas.ContainsKey(newSkillID))
return _datas[newSkillID];
else
return null;
}
}
}
