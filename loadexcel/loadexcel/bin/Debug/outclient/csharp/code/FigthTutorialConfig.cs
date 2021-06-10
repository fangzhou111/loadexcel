using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SuperMobs.Config
{
public class FigthTutorialData
{
/*引导编号*/
public int Order; 
/*引导步骤*/
public int Index; 
/*引导类型
1剧情对话
2点击场景或模型
3点击UI*/
public int Type; 
/*剧情对白显示角色名*/
public string Name; 
/*剧情对白角色模型*/
public string ModelName; 
/*剧情对白文本内容*/
public string Dialog; 
/*是否暂停战斗
1暂停0正常*/
public int GameStop; 
/*创建物体
物体和位置点必须同时存在
RS1 - 移动引导地面特效
RS2 - 集火图标
RS3 - 队长移动图片
RS4 - 全队移动图片*/
public string Obj; 
/*创建位置：
xx@xx@xx表示为地图上的一个点
Enemyxx表示为界面上一个HUD控件，挂载为Enemyxx角色
Imagexx@xx@xx表示在界面上加一个图片，位置为xx，xx*/
public string pos; 
/*是否强制引导*/
public int Force; 
/*切换下一条的时间*/
public int ToNextTime; 
/*要求鼠标操作
0、单击或双击
1、单击
2、双击
3、点击pos指定的怪*/
public int InputMouse; 
/*点击位置
1-5英雄技能
6自动战斗
7自动技能*/
public int InputPos; 
/*点击穿透*/
public int InputMap; 
/*弹出说话气泡的角色位置
无则填0*/
public int PlayerIndex; 
/*气泡文本内容*/
public string BubbleText; 
/*提示精灵位置
指离引导点击位置中心的偏移坐标*/
public string DialogBoxPos; 
/*精灵提示文本*/
public string DialogBox; 
/*是否派送提醒文字
大于等于1表示派送提示信息内容
0表示不派送，保持上一条提示
2表示可以开启手动操作（序章专用）*/
public int DispatchTips; 
/*派送文字内容*/
public string TipsText; 
/*语音提示*/
public int Audio; 
}
public partial class FigthTutorialConfig : ConfigBase
{
private static FigthTutorialConfig _instance;
public Dictionary<int, Dictionary<int, FigthTutorialData>> _datas;
public static FigthTutorialConfig Instance
{
get
{
if (_instance == null)
{
_instance = new FigthTutorialConfig();
_instance.Load();
ConfigManager.Add(_instance);
}
return _instance;
}
}
private void Load()
{
Stream fs = base.Load("FigthTutorial.bytes");
BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
for(int i = 0;i < 32;i++)
{
FigthTutorialData data = new FigthTutorialData();
data.Order = br.ReadInt32();
data.Index = br.ReadInt32();
data.Type = br.ReadInt32();
data.Name = br.ReadString();
data.ModelName = br.ReadString();
data.Dialog = br.ReadString();
data.GameStop = br.ReadInt32();
data.Obj = br.ReadString();
data.pos = br.ReadString();
data.Force = br.ReadInt32();
data.ToNextTime = br.ReadInt32();
data.InputMouse = br.ReadInt32();
data.InputPos = br.ReadInt32();
data.InputMap = br.ReadInt32();
data.PlayerIndex = br.ReadInt32();
data.BubbleText = br.ReadString();
data.DialogBoxPos = br.ReadString();
data.DialogBox = br.ReadString();
data.DispatchTips = br.ReadInt32();
data.TipsText = br.ReadString();
data.Audio = br.ReadInt32();
if (_datas == null)
_datas = new Dictionary<int, Dictionary<int, FigthTutorialData>>();
if (!_datas.ContainsKey(data.Order))
{
Dictionary<int, FigthTutorialData> _dic = new Dictionary<int, FigthTutorialData>();
_datas.Add(data.Order, _dic);
}
_datas[data.Order].Add(data.Index,data);
}
br.Close();
fs.Close();
}
public Dictionary<int, FigthTutorialData> Get(int newOrder)
{
if (_datas.ContainsKey(newOrder))
return _datas[newOrder];
else
return null;
}
public FigthTutorialData Get(int newOrder,int newIndex)
{
if (_datas.ContainsKey(newOrder) && _datas[newOrder].ContainsKey(newIndex))
return _datas[newOrder][newIndex];
else
return null;
}
}
}
