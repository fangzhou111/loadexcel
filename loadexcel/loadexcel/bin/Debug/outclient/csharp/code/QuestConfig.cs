using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class QuestData
{
/*主键ID，唯一不可重复*/
public int ID; 
/*显示用序列*/
public int ShowID; 
/*任务类型*/
public int Type; 
/*任务达成条件*/
public int Condition; 
/*任务参数1*/
public int Param1; 
/*任务参数2*/
public int Param2; 
/*任务参数3*/
public int Param3; 
/*任务进度*/
public int Progress; 
/*任务开启等级*/
public int NeedGrade; 
/*任务可完成等级*/
public int DoneGrade; 
/*任务结束等级*/
public int MaxGrade; 
/*开放此任务所需前置任务ID*/
public int PreQuestID; 
/*任务名称*/
public string Name; 
/*任务ICON*/
public string Icon; 
/*任务目标描述*/
public string Desc; 
/*完成任务描述*/
public string CompleteDesc; 
/*完成任务奖励*/
public int Order; 
/*点击此任务跳转模块*/
public int SwitchToModule; 
/*跳转模块参数*/
public int ModuleParameter; 
/*增加活跃度*/
public int ActiveValue; 
/*活动分类
1.日常
2.限时*/
public int ActivityType; 
/*接受任务对白
接取任务后自动弹出，尽量避免同时触发多个*/
public int StartDialogue; 
/*完成任务NPC*/
public int CompleteNPC; 
/*完成任务对白*/
public int CompleteDialogue; 
/*是否略过沙盘界面直接进入关卡战斗*/
public int BeginBattle; 
}
public partial class QuestConfig : ConfigBase
{
private static QuestConfig _instance;
public Dictionary<int, QuestData> _datas;
public static QuestConfig Instance
{
get
{
if (_instance == null)
{
_instance = new QuestConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("Quest.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 594;i++)
{
QuestData data = new QuestData();
data.ID = br.ReadInt32();
data.ShowID = br.ReadInt32();
data.Type = br.ReadInt32();
data.Condition = br.ReadInt32();
data.Param1 = br.ReadInt32();
data.Param2 = br.ReadInt32();
data.Param3 = br.ReadInt32();
data.Progress = br.ReadInt32();
data.NeedGrade = br.ReadInt32();
data.DoneGrade = br.ReadInt32();
data.MaxGrade = br.ReadInt32();
data.PreQuestID = br.ReadInt32();
data.Name = br.ReadString();
data.Icon = br.ReadString();
data.Desc = br.ReadString();
data.CompleteDesc = br.ReadString();
data.Order = br.ReadInt32();
data.SwitchToModule = br.ReadInt32();
data.ModuleParameter = br.ReadInt32();
data.ActiveValue = br.ReadInt32();
data.ActivityType = br.ReadInt32();
data.StartDialogue = br.ReadInt32();
data.CompleteNPC = br.ReadInt32();
data.CompleteDialogue = br.ReadInt32();
data.BeginBattle = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, QuestData>();
_datas.Add(data.ID,data);
}
br.Close();
fs.Close();
}
public QuestData Get(int newID)
{
if (_datas.ContainsKey(newID))
return _datas[newID];
else
return null;
}
}
}
