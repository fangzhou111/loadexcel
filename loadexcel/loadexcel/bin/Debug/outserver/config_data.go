package configdata

// 30个任务.xls
type Conf_Quest30 struct { 
	ID int32		`key`	/*主键ID，唯一不可重复*/
	SubFunctionId int32			/*功能ID*/
	ConditionType int32			/*完成条件类型*/
	Condition int32			/*任务达成条件*/
	Progress int32			/*任务进度*/
	Name string			/*任务名称*/
	Icon string			/*任务ICON*/
	Desc string			/*任务描述*/
	Order int32			/*完成任务奖励*/
} 
var MConf_Quest30 = map[string] * Conf_Quest30{}

// 30个任务.xls
type Conf_Quest30Reward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_Quest30Reward = map[string] * Conf_Quest30Reward{}

// data.xls
type Conf_character struct { 
	Id int32		`key`	/*ID*/
	Model string			/*模型*/
	Job int32			/*职业*/
	Atk float32			/*攻击*/
	Def float32			/*防御*/
	Hp float32			/*血量*/
	Minuspecent float32			/*减员底线*/
	Sodnum int32			/*军团士兵数*/
	Atkdis float32			/*攻击距离*/
	Atkinterval float32			/*攻击间隔*/
	Speed float32			/*移动速度*/
	Childmodelname string			/*3D模型名称*/
	Skillnames string			/*主动技能(#分割)*/
	Atkname string			/*默认平A*/
} 
var MConf_character = map[string] * Conf_character{}

// data.xls
type Conf_job struct { 
	Id int32		`key`	/*ID*/
	Name string			/*名字*/
	Tree string			/*AI*/
	Population int32			/*所占单位*/
	Atkerscount int32			/*阻敌数量*/
	Isbeingatkweak int32			/*被近身受到克制*/
	Beingatkweakparent float32			/*近身受克制比例*/
	Islongrange int32			/*近战or远程*/
} 
var MConf_job = map[string] * Conf_job{}

// data.xls
type Conf_array struct { 
	Row int32		`key`	/*行*/
	Cul int32		`key`	/*列*/
	Ctype int32			/*阵营*/
	Chaid int32			/*角色ID*/
} 
var MConf_array = map[string] * Conf_array{}

// data.xls
type Conf_ctrl struct { 
	Id int32		`key`	/*ID*/
	Job int32			/*职业*/
	Bejob int32			/*被克制职业*/
	Atkv1 float32			/*克制加成*/
	Atkv2 float32			/*被克制衰减*/
} 
var MConf_ctrl = map[string] * Conf_ctrl{}

// loading表.xls
type Conf_Loading struct { 
	ID int32		`key`	/*主键ID*/
	NAME string			/*背景图名字*/
	SHOW int32			/*显示*/
} 
var MConf_Loading = map[string] * Conf_Loading{}

// NPC表.xls
type Conf_NPCBase struct { 
	ID int32		`key`	/*NPC编号*/
	Type int32			/*类型*/
	Name string			/*名称*/
	Title string			/*称号*/
	NameHeigth int32			/*名字高度*/
	DefaultName string			/*不带颜色名字*/
	Angle int32			/*角度*/
	Shape int32			/*体型大小*/
	Model string			/*模型*/
	Dialogue string			/*默认对白*/
	Audio string			/*对话语音*/
} 
var MConf_NPCBase = map[string] * Conf_NPCBase{}

// VIP特权.xls
type Conf_VIPPrivilege struct { 
	ID string		`key`	/*VIP特权ID*/
	Desc string			/*VIP特权描述*/
	PrivilegeType int32			/*特权类型
1开启2次数*/
	VIP0 int32			/*免费用户*/
	VIP1 int32			/*VIP1特权*/
	VIP2 int32			/*VIP2特权*/
	VIP3 int32			/*VIP3特权*/
	VIP4 int32			/*VIP4特权*/
	VIP5 int32			/*VIP5特权*/
	VIP6 int32			/*VIP6特权*/
	VIP7 int32			/*VIP7特权*/
	VIP8 int32			/*VIP8特权*/
	VIP9 int32			/*VIP9特权*/
	VIP10 int32			/*VIP10特权*/
	VIP11 int32			/*VIP11特权*/
	VIP12 int32			/*VIP12特权*/
	VIP13 int32			/*VIP13特权*/
	VIP14 int32			/*VIP14特权*/
	VIP15 int32			/*VIP15特权*/
	VIP16 int32			/*VIP16特权*/
} 
var MConf_VIPPrivilege = map[string] * Conf_VIPPrivilege{}

// VIP特权.xls
type Conf_VIPReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_VIPReward = map[string] * Conf_VIPReward{}

// VIP特权.xls
type Conf_VIPDesc struct { 
	ID int32		`key`	/*特权编号*/
	VIP0 string			/*VIP0特权*/
	VIP1 string			/*VIP1特权*/
	VIP2 string			/*VIP2特权*/
	VIP3 string			/*VIP3特权*/
	VIP4 string			/*VIP4特权*/
	VIP5 string			/*VIP5特权*/
	VIP6 string			/*VIP6特权*/
	VIP7 string			/*VIP7特权*/
	VIP8 string			/*VIP8特权*/
	VIP9 string			/*VIP9特权*/
	VIP10 string			/*VIP10特权*/
	VIP11 string			/*VIP11特权*/
	VIP12 string			/*VIP12特权*/
	VIP13 string			/*VIP13特权*/
	VIP14 string			/*VIP14特权*/
	VIP15 string			/*VIP15特权*/
	VIP16 string			/*VIP16特权*/
} 
var MConf_VIPDesc = map[string] * Conf_VIPDesc{}

// 万能碎片转换.xls
type Conf_ChangeCard struct { 
	ID int32			/*主键ID*/
	ItemID int32			/*万能碎片ID*/
	ItemNum int32			/*需要数量*/
	ChangeItemID int32		`key`	/*可转换碎片*/
} 
var MConf_ChangeCard = map[string] * Conf_ChangeCard{}

// 世界BOSS.xls
type Conf_WorldBossCampaign struct { 
	CampaignID int32		`key`	/*关卡ID*/
	AttackReward int32			/*单次挑战可获得奖励*/
	KilledReward int32			/*杀死以后可获得奖励*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_WorldBossCampaign = map[string] * Conf_WorldBossCampaign{}

// 世界BOSS.xls
type Conf_WorldBossReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_WorldBossReward = map[string] * Conf_WorldBossReward{}

// 世界BOSS.xls
type Conf_WorldBossOnceRank struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_WorldBossOnceRank = map[string] * Conf_WorldBossOnceRank{}

// 世界BOSS.xls
type Conf_WorldBossCurveRank struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_WorldBossCurveRank = map[string] * Conf_WorldBossCurveRank{}

// 世界BOSS.xls
// 全局配置.xls
// 功能开放表.xls
// 商店整合.xls
// 宠物表.xls
// 开服嘉年华.xls
// 开服排行.xls
// 护送.xls
// 时光之穴副本.xls
// 祭坛.xls
// 禁魔监狱表.xls
// 第二周嘉年华.xls
// 签到.xls
// 缘分试炼.xls
// 英灵殿.xls
// 跨服竞技配置.xls
// 跨服联赛.xls
// 运营活动.xls
// 酒馆.xls
// 野外首领.xls
// 阵营选择.xls
// 领主争霸赛.xls
// 领地探险.xls
// 领地表.xls
// 黑市商店.xls
type Conf_GlobalConfig struct { 
	NameID string		`key`	/*功能名称*/
	Value int32			/*功能值*/
} 
var MConf_GlobalConfig = map[string] * Conf_GlobalConfig{}

// 世界BOSS.xls
type Conf_WorldBossOnceRank__act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_WorldBossOnceRank__act1 = map[string] * Conf_WorldBossOnceRank__act1{}

// 世界BOSS.xls
type Conf_WorldBossCurveRank_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_WorldBossCurveRank_act1 = map[string] * Conf_WorldBossCurveRank_act1{}

// 世界BOSS怪物.xls
type Conf_WorldBossMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	KillAttribute int32			/*击杀增加属性*/
	AttributeValue int32			/*增加值*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_WorldBossMonsterBase = map[string] * Conf_WorldBossMonsterBase{}

// 世界BOSS怪物.xls
type Conf_WorldBossBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_WorldBossBehavior = map[string] * Conf_WorldBossBehavior{}

// 世界BOSS怪物.xls
type Conf_WorldBossCampaignArmy struct { 
	CampaignID int32		`key`	/*世界boss等级*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterSide int32			/*怪物阵营*/
	Type1 int32			/*怪物类型1*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID/英雄ID*/
	Level int32			/*怪物等级/英雄等级*/
	Type int32			/*怪物类型/英雄阶数*/
	ID int32			/*怪物强度系数ID*/
	MonsterBehaviorID int32			/*当前序号调用怪物行为的ID*/
} 
var MConf_WorldBossCampaignArmy = map[string] * Conf_WorldBossCampaignArmy{}

// 人物升级表.xls
type Conf_PlayerUpgradeExp struct { 
	Level int32		`key`	/*人物等级*/
	Exp int32			/*升到下一级所需经验*/
	MaxStrength int32			/*当前等级体力上限*/
	MaxSpirit int32			/*精力上限*/
	UpgradeOfferStrength int32			/*升级获得体力*/
	UpgradeOfferSpirit int32			/*升级获得精力*/
	MaxHeroLevel int32			/*英雄等级上限*/
} 
var MConf_PlayerUpgradeExp = map[string] * Conf_PlayerUpgradeExp{}

// 人物升级表.xls
type Conf_PlayerUpgradeExp_act2 struct { 
	Level int32		`key`	/*人物等级*/
	Exp int32			/*升到下一级所需经验*/
	MaxStrength int32			/*当前等级体力上限*/
	MaxSpirit int32			/*精力上限*/
	UpgradeOfferStrength int32			/*升级获得体力*/
	UpgradeOfferSpirit int32			/*升级获得精力*/
	MaxHeroLevel int32			/*英雄等级上限*/
} 
var MConf_PlayerUpgradeExp_act2 = map[string] * Conf_PlayerUpgradeExp_act2{}

// 任务.xls
type Conf_Quest struct { 
	ID int32		`key`	/*主键ID，唯一不可重复*/
	ShowID int32			/*显示用序列*/
	Type int32			/*任务类型*/
	Condition int32			/*任务达成条件*/
	Param1 int32			/*任务参数1*/
	Param2 int32			/*任务参数2*/
	Param3 int32			/*任务参数3*/
	Progress int32			/*任务进度*/
	NeedGrade int32			/*任务开启等级*/
	DoneGrade int32			/*任务可完成等级*/
	MaxGrade int32			/*任务结束等级*/
	PreQuestID int32			/*开放此任务所需前置任务ID*/
	Name string			/*任务名称*/
	Icon string			/*任务ICON*/
	Desc string			/*任务目标描述*/
	CompleteDesc string			/*完成任务描述*/
	Order int32			/*完成任务奖励*/
	SwitchToModule int32			/*点击此任务跳转模块*/
	ModuleParameter int32			/*跳转模块参数*/
	ActiveValue int32			/*增加活跃度*/
	ActivityType int32			/*活动分类
1.日常
2.限时*/
	StartDialogue int32			/*接受任务对白
接取任务后自动弹出，尽量避免同时触发多个*/
	CompleteNPC int32			/*完成任务NPC*/
	CompleteDialogue int32			/*完成任务对白*/
	BeginBattle int32			/*是否略过沙盘界面直接进入关卡战斗*/
} 
var MConf_Quest = map[string] * Conf_Quest{}

// 任务.xls
type Conf_QuestReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_QuestReward = map[string] * Conf_QuestReward{}

// 任务.xls
type Conf_ActiveReward struct { 
	ID int32		`key`	/*主键*/
	ActiveValue int32			/*需要活跃度*/
	Order int32			/*奖励
对应QuestRward中的Order*/
} 
var MConf_ActiveReward = map[string] * Conf_ActiveReward{}

// 任务.xls
type Conf_QuestReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_QuestReward_act2 = map[string] * Conf_QuestReward_act2{}

// 传承价格表.xls
type Conf_InheritPrice struct { 
	Item int32		`key`	/*道具ID*/
	Price int32			/*传承价格（钻）*/
} 
var MConf_InheritPrice = map[string] * Conf_InheritPrice{}

// 传承价格表.xls
type Conf_GoldPrice struct { 
	Level int32		`key`	/*等级*/
	GoldPrice int32			/*金币价*/
} 
var MConf_GoldPrice = map[string] * Conf_GoldPrice{}

// 侍从.xls
type Conf_SquireSlots struct { 
	HeroID int32			/*英雄编号*/
	SquireSlot int32		`key`	/*侍从位置*/
	OpenLevel int32			/*开启要求主角等级*/
	NeedHeroStar int32			/*激活要求英雄星级*/
	SlotAdd int32			/*栏位加成索引*/
	SpecialHeroID int32			/*专属英雄*/
	ExtraBonus int32			/*传属英雄额外加成*/
	AllActivationEffect int32			/*全部激活奖励*/
} 
var MConf_SquireSlots = map[string] * Conf_SquireSlots{}

// 侍从.xls
type Conf_SquireSlotsAdd struct { 
	SlotAdd int32		`key`	/*栏位加成索引*/
	SlotLevel int32		`key`	/*栏位等级*/
	EffectID int32			/*effect表效果编号*/
	NumMin int32			/*升级最低次数
该次数以下必定失败*/
	NumMax int32			/*升级最高次数
达到该次数必定成功*/
	SuccessRate int32			/*实际成功率(百万分比)
达到最低次数后的成功率*/
	LuckyFirst int32			/*首次失败祝福值*/
	LuckyMax int32			/*祝福值上限
不得小于最高次数*10+首次失败祝福值
每次升级失败祝福值+10*/
	Item1 int32			/*升级道具1编号*/
	Num1 int32			/*升级道具1数量*/
	Item2 int32			/*升级道具2编号*/
	Num2 int32			/*升级道具2数量*/
	Item3 int32			/*升级道具3编号*/
	Num3 int32			/*升级道具3数量*/
} 
var MConf_SquireSlotsAdd = map[string] * Conf_SquireSlotsAdd{}

// 侍从.xls
type Conf_Squire struct { 
	ID int32			/*主键ID*/
	SquireSlot int32		`key`	/*侍从栏位*/
	OpenLevel int32			/*开放领主等级*/
	SlotLevel int32		`key`	/*栏位等级*/
	SquireLevel int32			/*需要侍从等级*/
	SquireStep int32			/*需要侍从的阶*/
	SquireAwake int32			/*需要侍从的觉醒*/
	PhysicsAtkAdd float32			/*物攻百分比加成*/
	MagicAtkAdd float32			/*魔攻百分比加成*/
	PhysicsDefAdd float32			/*物防百分比加成*/
	MagicDefAdd float32			/*魔防百分比加成*/
	HPAdd float32			/*血量百分比加成*/
} 
var MConf_Squire = map[string] * Conf_Squire{}

// 充值商品.xls
type Conf_Wares struct { 
	Index int32			/*商品排序*/
	ID int32		`key`	/*商品ID*/
	Name string			/*名称*/
	Description string			/*描述*/
	Icon string			/*图标*/
	Gold int32			/*价值钻石*/
	Gold_ex int32			/*赠送额外钻石*/
	Gold_first int32			/*首充额外奖励*/
	Rmb int32			/*购买所需人民币，单位（元）*/
	Wares_type int32			/*商品类型：
1为普通商品，2为月卡，3为成长基金*/
	Month_card_days int32			/*月卡持续时间*/
	Month_card_gold int32			/*月卡每次返还金额*/
	Vip_exp int32			/*vip经验*/
	Sdk_des string			/*商品SDK描述*/
	Lenovo_id string			/*联想平台商品ID*/
	Apple_id string			/*苹果ID*/
} 
var MConf_Wares = map[string] * Conf_Wares{}

// 充值商品.xls
type Conf_SVIPConfig struct { 
	Real_server_id int32		`key`	/*服务器ID*/
	Time_limit int32			/*限制开服时间，单位：天*/
	Rmb_amount int32			/*累计金额，单位：元*/
	Gm_name string			/*GM客服名称*/
	Gm_contact string			/*GM客服联系方式*/
	Gm_photo string			/*GM客服照片*/
	Enable int32			/*是否开启*/
} 
var MConf_SVIPConfig = map[string] * Conf_SVIPConfig{}

// 全局配置.xls
// 酒馆.xls
// 野外首领.xls
type Conf_GlobalConfig_act2 struct { 
	NameID string		`key`	/*功能名称*/
	Value int32			/*功能值*/
} 
var MConf_GlobalConfig_act2 = map[string] * Conf_GlobalConfig_act2{}

// 公会伊利丹.xls
type Conf_Illidan struct { 
	NeedIllidan int32		`key`	/*我要伊利丹等级*/
	NeedIllidanExp int32			/*升级经验*/
	GameTimeUp int32			/*可玩次数*/
	FreePlayNum int32			/*免费次数*/
	Money int32			/*捐献金币*/
	MoneyExp int32			/*捐献金币可获经验*/
	MoneyContribution int32			/*捐金币功勋*/
	Gold int32			/*捐献钻石*/
	GoldExp int32			/*捐献钻石可获经验*/
	GoldContribution int32			/*捐钻石功勋*/
} 
var MConf_Illidan = map[string] * Conf_Illidan{}

// 公会伊利丹.xls
type Conf_IllidanSpend struct { 
	SpendNum int32		`key`	/*次数*/
	SpendDiamond int32			/*钻石*/
} 
var MConf_IllidanSpend = map[string] * Conf_IllidanSpend{}

// 公会伊利丹.xls
type Conf_IllidanProbability struct { 
	IllidanNum int32		`key`	/*伊利丹个数*/
	IllidanProbability0 int32			/*0个伊利丹出现概率*/
	IllidanProbability1 int32			/*1个伊利丹出现概率*/
	IllidanProbability2 int32			/*2个伊利丹出现概率*/
	IllidanProbability3 int32			/*3个伊利丹出现概率*/
	IllidanProbability4 int32			/*4个伊利丹出现概率*/
	IllidanProbability5 int32			/*5个伊利丹出现概率*/
	IllidanProbability6 int32			/*6个伊利丹出现概率*/
} 
var MConf_IllidanProbability = map[string] * Conf_IllidanProbability{}

// 公会伊利丹.xls
type Conf_IllidanRward struct { 
	ID int32			/*序号*/
	IllidanNum int32		`key`	/*伊利丹个数*/
	IllidanRward1 int32			/*伊利丹奖励物品ID1*/
	IllidanRwardNum1 int32			/*奖励道具数量1*/
	IllidanRward2 int32			/*伊利丹奖励物品ID2*/
	IllidanRwardNum2 int32			/*奖励道具数量2*/
	IllidanRward3 int32			/*伊利丹奖励物品ID3*/
	IllidanRwardNum3 int32			/*奖励道具数量3*/
} 
var MConf_IllidanRward = map[string] * Conf_IllidanRward{}

// 公会伊利丹.xls
type Conf_IllidanLoop struct { 
	ID int32		`key`	/*主键ID*/
	Times int32			/*首轮的次数*/
	Order int32			/*分组*/
	Number int32			/*一粒蛋面数*/
} 
var MConf_IllidanLoop = map[string] * Conf_IllidanLoop{}

// 公会副本.xls
type Conf_GuildChapter struct { 
	CampaignChapterID int32		`key`	/*章节ID，主键唯一不可重复*/
	CampaignChapterName string			/*章节名称*/
	CampaignSandID string			/*沙盘资源ID*/
	NodeID string			/*路线预制体ID*/
	RwardShow string			/*奖励预览*/
	Riadshow int32			/*显示头像*/
	RiadFrameShow int32			/*显示头像框*/
	RiadNeedLevel int32			/*进入等级限制*/
	PreposeChapter int32			/*前置章节*/
	RaidDoneTime int32			/*限时通关*/
	RaidDoneRward int32			/*限时通关奖励*/
	DoneReward int32			/*通关奖励*/
} 
var MConf_GuildChapter = map[string] * Conf_GuildChapter{}

// 公会副本.xls
type Conf_GuildCampaign struct { 
	CampaignChapterID int32			/*章节ID，对应章节信息表上的章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignOptionType int32			/*关卡类型*/
	CampaignName string			/*关卡名称*/
	CampaignDesc string			/*关卡描述*/
	CampaignType int32			/*是否Boss关卡*/
	MonsterReviewID string			/*怪物预览*/
	PreposeCampaignID int32			/*开放此关卡前置关卡ID*/
	CampaignFightReward int32			/*战斗掉落*/
	BloodRward1 string			/*进度掉落1，对应副本奖励表内的掉落ID*/
	BloodRward2 string			/*进度掉落2，对应副本奖励表内的掉落ID*/
	BloodRward3 string			/*进度掉落3，对应副本奖励表内的掉落ID*/
	BloodRward4 string			/*进度掉落4，对应副本奖励表内的掉落ID*/
	BloodRward5 string			/*进度掉落5，对应副本奖励表内的掉落ID*/
	LastReward int32			/*最后一击奖励*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	ArmyID string			/*调用战斗部队ID*/
	HelperID string			/*调用外援英雄的队伍*/
	Dialog1 string			/*怪物对白1*/
	Dialog2 string			/*怪物对白2*/
	DialogBoss string			/*关底BOSS喊话*/
	MonShow string			/*怪物展示动作*/
} 
var MConf_GuildCampaign = map[string] * Conf_GuildCampaign{}

// 公会副本.xls
type Conf_GuildCampaignReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_GuildCampaignReward = map[string] * Conf_GuildCampaignReward{}

// 公会副本.xls
type Conf_GuildRaidRank struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_GuildRaidRank = map[string] * Conf_GuildRaidRank{}

// 公会副本.xls
type Conf_GuildCampaignReward_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_GuildCampaignReward_act1 = map[string] * Conf_GuildCampaignReward_act1{}

// 公会副本.xls
type Conf_GuildRaidRank_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_GuildRaidRank_act1 = map[string] * Conf_GuildRaidRank_act1{}

// 公会副本.xls
type Conf_GuildRaidRank_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_GuildRaidRank_act2 = map[string] * Conf_GuildRaidRank_act2{}

// 公会副本.xls
type Conf_GuildCampaignReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_GuildCampaignReward_act2 = map[string] * Conf_GuildCampaignReward_act2{}

// 公会副本建设.xls
type Conf_GuildRaidBuild struct { 
	RaidLevel int32		`key`	/*公会等级*/
	RaidNeedEXP int32			/*升级所需经验*/
	RaidOpen string			/*开启副本章节*/
	RaidFight int32			/*挑战次数*/
	RaidNum int32			/*重置次数*/
	Money int32			/*捐献金币*/
	MoneyExp int32			/*捐献金币可获经验*/
	MoneyContribution int32			/*捐金币功勋*/
	Gold int32			/*捐献钻石*/
	GoldExp int32			/*捐献钻石可获经验*/
	GoldContribution int32			/*捐钻石功勋*/
} 
var MConf_GuildRaidBuild = map[string] * Conf_GuildRaidBuild{}

// 公会副本怪物.xls
type Conf_GuildMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_GuildMonsterBase = map[string] * Conf_GuildMonsterBase{}

// 公会副本怪物.xls
type Conf_GuildMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_GuildMonsterBehavior = map[string] * Conf_GuildMonsterBehavior{}

// 公会副本怪物.xls
type Conf_GuildCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_GuildCampaignArmy = map[string] * Conf_GuildCampaignArmy{}

// 公会表.xls
type Conf_Guild struct { 
	GuildLevel int32		`key`	/*等级*/
	GuildExp int32			/*需要经验值*/
	Money int32			/*普通建设消耗金币*/
	MoneyExp int32			/*普通建设增加公会经验*/
	MoneyContribution int32			/*普通建设获得贡献*/
	MoneyProgress int32			/*普通建设增加进度*/
	Gold int32			/*中级建设消耗钻石*/
	GoldExp int32			/*中级建设公会经验*/
	GoldContribution int32			/*中级建设个人贡献*/
	GoldProgress int32			/*中级建设进度*/
	Diamond int32			/*高级建设消耗钻石*/
	DiamondEXP int32			/*高级建设公会经验*/
	DiamondContribution int32			/*高级建设个人贡献*/
	DiamondProgress int32			/*高级建设增加进度*/
	GuildPlayer int32			/*公会成员上限*/
	GuildLeader int32			/*公会官员上限*/
	GuildBuild int32			/*公会捐献次数*/
} 
var MConf_Guild = map[string] * Conf_Guild{}

// 公会表.xls
type Conf_GuildProgressReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Group int32			/*奖励分组*/
	Order int32		`key`	/*
需要建设进度*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_GuildProgressReward = map[string] * Conf_GuildProgressReward{}

// 公会表.xls
type Conf_GuildUnlock struct { 
	GuildLevel int32		`key`	/*公会等级*/
	GuildTechnology1 int32			/*我要伊利丹*/
	GuildTechnology2 int32			/*公会副本*/
	GuildTechnology3 int32			/*怪物消消乐*/
	GuildTechnology4 int32			/*公会商店*/
	GuildTechnology5 int32			/*公会熔炉*/
	GuildTechnology6 int32			/*公会领地*/
} 
var MConf_GuildUnlock = map[string] * Conf_GuildUnlock{}

// 军团入侵.xls
type Conf_LegionInvasion struct { 
	LegionID int32		`key`	/*军团ID，主键唯一不可重复*/
	LegionName string			/*军团名称*/
	LegionChallengeTime int32			/*每日可挑战次数(重置次数)*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_LegionInvasion = map[string] * Conf_LegionInvasion{}

// 军团入侵.xls
type Conf_LegionCampaign struct { 
	LegionID int32			/*军团ID，对应章节信息表上的章节ID*/
	LegionWaveID int32		`key`	/*波次ID*/
	PreposeCampaignID int32			/*需要通关普通关卡*/
	PreposeEliteCampaignID int32			/*需要通关精英关卡*/
	WaveLevel int32			/*波次等级*/
	WaveName string			/*波次名称*/
	WaveDesc string			/*波次描述*/
	BossWave int32			/*是否Boss波次*/
	WaveBattleTime int32			/*波次战斗回合*/
	JumpWaveBattleTime int32			/*波次跳波时间（秒）*/
	JumpWaveID int32			/*波次跳波ID*/
	Model int32			/*预览模型*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	FirstRewardOrder int32			/*通关首次奖励*/
	RewardOrder string			/*通过当前波次奖励，对应副本奖励表内的掉落ID*/
	Chest int32			/*通关额外宝箱
空或0表示无宝箱*/
	ModelScale int32			/*模型大小/100*/
} 
var MConf_LegionCampaign = map[string] * Conf_LegionCampaign{}

// 军团入侵.xls
type Conf_LegionReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_LegionReward = map[string] * Conf_LegionReward{}

// 军团入侵.xls
type Conf_LegionReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_LegionReward_act2 = map[string] * Conf_LegionReward_act2{}

// 军团入侵怪物表.xls
type Conf_LegionMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_LegionMonsterBase = map[string] * Conf_LegionMonsterBase{}

// 军团入侵怪物表.xls
type Conf_LegionMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
} 
var MConf_LegionMonsterBehavior = map[string] * Conf_LegionMonsterBehavior{}

// 军团入侵怪物表.xls
type Conf_LegionArmy struct { 
	WaveID int32		`key`	/*波次ID*/
	Index int32			/*波次内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID/英雄ID*/
	Level int32			/*怪物等级/英雄等级*/
	Type int32			/*怪物类型/阶数*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
} 
var MConf_LegionArmy = map[string] * Conf_LegionArmy{}

// 决战黑庙.xls
type Conf_BlackTempleCampaign struct { 
	CampaignID int32		`key`	/*波次ID*/
	WaveName string			/*波次名称*/
	WaveBattleTime int32			/*波次战斗回合*/
	Model int32			/*预览模型*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	RewardOrder int32			/*战斗奖励*/
	RewardBox int32			/*5关宝箱奖励*/
	CampaignFightReward int32			/*通关波次奖励*/
	AddBlood int32			/*通关增加血瓶*/
	ModelScale int32			/*模型大小/100*/
	HeroNum int32			/*可上阵人数*/
	ResetCampaignID int32			/*重置关数*/
} 
var MConf_BlackTempleCampaign = map[string] * Conf_BlackTempleCampaign{}

// 决战黑庙.xls
type Conf_BlackTempleReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BlackTempleReward = map[string] * Conf_BlackTempleReward{}

// 决战黑庙怪物.xls
type Conf_BlackTempleMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_BlackTempleMonsterBase = map[string] * Conf_BlackTempleMonsterBase{}

// 决战黑庙怪物.xls
type Conf_BlackTempleMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_BlackTempleMonsterBehavior = map[string] * Conf_BlackTempleMonsterBehavior{}

// 决战黑庙怪物.xls
type Conf_BlackTempleCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_BlackTempleCampaignArmy = map[string] * Conf_BlackTempleCampaignArmy{}

// 剧情副本与精英副本.xls
type Conf_Chapter struct { 
	CampaignChapterID int32		`key`	/*章节ID，主键唯一不可重复*/
	CampaignChapterName string			/*章节名称*/
	CampaignID string			/*宝箱开启条件（通关某关）*/
	CampaignChest string			/*关卡宝箱*/
	Star string			/*星级条件*/
	Order string			/*星级宝箱*/
	Customs  int32			/*通关天命道具奖励*/
	CampaignSandID string			/*沙盘资源ID*/
	NodeID string			/*路线预制体ID*/
} 
var MConf_Chapter = map[string] * Conf_Chapter{}

// 剧情副本与精英副本.xls
type Conf_Campaign struct { 
	CampaignChapterID int32		`key`	/*章节ID，对应章节信息表上的章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignOptionType int32			/*关卡类型*/
	CampaignLevel int32			/*关卡等级*/
	CampaignName string			/*关卡名称*/
	CampaignDesc string			/*关卡描述*/
	CampaignType int32			/*是否Boss关卡*/
	MonsterReviewID string			/*怪物预览*/
	CampaignOpeningLevel int32			/*关卡开放所需玩家等级*/
	CampaignChallengeTime int32			/*每天可挑战次数上限*/
	ActionPoint int32			/*每次挑战此关卡所消耗体力*/
	PreposeChapterID int32			/*开放此关卡前置章节ID*/
	PreposeCampaignID int32			/*开放此关卡前置关卡ID*/
	RewardOrder string			/*通关奖励，对应副本奖励表内的掉落ID*/
	FirstRewardOrder int32			/*通关首次掉落*/
	RewardPlayerExp int32			/*通关可获得人物经验*/
	RewardHeroExp int32			/*通关获得英雄经验*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	ArmyID string			/*调用战斗部队ID*/
	HelperID string			/*调用外援英雄的队伍*/
	Dialog1 string			/*怪物对白1*/
	Dialog2 string			/*怪物对白2*/
	DialogBoss string			/*关底BOSS喊话*/
	MonShow string			/*怪物展示动作*/
	AchievementCondition string			/*胜利条件*/
	AchievementNum int32			/*胜利条件参数*/
	AchievementNames string			/*关卡成就*/
	StarReward1 int32			/*星级奖励1*/
	StarReward2 int32			/*星级奖励2*/
	StarReward3 int32			/*星级奖励3*/
	DramaID int32			/*剧情对白ID(出现1次直接填值，出现多次天ID#true)*/
	ShowCampaign int32			/*表演关卡(需加到白名单)*/
} 
var MConf_Campaign = map[string] * Conf_Campaign{}

// 剧情副本与精英副本.xls
type Conf_CampaignReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_CampaignReward = map[string] * Conf_CampaignReward{}

// 剧情副本与精英副本.xls
type Conf_CampainWhiteList struct { 
	CampainID int32			/*关卡白名单ID*/
	ShowCampain int32		`key`	/*表演关卡*/
} 
var MConf_CampainWhiteList = map[string] * Conf_CampainWhiteList{}

// 剧情副本与精英副本.xls
type Conf_CampaignReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_CampaignReward_act2 = map[string] * Conf_CampaignReward_act2{}

// 剧情副本与精英副本怪物.xls
type Conf_MonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_MonsterBase = map[string] * Conf_MonsterBase{}

// 剧情副本与精英副本怪物.xls
type Conf_MonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_MonsterBehavior = map[string] * Conf_MonsterBehavior{}

// 剧情副本与精英副本怪物.xls
type Conf_CampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_CampaignArmy = map[string] * Conf_CampaignArmy{}

// 剧情副本与精英副本怪物.xls
type Conf_CampaignArmy_act1 struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_CampaignArmy_act1 = map[string] * Conf_CampaignArmy_act1{}

// 剧情副本与精英副本怪物.xls
type Conf_CampaignArmy_act2 struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_CampaignArmy_act2 = map[string] * Conf_CampaignArmy_act2{}

// 功能开放表.xls
type Conf_FunctionOpen struct { 
	ID int32			/*编号*/
	FunctionType int32		`key`	/*功能类型*/
	OpenType int32			/*开放条件类型*/
	OpenLevel int32			/*条件参数*/
	LevelDescription string			/*等级描述*/
	ReviewName string			/*预告图片名称*/
	ReviewDes string			/*预告描述*/
	IsShow int32			/*显否显示预告*/
	Des string			/*功能说明*/
} 
var MConf_FunctionOpen = map[string] * Conf_FunctionOpen{}

// 功能引导.xls
type Conf_Tutorial struct { 
	Index int32			/*排序*/
	ServerID int32		`key`	/*引导标识*/
	IsForce int32			/*是否强制
0否1是*/
	ItemListID int32			/*给道具标识*/
	TriggerType int32			/*触发类型*/
	TriggerParam string			/*触发参数*/
	Scene int32			/*场景*/
	UI string			/*UI*/
	EndType int32			/*完成条件*/
	EndValue int32			/*完成参数1*/
	EndValue1 int32			/*完成参数2*/
	SpecialTag int32			/*特殊处理标记*/
	Abolish int32			/*是否废除*/
} 
var MConf_Tutorial = map[string] * Conf_Tutorial{}

// 功能引导.xls
type Conf_TutorialItemList struct { 
	ItemListID int32		`key`	/*奖励道具列表*/
	ItemID1 int32			/*道具1编号*/
	ItemNum1 int32			/*道具1数量*/
	ItemID2 int32			/*道具2编号*/
	ItemNum2 int32			/*道具2数量*/
	ItemID3 int32			/*道具3编号*/
	ItemNum3 int32			/*道具3数量*/
	ItemID4 int32			/*道具4编号*/
	ItemNum4 int32			/*道具4数量*/
	ItemID5 int32			/*道具5编号*/
	ItemNum5 int32			/*道具5数量*/
	ItemID6 int32			/*道具6编号*/
	ItemNum6 int32			/*道具6数量*/
} 
var MConf_TutorialItemList = map[string] * Conf_TutorialItemList{}

// 合成.xls
type Conf_Compose struct { 
	ID int32			/*合成ID*/
	NewMaterial1 int32			/*新物品ID*/
	Name string			/*合成名字*/
	Desc string			/*合成描述*/
	Type int32		`key`	/*合成类型*/
	Material1 int32		`key`	/*物品1ID*/
	Count1 int32			/*物品1数量*/
	Material2 int32			/*物品2ID*/
	Count2 int32			/*物品2数量*/
	Material3 int32			/*物品3ID*/
	Count3 int32			/*物品3数量*/
	Material4 int32			/*物品4ID*/
	Count4 int32			/*物品4数量*/
	Material5 int32			/*物品5ID*/
	Count5 int32			/*物品5数量*/
	Material6 int32			/*物品6ID*/
	Count6 int32			/*物品6数量*/
	NeedGold int32			/*合成消耗金币*/
} 
var MConf_Compose = map[string] * Conf_Compose{}

// 商店整合.xls
type Conf_ShopConfig struct { 
	ShopType int32		`key`	/*商店类型*/
	CellNum int32			/*货柜总数*/
	RandomType int32			/*随机类型*/
	Group int32			/*分组*/
	Model string			/*形象*/
	Refresh int32			/*能否刷新*/
} 
var MConf_ShopConfig = map[string] * Conf_ShopConfig{}

// 商店整合.xls
type Conf_ShopItemResetTime struct { 
	ID int32		`key`	/*编号ID*/
	ShopType int32			/*商店类型*/
	ResetTime int32			/*刷新时间*/
} 
var MConf_ShopItemResetTime = map[string] * Conf_ShopItemResetTime{}

// 商店整合.xls
type Conf_Shop struct { 
	ID int32		`key`	/*商品编号*/
	ShopType int32			/*商店类型*/
	SubType int32			/*商店子类*/
	Group int32			/*商品分组/排序*/
	ItemID int32			/*商品的物品模板*/
	ItemNum int32			/*出售商品的数量*/
	BuyType int32			/*购买所需货币类型*/
	BuyNum int32			/*购买所需对应货币类型的数量*/
	BuyType2 int32			/*购买所需货币类型2*/
	BuyNum2 int32			/*购买所需对应货币类型的数量2*/
	Weight int32			/*刷新商品的权重*/
	BuyTimesLimit int32			/*购买次数限制
0表示无限制*/
	LimitType int32			/*购买限制时效
1每次2每日3永久*/
	Requirement int32			/*购买条件:
荣誉商店为排名
装备商店为军团层数
公会商店为公会等级*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
	Discount int32			/*折扣显示
0表示无折扣*/
} 
var MConf_Shop = map[string] * Conf_Shop{}

// 商店整合.xls
type Conf_ShopRandom struct { 
	Share int32			/*碎片获得率*/
	Type int32			/*碎片类型*/
	PlusMinus int32			/*1正2负*/
	WeightInc int32			/*权重增减量*/
	Index int32		`key`	/*index*/
} 
var MConf_ShopRandom = map[string] * Conf_ShopRandom{}

// 商店整合.xls
type Conf_VIPShop struct { 
	ID int32		`key`	/*商品编号*/
	Type int32			/*类型（0，普通；1、金币；2、英雄经验；3、饰品经验）大于0的类型在欢乐制造机找数量和购买次数价格*/
	VIPPrivilegeID string			/*购买次数在VIP特权表Key*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
} 
var MConf_VIPShop = map[string] * Conf_VIPShop{}

// 商店整合.xls
type Conf_Shop_act1 struct { 
	ID int32		`key`	/*商品编号*/
	ShopType int32			/*商店类型*/
	SubType int32			/*商店子类*/
	Group int32			/*商品分组/排序*/
	ItemID int32			/*商品的物品模板*/
	ItemNum int32			/*出售商品的数量*/
	BuyType int32			/*购买所需货币类型*/
	BuyNum int32			/*购买所需对应货币类型的数量*/
	BuyType2 int32			/*购买所需货币类型2*/
	BuyNum2 int32			/*购买所需对应货币类型的数量2*/
	Weight int32			/*刷新商品的权重*/
	BuyTimesLimit int32			/*购买次数限制
0表示无限制*/
	LimitType int32			/*购买限制时效
1每次2每日3永久*/
	Requirement int32			/*购买条件:
荣誉商店为排名
装备商店为军团层数
公会商店为公会等级*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
	Discount int32			/*折扣显示
0表示无折扣*/
} 
var MConf_Shop_act1 = map[string] * Conf_Shop_act1{}

// 商店整合.xls
type Conf_Shop_act2 struct { 
	ID int32		`key`	/*商品编号*/
	ShopType int32			/*商店类型*/
	SubType int32			/*商店子类*/
	Group int32			/*商品分组/排序*/
	ItemID int32			/*商品的物品模板*/
	ItemNum int32			/*出售商品的数量*/
	BuyType int32			/*购买所需货币类型*/
	BuyNum int32			/*购买所需对应货币类型的数量*/
	BuyType2 int32			/*购买所需货币类型2*/
	BuyNum2 int32			/*购买所需对应货币类型的数量2*/
	Weight int32			/*刷新商品的权重*/
	BuyTimesLimit int32			/*购买次数限制
0表示无限制*/
	LimitType int32			/*购买限制时效
1每次2每日3永久*/
	Requirement int32			/*购买条件:
荣誉商店为排名
装备商店为军团层数
公会商店为公会等级*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
	Discount int32			/*折扣显示
0表示无折扣*/
} 
var MConf_Shop_act2 = map[string] * Conf_Shop_act2{}

// 圣物表.xls
type Conf_KnowledgeLevel struct { 
	Step int32		`key`	/*阶段*/
	Level int32		`key`	/*等级*/
	EffectID int32			/*效果ID*/
	Type int32			/*加成对象*/
	CampaignID int32			/*需要关卡ID*/
} 
var MConf_KnowledgeLevel = map[string] * Conf_KnowledgeLevel{}

// 圣物表.xls
type Conf_KnowledgeStep struct { 
	Step int32		`key`	/*阶段*/
	Name string			/*名称*/
	Icon int32			/*图标*/
	OpenType int32			/*激活类型
1升品（升资质）
2效果
3解锁缘分*/
	Param1 int32			/*激活参数1*/
	Param2 int32			/*激活参数2*/
	Param3 int32			/*激活参数3*/
	Param4 int32			/*激活参数4*/
	Param5 int32			/*激活参数5*/
	Param6 int32			/*激活参数6*/
	Des string			/*激活描述*/
} 
var MConf_KnowledgeStep = map[string] * Conf_KnowledgeStep{}

// 场景音乐表.xls
type Conf_BGM struct { 
	CampaignSandID string		`key`	/*场景名*/
	Music string			/*音乐名*/
} 
var MConf_BGM = map[string] * Conf_BGM{}

// 头像框商店.xls
type Conf_FrameShop struct { 
	FrameID int32		`key`	/*头像框ID*/
	Type int32			/*类型*/
	Value int32			/*类型值*/
	ICONID int32			/*头像框资源ID*/
	FrameName string			/*头像框名字*/
	FrameDesc string			/*头像框描述*/
} 
var MConf_FrameShop = map[string] * Conf_FrameShop{}

// 完整客户端.xls
type Conf_FullClientReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_FullClientReward = map[string] * Conf_FullClientReward{}

// 宝物.xls
// 宠物表.xls
// 符文表.xls
// 装备.xls
// 饰品表.xls
type Conf_EquipmentExp struct { 
	Level int32		`key`	/*当前等级*/
	Type int32		`key`	/*装备*/
	BaseExp int32			/*提升所需*/
	BaseGold int32			/*精炼需要金钱*/
	StepLevel int32			/*进阶等级限制*/
	EquipDecLevelRatio int32			/*装备分解等级返还系数*/
} 
var MConf_EquipmentExp = map[string] * Conf_EquipmentExp{}

// 宝物.xls
// 宠物表.xls
// 符文表.xls
// 装备.xls
// 饰品表.xls
type Conf_EquipmentExpGrow struct { 
	ID int32			/*参数ID*/
	Type int32		`key`	/*参数类型*/
	Idvalue int32		`key`	/*参数对应的值*/
	ExpGrow float32			/*系数*/
} 
var MConf_EquipmentExpGrow = map[string] * Conf_EquipmentExpGrow{}

// 宝物.xls
// 装备.xls
// 饰品表.xls
type Conf_EquipmentBase struct { 
	ID int32		`key`	/*装备ID*/
	Model string			/*装备模型*/
	GS int32			/*装备等级*/
	EquipmentStar int32			/*装备星级*/
	EquipAwakeNum int32			/*装备精炼次数*/
	EquipmentPart int32			/*装备部位*/
	EquipmentType int32			/*装备类型*/
	SuitID int32			/*所属套装*/
	OfferExp int32			/*被吞噬提供经验*/
	Effect1Level int32			/*效果1开启等级*/
	Effect1ID string			/*效果1ID*/
	Effect2Level int32			/*效果2开启等级*/
	Effect2ID string			/*效果2ID*/
	Effect3Level int32			/*效果3开启等级*/
	Effect3ID string			/*效果3ID*/
	Quality int32			/*初始品质*/
} 
var MConf_EquipmentBase = map[string] * Conf_EquipmentBase{}

// 宝物.xls
// 装备.xls
type Conf_EquipmentStep struct { 
	ID int32		`key`	/*装备Id*/
	Step int32		`key`	/*分段起始*/
	StepMax int32			/*分段结束*/
	StepName string			/*当前阶名*/
	StepColor int32			/*当前阶颜色*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	NeedGold int32			/*被吞噬消耗金钱*/
	EffectID string			/*效果*/
	GemHoleNum int32			/*宝石孔数*/
	MaxGemNum int32			/*最大宝石孔*/
	SpecialGemHoleType int32			/*特殊孔类型*/
	SpecialGemHoleLevel int32			/*特殊孔等级*/
	SpecialGemHoleEffect int32			/*特殊孔携带效果*/
	StepNeedGold int32			/*进阶消耗金钱*/
	Item1ID int32			/*物品1ID*/
	Item1Num int32			/*物品1数量*/
	Item2ID int32			/*物品2ID*/
	Item2Num int32			/*物品2数量*/
	Item3ID int32			/*物品3ID*/
	Item3Num int32			/*物品3数量*/
	Item4ID int32			/*物品4ID*/
	Item4Num int32			/*物品4数量*/
	Item5ID int32			/*物品5ID*/
	Item5Num int32			/*物品5数量*/
	Item6ID int32			/*物品6ID*/
	Item6Num int32			/*物品6数量*/
	EquipDecAdvancedRatio int32			/*装备分解进阶返还系数*/
} 
var MConf_EquipmentStep = map[string] * Conf_EquipmentStep{}

// 宝物.xls
// 装备.xls
// 饰品表.xls
type Conf_EquipmentActivation struct { 
	ID int32		`key`	/*装备ID*/
	Name string			/*装备名*/
	EquipmentPart int32			/*装备部位*/
	EquipmentType int32			/*装备类型*/
	ActivationLevel int32		`key`	/*激活等级*/
	Effect int32			/*激活效果*/
	Anger int32			/*增加怒气*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻技能*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发器*/
	Effect1Name string			/*开启效果名*/
	Effect1Des string			/*开启效果描述*/
} 
var MConf_EquipmentActivation = map[string] * Conf_EquipmentActivation{}

// 宝石.xls
type Conf_GemBase struct { 
	GemID int32		`key`	/*宝石ID*/
	Type int32			/*宝石类型*/
	Level int32			/*宝石等级*/
	Profile int32			/*宝石品质*/
	PhysicsAtk int32			/*提供的物理攻击*/
	MagicAtk int32			/*提供的魔法攻击*/
	PhysicsDef int32			/*提供的物理防御*/
	MagicDef int32			/*提供的魔法防御*/
	HP int32			/*提供的血量*/
	HitRate int32			/*提供的命中值*/
	DodgeRate int32			/*提供的闪避值*/
	CritRate int32			/*提供的暴击值*/
	Toughness int32			/*提供的韧性值*/
	ParryRate int32			/*提供的招架值*/
	PrecisionRate int32			/*提供的精准值*/
	ModelColor string			/*模型颜色*/
} 
var MConf_GemBase = map[string] * Conf_GemBase{}

// 宝石.xls
type Conf_GemSuit struct { 
	SuitID int32		`key`	/*宝石套装ID*/
	Type int32			/*套装类型*/
	Para1 int32			/*参数1*/
	EffectID int32			/*效果ID*/
} 
var MConf_GemSuit = map[string] * Conf_GemSuit{}

// 宝石.xls
type Conf_GemDrop struct { 
	RewardID int32		`key`	/*奖励ID*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_GemDrop = map[string] * Conf_GemDrop{}

// 宝石.xls
type Conf_GemOutput struct { 
	OutputOrder int32		`key`	/*熔炉序号*/
	Order int32			/*掉落ID*/
	NeedDiamond int32			/*消耗钻石*/
	TurnOutputOrder int32			/*可跳转熔炉序号*/
	TurnProbability int32			/*跳转熔炉概率*/
} 
var MConf_GemOutput = map[string] * Conf_GemOutput{}

// 宠物图鉴.xls
type Conf_PetShow struct { 
	ID int32		`key`	/*显示顺序*/
	PetID int32			/*宠物ID*/
	Name string			/*名称*/
	ChartShow int32			/*图鉴里的大小*/
	SceneShow int32			/*场景里的大小*/
} 
var MConf_PetShow = map[string] * Conf_PetShow{}

// 宠物表.xls
type Conf_PetBase struct { 
	ID int32		`key`	/*符文ID*/
	Model string			/*宠物模型*/
	GS int32			/*宠物资质*/
	Quality int32			/*品质*/
	RunesAwake int32			/*宠物升星上限*/
	PhysicsAtk float32			/*物攻基础*/
	MagicAtk float32			/*魔攻基础*/
	PhysicsDef float32			/*物防基础*/
	MagicDef float32			/*魔防基础*/
	HP float32			/*血量基础*/
	HitRate float32			/*命中基础*/
	DodgeRate float32			/*闪避基础*/
	CritRate float32			/*暴击基础*/
	Toughness float32			/*韧性基础*/
	ParryRate float32			/*招架基础*/
	PrecisionRate float32			/*精准基础*/
	FireUp float32			/*灼烧增加基础*/
	PoisonUp float32			/*毒伤增加基础*/
	DamageUp float32			/*最终增伤基础*/
	HealthUp float32			/*治疗量增加基础*/
	FireDown float32			/*灼烧降低基础*/
	PoisonDown float32			/*毒伤降低基础*/
	DamageDown float32			/*最终伤害降低*/
	Becured float32			/*被治疗提升基础*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	FireUpInc float32			/*灼烧增加基础*/
	PoisonUpInc float32			/*毒伤增加基础*/
	DamageUpInc float32			/*最终增伤基础*/
	HealthUpInc float32			/*治疗量提升增量*/
	FireDownInc float32			/*灼烧降低基础*/
	PoisonDownInc float32			/*毒伤降低基础*/
	DamageDownInc float32			/*最终伤害降低*/
	BecuredInc float32			/*被治疗提升增量*/
} 
var MConf_PetBase = map[string] * Conf_PetBase{}

// 宠物表.xls
type Conf_PetStep struct { 
	ID int32		`key`	/*雕文编号*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	FireUpInc float32			/*灼烧增加基础*/
	PoisonUpInc float32			/*毒伤增加基础*/
	DamageUpInc float32			/*最终增伤基础*/
	HealthUpInc float32			/*治疗量提升基础*/
	FireDownInc float32			/*灼烧降低基础*/
	PoisonDownInc float32			/*毒伤降低基础*/
	DamageDownInc float32			/*最终增伤降低*/
	BecuredInc float32			/*被治疗基础*/
} 
var MConf_PetStep = map[string] * Conf_PetStep{}

// 宠物表.xls
type Conf_PetEffect struct { 
	PetID int32		`key`	/*宠物ID*/
	EffectNeedStar int32		`key`	/*激活需要的等级*/
	EffectNum int32			/*升星激活效果*/
	Icon string			/*效果图标*/
	Anger int32			/*增加怒气*/
	Trrigers string			/*触发器*/
} 
var MConf_PetEffect = map[string] * Conf_PetEffect{}

// 对白表.xls
type Conf_Dialogue struct { 
	ID int32		`key`	/*对白ID*/
	Index int32		`key`	/*对白顺序*/
	Model string			/*对白模型*/
	Name string			/*对白名称
填1代表主角名称*/
	Side int32			/*显示左右
1左2右*/
	Dialogue string			/*对白内容*/
} 
var MConf_Dialogue = map[string] * Conf_Dialogue{}

// 屏蔽字.xls
type Conf_ShieldingWord struct { 
	ID int32		`key`	/*唯一ID*/
	Word string			/*关键字*/
} 
var MConf_ShieldingWord = map[string] * Conf_ShieldingWord{}

// 属性等级系数表.xls
type Conf_LevelCoefficient struct { 
	Level int32		`key`	/*等级*/
	HitDodge
 float32			/*命中闪避系数*/
	CritToughness float32			/*暴击韧性系数*/
	ParryPrecision float32			/*招架精准系数*/
} 
var MConf_LevelCoefficient = map[string] * Conf_LevelCoefficient{}

// 开服嘉年华.xls
type Conf_CarnivalOpenDay struct { 
	OpenDay int32		`key`	/*开服第几天*/
	FunctionId int32			/*功能id*/
	FunctionName string			/*#功能名称*/
} 
var MConf_CarnivalOpenDay = map[string] * Conf_CarnivalOpenDay{}

// 开服嘉年华.xls
type Conf_CarnivalItems struct { 
	Id int32		`key`	/*唯一标识*/
	FunctionId int32		`key`	/*功能id*/
	SubFunctionId int32		`key`	/*子功能id*/
	SubFunctionValue1 int32			/*子功能要求*/
	SubFunctionValue2 int32			/*子功能要求2*/
	RewardId int32			/*奖励id*/
	JumpId int32			/*功能跳转*/
	SubFunctionName string			/*子功能名称*/
	SubFunctionDesc string			/*子功能项目描述*/
} 
var MConf_CarnivalItems = map[string] * Conf_CarnivalItems{}

// 开服嘉年华.xls
type Conf_CarnivalTotle struct { 
	GetCount int32		`key`	/*领取所需完成条数*/
	RewardId int32			/*奖励编号*/
} 
var MConf_CarnivalTotle = map[string] * Conf_CarnivalTotle{}

// 开服嘉年华.xls
type Conf_CarnivalReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_CarnivalReward = map[string] * Conf_CarnivalReward{}

// 开服嘉年华.xls
type Conf_CarnivaSell struct { 
	ID int32		`key`	/*主键ID*/
	OpenDay int32		`key`	/*开服第几天*/
	PageName string			/*分页名称*/
	SaleType int32			/*购买货币*/
	SaleValue1 int32			/*购买前价格*/
	SaleValue2 int32			/*实际购买价格*/
	ItemID int32			/*道具ID*/
	ItemNum int32			/*道具数量*/
	BuyNum int32			/*可购买次数*/
	ShowItem int32			/*是否显示奖励预览*/
	ShowItemID string			/*奖励预览*/
} 
var MConf_CarnivaSell = map[string] * Conf_CarnivaSell{}

// 开服嘉年华.xls
type Conf_CarnivalItems_act2 struct { 
	Id int32		`key`	/*唯一标识*/
	FunctionId int32		`key`	/*功能id*/
	SubFunctionId int32		`key`	/*子功能id*/
	SubFunctionValue1 int32			/*子功能要求*/
	SubFunctionValue2 int32			/*子功能要求2*/
	RewardId int32			/*奖励id*/
	JumpId int32			/*功能跳转*/
	SubFunctionName string			/*子功能名称*/
	SubFunctionDesc string			/*子功能项目描述*/
} 
var MConf_CarnivalItems_act2 = map[string] * Conf_CarnivalItems_act2{}

// 开服嘉年华.xls
type Conf_CarnivalReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_CarnivalReward_act2 = map[string] * Conf_CarnivalReward_act2{}

// 开服排行.xls
type Conf_BeginRank struct { 
	Id int32		`key`	/*唯一标识*/
	FunctionId int32			/*功能id*/
	SubFunctionValue1 int32			/*子功能要求*/
	SubFunctionValue2 int32			/*子功能要求2*/
	RewardId int32			/*奖励id*/
} 
var MConf_BeginRank = map[string] * Conf_BeginRank{}

// 开服排行.xls
type Conf_BeginRankReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BeginRankReward = map[string] * Conf_BeginRankReward{}

// 开服排行.xls
type Conf_BeginRankNotice struct { 
	Id int32		`key`	/*编号*/
	Desc string			/*小跑马灯描述*/
} 
var MConf_BeginRankNotice = map[string] * Conf_BeginRankNotice{}

// 开服签到.xls
type Conf_BeginCheckIn struct { 
	OpenDay int32		`key`	/*签到天数*/
	RewardID int32			/*奖励id*/
} 
var MConf_BeginCheckIn = map[string] * Conf_BeginCheckIn{}

// 开服签到.xls
type Conf_BeginCheckInReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BeginCheckInReward = map[string] * Conf_BeginCheckInReward{}

// 怪物强度表.xls
type Conf_Monster struct { 
	Level int32		`key`	/*等级*/
	PhysicsAtk int32			/*物攻*/
	MagicAtk int32			/*魔攻*/
	PhysicsDef int32			/*物防*/
	MagicDef int32			/*魔防*/
	HP int32			/*血量*/
	HitRate int32			/*命中*/
	DodgeRate int32			/*闪避*/
	CritRate int32			/*暴击*/
	Toughness int32			/*韧性*/
	ParryRate int32			/*招架*/
	PrecisionRate int32			/*精准*/
} 
var MConf_Monster = map[string] * Conf_Monster{}

// 怪物强度表.xls
type Conf_MonsterType struct { 
	Type int32		`key`	/*职业类型*/
	PhysicsAtk float32			/*物攻系数*/
	MagicAtk float32			/*魔攻系数*/
	PhysicsDef float32			/*物防系数*/
	MagicDef float32			/*魔防系数*/
	HP float32			/*血量系数*/
	HitRate float32			/*命中系数*/
	DodgeRate float32			/*闪避系数*/
	CritRate float32			/*暴击系数*/
	Toughness float32			/*韧性系数*/
	ParryRate float32			/*招架系数*/
	PrecisionRate float32			/*精准系数*/
} 
var MConf_MonsterType = map[string] * Conf_MonsterType{}

// 怪物强度表.xls
type Conf_MonsterPP struct { 
	ID int32		`key`	/*强度类型*/
	PhysicsAtk float32			/*物攻系数*/
	MagicAtk float32			/*魔攻系数*/
	PhysicsDef float32			/*物防系数*/
	MagicDef float32			/*魔防系数*/
	HP float32			/*血量系数*/
	HitRate float32			/*命中系数*/
	DodgeRate float32			/*闪避系数*/
	CritRate float32			/*暴击系数*/
	Toughness float32			/*韧性系数*/
	ParryRate float32			/*招架系数*/
	PrecisionRate float32			/*精准系数*/
	MonsterStarStr float32			/*资质系数*/
	MonsterTypeStr float32			/*怪物类型系数*/
} 
var MConf_MonsterPP = map[string] * Conf_MonsterPP{}

// 怪物强度表.xls
type Conf_Monster_act2 struct { 
	Level int32		`key`	/*等级*/
	PhysicsAtk int32			/*物攻*/
	MagicAtk int32			/*魔攻*/
	PhysicsDef int32			/*物防*/
	MagicDef int32			/*魔防*/
	HP int32			/*血量*/
	HitRate int32			/*命中*/
	DodgeRate int32			/*闪避*/
	CritRate int32			/*暴击*/
	Toughness int32			/*韧性*/
	ParryRate int32			/*招架*/
	PrecisionRate int32			/*精准*/
} 
var MConf_Monster_act2 = map[string] * Conf_Monster_act2{}

// 我要变强.xls
type Conf_WantStrong struct { 
	ID int32		`key`	/*编号*/
	FunctionType int32			/*功能类型*/
	FunctionName string			/*名称*/
	Icon string			/*图标ID*/
} 
var MConf_WantStrong = map[string] * Conf_WantStrong{}

// 战场奖励表.xls
type Conf_BattlefieldFightReward struct { 
	RewardType int32		`key`	/*奖励类型*/
	RewardCondition int32		`key`	/*奖励条件*/
	Score int32			/*奖励积分*/
	ConquerPoints int32			/*奖励征服点数*/
} 
var MConf_BattlefieldFightReward = map[string] * Conf_BattlefieldFightReward{}

// 战场奖励表.xls
type Conf_BattlefieldGradeReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BattlefieldGradeReward = map[string] * Conf_BattlefieldGradeReward{}

// 战斗公用资源加载表.xls
type Conf_FightCommonList struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
} 
var MConf_FightCommonList = map[string] * Conf_FightCommonList{}

// 战斗力公式系数.xls
type Conf_BattleEffectiveness struct { 
	ID int32		`key`	/*主键ID，指代职业*/
	PhysicsAtkPoint float32			/*物攻系数*/
	MagicAtkPoint float32			/*魔攻系数*/
	PhysicsDefPoint float32			/*物防系数*/
	MagicDefPoint float32			/*魔防系数*/
	HPPoint float32			/*血量系数*/
	HitRatePoint float32			/*命中系数*/
	DodgeRatePoint float32			/*闪避系数*/
	CritRatePoint float32			/*暴击系数*/
	ToughnessPoint float32			/*韧性系数*/
	ParryRatePoint float32			/*招架系数*/
	PrecisionRatePoint float32			/*精准系数*/
	FireUpPoint float32			/*灼烧增加基础*/
	PoisonUpPoint float32			/*毒伤增加基础*/
	DamageUpPoint float32			/*最终增伤基础*/
	FireDownPoint float32			/*灼烧降低基础*/
	PoisonDownPoint float32			/*毒伤降低基础*/
	DamageDownPoint float32			/*最终增伤降低*/
	HealthUpPoint float32			/*治疗量增加*/
	BecuredPoint float32			/*被治疗量增加*/
} 
var MConf_BattleEffectiveness = map[string] * Conf_BattleEffectiveness{}

// 战斗引导.xls
type Conf_FigthTutorial struct { 
	Order int32		`key`	/*引导编号*/
	Index int32		`key`	/*引导步骤*/
	Type int32			/*引导类型
1剧情对话
2点击场景或模型
3点击UI*/
	Name string			/*剧情对白显示角色名*/
	ModelName string			/*剧情对白角色模型*/
	Dialog string			/*剧情对白文本内容*/
	GameStop int32			/*是否暂停战斗
1暂停0正常*/
	Obj string			/*创建物体
物体和位置点必须同时存在
RS1 - 移动引导地面特效
RS2 - 集火图标
RS3 - 队长移动图片
RS4 - 全队移动图片*/
	Pos string			/*创建位置：
xx@xx@xx表示为地图上的一个点
Enemyxx表示为界面上一个HUD控件，挂载为Enemyxx角色
Imagexx@xx@xx表示在界面上加一个图片，位置为xx，xx*/
	Force int32			/*是否强制引导*/
	ToNextTime int32			/*切换下一条的时间*/
	InputMouse int32			/*要求鼠标操作
0、单击或双击
1、单击
2、双击
3、点击pos指定的怪*/
	InputPos int32			/*点击位置
1-5英雄技能
6自动战斗
7自动技能*/
	InputMap int32			/*点击穿透*/
	PlayerIndex int32			/*弹出说话气泡的角色位置
无则填0*/
	BubbleText string			/*气泡文本内容*/
	DialogBoxPos string			/*提示精灵位置
指离引导点击位置中心的偏移坐标*/
	DialogBox string			/*精灵提示文本*/
	DispatchTips int32			/*是否派送提醒文字
大于等于1表示派送提示信息内容
0表示不派送，保持上一条提示
2表示可以开启手动操作（序章专用）*/
	TipsText string			/*派送文字内容*/
	Audio int32			/*语音提示*/
} 
var MConf_FigthTutorial = map[string] * Conf_FigthTutorial{}

// 战斗成就描述表.xls
type Conf_AchievementDesc struct { 
	ID int32		`key`	/*描述ID*/
	Desc string			/*描述内容*/
} 
var MConf_AchievementDesc = map[string] * Conf_AchievementDesc{}

// 战斗阶段镜头配置.xls
type Conf_CameraConfig struct { 
	ID int32		`key`	/*唯一标示*/
	Name string			/*名字描述*/
	Hight int32			/*镜头高度*/
	Percent int32			/*镜头纵向百分比位置*/
	Angle int32			/*镜头角度*/
	Rotate int32			/*镜头旋转*/
} 
var MConf_CameraConfig = map[string] * Conf_CameraConfig{}

// 手机推送.xls
type Conf_Push struct { 
	Id int32		`key`	/*推送id*/
	PushType int32			/*推送类型*/
	PushParam int32			/*推送参数*/
	PushTitle string			/*标题*/
	PushText string			/*推送文字*/
	PushSound string			/*声音*/
} 
var MConf_Push = map[string] * Conf_Push{}

// 技能.xls
type Conf_SkillBase struct { 
	ID string		`key`	/*ID*/
	Name string			/*Name*/
	TreeName string			/*技能树名*/
	Text string			/*技能简介*/
	Desc string			/*技能描述*/
	SkillType string			/*技能类型*/
	Skillactivetype string			/*主动类型*/
	Addtype string			/*添加类型*/
	Coverbuffs string			/*覆盖*/
	Becoverbuffs string			/*被覆盖*/
	Resname string			/*资源名*/
	CD float32			/*技能CD*/
	BeginCD float32			/*技能入场CD*/
	SkillKind string			/*大招技能类型*/
	Icon string			/*技能图标*/
	HandedSkill int32			/*是否手动释放（1是，0否）*/
	ShowBuffIcon int32			/*buff图标*/
	FightingStrength float32			/*技能战斗力*/
	FightingBeginStrength float32			/*技能初始战斗力*/
} 
var MConf_SkillBase = map[string] * Conf_SkillBase{}

// 技能.xls
type Conf_SkillStrength struct { 
	SkillID string		`key`	/*技能ID*/
	TemplateName string			/*技能名*/
	GainRagePoint int32			/*主动技能释放获得怒气*/
	A float32			/*A*/
	B float32			/*B*/
	C float32			/*C*/
	D float32			/*D*/
	E float32			/*E（概率1）*/
	F float32			/*F（概率2）*/
	G float32			/*G*/
	H float32			/*H*/
	I float32			/*I*/
	J float32			/*J*/
	K float32			/*K*/
	L float32			/*L*/
	M float32			/*M*/
	N float32			/*N*/
	O float32			/*O*/
	P float32			/*P*/
	Q float32			/*Q*/
	R float32			/*R*/
	S float32			/*S*/
	T float32			/*T*/
	U float32			/*U*/
	V float32			/*V*/
	W float32			/*W*/
	X float32			/*X*/
	Y float32			/*Y*/
	Z float32			/*Z*/
} 
var MConf_SkillStrength = map[string] * Conf_SkillStrength{}

// 技能.xls
type Conf_SkillPassive struct { 
	ID string		`key`	/*被动技能ID*/
	Name string			/*技能名*/
	Formula int32			/*引用的公式*/
	AttributeUp int32			/*增加的属性*/
} 
var MConf_SkillPassive = map[string] * Conf_SkillPassive{}

// 技能.xls
type Conf_SkillExp struct { 
	Level int32		`key`	/*当前等级*/
	NeedExp int32			/*升到当前等级需要经验*/
	NeedGold int32			/*升到当前等级需要金币*/
	NeedSkillPoint int32			/*升级所需技能点*/
	SkillRatio int32			/*英雄分解返还系数*/
} 
var MConf_SkillExp = map[string] * Conf_SkillExp{}

// 护送.xls
type Conf_ConvoyStarProbability struct { 
	Star int32		`key`	/*星级*/
	StarProbability1 int32			/*1星概率*/
	StarProbability2 int32			/*2星概率*/
	StarProbability3 int32			/*3星概率*/
	StarProbability4 int32			/*4星概率*/
	StarProbability5 int32			/*5星概率*/
	GoldGrow float32			/*金币奖励系数*/
	ConquerGrow float32			/*征服点数奖励系数*/
	ConvoyTime int32			/*护送时间(分钟）*/
	AddPowerRate int32			/*护送战力百分比加成*/
} 
var MConf_ConvoyStarProbability = map[string] * Conf_ConvoyStarProbability{}

// 护送.xls
type Conf_ConvoyReward struct { 
	Lv int32		`key`	/*等级*/
	RewardItemNum1 int32			/*金币奖励数量*/
	RewardItemNum2 int32			/*征服点数奖励数量*/
} 
var MConf_ConvoyReward = map[string] * Conf_ConvoyReward{}

// 护送.xls
type Conf_ConvoyMap struct { 
	CampaignID int32		`key`	/*关卡ID*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_ConvoyMap = map[string] * Conf_ConvoyMap{}

// 换装表.xls
type Conf_ModelClothesBase struct { 
	ID int32		`key`	/*时装ID*/
	ShowID int32			/*显示用序列*/
	Name string			/*名称*/
	Model string			/*时装模型*/
	Icon int32			/*头像*/
	Desc string			/*时装描述*/
	VipLv int32			/*VIP等级*/
	ItemType int32			/*消耗类型*/
	Price int32			/*价格*/
	AttriType int32			/*属性类型*/
	FirstHandValue int32			/*先手值*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
} 
var MConf_ModelClothesBase = map[string] * Conf_ModelClothesBase{}

// 推荐阵容.xls
type Conf_RecommendTroops struct { 
	NameID int32			/*ID*/
	HeroPhyle int32		`key`	/*阵营*/
	GroupCount int32		`key`	/*组数*/
	Name string			/*名称*/
	Hero1 int32			/*英雄1*/
	Hero2 int32			/*英雄2*/
	Hero3 int32			/*英雄3*/
	Hero4 int32			/*英雄4*/
	Hero5 int32			/*英雄5*/
	Explain string			/*说明*/
} 
var MConf_RecommendTroops = map[string] * Conf_RecommendTroops{}

// 效果.xls
type Conf_Effect struct { 
	ID int32		`key`	/*主键，唯一ID*/
	Name string			/*效果名*/
	Desc string			/*描述*/
	Type int32			/*类型*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	SkillID string			/*携带技能ID*/
} 
var MConf_Effect = map[string] * Conf_Effect{}

// 新手流程节点表.xls
type Conf_PlayerClick struct { 
	ID int32			/*编号ID*/
	Type int32		`key`	/*类型*/
	Value int32		`key`	/*参数编号*/
} 
var MConf_PlayerClick = map[string] * Conf_PlayerClick{}

// 日常活动表.xls
type Conf_DailyActivities struct { 
	ActivityID int32			/*活动编号,唯一主键*/
	ActivityType string		`key`	/*活动类型*/
	Name string			/*活动名称*/
	Description string			/*活动说明*/
	Monday int32			/*周一*/
	Tuesday int32			/*周二*/
	Wednesday int32			/*周三*/
	Thursday int32			/*周四*/
	Friday int32			/*周五*/
	Saturday int32			/*周六*/
	Sunday int32			/*周日*/
	OpenTime int32			/*活动开启时间（分）
如20点即：20x60=1200*/
	Duration int32			/*活动持续时间(分）*/
} 
var MConf_DailyActivities = map[string] * Conf_DailyActivities{}

// 时光之穴副本.xls
type Conf_TimeCaveChapter struct { 
	CampaignChapterID int32		`key`	/*章节ID，主键唯一不可重复*/
	CampaignChapterName string			/*章节名称*/
	Model string			/*预览Boss模型*/
	OpenDay string			/*开放时间（星期几）*/
	Desc string			/*Boss描述*/
} 
var MConf_TimeCaveChapter = map[string] * Conf_TimeCaveChapter{}

// 时光之穴副本.xls
type Conf_TimeCaveCampaign struct { 
	CampaignChapterID int32			/*章节ID，对应章节信息表上的章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignDesc string			/*副本描述*/
	CampaignOpeningLevel int32			/*关卡开放所需玩家等级*/
	PreposeCampaignID int32			/*开放此关卡前置关卡ID*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	DropOneStar int32			/*1星奖励ID*/
	DropTwoStar int32			/*2星奖励ID*/
	DropThreeStar int32			/*3星奖励ID*/
} 
var MConf_TimeCaveCampaign = map[string] * Conf_TimeCaveCampaign{}

// 时光之穴副本.xls
type Conf_TimeCaveCampaignReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_TimeCaveCampaignReward = map[string] * Conf_TimeCaveCampaignReward{}

// 时光之穴副本.xls
type Conf_TimeCaveDropChest struct { 
	ID int32		`key`	/*主键，ID唯一不可更改*/
	CampaignID int32			/*关卡ID*/
	Group int32			/*商品分组/排序*/
	ItemID int32			/*道具ID*/
	ItemNum int32			/*道具数量*/
	Weight int32			/*组内权重*/
	GroupWeight int32			/*分组权重*/
} 
var MConf_TimeCaveDropChest = map[string] * Conf_TimeCaveDropChest{}

// 时光之穴副本怪物.xls
type Conf_TimeCaveMonsterBase struct { 
	ID int32		`key`	/*怪物ID*/
	Name string			/*怪物名称*/
	MonsterJob string			/*怪物职业*/
	Desc string			/*备注*/
	Model string			/*模型名称*/
	Icon string			/*头像图标*/
	MonsterType int32			/*怪物类型*/
	MonsterDamageType int32			/*怪物伤害类型*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
} 
var MConf_TimeCaveMonsterBase = map[string] * Conf_TimeCaveMonsterBase{}

// 时光之穴副本怪物.xls
type Conf_TimeCaveMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_TimeCaveMonsterBehavior = map[string] * Conf_TimeCaveMonsterBehavior{}

// 时光之穴副本怪物.xls
type Conf_TimeCaveCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*当前序号调用怪物强度ID等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterBehaviorID int32			/*当前序号调用怪物行为的ID*/
} 
var MConf_TimeCaveCampaignArmy = map[string] * Conf_TimeCaveCampaignArmy{}

// 服务器消息表.xls
type Conf_SeverString struct { 
	Tag string		`key`	/*标识*/
	Text string			/*文本*/
} 
var MConf_SeverString = map[string] * Conf_SeverString{}

// 次数找回数据表.xls
type Conf_ActivityBack struct { 
	ActivityID int32		`key`	/*系统ID*/
	ChildID int32		`key`	/*子系统*/
	Icon int32			/*系统图片*/
	ActivityName string			/*系统名称*/
	ActivityDesc string			/*内容描述*/
	Money int32			/*单次次数找回金额*/
	MoneyType int32			/*货币类型*/
	BackNum int32			/*找回数量*/
	Sort int32			/*排序*/
} 
var MConf_ActivityBack = map[string] * Conf_ActivityBack{}

// 欢乐制造机.xls
type Conf_JoyMachine struct { 
	ID int32		`key`	/*主键ID*/
	Type string			/*类型*/
	Name string			/*类型名*/
	FreeTimes int32			/*免费次数*/
	NeedLevel int32			/*等级限制*/
} 
var MConf_JoyMachine = map[string] * Conf_JoyMachine{}

// 欢乐制造机.xls
type Conf_JoyMachineOutput struct { 
	Grade int32		`key`	/*等级*/
	GoldOutput int32			/*金币产出*/
	HeroExpOutput int32			/*经验英雄产出ID*/
	HeroExpOutputNum int32			/*经验英雄产出数量*/
	EquipmentExpOutput int32			/*经验装备产出ID*/
	EquipmentExpOutputNum int32			/*经验装备产出数量*/
	SkillExpOutput int32			/*技能经验产出*/
	TalentExpOutput int32			/*雕文经验产出ID*/
	TalentExpOutputNum int32			/*雕文经验产出数量*/
} 
var MConf_JoyMachineOutput = map[string] * Conf_JoyMachineOutput{}

// 欢乐制造机.xls
type Conf_JoyMachinePrice struct { 
	Time int32		`key`	/*次数*/
	GoldPrice int32			/*金币价格*/
	Discount1 int32			/*折扣显示1*/
	GoldDoubleCrit int32			/*金币二倍暴击几率（1000000为100%）*/
	GoldFourCrit int32			/*金币四倍暴击几率（1000000为100%）*/
	HeroExpPrice int32			/*英雄经验价格*/
	Discount2 int32			/*折扣显示2*/
	HeroExpDoubleCrit int32			/*英雄经验二倍暴击几率（1000000为100%）*/
	HeroExpFourCrit int32			/*英雄经验四倍暴击几率（1000000为100%）*/
	EquipmentExpPrice int32			/*装备经验价格*/
	EquipmentExpDoubleCrit int32			/*装备经验二倍暴击几率（1000000为100%）*/
	EquipmentExpFourCrit int32			/*装备经验四倍暴击几率（1000000为100%）*/
	SkillExpPrice int32			/*技能经验价格*/
	SkillExpDoubleCrit int32			/*技能经验二倍暴击几率（1000000为100%）*/
	SkillExpFourCrit int32			/*技能经验四倍暴击几率（1000000为100%）*/
	TalentExpPrice int32			/*雕文经验价格*/
	Discount3 int32			/*折扣显示3*/
	TalentExpDoubleCrit int32			/*雕文经验二倍暴击几率（1000000为100%）*/
	TalentExpFourCrit int32			/*雕文经验四倍暴击几率（1000000为100%）*/
} 
var MConf_JoyMachinePrice = map[string] * Conf_JoyMachinePrice{}

// 每日目标汇总.xls
type Conf_daily struct { 
	Index int32			/*编号*/
	Name string			/*功能名称*/
	FuncID int32		`key`	/*功能编号*/
	ModuleParameter int32		`key`	/*功能跳转*/
	Icon string			/*功能图标*/
	Des string			/*功能产出*/
	NotOpen string			/*未开启*/
	ProDesc1 string			/*描述1*/
	ProDesc2 string			/*描述2*/
	ProDesc3 string			/*描述2*/
	Over string			/*任务结束*/
} 
var MConf_daily = map[string] * Conf_daily{}

// 白虎寺试炼.xls
type Conf_TempleChapter struct { 
	TempleChapterID int32		`key`	/*章节ID，主键唯一不可重复*/
	TempleChapterName string			/*资源副本章节名称*/
	TempleChapterOpeningTime string			/*资源副本章节开放时间（星期）*/
	TempleChapterChallengeTime int32			/*每日可挑战次数*/
	RewardReview string			/*奖励预览类型*/
} 
var MConf_TempleChapter = map[string] * Conf_TempleChapter{}

// 白虎寺试炼.xls
type Conf_TempleCampaign struct { 
	TempleChapterID int32			/*章节ID，对应章节信息表上的章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignLevel int32			/*关卡等级*/
	CampaignName string			/*关卡名称*/
	CampaignDesc string			/*关卡备注*/
	MonsterReviewID string			/*怪物预览*/
	CampaignOpeningLevel int32			/*关卡开放所需玩家等级*/
	CampaignChallengeTime int32			/*每天可挑战次数上限*/
	TempleReward int32			/*奖励*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	BattleJob string			/*允许进入的职业*/
	ItemReviewWord string			/*掉落装备预览文字*/
} 
var MConf_TempleCampaign = map[string] * Conf_TempleCampaign{}

// 白虎寺试炼.xls
type Conf_TempleRward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_TempleRward = map[string] * Conf_TempleRward{}

// 白虎寺试炼怪物.xls
type Conf_TempleMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob int32			/*ee*/
	Desc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
} 
var MConf_TempleMonsterBase = map[string] * Conf_TempleMonsterBase{}

// 白虎寺试炼怪物.xls
type Conf_TempleMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_TempleMonsterBehavior = map[string] * Conf_TempleMonsterBehavior{}

// 白虎寺试炼怪物.xls
type Conf_TempleCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterSide int32			/*怪物阵营*/
	Type1 int32			/*怪物类型1*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID/英雄ID*/
	Level int32			/*怪物等级/英雄等级*/
	Type int32			/*怪物类型/英雄阶数*/
	ID int32			/*怪物强度系数ID*/
	MonsterBehaviorID int32			/*当前序号调用怪物行为的ID*/
} 
var MConf_TempleCampaignArmy = map[string] * Conf_TempleCampaignArmy{}

// 目标引导.xls
type Conf_ObjectiveLeading struct { 
	ID int32		`key`	/*主键ID，唯一不可重复*/
	SubFunctionId int32			/*功能ID*/
	ConditionType int32			/*完成条件类型*/
	Condition int32			/*任务达成条件*/
	Progress int32			/*任务进度*/
	Name string			/*任务名称*/
	Icon string			/*任务ICON*/
	Desc string			/*任务描述*/
	Order int32			/*完成任务奖励*/
	Index int32			/*显示排序*/
} 
var MConf_ObjectiveLeading = map[string] * Conf_ObjectiveLeading{}

// 目标引导.xls
type Conf_ObjectiveLeadingReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ObjectiveLeadingReward = map[string] * Conf_ObjectiveLeadingReward{}

// 目标引导.xls
type Conf_ObjectiveLeadingReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ObjectiveLeadingReward_act2 = map[string] * Conf_ObjectiveLeadingReward_act2{}

// 神器.xls
type Conf_Artifact struct { 
	JobType int32		`key`	/*职业类型（1.坦克，2近战，3.远程，4.治疗）*/
	JobId int32		`key`	/*序号ID*/
	ArtifactName string			/*节点名称*/
	AttributeType int32			/*属性点类型（1.属性，2技能）*/
	AddAttributeType string			/*技能ID/增加属性类型（1.生命，2，物攻，3法攻，4物防，5魔防，6暴击，7韧性，8命中，9闪避，10精准，11招架*/
	FrontPoint string			/*前置点*/
	ActivationCondition int32			/*激活条件*/
	PointMaxLv int32			/*等级*/
	Lv1AddAttribute int32			/*1级增加属性*/
	Lv2AddAttribute int32			/*2级增加属性*/
	Lv3AddAttribute int32			/*3级增加属性*/
	Lv4AddAttribute int32			/*4级增加属性*/
	Lv5AddAttribute int32			/*5级增加属性*/
	Lv6AddAttribute int32			/*6级增加属性*/
	Lv7AddAttribute int32			/*7级增加属性*/
	Lv8AddAttribute int32			/*8级增加属性*/
	Lv9AddAttribute int32			/*9级增加属性*/
	Lv10AddAttribute int32			/*10级增加属性*/
	ArtifactDes string			/*描述*/
	ArtifactIcon string			/*图标*/
} 
var MConf_Artifact = map[string] * Conf_Artifact{}

// 神器.xls
type Conf_ArtifactCost struct { 
	ArtifactLv int32		`key`	/*神器等级*/
	EnergyCost int32			/*消耗神器能量*/
} 
var MConf_ArtifactCost = map[string] * Conf_ArtifactCost{}

// 神器模型.xls
type Conf_ArtifactModel struct { 
	ArtifactType int32		`key`	/*神器类型（1.坦克2.近战3.远程4.治疗）*/
	ArtifactName string			/*神器模型名*/
} 
var MConf_ArtifactModel = map[string] * Conf_ArtifactModel{}

// 神秘宝库.xls
type Conf_ResourceChapter struct { 
	ResourceChapterID int32		`key`	/*章节ID，主键唯一不可重复*/
	ResourceChapterName string			/*资源副本章节名称*/
	ResourceChapterOpeningTime string			/*资源副本章节开放时间（星期）*/
	ResourceChapterChallengeTime int32			/*每日可挑战次数*/
	RewardReview int32			/*奖励预览类型*/
	ResourceChapterMessage string			/*章节介绍*/
	ResourceChapterTxt string			/*章节开放描述*/
} 
var MConf_ResourceChapter = map[string] * Conf_ResourceChapter{}

// 神秘宝库.xls
type Conf_ResourceCampaign struct { 
	ResourceChapterID int32			/*章节ID，对应章节信息表上的章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignLevel int32			/*关卡等级*/
	CampaignName string			/*关卡名称*/
	CampaignDesc string			/*关卡备注*/
	MonsterReviewID string			/*怪物预览*/
	CampaignOpeningLevel int32			/*关卡开放所需玩家等级*/
	CampaignChallengeTime int32			/*每天可挑战次数上限*/
	FightType string			/*模式*/
	RoundNum int32			/*限制回合数*/
	WinConDes string			/*胜利条件描述*/
	RewardType string			/*奖励类型*/
	MaxItem int32			/*最高奖励道具*/
	RewardMax string			/*奖励极限*/
	Weight string			/*掉落权重*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_ResourceCampaign = map[string] * Conf_ResourceCampaign{}

// 神秘宝库怪物.xls
type Conf_ResourceMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_ResourceMonsterBase = map[string] * Conf_ResourceMonsterBase{}

// 神秘宝库怪物.xls
type Conf_ResourceMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_ResourceMonsterBehavior = map[string] * Conf_ResourceMonsterBehavior{}

// 神秘宝库怪物.xls
type Conf_ResourceCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_ResourceCampaignArmy = map[string] * Conf_ResourceCampaignArmy{}

// 祭坛.xls
type Conf_EquipDecomposeExtra struct { 
	Id int32		`key`	/*唯一id*/
	Star int32			/*装备星级*/
	Gs int32			/*装备等级*/
	Item_id int32			/*物品id*/
	Num int32			/*数量*/
} 
var MConf_EquipDecomposeExtra = map[string] * Conf_EquipDecomposeExtra{}

// 祭坛.xls
type Conf_ResolveHero struct { 
	Type int32		`key`	/*英雄类型
1整体2碎片*/
	StarStrength int32		`key`	/*资质/装等*/
	ResolveID int32			/*回收道具*/
	ResolveNum int32			/*回收数量*/
} 
var MConf_ResolveHero = map[string] * Conf_ResolveHero{}

// 祭坛.xls
type Conf_ResolveEquipment struct { 
	Type int32		`key`	/*装备类型
1整体2碎片*/
	StarStrength int32		`key`	/*装等*/
	ResolveID int32			/*回收道具*/
	ResolveNum int32			/*回收数量*/
} 
var MConf_ResolveEquipment = map[string] * Conf_ResolveEquipment{}

// 祭坛.xls
type Conf_ResolveTreasure struct { 
	Type int32		`key`	/*神器（宝物）类型
1整体2碎片*/
	StarStrength int32		`key`	/*装等*/
	ResolveID int32			/*回收道具*/
	ResolveNum int32			/*回收数量*/
} 
var MConf_ResolveTreasure = map[string] * Conf_ResolveTreasure{}

// 祭坛.xls
type Conf_ResolveRunes struct { 
	StarStrength int32		`key`	/*装等*/
	ResolveID int32		`key`	/*回收道具*/
	ResolveNum int32			/*回收数量*/
} 
var MConf_ResolveRunes = map[string] * Conf_ResolveRunes{}

// 祭坛.xls
type Conf_ResolvePet struct { 
	Type int32		`key`	/*宠物类型
1整体2碎片*/
	StarStrength int32		`key`	/*装等*/
	ResolveID int32			/*回收道具*/
	ResolveNum int32			/*回收数量*/
} 
var MConf_ResolvePet = map[string] * Conf_ResolvePet{}

// 禁魔监狱怪物.xls
type Conf_PrisonMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	KillAttribute int32			/*击杀增加属性*/
	AttributeValue int32			/*增加值*/
} 
var MConf_PrisonMonsterBase = map[string] * Conf_PrisonMonsterBase{}

// 禁魔监狱怪物.xls
type Conf_PrisonBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_PrisonBehavior = map[string] * Conf_PrisonBehavior{}

// 禁魔监狱怪物.xls
type Conf_PrisonCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32			/*关卡内怪物序号*/
	MonsterSide int32			/*怪物阵营*/
	Type1 int32			/*怪物类型1*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID/英雄ID*/
	Level int32			/*怪物等级/英雄等级（不用）*/
	Type int32			/*怪物类型/英雄阶数*/
	ID int32			/*怪物强度系数ID*/
	MonsterBehaviorID int32			/*当前序号调用怪物行为的ID*/
} 
var MConf_PrisonCampaignArmy = map[string] * Conf_PrisonCampaignArmy{}

// 禁魔监狱表.xls
type Conf_Prison struct { 
	PrisonLevel int32		`key`	/*层数*/
	PrisonStar int32		`key`	/*星级*/
	StarUp int32			/*刷星价格*/
	StarUpProbability int32			/*直接5星概率*/
	PrisonDifficulty int32			/*怪物等级*/
	PrisonRewardID int32			/*奖励ID*/
} 
var MConf_Prison = map[string] * Conf_Prison{}

// 禁魔监狱表.xls
type Conf_PrisonReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_PrisonReward = map[string] * Conf_PrisonReward{}

// 禁魔监狱表.xls
type Conf_PrisonCampaign struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Campaign int32			/*关卡概率*/
	MonsterReviewID int32			/*怪物预览*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_PrisonCampaign = map[string] * Conf_PrisonCampaign{}

// 福利大厅.xls
type Conf_Welfare struct { 
	ID int32		`key`	/*主键ID*/
	Type int32			/*类型*/
	Condition1 int32			/*领奖条件1*/
	Condition2 int32			/*领奖条件2*/
	Param1 int32			/*额外参数*/
	Param2 int32			/*额外参数*/
	Order int32			/*序列*/
	Star_time int32			/*开始时间*/
	End_time int32			/*结束时间*/
	DropID int32			/*掉落包ID*/
	Desc string			/*描述*/
	Desc1 string			/*条目描述*/
	Name string			/*活动名字*/
} 
var MConf_Welfare = map[string] * Conf_Welfare{}

// 福利大厅.xls
type Conf_WelfareDrop struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Drop int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_WelfareDrop = map[string] * Conf_WelfareDrop{}

// 称号.xls
type Conf_Title struct { 
	TitleID int32		`key`	/*主键ID*/
	TitleName string			/*称号名*/
	Desc string			/*称号描述*/
	Icon string			/*称号图标*/
	Priority int32			/*称号优先级*/
} 
var MConf_Title = map[string] * Conf_Title{}

// 称号表.xls
type Conf_TitleShow struct { 
	ID int32		`key`	/*主键ID，唯一不可重复*/
	ShowID int32			/*显示用序列*/
	Name string			/*名称*/
	Condition int32			/*任务达成条件*/
	Param1 int32			/*任务参数1*/
	Param2 int32			/*任务参数2*/
	Param3 int32			/*任务参数3*/
	Schedule int32			/*是否显示进度*/
	Icon string			/*任务ICON*/
	Desc string			/*任务目标描述*/
	AttriType int32			/*属性类型*/
	FirstHandValue int32			/*先手值*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
} 
var MConf_TitleShow = map[string] * Conf_TitleShow{}

// 竞技场奖励掉落.xls
type Conf_ArenaGradeReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaGradeReward = map[string] * Conf_ArenaGradeReward{}

// 竞技场奖励掉落.xls
type Conf_ArenaHistoryGradeReward struct { 
	RewardID int32			/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*历史排名*/
	Reward float32			/*奖励钻石(可使用小数）*/
} 
var MConf_ArenaHistoryGradeReward = map[string] * Conf_ArenaHistoryGradeReward{}

// 竞技场奖励掉落.xls
type Conf_ArenaGoalReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaGoalReward = map[string] * Conf_ArenaGoalReward{}

// 竞技场奖励掉落.xls
type Conf_ArenaScoreReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaScoreReward = map[string] * Conf_ArenaScoreReward{}

// 竞技场奖励掉落.xls
type Conf_ArenaGradeReward_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaGradeReward_act1 = map[string] * Conf_ArenaGradeReward_act1{}

// 竞技场奖励掉落.xls
type Conf_ArenaGradeReward_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaGradeReward_act2 = map[string] * Conf_ArenaGradeReward_act2{}

// 符文表.xls
type Conf_RunesBase struct { 
	ID int32		`key`	/*符文ID*/
	RunesPart int32			/*符文部位*/
	GS int32			/*符文等级*/
	Quality int32			/*品质*/
	RunesAwake int32			/*符文可否精炼*/
	PhysicsAtk float32			/*物攻基础*/
	MagicAtk float32			/*魔攻基础*/
	PhysicsDef float32			/*物防基础*/
	MagicDef float32			/*魔防基础*/
	HP float32			/*血量基础*/
	HitRate float32			/*命中基础*/
	DodgeRate float32			/*闪避基础*/
	CritRate float32			/*暴击基础*/
	Toughness float32			/*韧性基础*/
	ParryRate float32			/*招架基础*/
	PrecisionRate float32			/*精准基础*/
	FireUp float32			/*灼烧增加基础*/
	PoisonUp float32			/*毒伤增加基础*/
	DamageUp float32			/*最终增伤基础*/
	HealthUp float32			/*治疗量增加基础*/
	FireDown float32			/*灼烧降低基础*/
	PoisonDown float32			/*毒伤降低基础*/
	DamageDown float32			/*最终伤害降低*/
	Becured float32			/*被治疗提升基础*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	FireUpInc float32			/*灼烧增加基础*/
	PoisonUpInc float32			/*毒伤增加基础*/
	DamageUpInc float32			/*最终增伤基础*/
	HealthUpInc float32			/*治疗量提升增量*/
	FireDownInc float32			/*灼烧降低基础*/
	PoisonDownInc float32			/*毒伤降低基础*/
	DamageDownInc float32			/*最终伤害降低*/
	BecuredInc float32			/*被治疗提升增量*/
} 
var MConf_RunesBase = map[string] * Conf_RunesBase{}

// 符文表.xls
type Conf_RunesStep struct { 
	ID int32		`key`	/*雕文编号*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	FireUpInc float32			/*灼烧增加基础*/
	PoisonUpInc float32			/*毒伤增加基础*/
	DamageUpInc float32			/*最终增伤基础*/
	HealthUpInc float32			/*治疗量提升基础*/
	FireDownInc float32			/*灼烧降低基础*/
	PoisonDownInc float32			/*毒伤降低基础*/
	DamageDownInc float32			/*最终增伤降低*/
	BecuredInc float32			/*被治疗基础*/
	PhysicsAtkRatioInc float32			/*物攻万分比增量
万分比加成，后面也一样*/
	MagicAtkRatioInc float32			/*魔攻万分比增量*/
	PhysicsDefRatioInc float32			/*物防万分比增量*/
	MagicDefRatioInc float32			/*魔防万分比增量*/
	HPRatioInc float32			/*血量万分比增量*/
	HitRateRatioInc float32			/*命中万分比增量*/
	DodgeRateRatioInc float32			/*闪避万分比增量*/
	CritRateRatioInc float32			/*暴击万分比增量*/
	ToughnessRatioInc float32			/*韧性万分比增量*/
	ParryRateRatioInc float32			/*招架万分比增量*/
	PrecisionRateRatioInc float32			/*精准万分比增量*/
	FireUpRatioInc float32			/*灼烧增加万分比*/
	PoisonUpRatioInc float32			/*毒伤增加万分比*/
	DamageUpRatioInc float32			/*最终增伤万分比*/
	HealthUpRatioInc float32			/*治疗量提升万分比*/
	FireDownRatioInc float32			/*灼烧降低万分比*/
	PoisonDownRatioInc float32			/*毒伤降低万分比*/
	DamageDownRatioInc float32			/*最终伤害降低万分比*/
	BecuredRatioInc float32			/*被治疗量提升*/
} 
var MConf_RunesStep = map[string] * Conf_RunesStep{}

// 符文表.xls
type Conf_RunesSuit struct { 
	SuitID int32		`key`	/*套装ID*/
	Name string			/*套装名称*/
	SuitNeedNum int32		`key`	/*激活需要的件数*/
	EffectNum string			/*套装效果*/
	Anger string			/*增加怒气*/
	Trrigers string			/*触发器*/
	Weight int32			/*套装默认权重*/
} 
var MConf_RunesSuit = map[string] * Conf_RunesSuit{}

// 符文表.xls
type Conf_RunesName struct { 
	SuitID int32		`key`	/*套装ID*/
	SuitName string			/*套装名称*/
	RunesPart int32		`key`	/*符文部位*/
	Name string			/*符文名字*/
	Text string			/*符文说明*/
	Icon int32			/*符文图标*/
} 
var MConf_RunesName = map[string] * Conf_RunesName{}

// 符文表.xls
type Conf_RunesUnlock struct { 
	UnlockNum int32		`key`	/*符文解锁数量*/
	UnlockLevel int32			/*解锁需要等级*/
} 
var MConf_RunesUnlock = map[string] * Conf_RunesUnlock{}

// 第二周嘉年华.xls
type Conf_Carnival2 struct { 
	OpenDay int32		`key`	/*开服第几天*/
	PageName string			/*分页名称*/
} 
var MConf_Carnival2 = map[string] * Conf_Carnival2{}

// 第二周嘉年华.xls
type Conf_Carnival2Quset struct { 
	ID int32		`key`	/*唯一标识*/
	Openday int32		`key`	/*分页id*/
	SubPage int32		`key`	/*子分页id*/
	SubPageName string			/*子分页名称*/
	QuestType int32			/*任务类型*/
	Condition int32			/*任务目标*/
	Progress int32			/*任务需要数量*/
	RewardId int32			/*奖励id*/
	JumpId int32			/*功能跳转*/
	QuestDesc string			/*任务描述*/
} 
var MConf_Carnival2Quset = map[string] * Conf_Carnival2Quset{}

// 第二周嘉年华.xls
type Conf_Carnival2Sale struct { 
	ID int32		`key`	/*唯一标识*/
	ItemID int32			/*商品ID*/
	ItemNum int32			/*商品数量*/
	SaleType int32			/*出售货币*/
	SaleValue int32			/*出售价格*/
	SaleLimit int32			/*限购数量*/
	Discount int32			/*折扣显示*/
} 
var MConf_Carnival2Sale = map[string] * Conf_Carnival2Sale{}

// 第二周嘉年华.xls
type Conf_Carnival2Reward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_Carnival2Reward = map[string] * Conf_Carnival2Reward{}

// 签到.xls
type Conf_Sign struct { 
	ID int32		`key`	/*天数*/
	Item int32			/*道具编号*/
	Num int32			/*数量*/
	Vip int32			/*双倍要求VIP等级*/
} 
var MConf_Sign = map[string] * Conf_Sign{}

// 签到.xls
type Conf_SignNum struct { 
	ID int32		`key`	/*编号*/
	SignNum int32			/*累签天数
永久累积，达到最高天数每签七天*/
	Item1 int32			/*奖励1*/
	Num1 int32			/*数量1*/
	Item2 int32			/*奖励2*/
	Num2 int32			/*数量2*/
	Item3 int32			/*奖励3*/
	Num3 int32			/*数量3*/
} 
var MConf_SignNum = map[string] * Conf_SignNum{}

// 缘分试炼.xls
type Conf_FateFightChapter struct { 
	CampaignChapterID int32		`key`	/*章节ID*/
	CampaignChapterName string			/*章节名称*/
	CampaignOpeningLevel int32			/*章节开启等级*/
	RewardPreview string			/*奖励预览*/
} 
var MConf_FateFightChapter = map[string] * Conf_FateFightChapter{}

// 缘分试炼.xls
type Conf_FateFightCampaign struct { 
	CampaignChapterID int32			/*章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignDesc string			/*副本描述*/
	PreposeCampaignID int32			/*开放此关卡前置关卡ID*/
	FighthHeroNum int32			/*可上阵人数*/
	MapName string			/*地图名*/
	MapEditorName string			/*地图配置名*/
	RewardID string			/*奖励ID*/
} 
var MConf_FateFightCampaign = map[string] * Conf_FateFightCampaign{}

// 缘分试炼.xls
type Conf_FateFightCampaignReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	CampaignID int32		`key`	/*章节ID*/
	RewardLv int32			/*奖励等级*/
	RewardItemID1 int32			/*掉落物品ID1*/
	RewardItemNum1 int32			/*掉落物品数量1*/
	RewardItemID2 int32			/*掉落物品ID2*/
	RewardItemNum2 int32			/*掉落物品数量2*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_FateFightCampaignReward = map[string] * Conf_FateFightCampaignReward{}

// 缘分试炼怪物.xls
type Conf_FateFightMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
} 
var MConf_FateFightMonsterBase = map[string] * Conf_FateFightMonsterBase{}

// 缘分试炼怪物.xls
type Conf_FateFightMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_FateFightMonsterBehavior = map[string] * Conf_FateFightMonsterBehavior{}

// 缘分试炼怪物.xls
type Conf_FateFightCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterBehaviorID int32			/*当前序号调用怪物行为的ID*/
} 
var MConf_FateFightCampaignArmy = map[string] * Conf_FateFightCampaignArmy{}

// 英灵殿.xls
type Conf_Valhalla struct { 
	ID int32		`key`	/*Id*/
	IntimacyStep int32		`key`	/*当前好感阶段*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
} 
var MConf_Valhalla = map[string] * Conf_Valhalla{}

// 英灵殿.xls
type Conf_IntimacyEXP struct { 
	IntimacyStep int32		`key`	/*好感度阶段*/
	IntimacyLevel int32		`key`	/*等级*/
	IntimacyEXP int32			/*升级到该级所需经验*/
	IntimacyFirstHandValue int32			/*升到该级获得先手值*/
} 
var MConf_IntimacyEXP = map[string] * Conf_IntimacyEXP{}

// 英雄.xls
type Conf_HeroBase struct { 
	ID int32		`key`	/*英雄ID*/
	Name string			/*英雄名*/
	Heroself int32			/*是否英雄本体*/
	Desc string			/*英雄描述*/
	Model string			/*英雄模型*/
	HeroSex int32			/*英雄性别*/
	HeroPhyle int32			/*阵营*/
	HeroType int32			/*英雄类型*/
	HeroGroup int32			/*英灵殿分组*/
	Icon int32			/*英雄图标*/
	HeroDamageType int32			/*英雄伤害类型*/
	HeroQuality int32			/*初始品质*/
	HeroStarStrength int32			/*初始潜质*/
	SkillHeroStarStrength float32			/*潜质系数（技能用）*/
	HeroJob int32			/*英雄职业*/
	HeroFirstHandValue int32			/*英雄初始先手值*/
	OfferExp int32			/*被吞噬提供经验*/
	Item1 int32			/*食物1*/
	Item2 int32			/*食物2*/
	Item3 int32			/*食物3*/
	OwnArtifact int32			/*专属神器*/
} 
var MConf_HeroBase = map[string] * Conf_HeroBase{}

// 英雄.xls
type Conf_HeroStep struct { 
	ID int32		`key`	/*Id*/
	HeroStarStrength int32			/*资质*/
	NextStarStrength int32			/*下一资质*/
	StepColor int32			/*当前阶颜色*/
	Step int32		`key`	/*阶数*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	RagePointDamage int32			/*普通攻击获取怒气（单位：次）*/
	RagePointByDamage int32			/*血量耗尽后可获得怒气（单位：100%血量）*/
	RagePointHurt int32			/*受击获取怒气值*/
	RagePointMax int32			/*怒气最大值*/
	SkillStep float32			/*阶级系数（技能用）*/
	NeedLevel int32			/*进阶所需等级下限*/
	SkillIDs string			/*携带技能*/
	NeedGold int32			/*被吞噬消耗金钱*/
	StepNeedGold int32			/*进阶消耗金钱*/
	Item1ID int32			/*物品1ID*/
	Item1Num int32			/*物品1数量*/
	Item2ID int32			/*物品2ID*/
	Item2Num int32			/*物品2数量*/
	Item3ID int32			/*物品3ID*/
	Item3Num int32			/*物品3数量*/
	Item4ID int32			/*物品4ID*/
	Item4Num int32			/*物品4数量*/
	Item5ID int32			/*物品5ID*/
	Item5Num int32			/*物品5数量*/
	Item6ID int32			/*物品6ID*/
	Item6Num int32			/*物品6数量*/
	ResolveStep int32			/*英雄分解返还系数*/
} 
var MConf_HeroStep = map[string] * Conf_HeroStep{}

// 英雄.xls
type Conf_HeroExp struct { 
	Level int32		`key`	/*当前等级*/
	BaseExp int32			/*升到当前等级需要经验*/
	StepLevel int32			/*进阶等级限制*/
	ExperienceRatio int32			/*英雄分解返还系数*/
} 
var MConf_HeroExp = map[string] * Conf_HeroExp{}

// 英雄.xls
type Conf_HeroExpGrow struct { 
	ID int32			/*参数ID*/
	Type int32		`key`	/*参数类型*/
	Idvalue int32		`key`	/*参数对应的值*/
	ExpGrow float32			/*经验系数*/
} 
var MConf_HeroExpGrow = map[string] * Conf_HeroExpGrow{}

// 英雄.xls
type Conf_HeroAmity struct { 
	ID int32		`key`	/*主键ID，唯一不可更改*/
	HeroID int32		`key`	/*英雄ID*/
	HeroStep int32			/*英雄阶数*/
	AmityName string			/*缘分名*/
	AmityType int32			/*缘分类型*/
	Parameter1 int32			/*条件1*/
	Parameter2 int32			/*条件2*/
	Parameter3 int32			/*条件3*/
	Parameter4 int32			/*条件4*/
	Parameter5 int32			/*条件5*/
	Parameter6 int32			/*条件6*/
	EffectID int32			/*激活效果*/
	Order int32			/*分组序列*/
	NeedKnowledgeStep int32			/*生效需要主角考古阶段*/
} 
var MConf_HeroAmity = map[string] * Conf_HeroAmity{}

// 英雄.xls
type Conf_HeroCompose struct { 
	HeroID int32		`key`	/*英雄ID*/
	ItemID int32			/*英雄碎片ID*/
	Count int32			/*合成所需数量*/
	ShowHero int32			/*是否需要显示*/
	FortressFriendPoint int32			/*要塞兑换所需友好度*/
} 
var MConf_HeroCompose = map[string] * Conf_HeroCompose{}

// 英雄.xls
type Conf_HeroAwake struct { 
	ID int32		`key`	/*Id*/
	AwakeID int32		`key`	/*英雄星级*/
	AwakeGrow float32			/*星级系数*/
	Item1ID int32			/*消耗道具*/
	Item1Num int32			/*消耗数量*/
	Item3ID int32			/*消耗道具*/
	Item3Num int32			/*消耗数量*/
	Item2Num int32			/*金币消耗*/
	ResolveAwake int32			/*英雄觉醒钻石分解*/
	NeedStep int32			/*要求阶级*/
	RagePointBegin int32			/*初始怒气值*/
	EffectType int32			/*开启属性类型*/
	Effect1ID int32			/*开启效果(特质)*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻技能*/
	AngSkill string			/*怒攻技能*/
	Triggers string			/*触发器*/
	Effect1Name string			/*开启效果名*/
	Effect1Des string			/*开启效果描述*/
} 
var MConf_HeroAwake = map[string] * Conf_HeroAwake{}

// 英雄.xls
type Conf_HeroArmy struct { 
	ID int32		`key`	/*英雄ID*/
	ID1 int32			/*推荐阵容英雄1*/
	ID2 int32			/*推荐阵容英雄2*/
	ID3 int32			/*推荐阵容英雄3*/
	ID4 int32			/*推荐阵容英雄4*/
	ID5 int32			/*推荐阵容英雄5*/
} 
var MConf_HeroArmy = map[string] * Conf_HeroArmy{}

// 英雄.xls
type Conf_HeroTalent struct { 
	HeroJob int32		`key`	/*职业*/
	TalentLevel int32		`key`	/*等级*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*法防*/
	HP float32			/*生命*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	AllRatio float32			/*基础属性加成(百分比)*/
} 
var MConf_HeroTalent = map[string] * Conf_HeroTalent{}

// 英雄.xls
type Conf_HeroTalentCost struct { 
	TalentStep int32		`key`	/*阶段*/
	TalentLevel int32		`key`	/*等级*/
	NeedItemID int32			/*消耗道具数量*/
	NeedNum int32			/*消耗道具数量*/
	Probability int32			/*成功率(万分比）*/
} 
var MConf_HeroTalentCost = map[string] * Conf_HeroTalentCost{}

// 英雄.xls
type Conf_HeroExpGrow_act1 struct { 
	ID int32			/*参数ID*/
	Type int32		`key`	/*参数类型*/
	Idvalue int32		`key`	/*参数对应的值*/
	ExpGrow float32			/*经验系数*/
} 
var MConf_HeroExpGrow_act1 = map[string] * Conf_HeroExpGrow_act1{}

// 英雄.xls
type Conf_HeroExpGrow_act2 struct { 
	ID int32			/*参数ID*/
	Type int32		`key`	/*参数类型*/
	Idvalue int32		`key`	/*参数对应的值*/
	ExpGrow float32			/*经验系数*/
} 
var MConf_HeroExpGrow_act2 = map[string] * Conf_HeroExpGrow_act2{}

// 英雄.xls
type Conf_HeroExp_act2 struct { 
	Level int32		`key`	/*当前等级*/
	BaseExp int32			/*升到当前等级需要经验*/
	StepLevel int32			/*进阶等级限制*/
	ExperienceRatio int32			/*英雄分解返还系数*/
} 
var MConf_HeroExp_act2 = map[string] * Conf_HeroExp_act2{}

// 英雄.xls
type Conf_HeroStep_act2 struct { 
	ID int32		`key`	/*Id*/
	HeroStarStrength int32			/*资质*/
	NextStarStrength int32			/*下一资质*/
	StepColor int32			/*当前阶颜色*/
	Step int32		`key`	/*阶数*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	RagePointDamage int32			/*普通攻击获取怒气（单位：次）*/
	RagePointByDamage int32			/*血量耗尽后可获得怒气（单位：100%血量）*/
	RagePointHurt int32			/*受击获取怒气值*/
	RagePointMax int32			/*怒气最大值*/
	SkillStep float32			/*阶级系数（技能用）*/
	NeedLevel int32			/*进阶所需等级下限*/
	SkillIDs string			/*携带技能*/
	NeedGold int32			/*被吞噬消耗金钱*/
	StepNeedGold int32			/*进阶消耗金钱*/
	Item1ID int32			/*物品1ID*/
	Item1Num int32			/*物品1数量*/
	Item2ID int32			/*物品2ID*/
	Item2Num int32			/*物品2数量*/
	Item3ID int32			/*物品3ID*/
	Item3Num int32			/*物品3数量*/
	Item4ID int32			/*物品4ID*/
	Item4Num int32			/*物品4数量*/
	Item5ID int32			/*物品5ID*/
	Item5Num int32			/*物品5数量*/
	Item6ID int32			/*物品6ID*/
	Item6Num int32			/*物品6数量*/
	ResolveStep int32			/*英雄分解返还系数*/
} 
var MConf_HeroStep_act2 = map[string] * Conf_HeroStep_act2{}

// 英雄.xls
type Conf_HeroAwake_act2 struct { 
	ID int32		`key`	/*Id*/
	AwakeID int32		`key`	/*英雄星级*/
	AwakeGrow float32			/*星级系数*/
	Item1ID int32			/*消耗道具*/
	Item1Num int32			/*消耗数量*/
	Item3ID int32			/*消耗道具*/
	Item3Num int32			/*消耗数量*/
	Item2Num int32			/*金币消耗*/
	ResolveAwake int32			/*英雄觉醒钻石分解*/
	NeedStep int32			/*要求阶级*/
	RagePointBegin int32			/*初始怒气值*/
	EffectType int32			/*开启属性类型*/
	Effect1ID int32			/*开启效果(特质)*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻技能*/
	AngSkill string			/*怒攻技能*/
	Triggers string			/*触发器*/
	Effect1Name string			/*开启效果名*/
	Effect1Des string			/*开启效果描述*/
} 
var MConf_HeroAwake_act2 = map[string] * Conf_HeroAwake_act2{}

// 获取途径表.xls
type Conf_Guide struct { 
	ID int32		`key`	/*唯一编号*/
	ItemID int32		`key`	/*道具编号*/
	Function int32			/*来源功能*/
	Value int32			/*功能值*/
} 
var MConf_Guide = map[string] * Conf_Guide{}

// 获取途径表.xls
type Conf_GuideDes struct { 
	Function int32		`key`	/*功能*/
	Value int32		`key`	/*功能值*/
	Des string			/*描述*/
	FunctionName string			/*功能名*/
} 
var MConf_GuideDes = map[string] * Conf_GuideDes{}

// 虚空狩猎.xls
type Conf_RunesOutput struct { 
	OutputOrder int32		`key`	/*序号*/
	Order int32			/*掉落包ID*/
	NeedItem int32			/*消耗道具*/
	NeedNum int32			/*消耗道具数量*/
	NeedItem1 int32			/*消耗道具2*/
	NeedNum1 int32			/*消耗道具2数量*/
	TurnOutputOrder int32			/*可跳序号*/
	TurnProbability int32			/*跳转概率*/
	Bulletin int32			/*是否提醒*/
	Name string			/*名字*/
	Profile int32			/*名字品质*/
	Model string			/*模型*/
	CombatNum int32			/*战斗力限制*/
} 
var MConf_RunesOutput = map[string] * Conf_RunesOutput{}

// 虚空狩猎.xls
type Conf_RunesDrop struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_RunesDrop = map[string] * Conf_RunesDrop{}

// 装备.xls
// 饰品表.xls
type Conf_EquipmentPromote struct { 
	ID int32		`key`	/*装备Id*/
	EquipmentPart int32			/*装备部位*/
	EquipmentType int32			/*装备类型*/
	PromoteStart int32		`key`	/*分段起始等级*/
	PromoteOver int32			/*分段结束等级*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
} 
var MConf_EquipmentPromote = map[string] * Conf_EquipmentPromote{}

// 装备.xls
type Conf_EquipmentSuit struct { 
	SuitID int32		`key`	/*主键，唯一ID*/
	Name string			/*套装名*/
	Desc string			/*套装描述*/
	Equipment1 int32			/*装备ID1*/
	Equipment2 int32			/*装备ID2*/
	Equipment3 int32			/*装备ID3*/
	Equipment4 int32			/*装备ID4*/
	Equipment5 int32			/*装备ID5*/
	Equipment6 int32			/*装备ID6*/
	EffectID1 string			/*1套装效果ID*/
	EffectID2 string			/*2套装效果ID*/
	EffectID3 string			/*3套装效果ID*/
	EffectID4 string			/*4套装效果ID*/
	EffectID5 string			/*5套装效果ID*/
	EffectID6 string			/*6套装效果ID*/
	Trrigers1 string			/*1套装触发器*/
	Trrigers2 string			/*2套装触发器*/
	Trrigers3 string			/*3套装触发器*/
	Trrigers4 string			/*4套装触发器*/
	Desc2 string			/*2套装描述*/
	Desc3 string			/*3套装描述*/
	Desc4 string			/*4套装描述*/
} 
var MConf_EquipmentSuit = map[string] * Conf_EquipmentSuit{}

// 装备.xls
type Conf_EquipmentAwake struct { 
	ID int32		`key`	/*Id*/
	AwakeID int32		`key`	/*觉醒等级*/
	AwakeGrow float32			/*觉醒系数*/
	ItemID int32			/*觉醒道具*/
	Item1Num int32			/*消耗数量*/
	Item2Num int32			/*金币消耗*/
	EquipDecAwakeRatio int32			/*装备觉醒钻石分解*/
} 
var MConf_EquipmentAwake = map[string] * Conf_EquipmentAwake{}

// 装备.xls
type Conf_EquipmentEnchant struct { 
	ID int32			/*主键，唯一ID*/
	ExchantLevel int32		`key`	/*附魔等级*/
	GS int32		`key`	/*装备装等*/
	EquipmentType int32		`key`	/*装备类型*/
	PhysicsAtkMIN int32			/*物攻最小值*/
	PhysicsAtkMAX int32			/*物攻最大值*/
	MagicAtkMIN int32			/*魔攻最小值*/
	MagicAtkMAX int32			/*魔攻最大值*/
	PhysicsDefMIN int32			/*物防最小值*/
	PhysicsDefMAX int32			/*物防最大值*/
	MagicDefMIN int32			/*魔防最小值*/
	MagicDefMAX int32			/*魔防最大值*/
	HPMIN int32			/*血量最小值*/
	HPMAX int32			/*血量最大值*/
	HitRateMIN int32			/*命中最小值*/
	HitRateMAX int32			/*命中最大值*/
	DodgeRateMIN int32			/*闪避最小值*/
	DodgeRateMAX int32			/*闪避最小值*/
	CritRateMIN int32			/*暴击最小值*/
	CritRateMAX int32			/*暴击最大值*/
	ToughnessMIN int32			/*韧性最小值*/
	ToughnessMAX int32			/*韧性最打值*/
	ParryRateMIN int32			/*招架最小值*/
	ParryRateMAX int32			/*招架最大值*/
	PrecisionRateMIN int32			/*精准最小值*/
	PrecisionRateMAX int32			/*精准最大值*/
	FireUpMIN int32			/*灼烧增加最小值*/
	FireUpMAX int32			/*灼烧增加最大值*/
	PoisonUpMIN int32			/*毒伤增加最小值*/
	PoisonUpMAX int32			/*毒伤增加最大值*/
	DamageUpMIN int32			/*最终增伤最小值*/
	DamageUpMAX int32			/*最终增伤最大值*/
	HealthUpMIN int32			/*治疗量增加最小值*/
	HealthUpMAX int32			/*治疗量增加最大值*/
	FireDownMIN int32			/*灼烧降低最小*/
	FireDownMAX int32			/*灼烧降低最大*/
	PoisonDownMIN int32			/*毒伤降低最小*/
	PoisonDownMAX int32			/*毒伤降低最大*/
	DamageDownMIN int32			/*最终减伤最小*/
	DamageDownMAX int32			/*最终减伤最大*/
	BecuredMIN int32			/*被治疗提升最小*/
	BecuredMAX int32			/*被治疗提升最大*/
} 
var MConf_EquipmentEnchant = map[string] * Conf_EquipmentEnchant{}

// 装备.xls
type Conf_EquipmentEnchantQuality struct { 
	EnchantQuality int32		`key`	/*附魔品质颜色*/
	GS int32		`key`	/*装备装等*/
	EquipmentType int32		`key`	/*装备类型*/
	PhysicsAtkMIN int32			/*物攻最小值*/
	PhysicsAtkMAX int32			/*物攻最大值*/
	MagicAtkMIN int32			/*魔攻最小值*/
	MagicAtkMAX int32			/*魔攻最大值*/
	PhysicsDefMIN int32			/*物防最小值*/
	PhysicsDefMAX int32			/*物防最大值*/
	MagicDefMIN int32			/*魔防最小值*/
	MagicDefMAX int32			/*魔防最大值*/
	HPMIN int32			/*血量最小值*/
	HPMAX int32			/*血量最大值*/
	HitRateMIN int32			/*命中最小值*/
	HitRateMAX int32			/*命中最大值*/
	DodgeRateMIN int32			/*闪避最小值*/
	DodgeRateMAX int32			/*闪避最小值*/
	CritRateMIN int32			/*暴击最小值*/
	CritRateMAX int32			/*暴击最大值*/
	ToughnessMIN int32			/*韧性最小值*/
	ToughnessMAX int32			/*韧性最打值*/
	ParryRateMIN int32			/*招架最小值*/
	ParryRateMAX int32			/*招架最大值*/
	PrecisionRateMIN int32			/*精准最小值*/
	PrecisionRateMAX int32			/*精准最大值*/
	FireUpMIN int32			/*灼烧增加最小值*/
	FireUpMAX int32			/*灼烧增加最大值*/
	PoisonUpMIN int32			/*毒伤增加最小值*/
	PoisonUpMAX int32			/*毒伤增加最大值*/
	DamageUpMIN int32			/*最终增伤最小值*/
	DamageUpMAX int32			/*最终增伤最大值*/
	HealthUpMIN int32			/*治疗量增加最小值*/
	HealthUpMAX int32			/*治疗量增加最大值*/
	FireDownMIN int32			/*灼烧降低最小*/
	FireDownMAX int32			/*灼烧降低最大*/
	PoisonDownMIN int32			/*毒伤降低最小*/
	PoisonDownMAX int32			/*毒伤降低最大*/
	DamageDownMIN int32			/*最终减伤最小*/
	DamageDownMAX int32			/*最终减伤最大*/
	BecuredMIN int32			/*被治疗提升最小*/
	BecuredMAX int32			/*被治疗提升最大*/
} 
var MConf_EquipmentEnchantQuality = map[string] * Conf_EquipmentEnchantQuality{}

// 装备.xls
type Conf_EquipmentEnchantExp struct { 
	ExchantLevel int32		`key`	/*当前熟练度等级*/
	EnchantExp int32			/*升级到当前熟练度等级所需经验*/
	PropertyNumLowerLimit int32			/*属性数下限*/
	PropertyNumUpperLimit int32			/*属性数上限*/
	NeedMaterial int32			/*每次消耗材料*/
	NeedDiamond int32			/*每次消耗钻石*/
	UpgradeFirstEnchantNum int32			/*升级后第一次随机条目数*/
	Confine int32			/*大随机范围百分比*/
	MAXProbability int32			/*最大值刷出率*/
} 
var MConf_EquipmentEnchantExp = map[string] * Conf_EquipmentEnchantExp{}

// 装备大师属性表.xls
type Conf_EquipmentStrengMaster struct { 
	ID int32			/*ID*/
	EquipmentType int32		`key`	/*装备类型*/
	StrengLevel int32		`key`	/*需要等级*/
	StrengMaster int32			/*激活强化大师等级*/
	EffectStreng int32			/*激活效果*/
	Desc string			/*效果描述*/
} 
var MConf_EquipmentStrengMaster = map[string] * Conf_EquipmentStrengMaster{}

// 装备大师属性表.xls
type Conf_EquipmentRefineMaster struct { 
	ID int32			/*ID*/
	EquipmentType int32		`key`	/*装备类型*/
	RefineLevel int32		`key`	/*需要等级*/
	RefineMaster int32			/*激活大师等级*/
	EffectRefine int32			/*激活效果*/
	Desc string			/*效果描述*/
} 
var MConf_EquipmentRefineMaster = map[string] * Conf_EquipmentRefineMaster{}

// 装备推荐表.xls
type Conf_RecommendEquip struct { 
	ID int32		`key`	/*装备ID*/
	Name string			/*装备名称*/
	RecommendEquipLv int32			/*推荐等级*/
} 
var MConf_RecommendEquip = map[string] * Conf_RecommendEquip{}

// 角斗场.xls
type Conf_WrestlingStrength struct { 
	MinGrade int32			/*等级下限*/
	MaxGrade int32			/*等级上限*/
	Rank int32		`key`	/*名次*/
	MinStrength int32			/*强度系数下限(100为100%)*/
	MaxStrength int32			/*强度系数上限(100为100%)*/
	Type int32			/*对应掉落宝箱类型*/
	Order int32			/*对应掉落*/
} 
var MConf_WrestlingStrength = map[string] * Conf_WrestlingStrength{}

// 角斗场.xls
type Conf_WrestlingReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
} 
var MConf_WrestlingReward = map[string] * Conf_WrestlingReward{}

// 角斗场.xls
type Conf_WrestlingGold struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	OrderLevel int32			/*等级段*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
} 
var MConf_WrestlingGold = map[string] * Conf_WrestlingGold{}

// 角斗场.xls
type Conf_WrestlingMap struct { 
	WrestlingID int32		`key`	/*关卡ID*/
	CampaignChallengeTime int32			/*每天可挑战次数上限*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_WrestlingMap = map[string] * Conf_WrestlingMap{}

// 讨伐.xls
type Conf_CrusadeChapter struct { 
	ChapterID int32		`key`	/*章节ID*/
	CampaignChapterID int32			/*前置剧情副本章节id*/
	CampaignChapterName string			/*章节名称*/
	Riadshow int32			/*显示头像*/
	DoneReward int32			/*通关奖励*/
} 
var MConf_CrusadeChapter = map[string] * Conf_CrusadeChapter{}

// 讨伐.xls
type Conf_CrusadeCampaign struct { 
	ChapterID int32			/*章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignType int32			/*是否Boss关卡*/
	MonsterBase string			/*加载怪物模型*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	Critprobability1 int32			/*两倍暴击概率*/
	Critprobability2 int32			/*4倍暴击概率*/
	BloodGold int32			/*每点血奖励金钱*/
	BloodExp int32			/*每点血奖励经验*/
	Reward int32			/*打死奖励*/
	Dialog1 string			/*怪物对白1*/
	Dialog2 string			/*怪物对白2*/
	Dialog3 string			/*关底BOSS喊话*/
} 
var MConf_CrusadeCampaign = map[string] * Conf_CrusadeCampaign{}

// 讨伐.xls
type Conf_CrusadeCampaignReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_CrusadeCampaignReward = map[string] * Conf_CrusadeCampaignReward{}

// 讨伐.xls
type Conf_CruasdeBloodLoop struct { 
	ID int32		`key`	/*主键ID*/
	Times int32			/*次数*/
	Order int32			/*分组*/
	Blood int32			/*血量*/
} 
var MConf_CruasdeBloodLoop = map[string] * Conf_CruasdeBloodLoop{}

// 讨伐怪物.xls
type Conf_CrusadeMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_CrusadeMonsterBase = map[string] * Conf_CrusadeMonsterBase{}

// 讨伐怪物.xls
type Conf_CrusadeMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_CrusadeMonsterBehavior = map[string] * Conf_CrusadeMonsterBehavior{}

// 讨伐怪物.xls
type Conf_CrusadeCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
} 
var MConf_CrusadeCampaignArmy = map[string] * Conf_CrusadeCampaignArmy{}

// 购买次数价格表.xls
type Conf_BuyTimes struct { 
	Type string		`key`	/*模块*/
	Times int32		`key`	/*次数*/
	ItemID int32			/*购买道具类型*/
	Num int32			/*数量*/
	ItemID1 int32			/*消耗道具ID1*/
	ItemNum1 int32			/*消耗道具数量1*/
	Discount int32			/*折扣显示1*/
	ItemID2 int32			/*消耗道具ID2*/
	ItemNum2 int32			/*消耗道具数量2*/
} 
var MConf_BuyTimes = map[string] * Conf_BuyTimes{}

// 购买次数价格表.xls
type Conf_BuyTimes_act1 struct { 
	Type string		`key`	/*模块*/
	Times int32		`key`	/*次数*/
	ItemID int32			/*购买道具类型*/
	Num int32			/*数量*/
	ItemID1 int32			/*消耗道具ID1*/
	ItemNum1 int32			/*消耗道具数量1*/
	Discount int32			/*折扣显示1*/
	ItemID2 int32			/*消耗道具ID2*/
	ItemNum2 int32			/*消耗道具数量2*/
} 
var MConf_BuyTimes_act1 = map[string] * Conf_BuyTimes_act1{}

// 购买次数价格表.xls
type Conf_BuyTimes_act2 struct { 
	Type string		`key`	/*模块*/
	Times int32		`key`	/*次数*/
	ItemID int32			/*购买道具类型*/
	Num int32			/*数量*/
	ItemID1 int32			/*消耗道具ID1*/
	ItemNum1 int32			/*消耗道具数量1*/
	Discount int32			/*折扣显示1*/
	ItemID2 int32			/*消耗道具ID2*/
	ItemNum2 int32			/*消耗道具数量2*/
} 
var MConf_BuyTimes_act2 = map[string] * Conf_BuyTimes_act2{}

// 跨服抢矿战.xls
type Conf_Vein struct { 
	PitID int32		`key`	/*矿点索引*/
	Vein int32			/*矿图*/
	VeinNum int32			/*矿图数量*/
	PitLevel int32			/*矿点等级*/
	PitNum int32			/*矿点数量*/
	PitResources int32			/*矿点累积资源*/
	PitTime int32			/*资源累积时间（秒）*/
	VeinName string			/*矿图名称*/
} 
var MConf_Vein = map[string] * Conf_Vein{}

// 跨服抢矿战.xls
type Conf_VeinMap struct { 
	PitID int32		`key`	/*唯一ID*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_VeinMap = map[string] * Conf_VeinMap{}

// 跨服竞技配置.xls
type Conf_PublicArenaRankReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
（每周排名）*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_PublicArenaRankReward = map[string] * Conf_PublicArenaRankReward{}

// 跨服竞技配置.xls
type Conf_PublicArenaDayReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
（胜利次数）*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_PublicArenaDayReward = map[string] * Conf_PublicArenaDayReward{}

// 跨服竞技配置.xls
type Conf_PublicArenaEnemy struct { 
	ID int32		`key`	/*对手编号*/
	PowMin int32			/*对手最低战力
百分比*/
	PowMax int32			/*对手最高战力
百分比*/
} 
var MConf_PublicArenaEnemy = map[string] * Conf_PublicArenaEnemy{}

// 跨服联赛.xls
type Conf_LeagueMatchRankLevel struct { 
	RankLevel int32		`key`	/*军衔等级*/
	Name string			/*名称*/
	RankScore int32			/*需要积分*/
	Grade int32			/*需要排名*/
	Icon string			/*图标*/
} 
var MConf_LeagueMatchRankLevel = map[string] * Conf_LeagueMatchRankLevel{}

// 跨服联赛.xls
type Conf_LeagueMatchReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_LeagueMatchReward = map[string] * Conf_LeagueMatchReward{}

// 跨服联赛.xls
type Conf_LeagueMatchMap struct { 
	ID int32		`key`	/*关卡ID*/
	CampaignChallengeTime int32			/*每天可挑战次数上限
此处无用*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_LeagueMatchMap = map[string] * Conf_LeagueMatchMap{}

// 跨服联赛.xls
type Conf_LeagueMatchChestOrder struct { 
	ID int32		`key`	/*主键
掉落顺序*/
	ChestID int32			/*掉落宝箱*/
} 
var MConf_LeagueMatchChestOrder = map[string] * Conf_LeagueMatchChestOrder{}

// 跨服联赛.xls
type Conf_LeagueMatchChestType struct { 
	ID int32		`key`	/*主键ID*/
	ChestID int32			/*宝箱编号*/
	ChestPrice int32			/*宝箱开启价格
（钻/10分钟）*/
	ChestTime int32			/*宝箱开启时限*/
	ChestModel string			/*宝箱模型*/
	Name string			/*宝箱名称*/
	Dec string			/*宝箱描述*/
} 
var MConf_LeagueMatchChestType = map[string] * Conf_LeagueMatchChestType{}

// 跨服联赛.xls
type Conf_LeagueMatchChestReward struct { 
	RewardID int32		`key`	/*主键ID*/
	Order int32		`key`	/*宝箱编号*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
	MinLevel int32			/*等级下限*/
	MaxLevel int32			/*等级上限*/
} 
var MConf_LeagueMatchChestReward = map[string] * Conf_LeagueMatchChestReward{}

// 运营活动.xls
type Conf_GrowthFund struct { 
	ID int32		`key`	/*主键*/
	Level int32			/*等级*/
	Item_id int32			/*奖励ID*/
	Item_num int32			/*奖励数量*/
	Rmb int32			/*价值对比*/
	Icon string			/*图标*/
} 
var MConf_GrowthFund = map[string] * Conf_GrowthFund{}

// 运营活动.xls
type Conf_DoubleDrop struct { 
	ID int32		`key`	/*主键*/
	Icon string			/*活动图片*/
	SwitchToFunction int32			/*跳转功能*/
	Dec string			/*描述*/
} 
var MConf_DoubleDrop = map[string] * Conf_DoubleDrop{}

// 运营活动.xls
type Conf_ArenaRankReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
排行顺序*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaRankReward = map[string] * Conf_ArenaRankReward{}

// 运营活动.xls
type Conf_ArenaRankReward_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
排行顺序*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_ArenaRankReward_act1 = map[string] * Conf_ArenaRankReward_act1{}

// 道具.xls
type Conf_Item struct { 
	ID int32		`key`	/*唯一ID*/
	Name string			/*名称*/
	Desc string			/*描述*/
	Max_Amount int32			/*最大堆叠数*/
	ItemUsedGrade int32			/*物品使用等级*/
	Timeout int32			/*有效时间(单位秒)*/
	Type int32			/*物品类型*/
	Detail_Type int32			/*物品子类型*/
	Profile int32			/*物品品质*/
	Icon string			/*道具图标*/
	ItemSellType int32			/*是否可出售*/
	GainGoldSell int32			/*出售可获得金钱*/
	Param1 int32			/*扩展参数1(数字)*/
	Param2 int32			/*扩展参数2(数字)*/
	Param3 string			/*扩展参数3(字符)*/
	Param4 string			/*扩展参数4(字符)*/
} 
var MConf_Item = map[string] * Conf_Item{}

// 道具.xls
type Conf_DropPackage struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
} 
var MConf_DropPackage = map[string] * Conf_DropPackage{}

// 道具.xls
type Conf_Item_act1 struct { 
	ID int32		`key`	/*唯一ID*/
	Name string			/*名称*/
	Desc string			/*描述*/
	Max_Amount int32			/*最大堆叠数*/
	ItemUsedGrade int32			/*物品使用等级*/
	Timeout int32			/*有效时间(单位秒)*/
	Type int32			/*物品类型*/
	Detail_Type int32			/*物品子类型*/
	Profile int32			/*物品品质*/
	Icon string			/*道具图标*/
	ItemSellType int32			/*是否可出售*/
	GainGoldSell int32			/*出售可获得金钱*/
	Param1 int32			/*扩展参数1(数字)*/
	Param2 int32			/*扩展参数2(数字)*/
	Param3 string			/*扩展参数3(字符)*/
	Param4 string			/*扩展参数4(字符)*/
} 
var MConf_Item_act1 = map[string] * Conf_Item_act1{}

// 道具.xls
type Conf_DropPackage_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
} 
var MConf_DropPackage_act1 = map[string] * Conf_DropPackage_act1{}

// 道具.xls
type Conf_Item_act2 struct { 
	ID int32		`key`	/*唯一ID*/
	Name string			/*名称*/
	Desc string			/*描述*/
	Max_Amount int32			/*最大堆叠数*/
	ItemUsedGrade int32			/*物品使用等级*/
	Timeout int32			/*有效时间(单位秒)*/
	Type int32			/*物品类型*/
	Detail_Type int32			/*物品子类型*/
	Profile int32			/*物品品质*/
	Icon string			/*道具图标*/
	ItemSellType int32			/*是否可出售*/
	GainGoldSell int32			/*出售可获得金钱*/
	Param1 int32			/*扩展参数1(数字)*/
	Param2 int32			/*扩展参数2(数字)*/
	Param3 string			/*扩展参数3(字符)*/
	Param4 string			/*扩展参数4(字符)*/
} 
var MConf_Item_act2 = map[string] * Conf_Item_act2{}

// 道具.xls
type Conf_DropPackage_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32			/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNumMin int32			/*掉落物品数量最小*/
	RewardItemNumMax int32			/*掉落物品数量最大*/
	RewardProbability int32			/*概率或权重*/
} 
var MConf_DropPackage_act2 = map[string] * Conf_DropPackage_act2{}

// 酒馆.xls
type Conf_Tavern struct { 
	ID int32		`key`	/*主键ID*/
	Type int32			/*抽取类型*/
	Desc string			/*类型描述*/
	Button int32			/*按钮*/
	Order int32			/*英雄包ID*/
	ItemOrder int32			/*道具包id*/
	TenthExtraDropID int32			/*10次抽取后额外掉落包ID*/
	TenExtraDropID int32			/*高级十连抽额外获得掉落包ID*/
} 
var MConf_Tavern = map[string] * Conf_Tavern{}

// 酒馆.xls
type Conf_TavernHeroDrop struct { 
	ID int32		`key`	/*主键ID*/
	Order int32		`key`	/*掉落包*/
	DropCondition int32			/*掉落类型*/
	DropItemID int32			/*掉落物品ID*/
	DropItemNum int32			/*掉落物品数量*/
	DropProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
} 
var MConf_TavernHeroDrop = map[string] * Conf_TavernHeroDrop{}

// 酒馆.xls
type Conf_TavernPreview struct { 
	ID int32		`key`	/*位置ID*/
	DropItemID int32			/*奖励ID*/
	DropType int32			/*类型*/
} 
var MConf_TavernPreview = map[string] * Conf_TavernPreview{}

// 酒馆.xls
type Conf_TavernLoop struct { 
	ID int32		`key`	/*主键ID*/
	Order int32		`key`	/*掉落包ID*/
	TavernID int32			/*对应Tacern主键ID*/
	Item_type int32			/*掉落类型*/
	Item_id int32			/*掉落ID*/
} 
var MConf_TavernLoop = map[string] * Conf_TavernLoop{}

// 酒馆.xls
type Conf_TavernEquipmentLoop struct { 
	Time int32		`key`	/*次数*/
	Type int32			/*类型*/
	Item_type1 int32			/*掉落类型*/
	Item_id1 int32			/*掉落ID1*/
	Item_num1 int32			/*掉落数量1*/
	Item_type2 int32			/*掉落类型*/
	Item_id2 int32			/*掉落ID2*/
	Item_num2 int32			/*掉落数量2*/
	Unlock int32			/*解锁装备碎片*/
} 
var MConf_TavernEquipmentLoop = map[string] * Conf_TavernEquipmentLoop{}

// 酒馆.xls
type Conf_TavernEquipPreview struct { 
	ID int32		`key`	/*位置ID*/
	DropItemID int32			/*奖励ID*/
} 
var MConf_TavernEquipPreview = map[string] * Conf_TavernEquipPreview{}

// 酒馆.xls
type Conf_TavernHeroBlessing struct { 
	ID int32		`key`	/*主键编号*/
	Type int32			/*召唤类型
1高级召唤
101~103对应传奇召唤热点英雄*/
	Order int32			/*奖励分组*/
	NeedBlessing int32			/*需要积分*/
	HeroPieceID int32			/*英雄或英雄碎片编号*/
	Num int32			/*数量*/
} 
var MConf_TavernHeroBlessing = map[string] * Conf_TavernHeroBlessing{}

// 酒馆.xls
type Conf_TavernHeroDrop_act1 struct { 
	ID int32		`key`	/*主键ID*/
	Order int32		`key`	/*掉落包*/
	DropCondition int32			/*掉落类型*/
	DropItemID int32			/*掉落物品ID*/
	DropItemNum int32			/*掉落物品数量*/
	DropProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
} 
var MConf_TavernHeroDrop_act1 = map[string] * Conf_TavernHeroDrop_act1{}

// 酒馆.xls
type Conf_TavernHeroDrop_act2 struct { 
	ID int32		`key`	/*主键ID*/
	Order int32		`key`	/*掉落包*/
	DropCondition int32			/*掉落类型*/
	DropItemID int32			/*掉落物品ID*/
	DropItemNum int32			/*掉落物品数量*/
	DropProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
} 
var MConf_TavernHeroDrop_act2 = map[string] * Conf_TavernHeroDrop_act2{}

// 野外首领.xls
type Conf_BossChallengeChapter struct { 
	BossChallengeChapterID int32		`key`	/*章节ID，主键唯一不可重复*/
	BossChallengeChapterName string			/*boss名称*/
	BossChallengeChapterProbability int32			/*触发概率*/
	BossChallengeShow string			/*无奖励时预览*/
} 
var MConf_BossChallengeChapter = map[string] * Conf_BossChallengeChapter{}

// 野外首领.xls
type Conf_BossChallengeCampaign struct { 
	BossChallengeChapterID int32			/*章节ID，对应章节信息表上的章节ID*/
	CampaignID int32		`key`	/*关卡ID*/
	CampaignPlayerLevel int32			/*适用玩家最小区间*/
	CampaignPlayerLevelMax int32			/*适用玩家最大区间*/
	CampaignChallengeTime int32			/*挑战消耗体力*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
	StrengthUp int32			/*强度增长*/
} 
var MConf_BossChallengeCampaign = map[string] * Conf_BossChallengeCampaign{}

// 野外首领.xls
type Conf_BossChanllengeGetLevel struct { 
	PlayerLevel int32		`key`	/*玩家等级*/
	GetMonsterLevel int32			/*触发怪物等级*/
} 
var MConf_BossChanllengeGetLevel = map[string] * Conf_BossChanllengeGetLevel{}

// 野外首领.xls
type Conf_BossChallengeReward struct { 
	BossChallengeChapterID int32		`key`	/*章节ID*/
	BossChallengeMonsterlv int32			/*怪物等级*/
	CampaignBossLevel int32		`key`	/*boss强度等级*/
	BattleExp string			/*每次战斗获取经验*/
	FindReward int32			/*发现奖励*/
	KillReward int32			/*击杀奖励*/
	OnceReward int32			/*每次战斗奖励*/
	ShareReward int32			/*分享奖励*/
} 
var MConf_BossChallengeReward = map[string] * Conf_BossChallengeReward{}

// 野外首领.xls
type Conf_BossChallengeRewardNew struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_BossChallengeRewardNew = map[string] * Conf_BossChallengeRewardNew{}

// 野外首领.xls
type Conf_BossChallengeDamage struct { 
	Level int32		`key`	/*等级*/
	DamageBase int32			/*伤害要求基础值*/
	Reward1 int32			/*金币奖励基础值*/
	Reward2 int32			/*宝物进阶石奖励基础值*/
	Reward3 int32			/*徽章奖励基础*/
} 
var MConf_BossChallengeDamage = map[string] * Conf_BossChallengeDamage{}

// 野外首领.xls
type Conf_BossChallengeDamageGrow struct { 
	ID int32		`key`	/*奖励序号*/
	DamageRatio float32			/*伤害要求系数*/
	Type int32			/*奖励类型*/
	ItemID int32			/*其他道具奖励ID*/
	Number float32			/*道具数量*/
} 
var MConf_BossChallengeDamageGrow = map[string] * Conf_BossChallengeDamageGrow{}

// 野外首领.xls
type Conf_BossChallengeRank struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BossChallengeRank = map[string] * Conf_BossChallengeRank{}

// 野外首领.xls
type Conf_BossChallengeCurveRank struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BossChallengeCurveRank = map[string] * Conf_BossChallengeCurveRank{}

// 野外首领.xls
type Conf_BossChallengeRewardNew_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_BossChallengeRewardNew_act1 = map[string] * Conf_BossChallengeRewardNew_act1{}

// 野外首领.xls
type Conf_BossChallengeRank_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BossChallengeRank_act1 = map[string] * Conf_BossChallengeRank_act1{}

// 野外首领.xls
type Conf_BossChallengeCurveRank_act1 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BossChallengeCurveRank_act1 = map[string] * Conf_BossChallengeCurveRank_act1{}

// 野外首领.xls
type Conf_BossChallengeRewardNew_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	SubOrder int32			/*子分组*/
	RewardPreview int32			/*奖励预览*/
	GetShow int32			/*获取途径显示优先级*/
} 
var MConf_BossChallengeRewardNew_act2 = map[string] * Conf_BossChallengeRewardNew_act2{}

// 野外首领.xls
type Conf_BossChallengeRank_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BossChallengeRank_act2 = map[string] * Conf_BossChallengeRank_act2{}

// 野外首领.xls
type Conf_BossChallengeCurveRank_act2 struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型，当类型为0时，RewardProbability指代概率（1000000为100%）
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_BossChallengeCurveRank_act2 = map[string] * Conf_BossChallengeCurveRank_act2{}

// 野外首领怪物.xls
type Conf_BossChallengeMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	MonsterDesc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	BeginArg int32			/*初始怒气*/
} 
var MConf_BossChallengeMonsterBase = map[string] * Conf_BossChallengeMonsterBase{}

// 野外首领怪物.xls
type Conf_BossChallengeBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	GelSkill string			/*普攻技能*/
	BulletName string			/*普攻子弹*/
	AngSkill string			/*怒攻技能*/
	Trrigers string			/*触发技能*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_BossChallengeBehavior = map[string] * Conf_BossChallengeBehavior{}

// 野外首领怪物.xls
type Conf_BossChallengeCampaignArmy struct { 
	CampaignID int32		`key`	/*关卡ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Level int32			/*怪物等级*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterSize int32			/*怪物体型*/
	BossShow int32			/*BOSS展示*/
	MonsterType int32			/*boss血条*/
} 
var MConf_BossChallengeCampaignArmy = map[string] * Conf_BossChallengeCampaignArmy{}

// 错误码.xls
type Conf_ErrorDefine struct { 
	ID int32		`key`	/*错误码ID*/
	String string			/*错误码文字*/
} 
var MConf_ErrorDefine = map[string] * Conf_ErrorDefine{}

// 随机名字库.xls
type Conf_randname struct { 
	ID int32		`key`	/*唯一ID*/
	Firstname string			/*姓*/
	Midname string			/*分隔符*/
	Lastname string			/*名*/
} 
var MConf_randname = map[string] * Conf_randname{}

// 雕文表.xls
type Conf_InscriptionLevelUp struct { 
	NodeID int32		`key`	/*节点ID*/
	Level int32		`key`	/*专精级别*/
	AttributeValue int32			/*属性数值*/
	NeedInscriptionExp int32			/*雕文经验消耗*/
	NeedMoney int32			/*金币消耗*/
} 
var MConf_InscriptionLevelUp = map[string] * Conf_InscriptionLevelUp{}

// 雕文表.xls
type Conf_InscriptionActive struct { 
	NodeID int32		`key`	/*节点id*/
	NeedNode int32			/*前置节点id*/
	AttributeType int32			/*属性类型*/
	WorkID int32			/*所属职业*/
	HeroQuality int32			/*英雄品质*/
	NeedMoney int32			/*每次金币消耗*/
	NeedInscriptionStone int32			/*每次雕文石消耗*/
	SuccessMin int32			/*最低次数*/
	SuccessMax int32			/*最高次数*/
	SuccessRate int32			/*成功率*/
	LuckyFirst int32			/*首次失败祝福值*/
	LuckyMax int32			/*祝福值上限*/
	LuckyStep int32			/*祝福步进值*/
} 
var MConf_InscriptionActive = map[string] * Conf_InscriptionActive{}

// 雕文表New.xls
type Conf_GlyphsBase struct { 
	ID int32		`key`	/*雕文编号*/
	Name string			/*名称*/
	Icon int32			/*图标*/
	Type int32			/*类型*/
	Star int32			/*星级*/
	Quality int32			/*品质*/
	OfferExp int32			/*产出经验*/
} 
var MConf_GlyphsBase = map[string] * Conf_GlyphsBase{}

// 雕文表New.xls
type Conf_GlyphsExp struct { 
	Level int32		`key`	/*等级*/
	Star int32		`key`	/*星级*/
	NeedExp int32			/*本级需要经验*/
} 
var MConf_GlyphsExp = map[string] * Conf_GlyphsExp{}

// 雕文表New.xls
type Conf_GlyphsStrengthen struct { 
	ID int32		`key`	/*雕文编号*/
	Type int32			/*类型*/
	Quality int32			/*品质*/
	LevelMin int32		`key`	/*最低等级
等级在该范围内的属性成长*/
	LevelMax int32			/*最高等级*/
	PhysicsAtkRatio float32			/*物攻万分比
万分比加成，其它属性也一样*/
	MagicAtkRatio float32			/*魔攻万分比*/
	PhysicsDefRatio float32			/*物防万分比*/
	MagicDefRatio float32			/*魔防万分比*/
	HPRatio float32			/*血量万分比*/
	HitRateRatio float32			/*命中万分比*/
	DodgeRateRatio float32			/*闪避万分比*/
	CritRateRatio float32			/*暴击万分比*/
	ToughnessRatio float32			/*韧性万分比*/
	ParryRateRatio float32			/*招架万分比*/
	PrecisionRateRatio float32			/*精准万分比*/
	PhysicsAtkRatioInc float32			/*物攻万分比增量
万分比加成，后面也一样*/
	MagicAtkRatioInc float32			/*魔攻万分比增量*/
	PhysicsDefRatioInc float32			/*物防万分比增量*/
	MagicDefRatioInc float32			/*魔防万分比增量*/
	HPRatioInc float32			/*血量万分比增量*/
	HitRateRatioInc float32			/*命中万分比增量*/
	DodgeRateRatioInc float32			/*闪避万分比增量*/
	CritRateRatioInc float32			/*暴击万分比增量*/
	ToughnessRatioInc float32			/*韧性万分比增量*/
	ParryRateRatioInc float32			/*招架万分比增量*/
	PrecisionRateRatioInc float32			/*精准万分比增量*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	StepNeedGold int32			/*进阶消耗金钱*/
	Item1ID int32			/*物品1ID*/
	Item1Num int32			/*物品1数量*/
	Item2ID int32			/*物品2ID*/
	Item2Num int32			/*物品2数量*/
	Item3ID int32			/*物品3ID*/
	Item3Num int32			/*物品3数量*/
	Item4ID int32			/*物品4ID*/
	Item4Num int32			/*物品4数量*/
	Item5ID int32			/*物品5ID*/
	Item5Num int32			/*物品5数量*/
	Item6ID int32			/*物品6ID*/
	Item6Num int32			/*物品6数量*/
	EffectID string			/*效果*/
	EquipDecAdvancedRatio int32			/*装备分解进阶返还系数*/
} 
var MConf_GlyphsStrengthen = map[string] * Conf_GlyphsStrengthen{}

// 雕文表New.xls
type Conf_GlyphsCompose struct { 
	GlyphsID int32			/*雕文*/
	ItemID int32		`key`	/*碎片ID*/
	Count int32			/*合成所需数量*/
} 
var MConf_GlyphsCompose = map[string] * Conf_GlyphsCompose{}

// 音量控制表.xls
type Conf_audio struct { 
	Index int32			/*编号*/
	Name string		`key`	/*音频名称*/
	Db int32			/*音量大小*/
} 
var MConf_audio = map[string] * Conf_audio{}

// 领主争霸赛.xls
type Conf_CupSupportReward struct { 
	Level int32		`key`	/*领主等级段*/
	GoldReward int32			/*奖励金币*/
} 
var MConf_CupSupportReward = map[string] * Conf_CupSupportReward{}

// 领主争霸赛.xls
type Conf_CupRankReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
	CupType int32		`key`	/*比赛阶段
1本服赛
2跨服赛*/
} 
var MConf_CupRankReward = map[string] * Conf_CupRankReward{}

// 领主争霸赛.xls
type Conf_CupMap struct { 
	ID int32		`key`	/*关卡ID*/
	CampaignChallengeTime int32			/*每天可挑战次数上限
此处无用*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_CupMap = map[string] * Conf_CupMap{}

// 领地怪物表.xls
type Conf_DomainMap struct { 
	ID int32		`key`	/*主键，地图ID*/
	BattleType int32			/*战斗类型
1机器人2玩家3资源点*/
	MapName string			/*地图名，调用资源用*/
	MapEditorName string			/*地图配置名，场景编辑器生成的配置文件名*/
} 
var MConf_DomainMap = map[string] * Conf_DomainMap{}

// 领地怪物表.xls
type Conf_DomainBuildingEnemy struct { 
	MatchValue int32			/*匹配值
=活跃度*领地匹配系数
代表比值以上*/
	BotHPMin int32			/*机器人最低生命加成
百分比，90指90%*/
	BotHPMax int32			/*机器人最高生命加成
百分比，90指90%*/
	BotAttMin int32			/*机器人最低攻击加成*/
	BotAttMax int32			/*机器人最高攻击加成*/
	BotDefMin int32			/*机器人最低防御加成*/
	BotDefMax int32			/*机器人最高防御加成*/
	BotLevelMin int32			/*机器人最低等级差*/
	BotLevelMax int32			/*机器人最高等级差*/
	PlayerPowerMin int32		`key`	/*玩家最低战力系数
百分比，90指90%*/
	PlayerPowerMax int32			/*列家最高战力系数
百分比，90指90%*/
} 
var MConf_DomainBuildingEnemy = map[string] * Conf_DomainBuildingEnemy{}

// 领地怪物表.xls
type Conf_DomainMineMonsterBase struct { 
	ID int32		`key`	/*ee*/
	Name string			/*ee*/
	MonsterJob string			/*ee*/
	Desc string			/*ee*/
	Model string			/*ee*/
	Icon string			/*dd*/
	MonsterType int32			/*ee*/
	MonsterDamageType int32			/*ff*/
	ColorType string			/*贴图类型*/
	Size int32			/*模型大小*/
	RagePointByKill int32			/*击杀获得怒气*/
	KillAttribute int32			/*击杀增加属性*/
	AttributeValue int32			/*增加值*/
} 
var MConf_DomainMineMonsterBase = map[string] * Conf_DomainMineMonsterBase{}

// 领地怪物表.xls
type Conf_DomainMineMonsterBehavior struct { 
	MonsterBehaviorID int32		`key`	/*怪物行为AI*/
	AIs string			/*携带AI*/
	SkillIDs string			/*携带技能*/
	BaseFindEnemyAIs string			/*自动索敌AI*/
} 
var MConf_DomainMineMonsterBehavior = map[string] * Conf_DomainMineMonsterBehavior{}

// 领地怪物表.xls
type Conf_DomainMineArmy struct { 
	CampaignID int32		`key`	/*怪物组合ID*/
	Index int32		`key`	/*关卡内怪物序号*/
	CampaignPlayerLevel int32			/*适用玩家最小区间*/
	CampaignPlayerLevelMax int32			/*适用玩家最大区间*/
	MonsterBaseID int32			/*当前序号调用怪物基础ID*/
	Type int32			/*怪物类型*/
	ID int32			/*怪物强度系数ID*/
	MonsterBehaviorID int32			/*当前序号调用怪物行为的ID*/
	StrengthUp int32			/*交换攻守增加强度*/
} 
var MConf_DomainMineArmy = map[string] * Conf_DomainMineArmy{}

// 领地探险.xls
type Conf_DomainBase struct { 
	DomainQuestType int32		`key`	/*任务品质*/
	Probability int32			/*刷新概率*/
	Time int32			/*任务时长*/
	HeroJob int32			/*职业限制个数*/
	HeroExpOrder int32			/*英雄经验奖励*/
	Order int32			/*奖励分组*/
	HeroSuccessRatio int32			/*符合要求英雄的成功率*/
} 
var MConf_DomainBase = map[string] * Conf_DomainBase{}

// 领地探险.xls
type Conf_DomainMonster struct { 
	DomainQuestType int32		`key`	/*对应任务品质*/
	Icon string		`key`	/*怪物头像ICON*/
} 
var MConf_DomainMonster = map[string] * Conf_DomainMonster{}

// 领地探险.xls
type Conf_DomainQuestReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
} 
var MConf_DomainQuestReward = map[string] * Conf_DomainQuestReward{}

// 领地探险.xls
type Conf_HeroExpReward struct { 
	HeroExpOrder int32		`key`	/*英雄经验奖励分组*/
	PlayerLevel int32		`key`	/*等级分组*/
	RewardItemNum int32			/*掉落物品数量*/
} 
var MConf_HeroExpReward = map[string] * Conf_HeroExpReward{}

// 领地探险.xls
type Conf_DomainQuest struct { 
	QuestID int32		`key`	/*任务ID*/
	QuestName string			/*任务名*/
	Dec string			/*任务描述*/
} 
var MConf_DomainQuest = map[string] * Conf_DomainQuest{}

// 领地探险.xls
type Conf_BuySuccessRatio struct { 
	SuccessRatio int32		`key`	/*成功率*/
	Price int32			/*购买价格*/
	BuyTimes int32			/*购买次数*/
} 
var MConf_BuySuccessRatio = map[string] * Conf_BuySuccessRatio{}

// 领地探险.xls
type Conf_DomainQuestHeroMax struct { 
	PlayLevel int32		`key`	/*领主等级*/
	DomainQuestHeroMax int32			/*最大英雄派遣数量*/
} 
var MConf_DomainQuestHeroMax = map[string] * Conf_DomainQuestHeroMax{}

// 领地表.xls
type Conf_DomainOpen struct { 
	AreaID int32		`key`	/*区域ID*/
	OpenLevel int32			/*开启需要领主等级*/
	GoldCost int32			/*消耗金币*/
	MatchRatio float32			/*区配值系数
匹配值=当前活跃度*匹配系数/100*/
} 
var MConf_DomainOpen = map[string] * Conf_DomainOpen{}

// 领地表.xls
type Conf_DomainType struct { 
	ID int32		`key`	/*主键编号*/
	DomainType int32			/*据点类型*/
	OccupationType int32			/*占领状态*/
	OccupationTime  int32			/*可占领时长*/
	ResetTime int32			/*刷新间隔(秒）*/
	EnemyRatio int32			/*被占最大比例*/
	Reward int32			/*占领奖励*/
} 
var MConf_DomainType = map[string] * Conf_DomainType{}

// 领地表.xls
type Conf_Domain struct { 
	ID int32		`key`	/*地图节点编号*/
	DomainType int32			/*据点类型
1普通点2资源点3宝箱*/
	Area int32			/*所属区域*/
	IsOccupation int32			/*初始是否被占领*/
} 
var MConf_Domain = map[string] * Conf_Domain{}

// 领地表.xls
type Conf_DomainBuildingReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
按领主等级区分，表示XX级以上的奖励*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_DomainBuildingReward = map[string] * Conf_DomainBuildingReward{}

// 领地表.xls
type Conf_DomainMineReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
按领主等级区分，表示XX级以上的奖励*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_DomainMineReward = map[string] * Conf_DomainMineReward{}

// 领地表.xls
type Conf_DomainMineProduct struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组*/
	MinLevel int32			/*奖励最低等级*/
	MaxLevel int32			/*奖励最高等级*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_DomainMineProduct = map[string] * Conf_DomainMineProduct{}

// 领地表.xls
type Conf_DomainChestReward struct { 
	RewardID int32		`key`	/*奖励ID，主键唯一不可重复*/
	Order int32		`key`	/*奖励分组
按领主等级区分，表示XX级以上的奖励*/
	RewardCondition int32			/*奖励类型:
当类型为0时，RewardProbability指代概率（1000000为100%）；
当类型为大于0的整数时，RewardProbability指代权重
且不同的整数代表不同的掉落包*/
	RewardItemID int32			/*掉落物品ID*/
	RewardItemNum int32			/*掉落物品数量*/
	RewardProbability int32			/*概率或权重*/
	RewardPreview int32			/*奖励预览*/
} 
var MConf_DomainChestReward = map[string] * Conf_DomainChestReward{}

// 饰品表.xls
type Conf_JewelryStep struct { 
	ID int32		`key`	/*雕文编号*/
	Type int32			/*类型*/
	Quality int32			/*品质*/
	LevelMin int32			/*最低等级
等级在该范围内的属性成长*/
	LevelMax int32			/*最高等级*/
	Step int32		`key`	/*分段起始*/
	StepMax int32			/*分段结束*/
	EquipmentPart int32			/*装备部位*/
	EquipmentType int32			/*装备类型*/
	PhysicsAtk float32			/*物攻*/
	MagicAtk float32			/*魔攻*/
	PhysicsDef float32			/*物防*/
	MagicDef float32			/*魔防*/
	HP float32			/*血量*/
	HitRate float32			/*命中*/
	DodgeRate float32			/*闪避*/
	CritRate float32			/*暴击*/
	Toughness float32			/*韧性*/
	ParryRate float32			/*招架*/
	PrecisionRate float32			/*精准*/
	PhysicsAtkInc float32			/*物攻增量*/
	MagicAtkInc float32			/*魔攻增量*/
	PhysicsDefInc float32			/*物防增量*/
	MagicDefInc float32			/*魔防增量*/
	HPInc float32			/*血量增量*/
	HitRateInc float32			/*命中增量*/
	DodgeRateInc float32			/*闪避增量*/
	CritRateInc float32			/*暴击增量*/
	ToughnessInc float32			/*韧性增量*/
	ParryRateInc float32			/*招架增量*/
	PrecisionRateInc float32			/*精准增量*/
	PhysicsAtkRatio float32			/*物攻万分比
万分比加成，其它属性也一样*/
	MagicAtkRatio float32			/*魔攻万分比*/
	PhysicsDefRatio float32			/*物防万分比*/
	MagicDefRatio float32			/*魔防万分比*/
	HPRatio float32			/*血量万分比*/
	HitRateRatio float32			/*命中万分比*/
	DodgeRateRatio float32			/*闪避万分比*/
	CritRateRatio float32			/*暴击万分比*/
	ToughnessRatio float32			/*韧性万分比*/
	ParryRateRatio float32			/*招架万分比*/
	PrecisionRateRatio float32			/*精准万分比*/
	PhysicsAtkRatioInc float32			/*物攻万分比增量
万分比加成，后面也一样*/
	MagicAtkRatioInc float32			/*魔攻万分比增量*/
	PhysicsDefRatioInc float32			/*物防万分比增量*/
	MagicDefRatioInc float32			/*魔防万分比增量*/
	HPRatioInc float32			/*血量万分比增量*/
	HitRateRatioInc float32			/*命中万分比增量*/
	DodgeRateRatioInc float32			/*闪避万分比增量*/
	CritRateRatioInc float32			/*暴击万分比增量*/
	ToughnessRatioInc float32			/*韧性万分比增量*/
	ParryRateRatioInc float32			/*招架万分比增量*/
	PrecisionRateRatioInc float32			/*精准万分比增量*/
	StepNeedGold int32			/*进阶消耗金钱*/
	Item1ID int32			/*物品1ID*/
	Item1Num int32			/*物品1数量*/
	Item2ID int32			/*物品2ID*/
	Item2Num int32			/*物品2数量*/
	Item3ID int32			/*物品3ID*/
	Item3Num int32			/*物品3数量*/
	Item4ID int32			/*物品4ID*/
	Item4Num int32			/*物品4数量*/
	Item5ID int32			/*物品5ID*/
	Item5Num int32			/*物品5数量*/
	Item6ID int32			/*物品6ID*/
	Item6Num int32			/*物品6数量*/
	EffectID string			/*效果*/
	EquipDecAdvancedRatio int32			/*装备分解进阶返还系数*/
} 
var MConf_JewelryStep = map[string] * Conf_JewelryStep{}

// 黑市商店.xls
type Conf_BlackShop struct { 
	ID int32		`key`	/*商品编号*/
	Group int32			/*商品分组/排序*/
	ItemID int32			/*商品的物品模板*/
	ItemNum int32			/*出售商品的数量*/
	BuyType int32			/*购买所需货币类型*/
	BuyNum int32			/*购买所需对应货币类型的数量*/
	Weight int32			/*刷新商品的权重*/
	MinLevel int32			/*刷新最低等级*/
	MaxLevel int32			/*刷新最高等级*/
} 
var MConf_BlackShop = map[string] * Conf_BlackShop{}
func load() {
	loadconfigdata(&MConf_Quest30)
	loadconfigdata(&MConf_Quest30Reward)
	loadconfigdata(&MConf_character)
	loadconfigdata(&MConf_job)
	loadconfigdata(&MConf_array)
	loadconfigdata(&MConf_ctrl)
	loadconfigdata(&MConf_Loading)
	loadconfigdata(&MConf_NPCBase)
	loadconfigdata(&MConf_VIPPrivilege)
	loadconfigdata(&MConf_VIPReward)
	loadconfigdata(&MConf_VIPDesc)
	loadconfigdata(&MConf_ChangeCard)
	loadconfigdata(&MConf_WorldBossCampaign)
	loadconfigdata(&MConf_WorldBossReward)
	loadconfigdata(&MConf_WorldBossOnceRank)
	loadconfigdata(&MConf_WorldBossCurveRank)
	loadconfigdata(&MConf_GlobalConfig)
	loadconfigdata(&MConf_WorldBossOnceRank__act1)
	loadconfigdata(&MConf_WorldBossCurveRank_act1)
	loadconfigdata(&MConf_WorldBossMonsterBase)
	loadconfigdata(&MConf_WorldBossBehavior)
	loadconfigdata(&MConf_WorldBossCampaignArmy)
	loadconfigdata(&MConf_PlayerUpgradeExp)
	loadconfigdata(&MConf_PlayerUpgradeExp_act2)
	loadconfigdata(&MConf_Quest)
	loadconfigdata(&MConf_QuestReward)
	loadconfigdata(&MConf_ActiveReward)
	loadconfigdata(&MConf_QuestReward_act2)
	loadconfigdata(&MConf_InheritPrice)
	loadconfigdata(&MConf_GoldPrice)
	loadconfigdata(&MConf_SquireSlots)
	loadconfigdata(&MConf_SquireSlotsAdd)
	loadconfigdata(&MConf_Squire)
	loadconfigdata(&MConf_Wares)
	loadconfigdata(&MConf_SVIPConfig)
	loadconfigdata(&MConf_GlobalConfig_act2)
	loadconfigdata(&MConf_Illidan)
	loadconfigdata(&MConf_IllidanSpend)
	loadconfigdata(&MConf_IllidanProbability)
	loadconfigdata(&MConf_IllidanRward)
	loadconfigdata(&MConf_IllidanLoop)
	loadconfigdata(&MConf_GuildChapter)
	loadconfigdata(&MConf_GuildCampaign)
	loadconfigdata(&MConf_GuildCampaignReward)
	loadconfigdata(&MConf_GuildRaidRank)
	loadconfigdata(&MConf_GuildCampaignReward_act1)
	loadconfigdata(&MConf_GuildRaidRank_act1)
	loadconfigdata(&MConf_GuildRaidRank_act2)
	loadconfigdata(&MConf_GuildCampaignReward_act2)
	loadconfigdata(&MConf_GuildRaidBuild)
	loadconfigdata(&MConf_GuildMonsterBase)
	loadconfigdata(&MConf_GuildMonsterBehavior)
	loadconfigdata(&MConf_GuildCampaignArmy)
	loadconfigdata(&MConf_Guild)
	loadconfigdata(&MConf_GuildProgressReward)
	loadconfigdata(&MConf_GuildUnlock)
	loadconfigdata(&MConf_LegionInvasion)
	loadconfigdata(&MConf_LegionCampaign)
	loadconfigdata(&MConf_LegionReward)
	loadconfigdata(&MConf_LegionReward_act2)
	loadconfigdata(&MConf_LegionMonsterBase)
	loadconfigdata(&MConf_LegionMonsterBehavior)
	loadconfigdata(&MConf_LegionArmy)
	loadconfigdata(&MConf_BlackTempleCampaign)
	loadconfigdata(&MConf_BlackTempleReward)
	loadconfigdata(&MConf_BlackTempleMonsterBase)
	loadconfigdata(&MConf_BlackTempleMonsterBehavior)
	loadconfigdata(&MConf_BlackTempleCampaignArmy)
	loadconfigdata(&MConf_Chapter)
	loadconfigdata(&MConf_Campaign)
	loadconfigdata(&MConf_CampaignReward)
	loadconfigdata(&MConf_CampainWhiteList)
	loadconfigdata(&MConf_CampaignReward_act2)
	loadconfigdata(&MConf_MonsterBase)
	loadconfigdata(&MConf_MonsterBehavior)
	loadconfigdata(&MConf_CampaignArmy)
	loadconfigdata(&MConf_CampaignArmy_act1)
	loadconfigdata(&MConf_CampaignArmy_act2)
	loadconfigdata(&MConf_FunctionOpen)
	loadconfigdata(&MConf_Tutorial)
	loadconfigdata(&MConf_TutorialItemList)
	loadconfigdata(&MConf_Compose)
	loadconfigdata(&MConf_ShopConfig)
	loadconfigdata(&MConf_ShopItemResetTime)
	loadconfigdata(&MConf_Shop)
	loadconfigdata(&MConf_ShopRandom)
	loadconfigdata(&MConf_VIPShop)
	loadconfigdata(&MConf_Shop_act1)
	loadconfigdata(&MConf_Shop_act2)
	loadconfigdata(&MConf_KnowledgeLevel)
	loadconfigdata(&MConf_KnowledgeStep)
	loadconfigdata(&MConf_BGM)
	loadconfigdata(&MConf_FrameShop)
	loadconfigdata(&MConf_FullClientReward)
	loadconfigdata(&MConf_EquipmentExp)
	loadconfigdata(&MConf_EquipmentExpGrow)
	loadconfigdata(&MConf_EquipmentBase)
	loadconfigdata(&MConf_EquipmentStep)
	loadconfigdata(&MConf_EquipmentActivation)
	loadconfigdata(&MConf_GemBase)
	loadconfigdata(&MConf_GemSuit)
	loadconfigdata(&MConf_GemDrop)
	loadconfigdata(&MConf_GemOutput)
	loadconfigdata(&MConf_PetShow)
	loadconfigdata(&MConf_PetBase)
	loadconfigdata(&MConf_PetStep)
	loadconfigdata(&MConf_PetEffect)
	loadconfigdata(&MConf_Dialogue)
	loadconfigdata(&MConf_ShieldingWord)
	loadconfigdata(&MConf_LevelCoefficient)
	loadconfigdata(&MConf_CarnivalOpenDay)
	loadconfigdata(&MConf_CarnivalItems)
	loadconfigdata(&MConf_CarnivalTotle)
	loadconfigdata(&MConf_CarnivalReward)
	loadconfigdata(&MConf_CarnivaSell)
	loadconfigdata(&MConf_CarnivalItems_act2)
	loadconfigdata(&MConf_CarnivalReward_act2)
	loadconfigdata(&MConf_BeginRank)
	loadconfigdata(&MConf_BeginRankReward)
	loadconfigdata(&MConf_BeginRankNotice)
	loadconfigdata(&MConf_BeginCheckIn)
	loadconfigdata(&MConf_BeginCheckInReward)
	loadconfigdata(&MConf_Monster)
	loadconfigdata(&MConf_MonsterType)
	loadconfigdata(&MConf_MonsterPP)
	loadconfigdata(&MConf_Monster_act2)
	loadconfigdata(&MConf_WantStrong)
	loadconfigdata(&MConf_BattlefieldFightReward)
	loadconfigdata(&MConf_BattlefieldGradeReward)
	loadconfigdata(&MConf_FightCommonList)
	loadconfigdata(&MConf_BattleEffectiveness)
	loadconfigdata(&MConf_FigthTutorial)
	loadconfigdata(&MConf_AchievementDesc)
	loadconfigdata(&MConf_CameraConfig)
	loadconfigdata(&MConf_Push)
	loadconfigdata(&MConf_SkillBase)
	loadconfigdata(&MConf_SkillStrength)
	loadconfigdata(&MConf_SkillPassive)
	loadconfigdata(&MConf_SkillExp)
	loadconfigdata(&MConf_ConvoyStarProbability)
	loadconfigdata(&MConf_ConvoyReward)
	loadconfigdata(&MConf_ConvoyMap)
	loadconfigdata(&MConf_ModelClothesBase)
	loadconfigdata(&MConf_RecommendTroops)
	loadconfigdata(&MConf_Effect)
	loadconfigdata(&MConf_PlayerClick)
	loadconfigdata(&MConf_DailyActivities)
	loadconfigdata(&MConf_TimeCaveChapter)
	loadconfigdata(&MConf_TimeCaveCampaign)
	loadconfigdata(&MConf_TimeCaveCampaignReward)
	loadconfigdata(&MConf_TimeCaveDropChest)
	loadconfigdata(&MConf_TimeCaveMonsterBase)
	loadconfigdata(&MConf_TimeCaveMonsterBehavior)
	loadconfigdata(&MConf_TimeCaveCampaignArmy)
	loadconfigdata(&MConf_SeverString)
	loadconfigdata(&MConf_ActivityBack)
	loadconfigdata(&MConf_JoyMachine)
	loadconfigdata(&MConf_JoyMachineOutput)
	loadconfigdata(&MConf_JoyMachinePrice)
	loadconfigdata(&MConf_daily)
	loadconfigdata(&MConf_TempleChapter)
	loadconfigdata(&MConf_TempleCampaign)
	loadconfigdata(&MConf_TempleRward)
	loadconfigdata(&MConf_TempleMonsterBase)
	loadconfigdata(&MConf_TempleMonsterBehavior)
	loadconfigdata(&MConf_TempleCampaignArmy)
	loadconfigdata(&MConf_ObjectiveLeading)
	loadconfigdata(&MConf_ObjectiveLeadingReward)
	loadconfigdata(&MConf_ObjectiveLeadingReward_act2)
	loadconfigdata(&MConf_Artifact)
	loadconfigdata(&MConf_ArtifactCost)
	loadconfigdata(&MConf_ArtifactModel)
	loadconfigdata(&MConf_ResourceChapter)
	loadconfigdata(&MConf_ResourceCampaign)
	loadconfigdata(&MConf_ResourceMonsterBase)
	loadconfigdata(&MConf_ResourceMonsterBehavior)
	loadconfigdata(&MConf_ResourceCampaignArmy)
	loadconfigdata(&MConf_EquipDecomposeExtra)
	loadconfigdata(&MConf_ResolveHero)
	loadconfigdata(&MConf_ResolveEquipment)
	loadconfigdata(&MConf_ResolveTreasure)
	loadconfigdata(&MConf_ResolveRunes)
	loadconfigdata(&MConf_ResolvePet)
	loadconfigdata(&MConf_PrisonMonsterBase)
	loadconfigdata(&MConf_PrisonBehavior)
	loadconfigdata(&MConf_PrisonCampaignArmy)
	loadconfigdata(&MConf_Prison)
	loadconfigdata(&MConf_PrisonReward)
	loadconfigdata(&MConf_PrisonCampaign)
	loadconfigdata(&MConf_Welfare)
	loadconfigdata(&MConf_WelfareDrop)
	loadconfigdata(&MConf_Title)
	loadconfigdata(&MConf_TitleShow)
	loadconfigdata(&MConf_ArenaGradeReward)
	loadconfigdata(&MConf_ArenaHistoryGradeReward)
	loadconfigdata(&MConf_ArenaGoalReward)
	loadconfigdata(&MConf_ArenaScoreReward)
	loadconfigdata(&MConf_ArenaGradeReward_act1)
	loadconfigdata(&MConf_ArenaGradeReward_act2)
	loadconfigdata(&MConf_RunesBase)
	loadconfigdata(&MConf_RunesStep)
	loadconfigdata(&MConf_RunesSuit)
	loadconfigdata(&MConf_RunesName)
	loadconfigdata(&MConf_RunesUnlock)
	loadconfigdata(&MConf_Carnival2)
	loadconfigdata(&MConf_Carnival2Quset)
	loadconfigdata(&MConf_Carnival2Sale)
	loadconfigdata(&MConf_Carnival2Reward)
	loadconfigdata(&MConf_Sign)
	loadconfigdata(&MConf_SignNum)
	loadconfigdata(&MConf_FateFightChapter)
	loadconfigdata(&MConf_FateFightCampaign)
	loadconfigdata(&MConf_FateFightCampaignReward)
	loadconfigdata(&MConf_FateFightMonsterBase)
	loadconfigdata(&MConf_FateFightMonsterBehavior)
	loadconfigdata(&MConf_FateFightCampaignArmy)
	loadconfigdata(&MConf_Valhalla)
	loadconfigdata(&MConf_IntimacyEXP)
	loadconfigdata(&MConf_HeroBase)
	loadconfigdata(&MConf_HeroStep)
	loadconfigdata(&MConf_HeroExp)
	loadconfigdata(&MConf_HeroExpGrow)
	loadconfigdata(&MConf_HeroAmity)
	loadconfigdata(&MConf_HeroCompose)
	loadconfigdata(&MConf_HeroAwake)
	loadconfigdata(&MConf_HeroArmy)
	loadconfigdata(&MConf_HeroTalent)
	loadconfigdata(&MConf_HeroTalentCost)
	loadconfigdata(&MConf_HeroExpGrow_act1)
	loadconfigdata(&MConf_HeroExpGrow_act2)
	loadconfigdata(&MConf_HeroExp_act2)
	loadconfigdata(&MConf_HeroStep_act2)
	loadconfigdata(&MConf_HeroAwake_act2)
	loadconfigdata(&MConf_Guide)
	loadconfigdata(&MConf_GuideDes)
	loadconfigdata(&MConf_RunesOutput)
	loadconfigdata(&MConf_RunesDrop)
	loadconfigdata(&MConf_EquipmentPromote)
	loadconfigdata(&MConf_EquipmentSuit)
	loadconfigdata(&MConf_EquipmentAwake)
	loadconfigdata(&MConf_EquipmentEnchant)
	loadconfigdata(&MConf_EquipmentEnchantQuality)
	loadconfigdata(&MConf_EquipmentEnchantExp)
	loadconfigdata(&MConf_EquipmentStrengMaster)
	loadconfigdata(&MConf_EquipmentRefineMaster)
	loadconfigdata(&MConf_RecommendEquip)
	loadconfigdata(&MConf_WrestlingStrength)
	loadconfigdata(&MConf_WrestlingReward)
	loadconfigdata(&MConf_WrestlingGold)
	loadconfigdata(&MConf_WrestlingMap)
	loadconfigdata(&MConf_CrusadeChapter)
	loadconfigdata(&MConf_CrusadeCampaign)
	loadconfigdata(&MConf_CrusadeCampaignReward)
	loadconfigdata(&MConf_CruasdeBloodLoop)
	loadconfigdata(&MConf_CrusadeMonsterBase)
	loadconfigdata(&MConf_CrusadeMonsterBehavior)
	loadconfigdata(&MConf_CrusadeCampaignArmy)
	loadconfigdata(&MConf_BuyTimes)
	loadconfigdata(&MConf_BuyTimes_act1)
	loadconfigdata(&MConf_BuyTimes_act2)
	loadconfigdata(&MConf_Vein)
	loadconfigdata(&MConf_VeinMap)
	loadconfigdata(&MConf_PublicArenaRankReward)
	loadconfigdata(&MConf_PublicArenaDayReward)
	loadconfigdata(&MConf_PublicArenaEnemy)
	loadconfigdata(&MConf_LeagueMatchRankLevel)
	loadconfigdata(&MConf_LeagueMatchReward)
	loadconfigdata(&MConf_LeagueMatchMap)
	loadconfigdata(&MConf_LeagueMatchChestOrder)
	loadconfigdata(&MConf_LeagueMatchChestType)
	loadconfigdata(&MConf_LeagueMatchChestReward)
	loadconfigdata(&MConf_GrowthFund)
	loadconfigdata(&MConf_DoubleDrop)
	loadconfigdata(&MConf_ArenaRankReward)
	loadconfigdata(&MConf_ArenaRankReward_act1)
	loadconfigdata(&MConf_Item)
	loadconfigdata(&MConf_DropPackage)
	loadconfigdata(&MConf_Item_act1)
	loadconfigdata(&MConf_DropPackage_act1)
	loadconfigdata(&MConf_Item_act2)
	loadconfigdata(&MConf_DropPackage_act2)
	loadconfigdata(&MConf_Tavern)
	loadconfigdata(&MConf_TavernHeroDrop)
	loadconfigdata(&MConf_TavernPreview)
	loadconfigdata(&MConf_TavernLoop)
	loadconfigdata(&MConf_TavernEquipmentLoop)
	loadconfigdata(&MConf_TavernEquipPreview)
	loadconfigdata(&MConf_TavernHeroBlessing)
	loadconfigdata(&MConf_TavernHeroDrop_act1)
	loadconfigdata(&MConf_TavernHeroDrop_act2)
	loadconfigdata(&MConf_BossChallengeChapter)
	loadconfigdata(&MConf_BossChallengeCampaign)
	loadconfigdata(&MConf_BossChanllengeGetLevel)
	loadconfigdata(&MConf_BossChallengeReward)
	loadconfigdata(&MConf_BossChallengeRewardNew)
	loadconfigdata(&MConf_BossChallengeDamage)
	loadconfigdata(&MConf_BossChallengeDamageGrow)
	loadconfigdata(&MConf_BossChallengeRank)
	loadconfigdata(&MConf_BossChallengeCurveRank)
	loadconfigdata(&MConf_BossChallengeRewardNew_act1)
	loadconfigdata(&MConf_BossChallengeRank_act1)
	loadconfigdata(&MConf_BossChallengeCurveRank_act1)
	loadconfigdata(&MConf_BossChallengeRewardNew_act2)
	loadconfigdata(&MConf_BossChallengeRank_act2)
	loadconfigdata(&MConf_BossChallengeCurveRank_act2)
	loadconfigdata(&MConf_BossChallengeMonsterBase)
	loadconfigdata(&MConf_BossChallengeBehavior)
	loadconfigdata(&MConf_BossChallengeCampaignArmy)
	loadconfigdata(&MConf_ErrorDefine)
	loadconfigdata(&MConf_randname)
	loadconfigdata(&MConf_InscriptionLevelUp)
	loadconfigdata(&MConf_InscriptionActive)
	loadconfigdata(&MConf_GlyphsBase)
	loadconfigdata(&MConf_GlyphsExp)
	loadconfigdata(&MConf_GlyphsStrengthen)
	loadconfigdata(&MConf_GlyphsCompose)
	loadconfigdata(&MConf_audio)
	loadconfigdata(&MConf_CupSupportReward)
	loadconfigdata(&MConf_CupRankReward)
	loadconfigdata(&MConf_CupMap)
	loadconfigdata(&MConf_DomainMap)
	loadconfigdata(&MConf_DomainBuildingEnemy)
	loadconfigdata(&MConf_DomainMineMonsterBase)
	loadconfigdata(&MConf_DomainMineMonsterBehavior)
	loadconfigdata(&MConf_DomainMineArmy)
	loadconfigdata(&MConf_DomainBase)
	loadconfigdata(&MConf_DomainMonster)
	loadconfigdata(&MConf_DomainQuestReward)
	loadconfigdata(&MConf_HeroExpReward)
	loadconfigdata(&MConf_DomainQuest)
	loadconfigdata(&MConf_BuySuccessRatio)
	loadconfigdata(&MConf_DomainQuestHeroMax)
	loadconfigdata(&MConf_DomainOpen)
	loadconfigdata(&MConf_DomainType)
	loadconfigdata(&MConf_Domain)
	loadconfigdata(&MConf_DomainBuildingReward)
	loadconfigdata(&MConf_DomainMineReward)
	loadconfigdata(&MConf_DomainMineProduct)
	loadconfigdata(&MConf_DomainChestReward)
	loadconfigdata(&MConf_JewelryStep)
	loadconfigdata(&MConf_BlackShop)
}
func HotUpdateConfigData(sheetname string) bool {
	switch sheetname {
	case "Quest30":
		m :=map[string]*Conf_Quest30{}
		loadconfigdata(&m)
		MConf_Quest30 = m
		return true
	case "Quest30Reward":
		m :=map[string]*Conf_Quest30Reward{}
		loadconfigdata(&m)
		MConf_Quest30Reward = m
		return true
	case "character":
		m :=map[string]*Conf_character{}
		loadconfigdata(&m)
		MConf_character = m
		return true
	case "job":
		m :=map[string]*Conf_job{}
		loadconfigdata(&m)
		MConf_job = m
		return true
	case "array":
		m :=map[string]*Conf_array{}
		loadconfigdata(&m)
		MConf_array = m
		return true
	case "ctrl":
		m :=map[string]*Conf_ctrl{}
		loadconfigdata(&m)
		MConf_ctrl = m
		return true
	case "Loading":
		m :=map[string]*Conf_Loading{}
		loadconfigdata(&m)
		MConf_Loading = m
		return true
	case "NPCBase":
		m :=map[string]*Conf_NPCBase{}
		loadconfigdata(&m)
		MConf_NPCBase = m
		return true
	case "VIPPrivilege":
		m :=map[string]*Conf_VIPPrivilege{}
		loadconfigdata(&m)
		MConf_VIPPrivilege = m
		return true
	case "VIPReward":
		m :=map[string]*Conf_VIPReward{}
		loadconfigdata(&m)
		MConf_VIPReward = m
		return true
	case "VIPDesc":
		m :=map[string]*Conf_VIPDesc{}
		loadconfigdata(&m)
		MConf_VIPDesc = m
		return true
	case "ChangeCard":
		m :=map[string]*Conf_ChangeCard{}
		loadconfigdata(&m)
		MConf_ChangeCard = m
		return true
	case "WorldBossCampaign":
		m :=map[string]*Conf_WorldBossCampaign{}
		loadconfigdata(&m)
		MConf_WorldBossCampaign = m
		return true
	case "WorldBossReward":
		m :=map[string]*Conf_WorldBossReward{}
		loadconfigdata(&m)
		MConf_WorldBossReward = m
		return true
	case "WorldBossOnceRank":
		m :=map[string]*Conf_WorldBossOnceRank{}
		loadconfigdata(&m)
		MConf_WorldBossOnceRank = m
		return true
	case "WorldBossCurveRank":
		m :=map[string]*Conf_WorldBossCurveRank{}
		loadconfigdata(&m)
		MConf_WorldBossCurveRank = m
		return true
	case "GlobalConfig":
		m :=map[string]*Conf_GlobalConfig{}
		loadconfigdata(&m)
		MConf_GlobalConfig = m
		return true
	case "WorldBossOnceRank__act1":
		m :=map[string]*Conf_WorldBossOnceRank__act1{}
		loadconfigdata(&m)
		MConf_WorldBossOnceRank__act1 = m
		return true
	case "WorldBossCurveRank_act1":
		m :=map[string]*Conf_WorldBossCurveRank_act1{}
		loadconfigdata(&m)
		MConf_WorldBossCurveRank_act1 = m
		return true
	case "WorldBossMonsterBase":
		m :=map[string]*Conf_WorldBossMonsterBase{}
		loadconfigdata(&m)
		MConf_WorldBossMonsterBase = m
		return true
	case "WorldBossBehavior":
		m :=map[string]*Conf_WorldBossBehavior{}
		loadconfigdata(&m)
		MConf_WorldBossBehavior = m
		return true
	case "WorldBossCampaignArmy":
		m :=map[string]*Conf_WorldBossCampaignArmy{}
		loadconfigdata(&m)
		MConf_WorldBossCampaignArmy = m
		return true
	case "PlayerUpgradeExp":
		m :=map[string]*Conf_PlayerUpgradeExp{}
		loadconfigdata(&m)
		MConf_PlayerUpgradeExp = m
		return true
	case "PlayerUpgradeExp_act2":
		m :=map[string]*Conf_PlayerUpgradeExp_act2{}
		loadconfigdata(&m)
		MConf_PlayerUpgradeExp_act2 = m
		return true
	case "Quest":
		m :=map[string]*Conf_Quest{}
		loadconfigdata(&m)
		MConf_Quest = m
		return true
	case "QuestReward":
		m :=map[string]*Conf_QuestReward{}
		loadconfigdata(&m)
		MConf_QuestReward = m
		return true
	case "ActiveReward":
		m :=map[string]*Conf_ActiveReward{}
		loadconfigdata(&m)
		MConf_ActiveReward = m
		return true
	case "QuestReward_act2":
		m :=map[string]*Conf_QuestReward_act2{}
		loadconfigdata(&m)
		MConf_QuestReward_act2 = m
		return true
	case "InheritPrice":
		m :=map[string]*Conf_InheritPrice{}
		loadconfigdata(&m)
		MConf_InheritPrice = m
		return true
	case "GoldPrice":
		m :=map[string]*Conf_GoldPrice{}
		loadconfigdata(&m)
		MConf_GoldPrice = m
		return true
	case "SquireSlots":
		m :=map[string]*Conf_SquireSlots{}
		loadconfigdata(&m)
		MConf_SquireSlots = m
		return true
	case "SquireSlotsAdd":
		m :=map[string]*Conf_SquireSlotsAdd{}
		loadconfigdata(&m)
		MConf_SquireSlotsAdd = m
		return true
	case "Squire":
		m :=map[string]*Conf_Squire{}
		loadconfigdata(&m)
		MConf_Squire = m
		return true
	case "Wares":
		m :=map[string]*Conf_Wares{}
		loadconfigdata(&m)
		MConf_Wares = m
		return true
	case "SVIPConfig":
		m :=map[string]*Conf_SVIPConfig{}
		loadconfigdata(&m)
		MConf_SVIPConfig = m
		return true
	case "GlobalConfig_act2":
		m :=map[string]*Conf_GlobalConfig_act2{}
		loadconfigdata(&m)
		MConf_GlobalConfig_act2 = m
		return true
	case "Illidan":
		m :=map[string]*Conf_Illidan{}
		loadconfigdata(&m)
		MConf_Illidan = m
		return true
	case "IllidanSpend":
		m :=map[string]*Conf_IllidanSpend{}
		loadconfigdata(&m)
		MConf_IllidanSpend = m
		return true
	case "IllidanProbability":
		m :=map[string]*Conf_IllidanProbability{}
		loadconfigdata(&m)
		MConf_IllidanProbability = m
		return true
	case "IllidanRward":
		m :=map[string]*Conf_IllidanRward{}
		loadconfigdata(&m)
		MConf_IllidanRward = m
		return true
	case "IllidanLoop":
		m :=map[string]*Conf_IllidanLoop{}
		loadconfigdata(&m)
		MConf_IllidanLoop = m
		return true
	case "GuildChapter":
		m :=map[string]*Conf_GuildChapter{}
		loadconfigdata(&m)
		MConf_GuildChapter = m
		return true
	case "GuildCampaign":
		m :=map[string]*Conf_GuildCampaign{}
		loadconfigdata(&m)
		MConf_GuildCampaign = m
		return true
	case "GuildCampaignReward":
		m :=map[string]*Conf_GuildCampaignReward{}
		loadconfigdata(&m)
		MConf_GuildCampaignReward = m
		return true
	case "GuildRaidRank":
		m :=map[string]*Conf_GuildRaidRank{}
		loadconfigdata(&m)
		MConf_GuildRaidRank = m
		return true
	case "GuildCampaignReward_act1":
		m :=map[string]*Conf_GuildCampaignReward_act1{}
		loadconfigdata(&m)
		MConf_GuildCampaignReward_act1 = m
		return true
	case "GuildRaidRank_act1":
		m :=map[string]*Conf_GuildRaidRank_act1{}
		loadconfigdata(&m)
		MConf_GuildRaidRank_act1 = m
		return true
	case "GuildRaidRank_act2":
		m :=map[string]*Conf_GuildRaidRank_act2{}
		loadconfigdata(&m)
		MConf_GuildRaidRank_act2 = m
		return true
	case "GuildCampaignReward_act2":
		m :=map[string]*Conf_GuildCampaignReward_act2{}
		loadconfigdata(&m)
		MConf_GuildCampaignReward_act2 = m
		return true
	case "GuildRaidBuild":
		m :=map[string]*Conf_GuildRaidBuild{}
		loadconfigdata(&m)
		MConf_GuildRaidBuild = m
		return true
	case "GuildMonsterBase":
		m :=map[string]*Conf_GuildMonsterBase{}
		loadconfigdata(&m)
		MConf_GuildMonsterBase = m
		return true
	case "GuildMonsterBehavior":
		m :=map[string]*Conf_GuildMonsterBehavior{}
		loadconfigdata(&m)
		MConf_GuildMonsterBehavior = m
		return true
	case "GuildCampaignArmy":
		m :=map[string]*Conf_GuildCampaignArmy{}
		loadconfigdata(&m)
		MConf_GuildCampaignArmy = m
		return true
	case "Guild":
		m :=map[string]*Conf_Guild{}
		loadconfigdata(&m)
		MConf_Guild = m
		return true
	case "GuildProgressReward":
		m :=map[string]*Conf_GuildProgressReward{}
		loadconfigdata(&m)
		MConf_GuildProgressReward = m
		return true
	case "GuildUnlock":
		m :=map[string]*Conf_GuildUnlock{}
		loadconfigdata(&m)
		MConf_GuildUnlock = m
		return true
	case "LegionInvasion":
		m :=map[string]*Conf_LegionInvasion{}
		loadconfigdata(&m)
		MConf_LegionInvasion = m
		return true
	case "LegionCampaign":
		m :=map[string]*Conf_LegionCampaign{}
		loadconfigdata(&m)
		MConf_LegionCampaign = m
		return true
	case "LegionReward":
		m :=map[string]*Conf_LegionReward{}
		loadconfigdata(&m)
		MConf_LegionReward = m
		return true
	case "LegionReward_act2":
		m :=map[string]*Conf_LegionReward_act2{}
		loadconfigdata(&m)
		MConf_LegionReward_act2 = m
		return true
	case "LegionMonsterBase":
		m :=map[string]*Conf_LegionMonsterBase{}
		loadconfigdata(&m)
		MConf_LegionMonsterBase = m
		return true
	case "LegionMonsterBehavior":
		m :=map[string]*Conf_LegionMonsterBehavior{}
		loadconfigdata(&m)
		MConf_LegionMonsterBehavior = m
		return true
	case "LegionArmy":
		m :=map[string]*Conf_LegionArmy{}
		loadconfigdata(&m)
		MConf_LegionArmy = m
		return true
	case "BlackTempleCampaign":
		m :=map[string]*Conf_BlackTempleCampaign{}
		loadconfigdata(&m)
		MConf_BlackTempleCampaign = m
		return true
	case "BlackTempleReward":
		m :=map[string]*Conf_BlackTempleReward{}
		loadconfigdata(&m)
		MConf_BlackTempleReward = m
		return true
	case "BlackTempleMonsterBase":
		m :=map[string]*Conf_BlackTempleMonsterBase{}
		loadconfigdata(&m)
		MConf_BlackTempleMonsterBase = m
		return true
	case "BlackTempleMonsterBehavior":
		m :=map[string]*Conf_BlackTempleMonsterBehavior{}
		loadconfigdata(&m)
		MConf_BlackTempleMonsterBehavior = m
		return true
	case "BlackTempleCampaignArmy":
		m :=map[string]*Conf_BlackTempleCampaignArmy{}
		loadconfigdata(&m)
		MConf_BlackTempleCampaignArmy = m
		return true
	case "Chapter":
		m :=map[string]*Conf_Chapter{}
		loadconfigdata(&m)
		MConf_Chapter = m
		return true
	case "Campaign":
		m :=map[string]*Conf_Campaign{}
		loadconfigdata(&m)
		MConf_Campaign = m
		return true
	case "CampaignReward":
		m :=map[string]*Conf_CampaignReward{}
		loadconfigdata(&m)
		MConf_CampaignReward = m
		return true
	case "CampainWhiteList":
		m :=map[string]*Conf_CampainWhiteList{}
		loadconfigdata(&m)
		MConf_CampainWhiteList = m
		return true
	case "CampaignReward_act2":
		m :=map[string]*Conf_CampaignReward_act2{}
		loadconfigdata(&m)
		MConf_CampaignReward_act2 = m
		return true
	case "MonsterBase":
		m :=map[string]*Conf_MonsterBase{}
		loadconfigdata(&m)
		MConf_MonsterBase = m
		return true
	case "MonsterBehavior":
		m :=map[string]*Conf_MonsterBehavior{}
		loadconfigdata(&m)
		MConf_MonsterBehavior = m
		return true
	case "CampaignArmy":
		m :=map[string]*Conf_CampaignArmy{}
		loadconfigdata(&m)
		MConf_CampaignArmy = m
		return true
	case "CampaignArmy_act1":
		m :=map[string]*Conf_CampaignArmy_act1{}
		loadconfigdata(&m)
		MConf_CampaignArmy_act1 = m
		return true
	case "CampaignArmy_act2":
		m :=map[string]*Conf_CampaignArmy_act2{}
		loadconfigdata(&m)
		MConf_CampaignArmy_act2 = m
		return true
	case "FunctionOpen":
		m :=map[string]*Conf_FunctionOpen{}
		loadconfigdata(&m)
		MConf_FunctionOpen = m
		return true
	case "Tutorial":
		m :=map[string]*Conf_Tutorial{}
		loadconfigdata(&m)
		MConf_Tutorial = m
		return true
	case "TutorialItemList":
		m :=map[string]*Conf_TutorialItemList{}
		loadconfigdata(&m)
		MConf_TutorialItemList = m
		return true
	case "Compose":
		m :=map[string]*Conf_Compose{}
		loadconfigdata(&m)
		MConf_Compose = m
		return true
	case "ShopConfig":
		m :=map[string]*Conf_ShopConfig{}
		loadconfigdata(&m)
		MConf_ShopConfig = m
		return true
	case "ShopItemResetTime":
		m :=map[string]*Conf_ShopItemResetTime{}
		loadconfigdata(&m)
		MConf_ShopItemResetTime = m
		return true
	case "Shop":
		m :=map[string]*Conf_Shop{}
		loadconfigdata(&m)
		MConf_Shop = m
		return true
	case "ShopRandom":
		m :=map[string]*Conf_ShopRandom{}
		loadconfigdata(&m)
		MConf_ShopRandom = m
		return true
	case "VIPShop":
		m :=map[string]*Conf_VIPShop{}
		loadconfigdata(&m)
		MConf_VIPShop = m
		return true
	case "Shop_act1":
		m :=map[string]*Conf_Shop_act1{}
		loadconfigdata(&m)
		MConf_Shop_act1 = m
		return true
	case "Shop_act2":
		m :=map[string]*Conf_Shop_act2{}
		loadconfigdata(&m)
		MConf_Shop_act2 = m
		return true
	case "KnowledgeLevel":
		m :=map[string]*Conf_KnowledgeLevel{}
		loadconfigdata(&m)
		MConf_KnowledgeLevel = m
		return true
	case "KnowledgeStep":
		m :=map[string]*Conf_KnowledgeStep{}
		loadconfigdata(&m)
		MConf_KnowledgeStep = m
		return true
	case "BGM":
		m :=map[string]*Conf_BGM{}
		loadconfigdata(&m)
		MConf_BGM = m
		return true
	case "FrameShop":
		m :=map[string]*Conf_FrameShop{}
		loadconfigdata(&m)
		MConf_FrameShop = m
		return true
	case "FullClientReward":
		m :=map[string]*Conf_FullClientReward{}
		loadconfigdata(&m)
		MConf_FullClientReward = m
		return true
	case "EquipmentExp":
		m :=map[string]*Conf_EquipmentExp{}
		loadconfigdata(&m)
		MConf_EquipmentExp = m
		return true
	case "EquipmentExpGrow":
		m :=map[string]*Conf_EquipmentExpGrow{}
		loadconfigdata(&m)
		MConf_EquipmentExpGrow = m
		return true
	case "EquipmentBase":
		m :=map[string]*Conf_EquipmentBase{}
		loadconfigdata(&m)
		MConf_EquipmentBase = m
		return true
	case "EquipmentStep":
		m :=map[string]*Conf_EquipmentStep{}
		loadconfigdata(&m)
		MConf_EquipmentStep = m
		return true
	case "EquipmentActivation":
		m :=map[string]*Conf_EquipmentActivation{}
		loadconfigdata(&m)
		MConf_EquipmentActivation = m
		return true
	case "GemBase":
		m :=map[string]*Conf_GemBase{}
		loadconfigdata(&m)
		MConf_GemBase = m
		return true
	case "GemSuit":
		m :=map[string]*Conf_GemSuit{}
		loadconfigdata(&m)
		MConf_GemSuit = m
		return true
	case "GemDrop":
		m :=map[string]*Conf_GemDrop{}
		loadconfigdata(&m)
		MConf_GemDrop = m
		return true
	case "GemOutput":
		m :=map[string]*Conf_GemOutput{}
		loadconfigdata(&m)
		MConf_GemOutput = m
		return true
	case "PetShow":
		m :=map[string]*Conf_PetShow{}
		loadconfigdata(&m)
		MConf_PetShow = m
		return true
	case "PetBase":
		m :=map[string]*Conf_PetBase{}
		loadconfigdata(&m)
		MConf_PetBase = m
		return true
	case "PetStep":
		m :=map[string]*Conf_PetStep{}
		loadconfigdata(&m)
		MConf_PetStep = m
		return true
	case "PetEffect":
		m :=map[string]*Conf_PetEffect{}
		loadconfigdata(&m)
		MConf_PetEffect = m
		return true
	case "Dialogue":
		m :=map[string]*Conf_Dialogue{}
		loadconfigdata(&m)
		MConf_Dialogue = m
		return true
	case "ShieldingWord":
		m :=map[string]*Conf_ShieldingWord{}
		loadconfigdata(&m)
		MConf_ShieldingWord = m
		return true
	case "LevelCoefficient":
		m :=map[string]*Conf_LevelCoefficient{}
		loadconfigdata(&m)
		MConf_LevelCoefficient = m
		return true
	case "CarnivalOpenDay":
		m :=map[string]*Conf_CarnivalOpenDay{}
		loadconfigdata(&m)
		MConf_CarnivalOpenDay = m
		return true
	case "CarnivalItems":
		m :=map[string]*Conf_CarnivalItems{}
		loadconfigdata(&m)
		MConf_CarnivalItems = m
		return true
	case "CarnivalTotle":
		m :=map[string]*Conf_CarnivalTotle{}
		loadconfigdata(&m)
		MConf_CarnivalTotle = m
		return true
	case "CarnivalReward":
		m :=map[string]*Conf_CarnivalReward{}
		loadconfigdata(&m)
		MConf_CarnivalReward = m
		return true
	case "CarnivaSell":
		m :=map[string]*Conf_CarnivaSell{}
		loadconfigdata(&m)
		MConf_CarnivaSell = m
		return true
	case "CarnivalItems_act2":
		m :=map[string]*Conf_CarnivalItems_act2{}
		loadconfigdata(&m)
		MConf_CarnivalItems_act2 = m
		return true
	case "CarnivalReward_act2":
		m :=map[string]*Conf_CarnivalReward_act2{}
		loadconfigdata(&m)
		MConf_CarnivalReward_act2 = m
		return true
	case "BeginRank":
		m :=map[string]*Conf_BeginRank{}
		loadconfigdata(&m)
		MConf_BeginRank = m
		return true
	case "BeginRankReward":
		m :=map[string]*Conf_BeginRankReward{}
		loadconfigdata(&m)
		MConf_BeginRankReward = m
		return true
	case "BeginRankNotice":
		m :=map[string]*Conf_BeginRankNotice{}
		loadconfigdata(&m)
		MConf_BeginRankNotice = m
		return true
	case "BeginCheckIn":
		m :=map[string]*Conf_BeginCheckIn{}
		loadconfigdata(&m)
		MConf_BeginCheckIn = m
		return true
	case "BeginCheckInReward":
		m :=map[string]*Conf_BeginCheckInReward{}
		loadconfigdata(&m)
		MConf_BeginCheckInReward = m
		return true
	case "Monster":
		m :=map[string]*Conf_Monster{}
		loadconfigdata(&m)
		MConf_Monster = m
		return true
	case "MonsterType":
		m :=map[string]*Conf_MonsterType{}
		loadconfigdata(&m)
		MConf_MonsterType = m
		return true
	case "MonsterPP":
		m :=map[string]*Conf_MonsterPP{}
		loadconfigdata(&m)
		MConf_MonsterPP = m
		return true
	case "Monster_act2":
		m :=map[string]*Conf_Monster_act2{}
		loadconfigdata(&m)
		MConf_Monster_act2 = m
		return true
	case "WantStrong":
		m :=map[string]*Conf_WantStrong{}
		loadconfigdata(&m)
		MConf_WantStrong = m
		return true
	case "BattlefieldFightReward":
		m :=map[string]*Conf_BattlefieldFightReward{}
		loadconfigdata(&m)
		MConf_BattlefieldFightReward = m
		return true
	case "BattlefieldGradeReward":
		m :=map[string]*Conf_BattlefieldGradeReward{}
		loadconfigdata(&m)
		MConf_BattlefieldGradeReward = m
		return true
	case "FightCommonList":
		m :=map[string]*Conf_FightCommonList{}
		loadconfigdata(&m)
		MConf_FightCommonList = m
		return true
	case "BattleEffectiveness":
		m :=map[string]*Conf_BattleEffectiveness{}
		loadconfigdata(&m)
		MConf_BattleEffectiveness = m
		return true
	case "FigthTutorial":
		m :=map[string]*Conf_FigthTutorial{}
		loadconfigdata(&m)
		MConf_FigthTutorial = m
		return true
	case "AchievementDesc":
		m :=map[string]*Conf_AchievementDesc{}
		loadconfigdata(&m)
		MConf_AchievementDesc = m
		return true
	case "CameraConfig":
		m :=map[string]*Conf_CameraConfig{}
		loadconfigdata(&m)
		MConf_CameraConfig = m
		return true
	case "Push":
		m :=map[string]*Conf_Push{}
		loadconfigdata(&m)
		MConf_Push = m
		return true
	case "SkillBase":
		m :=map[string]*Conf_SkillBase{}
		loadconfigdata(&m)
		MConf_SkillBase = m
		return true
	case "SkillStrength":
		m :=map[string]*Conf_SkillStrength{}
		loadconfigdata(&m)
		MConf_SkillStrength = m
		return true
	case "SkillPassive":
		m :=map[string]*Conf_SkillPassive{}
		loadconfigdata(&m)
		MConf_SkillPassive = m
		return true
	case "SkillExp":
		m :=map[string]*Conf_SkillExp{}
		loadconfigdata(&m)
		MConf_SkillExp = m
		return true
	case "ConvoyStarProbability":
		m :=map[string]*Conf_ConvoyStarProbability{}
		loadconfigdata(&m)
		MConf_ConvoyStarProbability = m
		return true
	case "ConvoyReward":
		m :=map[string]*Conf_ConvoyReward{}
		loadconfigdata(&m)
		MConf_ConvoyReward = m
		return true
	case "ConvoyMap":
		m :=map[string]*Conf_ConvoyMap{}
		loadconfigdata(&m)
		MConf_ConvoyMap = m
		return true
	case "ModelClothesBase":
		m :=map[string]*Conf_ModelClothesBase{}
		loadconfigdata(&m)
		MConf_ModelClothesBase = m
		return true
	case "RecommendTroops":
		m :=map[string]*Conf_RecommendTroops{}
		loadconfigdata(&m)
		MConf_RecommendTroops = m
		return true
	case "Effect":
		m :=map[string]*Conf_Effect{}
		loadconfigdata(&m)
		MConf_Effect = m
		return true
	case "PlayerClick":
		m :=map[string]*Conf_PlayerClick{}
		loadconfigdata(&m)
		MConf_PlayerClick = m
		return true
	case "DailyActivities":
		m :=map[string]*Conf_DailyActivities{}
		loadconfigdata(&m)
		MConf_DailyActivities = m
		return true
	case "TimeCaveChapter":
		m :=map[string]*Conf_TimeCaveChapter{}
		loadconfigdata(&m)
		MConf_TimeCaveChapter = m
		return true
	case "TimeCaveCampaign":
		m :=map[string]*Conf_TimeCaveCampaign{}
		loadconfigdata(&m)
		MConf_TimeCaveCampaign = m
		return true
	case "TimeCaveCampaignReward":
		m :=map[string]*Conf_TimeCaveCampaignReward{}
		loadconfigdata(&m)
		MConf_TimeCaveCampaignReward = m
		return true
	case "TimeCaveDropChest":
		m :=map[string]*Conf_TimeCaveDropChest{}
		loadconfigdata(&m)
		MConf_TimeCaveDropChest = m
		return true
	case "TimeCaveMonsterBase":
		m :=map[string]*Conf_TimeCaveMonsterBase{}
		loadconfigdata(&m)
		MConf_TimeCaveMonsterBase = m
		return true
	case "TimeCaveMonsterBehavior":
		m :=map[string]*Conf_TimeCaveMonsterBehavior{}
		loadconfigdata(&m)
		MConf_TimeCaveMonsterBehavior = m
		return true
	case "TimeCaveCampaignArmy":
		m :=map[string]*Conf_TimeCaveCampaignArmy{}
		loadconfigdata(&m)
		MConf_TimeCaveCampaignArmy = m
		return true
	case "SeverString":
		m :=map[string]*Conf_SeverString{}
		loadconfigdata(&m)
		MConf_SeverString = m
		return true
	case "ActivityBack":
		m :=map[string]*Conf_ActivityBack{}
		loadconfigdata(&m)
		MConf_ActivityBack = m
		return true
	case "JoyMachine":
		m :=map[string]*Conf_JoyMachine{}
		loadconfigdata(&m)
		MConf_JoyMachine = m
		return true
	case "JoyMachineOutput":
		m :=map[string]*Conf_JoyMachineOutput{}
		loadconfigdata(&m)
		MConf_JoyMachineOutput = m
		return true
	case "JoyMachinePrice":
		m :=map[string]*Conf_JoyMachinePrice{}
		loadconfigdata(&m)
		MConf_JoyMachinePrice = m
		return true
	case "daily":
		m :=map[string]*Conf_daily{}
		loadconfigdata(&m)
		MConf_daily = m
		return true
	case "TempleChapter":
		m :=map[string]*Conf_TempleChapter{}
		loadconfigdata(&m)
		MConf_TempleChapter = m
		return true
	case "TempleCampaign":
		m :=map[string]*Conf_TempleCampaign{}
		loadconfigdata(&m)
		MConf_TempleCampaign = m
		return true
	case "TempleRward":
		m :=map[string]*Conf_TempleRward{}
		loadconfigdata(&m)
		MConf_TempleRward = m
		return true
	case "TempleMonsterBase":
		m :=map[string]*Conf_TempleMonsterBase{}
		loadconfigdata(&m)
		MConf_TempleMonsterBase = m
		return true
	case "TempleMonsterBehavior":
		m :=map[string]*Conf_TempleMonsterBehavior{}
		loadconfigdata(&m)
		MConf_TempleMonsterBehavior = m
		return true
	case "TempleCampaignArmy":
		m :=map[string]*Conf_TempleCampaignArmy{}
		loadconfigdata(&m)
		MConf_TempleCampaignArmy = m
		return true
	case "ObjectiveLeading":
		m :=map[string]*Conf_ObjectiveLeading{}
		loadconfigdata(&m)
		MConf_ObjectiveLeading = m
		return true
	case "ObjectiveLeadingReward":
		m :=map[string]*Conf_ObjectiveLeadingReward{}
		loadconfigdata(&m)
		MConf_ObjectiveLeadingReward = m
		return true
	case "ObjectiveLeadingReward_act2":
		m :=map[string]*Conf_ObjectiveLeadingReward_act2{}
		loadconfigdata(&m)
		MConf_ObjectiveLeadingReward_act2 = m
		return true
	case "Artifact":
		m :=map[string]*Conf_Artifact{}
		loadconfigdata(&m)
		MConf_Artifact = m
		return true
	case "ArtifactCost":
		m :=map[string]*Conf_ArtifactCost{}
		loadconfigdata(&m)
		MConf_ArtifactCost = m
		return true
	case "ArtifactModel":
		m :=map[string]*Conf_ArtifactModel{}
		loadconfigdata(&m)
		MConf_ArtifactModel = m
		return true
	case "ResourceChapter":
		m :=map[string]*Conf_ResourceChapter{}
		loadconfigdata(&m)
		MConf_ResourceChapter = m
		return true
	case "ResourceCampaign":
		m :=map[string]*Conf_ResourceCampaign{}
		loadconfigdata(&m)
		MConf_ResourceCampaign = m
		return true
	case "ResourceMonsterBase":
		m :=map[string]*Conf_ResourceMonsterBase{}
		loadconfigdata(&m)
		MConf_ResourceMonsterBase = m
		return true
	case "ResourceMonsterBehavior":
		m :=map[string]*Conf_ResourceMonsterBehavior{}
		loadconfigdata(&m)
		MConf_ResourceMonsterBehavior = m
		return true
	case "ResourceCampaignArmy":
		m :=map[string]*Conf_ResourceCampaignArmy{}
		loadconfigdata(&m)
		MConf_ResourceCampaignArmy = m
		return true
	case "EquipDecomposeExtra":
		m :=map[string]*Conf_EquipDecomposeExtra{}
		loadconfigdata(&m)
		MConf_EquipDecomposeExtra = m
		return true
	case "ResolveHero":
		m :=map[string]*Conf_ResolveHero{}
		loadconfigdata(&m)
		MConf_ResolveHero = m
		return true
	case "ResolveEquipment":
		m :=map[string]*Conf_ResolveEquipment{}
		loadconfigdata(&m)
		MConf_ResolveEquipment = m
		return true
	case "ResolveTreasure":
		m :=map[string]*Conf_ResolveTreasure{}
		loadconfigdata(&m)
		MConf_ResolveTreasure = m
		return true
	case "ResolveRunes":
		m :=map[string]*Conf_ResolveRunes{}
		loadconfigdata(&m)
		MConf_ResolveRunes = m
		return true
	case "ResolvePet":
		m :=map[string]*Conf_ResolvePet{}
		loadconfigdata(&m)
		MConf_ResolvePet = m
		return true
	case "PrisonMonsterBase":
		m :=map[string]*Conf_PrisonMonsterBase{}
		loadconfigdata(&m)
		MConf_PrisonMonsterBase = m
		return true
	case "PrisonBehavior":
		m :=map[string]*Conf_PrisonBehavior{}
		loadconfigdata(&m)
		MConf_PrisonBehavior = m
		return true
	case "PrisonCampaignArmy":
		m :=map[string]*Conf_PrisonCampaignArmy{}
		loadconfigdata(&m)
		MConf_PrisonCampaignArmy = m
		return true
	case "Prison":
		m :=map[string]*Conf_Prison{}
		loadconfigdata(&m)
		MConf_Prison = m
		return true
	case "PrisonReward":
		m :=map[string]*Conf_PrisonReward{}
		loadconfigdata(&m)
		MConf_PrisonReward = m
		return true
	case "PrisonCampaign":
		m :=map[string]*Conf_PrisonCampaign{}
		loadconfigdata(&m)
		MConf_PrisonCampaign = m
		return true
	case "Welfare":
		m :=map[string]*Conf_Welfare{}
		loadconfigdata(&m)
		MConf_Welfare = m
		return true
	case "WelfareDrop":
		m :=map[string]*Conf_WelfareDrop{}
		loadconfigdata(&m)
		MConf_WelfareDrop = m
		return true
	case "Title":
		m :=map[string]*Conf_Title{}
		loadconfigdata(&m)
		MConf_Title = m
		return true
	case "TitleShow":
		m :=map[string]*Conf_TitleShow{}
		loadconfigdata(&m)
		MConf_TitleShow = m
		return true
	case "ArenaGradeReward":
		m :=map[string]*Conf_ArenaGradeReward{}
		loadconfigdata(&m)
		MConf_ArenaGradeReward = m
		return true
	case "ArenaHistoryGradeReward":
		m :=map[string]*Conf_ArenaHistoryGradeReward{}
		loadconfigdata(&m)
		MConf_ArenaHistoryGradeReward = m
		return true
	case "ArenaGoalReward":
		m :=map[string]*Conf_ArenaGoalReward{}
		loadconfigdata(&m)
		MConf_ArenaGoalReward = m
		return true
	case "ArenaScoreReward":
		m :=map[string]*Conf_ArenaScoreReward{}
		loadconfigdata(&m)
		MConf_ArenaScoreReward = m
		return true
	case "ArenaGradeReward_act1":
		m :=map[string]*Conf_ArenaGradeReward_act1{}
		loadconfigdata(&m)
		MConf_ArenaGradeReward_act1 = m
		return true
	case "ArenaGradeReward_act2":
		m :=map[string]*Conf_ArenaGradeReward_act2{}
		loadconfigdata(&m)
		MConf_ArenaGradeReward_act2 = m
		return true
	case "RunesBase":
		m :=map[string]*Conf_RunesBase{}
		loadconfigdata(&m)
		MConf_RunesBase = m
		return true
	case "RunesStep":
		m :=map[string]*Conf_RunesStep{}
		loadconfigdata(&m)
		MConf_RunesStep = m
		return true
	case "RunesSuit":
		m :=map[string]*Conf_RunesSuit{}
		loadconfigdata(&m)
		MConf_RunesSuit = m
		return true
	case "RunesName":
		m :=map[string]*Conf_RunesName{}
		loadconfigdata(&m)
		MConf_RunesName = m
		return true
	case "RunesUnlock":
		m :=map[string]*Conf_RunesUnlock{}
		loadconfigdata(&m)
		MConf_RunesUnlock = m
		return true
	case "Carnival2":
		m :=map[string]*Conf_Carnival2{}
		loadconfigdata(&m)
		MConf_Carnival2 = m
		return true
	case "Carnival2Quset":
		m :=map[string]*Conf_Carnival2Quset{}
		loadconfigdata(&m)
		MConf_Carnival2Quset = m
		return true
	case "Carnival2Sale":
		m :=map[string]*Conf_Carnival2Sale{}
		loadconfigdata(&m)
		MConf_Carnival2Sale = m
		return true
	case "Carnival2Reward":
		m :=map[string]*Conf_Carnival2Reward{}
		loadconfigdata(&m)
		MConf_Carnival2Reward = m
		return true
	case "Sign":
		m :=map[string]*Conf_Sign{}
		loadconfigdata(&m)
		MConf_Sign = m
		return true
	case "SignNum":
		m :=map[string]*Conf_SignNum{}
		loadconfigdata(&m)
		MConf_SignNum = m
		return true
	case "FateFightChapter":
		m :=map[string]*Conf_FateFightChapter{}
		loadconfigdata(&m)
		MConf_FateFightChapter = m
		return true
	case "FateFightCampaign":
		m :=map[string]*Conf_FateFightCampaign{}
		loadconfigdata(&m)
		MConf_FateFightCampaign = m
		return true
	case "FateFightCampaignReward":
		m :=map[string]*Conf_FateFightCampaignReward{}
		loadconfigdata(&m)
		MConf_FateFightCampaignReward = m
		return true
	case "FateFightMonsterBase":
		m :=map[string]*Conf_FateFightMonsterBase{}
		loadconfigdata(&m)
		MConf_FateFightMonsterBase = m
		return true
	case "FateFightMonsterBehavior":
		m :=map[string]*Conf_FateFightMonsterBehavior{}
		loadconfigdata(&m)
		MConf_FateFightMonsterBehavior = m
		return true
	case "FateFightCampaignArmy":
		m :=map[string]*Conf_FateFightCampaignArmy{}
		loadconfigdata(&m)
		MConf_FateFightCampaignArmy = m
		return true
	case "Valhalla":
		m :=map[string]*Conf_Valhalla{}
		loadconfigdata(&m)
		MConf_Valhalla = m
		return true
	case "IntimacyEXP":
		m :=map[string]*Conf_IntimacyEXP{}
		loadconfigdata(&m)
		MConf_IntimacyEXP = m
		return true
	case "HeroBase":
		m :=map[string]*Conf_HeroBase{}
		loadconfigdata(&m)
		MConf_HeroBase = m
		return true
	case "HeroStep":
		m :=map[string]*Conf_HeroStep{}
		loadconfigdata(&m)
		MConf_HeroStep = m
		return true
	case "HeroExp":
		m :=map[string]*Conf_HeroExp{}
		loadconfigdata(&m)
		MConf_HeroExp = m
		return true
	case "HeroExpGrow":
		m :=map[string]*Conf_HeroExpGrow{}
		loadconfigdata(&m)
		MConf_HeroExpGrow = m
		return true
	case "HeroAmity":
		m :=map[string]*Conf_HeroAmity{}
		loadconfigdata(&m)
		MConf_HeroAmity = m
		return true
	case "HeroCompose":
		m :=map[string]*Conf_HeroCompose{}
		loadconfigdata(&m)
		MConf_HeroCompose = m
		return true
	case "HeroAwake":
		m :=map[string]*Conf_HeroAwake{}
		loadconfigdata(&m)
		MConf_HeroAwake = m
		return true
	case "HeroArmy":
		m :=map[string]*Conf_HeroArmy{}
		loadconfigdata(&m)
		MConf_HeroArmy = m
		return true
	case "HeroTalent":
		m :=map[string]*Conf_HeroTalent{}
		loadconfigdata(&m)
		MConf_HeroTalent = m
		return true
	case "HeroTalentCost":
		m :=map[string]*Conf_HeroTalentCost{}
		loadconfigdata(&m)
		MConf_HeroTalentCost = m
		return true
	case "HeroExpGrow_act1":
		m :=map[string]*Conf_HeroExpGrow_act1{}
		loadconfigdata(&m)
		MConf_HeroExpGrow_act1 = m
		return true
	case "HeroExpGrow_act2":
		m :=map[string]*Conf_HeroExpGrow_act2{}
		loadconfigdata(&m)
		MConf_HeroExpGrow_act2 = m
		return true
	case "HeroExp_act2":
		m :=map[string]*Conf_HeroExp_act2{}
		loadconfigdata(&m)
		MConf_HeroExp_act2 = m
		return true
	case "HeroStep_act2":
		m :=map[string]*Conf_HeroStep_act2{}
		loadconfigdata(&m)
		MConf_HeroStep_act2 = m
		return true
	case "HeroAwake_act2":
		m :=map[string]*Conf_HeroAwake_act2{}
		loadconfigdata(&m)
		MConf_HeroAwake_act2 = m
		return true
	case "Guide":
		m :=map[string]*Conf_Guide{}
		loadconfigdata(&m)
		MConf_Guide = m
		return true
	case "GuideDes":
		m :=map[string]*Conf_GuideDes{}
		loadconfigdata(&m)
		MConf_GuideDes = m
		return true
	case "RunesOutput":
		m :=map[string]*Conf_RunesOutput{}
		loadconfigdata(&m)
		MConf_RunesOutput = m
		return true
	case "RunesDrop":
		m :=map[string]*Conf_RunesDrop{}
		loadconfigdata(&m)
		MConf_RunesDrop = m
		return true
	case "EquipmentPromote":
		m :=map[string]*Conf_EquipmentPromote{}
		loadconfigdata(&m)
		MConf_EquipmentPromote = m
		return true
	case "EquipmentSuit":
		m :=map[string]*Conf_EquipmentSuit{}
		loadconfigdata(&m)
		MConf_EquipmentSuit = m
		return true
	case "EquipmentAwake":
		m :=map[string]*Conf_EquipmentAwake{}
		loadconfigdata(&m)
		MConf_EquipmentAwake = m
		return true
	case "EquipmentEnchant":
		m :=map[string]*Conf_EquipmentEnchant{}
		loadconfigdata(&m)
		MConf_EquipmentEnchant = m
		return true
	case "EquipmentEnchantQuality":
		m :=map[string]*Conf_EquipmentEnchantQuality{}
		loadconfigdata(&m)
		MConf_EquipmentEnchantQuality = m
		return true
	case "EquipmentEnchantExp":
		m :=map[string]*Conf_EquipmentEnchantExp{}
		loadconfigdata(&m)
		MConf_EquipmentEnchantExp = m
		return true
	case "EquipmentStrengMaster":
		m :=map[string]*Conf_EquipmentStrengMaster{}
		loadconfigdata(&m)
		MConf_EquipmentStrengMaster = m
		return true
	case "EquipmentRefineMaster":
		m :=map[string]*Conf_EquipmentRefineMaster{}
		loadconfigdata(&m)
		MConf_EquipmentRefineMaster = m
		return true
	case "RecommendEquip":
		m :=map[string]*Conf_RecommendEquip{}
		loadconfigdata(&m)
		MConf_RecommendEquip = m
		return true
	case "WrestlingStrength":
		m :=map[string]*Conf_WrestlingStrength{}
		loadconfigdata(&m)
		MConf_WrestlingStrength = m
		return true
	case "WrestlingReward":
		m :=map[string]*Conf_WrestlingReward{}
		loadconfigdata(&m)
		MConf_WrestlingReward = m
		return true
	case "WrestlingGold":
		m :=map[string]*Conf_WrestlingGold{}
		loadconfigdata(&m)
		MConf_WrestlingGold = m
		return true
	case "WrestlingMap":
		m :=map[string]*Conf_WrestlingMap{}
		loadconfigdata(&m)
		MConf_WrestlingMap = m
		return true
	case "CrusadeChapter":
		m :=map[string]*Conf_CrusadeChapter{}
		loadconfigdata(&m)
		MConf_CrusadeChapter = m
		return true
	case "CrusadeCampaign":
		m :=map[string]*Conf_CrusadeCampaign{}
		loadconfigdata(&m)
		MConf_CrusadeCampaign = m
		return true
	case "CrusadeCampaignReward":
		m :=map[string]*Conf_CrusadeCampaignReward{}
		loadconfigdata(&m)
		MConf_CrusadeCampaignReward = m
		return true
	case "CruasdeBloodLoop":
		m :=map[string]*Conf_CruasdeBloodLoop{}
		loadconfigdata(&m)
		MConf_CruasdeBloodLoop = m
		return true
	case "CrusadeMonsterBase":
		m :=map[string]*Conf_CrusadeMonsterBase{}
		loadconfigdata(&m)
		MConf_CrusadeMonsterBase = m
		return true
	case "CrusadeMonsterBehavior":
		m :=map[string]*Conf_CrusadeMonsterBehavior{}
		loadconfigdata(&m)
		MConf_CrusadeMonsterBehavior = m
		return true
	case "CrusadeCampaignArmy":
		m :=map[string]*Conf_CrusadeCampaignArmy{}
		loadconfigdata(&m)
		MConf_CrusadeCampaignArmy = m
		return true
	case "BuyTimes":
		m :=map[string]*Conf_BuyTimes{}
		loadconfigdata(&m)
		MConf_BuyTimes = m
		return true
	case "BuyTimes_act1":
		m :=map[string]*Conf_BuyTimes_act1{}
		loadconfigdata(&m)
		MConf_BuyTimes_act1 = m
		return true
	case "BuyTimes_act2":
		m :=map[string]*Conf_BuyTimes_act2{}
		loadconfigdata(&m)
		MConf_BuyTimes_act2 = m
		return true
	case "Vein":
		m :=map[string]*Conf_Vein{}
		loadconfigdata(&m)
		MConf_Vein = m
		return true
	case "VeinMap":
		m :=map[string]*Conf_VeinMap{}
		loadconfigdata(&m)
		MConf_VeinMap = m
		return true
	case "PublicArenaRankReward":
		m :=map[string]*Conf_PublicArenaRankReward{}
		loadconfigdata(&m)
		MConf_PublicArenaRankReward = m
		return true
	case "PublicArenaDayReward":
		m :=map[string]*Conf_PublicArenaDayReward{}
		loadconfigdata(&m)
		MConf_PublicArenaDayReward = m
		return true
	case "PublicArenaEnemy":
		m :=map[string]*Conf_PublicArenaEnemy{}
		loadconfigdata(&m)
		MConf_PublicArenaEnemy = m
		return true
	case "LeagueMatchRankLevel":
		m :=map[string]*Conf_LeagueMatchRankLevel{}
		loadconfigdata(&m)
		MConf_LeagueMatchRankLevel = m
		return true
	case "LeagueMatchReward":
		m :=map[string]*Conf_LeagueMatchReward{}
		loadconfigdata(&m)
		MConf_LeagueMatchReward = m
		return true
	case "LeagueMatchMap":
		m :=map[string]*Conf_LeagueMatchMap{}
		loadconfigdata(&m)
		MConf_LeagueMatchMap = m
		return true
	case "LeagueMatchChestOrder":
		m :=map[string]*Conf_LeagueMatchChestOrder{}
		loadconfigdata(&m)
		MConf_LeagueMatchChestOrder = m
		return true
	case "LeagueMatchChestType":
		m :=map[string]*Conf_LeagueMatchChestType{}
		loadconfigdata(&m)
		MConf_LeagueMatchChestType = m
		return true
	case "LeagueMatchChestReward":
		m :=map[string]*Conf_LeagueMatchChestReward{}
		loadconfigdata(&m)
		MConf_LeagueMatchChestReward = m
		return true
	case "GrowthFund":
		m :=map[string]*Conf_GrowthFund{}
		loadconfigdata(&m)
		MConf_GrowthFund = m
		return true
	case "DoubleDrop":
		m :=map[string]*Conf_DoubleDrop{}
		loadconfigdata(&m)
		MConf_DoubleDrop = m
		return true
	case "ArenaRankReward":
		m :=map[string]*Conf_ArenaRankReward{}
		loadconfigdata(&m)
		MConf_ArenaRankReward = m
		return true
	case "ArenaRankReward_act1":
		m :=map[string]*Conf_ArenaRankReward_act1{}
		loadconfigdata(&m)
		MConf_ArenaRankReward_act1 = m
		return true
	case "Item":
		m :=map[string]*Conf_Item{}
		loadconfigdata(&m)
		MConf_Item = m
		return true
	case "DropPackage":
		m :=map[string]*Conf_DropPackage{}
		loadconfigdata(&m)
		MConf_DropPackage = m
		return true
	case "Item_act1":
		m :=map[string]*Conf_Item_act1{}
		loadconfigdata(&m)
		MConf_Item_act1 = m
		return true
	case "DropPackage_act1":
		m :=map[string]*Conf_DropPackage_act1{}
		loadconfigdata(&m)
		MConf_DropPackage_act1 = m
		return true
	case "Item_act2":
		m :=map[string]*Conf_Item_act2{}
		loadconfigdata(&m)
		MConf_Item_act2 = m
		return true
	case "DropPackage_act2":
		m :=map[string]*Conf_DropPackage_act2{}
		loadconfigdata(&m)
		MConf_DropPackage_act2 = m
		return true
	case "Tavern":
		m :=map[string]*Conf_Tavern{}
		loadconfigdata(&m)
		MConf_Tavern = m
		return true
	case "TavernHeroDrop":
		m :=map[string]*Conf_TavernHeroDrop{}
		loadconfigdata(&m)
		MConf_TavernHeroDrop = m
		return true
	case "TavernPreview":
		m :=map[string]*Conf_TavernPreview{}
		loadconfigdata(&m)
		MConf_TavernPreview = m
		return true
	case "TavernLoop":
		m :=map[string]*Conf_TavernLoop{}
		loadconfigdata(&m)
		MConf_TavernLoop = m
		return true
	case "TavernEquipmentLoop":
		m :=map[string]*Conf_TavernEquipmentLoop{}
		loadconfigdata(&m)
		MConf_TavernEquipmentLoop = m
		return true
	case "TavernEquipPreview":
		m :=map[string]*Conf_TavernEquipPreview{}
		loadconfigdata(&m)
		MConf_TavernEquipPreview = m
		return true
	case "TavernHeroBlessing":
		m :=map[string]*Conf_TavernHeroBlessing{}
		loadconfigdata(&m)
		MConf_TavernHeroBlessing = m
		return true
	case "TavernHeroDrop_act1":
		m :=map[string]*Conf_TavernHeroDrop_act1{}
		loadconfigdata(&m)
		MConf_TavernHeroDrop_act1 = m
		return true
	case "TavernHeroDrop_act2":
		m :=map[string]*Conf_TavernHeroDrop_act2{}
		loadconfigdata(&m)
		MConf_TavernHeroDrop_act2 = m
		return true
	case "BossChallengeChapter":
		m :=map[string]*Conf_BossChallengeChapter{}
		loadconfigdata(&m)
		MConf_BossChallengeChapter = m
		return true
	case "BossChallengeCampaign":
		m :=map[string]*Conf_BossChallengeCampaign{}
		loadconfigdata(&m)
		MConf_BossChallengeCampaign = m
		return true
	case "BossChanllengeGetLevel":
		m :=map[string]*Conf_BossChanllengeGetLevel{}
		loadconfigdata(&m)
		MConf_BossChanllengeGetLevel = m
		return true
	case "BossChallengeReward":
		m :=map[string]*Conf_BossChallengeReward{}
		loadconfigdata(&m)
		MConf_BossChallengeReward = m
		return true
	case "BossChallengeRewardNew":
		m :=map[string]*Conf_BossChallengeRewardNew{}
		loadconfigdata(&m)
		MConf_BossChallengeRewardNew = m
		return true
	case "BossChallengeDamage":
		m :=map[string]*Conf_BossChallengeDamage{}
		loadconfigdata(&m)
		MConf_BossChallengeDamage = m
		return true
	case "BossChallengeDamageGrow":
		m :=map[string]*Conf_BossChallengeDamageGrow{}
		loadconfigdata(&m)
		MConf_BossChallengeDamageGrow = m
		return true
	case "BossChallengeRank":
		m :=map[string]*Conf_BossChallengeRank{}
		loadconfigdata(&m)
		MConf_BossChallengeRank = m
		return true
	case "BossChallengeCurveRank":
		m :=map[string]*Conf_BossChallengeCurveRank{}
		loadconfigdata(&m)
		MConf_BossChallengeCurveRank = m
		return true
	case "BossChallengeRewardNew_act1":
		m :=map[string]*Conf_BossChallengeRewardNew_act1{}
		loadconfigdata(&m)
		MConf_BossChallengeRewardNew_act1 = m
		return true
	case "BossChallengeRank_act1":
		m :=map[string]*Conf_BossChallengeRank_act1{}
		loadconfigdata(&m)
		MConf_BossChallengeRank_act1 = m
		return true
	case "BossChallengeCurveRank_act1":
		m :=map[string]*Conf_BossChallengeCurveRank_act1{}
		loadconfigdata(&m)
		MConf_BossChallengeCurveRank_act1 = m
		return true
	case "BossChallengeRewardNew_act2":
		m :=map[string]*Conf_BossChallengeRewardNew_act2{}
		loadconfigdata(&m)
		MConf_BossChallengeRewardNew_act2 = m
		return true
	case "BossChallengeRank_act2":
		m :=map[string]*Conf_BossChallengeRank_act2{}
		loadconfigdata(&m)
		MConf_BossChallengeRank_act2 = m
		return true
	case "BossChallengeCurveRank_act2":
		m :=map[string]*Conf_BossChallengeCurveRank_act2{}
		loadconfigdata(&m)
		MConf_BossChallengeCurveRank_act2 = m
		return true
	case "BossChallengeMonsterBase":
		m :=map[string]*Conf_BossChallengeMonsterBase{}
		loadconfigdata(&m)
		MConf_BossChallengeMonsterBase = m
		return true
	case "BossChallengeBehavior":
		m :=map[string]*Conf_BossChallengeBehavior{}
		loadconfigdata(&m)
		MConf_BossChallengeBehavior = m
		return true
	case "BossChallengeCampaignArmy":
		m :=map[string]*Conf_BossChallengeCampaignArmy{}
		loadconfigdata(&m)
		MConf_BossChallengeCampaignArmy = m
		return true
	case "ErrorDefine":
		m :=map[string]*Conf_ErrorDefine{}
		loadconfigdata(&m)
		MConf_ErrorDefine = m
		return true
	case "randname":
		m :=map[string]*Conf_randname{}
		loadconfigdata(&m)
		MConf_randname = m
		return true
	case "InscriptionLevelUp":
		m :=map[string]*Conf_InscriptionLevelUp{}
		loadconfigdata(&m)
		MConf_InscriptionLevelUp = m
		return true
	case "InscriptionActive":
		m :=map[string]*Conf_InscriptionActive{}
		loadconfigdata(&m)
		MConf_InscriptionActive = m
		return true
	case "GlyphsBase":
		m :=map[string]*Conf_GlyphsBase{}
		loadconfigdata(&m)
		MConf_GlyphsBase = m
		return true
	case "GlyphsExp":
		m :=map[string]*Conf_GlyphsExp{}
		loadconfigdata(&m)
		MConf_GlyphsExp = m
		return true
	case "GlyphsStrengthen":
		m :=map[string]*Conf_GlyphsStrengthen{}
		loadconfigdata(&m)
		MConf_GlyphsStrengthen = m
		return true
	case "GlyphsCompose":
		m :=map[string]*Conf_GlyphsCompose{}
		loadconfigdata(&m)
		MConf_GlyphsCompose = m
		return true
	case "audio":
		m :=map[string]*Conf_audio{}
		loadconfigdata(&m)
		MConf_audio = m
		return true
	case "CupSupportReward":
		m :=map[string]*Conf_CupSupportReward{}
		loadconfigdata(&m)
		MConf_CupSupportReward = m
		return true
	case "CupRankReward":
		m :=map[string]*Conf_CupRankReward{}
		loadconfigdata(&m)
		MConf_CupRankReward = m
		return true
	case "CupMap":
		m :=map[string]*Conf_CupMap{}
		loadconfigdata(&m)
		MConf_CupMap = m
		return true
	case "DomainMap":
		m :=map[string]*Conf_DomainMap{}
		loadconfigdata(&m)
		MConf_DomainMap = m
		return true
	case "DomainBuildingEnemy":
		m :=map[string]*Conf_DomainBuildingEnemy{}
		loadconfigdata(&m)
		MConf_DomainBuildingEnemy = m
		return true
	case "DomainMineMonsterBase":
		m :=map[string]*Conf_DomainMineMonsterBase{}
		loadconfigdata(&m)
		MConf_DomainMineMonsterBase = m
		return true
	case "DomainMineMonsterBehavior":
		m :=map[string]*Conf_DomainMineMonsterBehavior{}
		loadconfigdata(&m)
		MConf_DomainMineMonsterBehavior = m
		return true
	case "DomainMineArmy":
		m :=map[string]*Conf_DomainMineArmy{}
		loadconfigdata(&m)
		MConf_DomainMineArmy = m
		return true
	case "DomainBase":
		m :=map[string]*Conf_DomainBase{}
		loadconfigdata(&m)
		MConf_DomainBase = m
		return true
	case "DomainMonster":
		m :=map[string]*Conf_DomainMonster{}
		loadconfigdata(&m)
		MConf_DomainMonster = m
		return true
	case "DomainQuestReward":
		m :=map[string]*Conf_DomainQuestReward{}
		loadconfigdata(&m)
		MConf_DomainQuestReward = m
		return true
	case "HeroExpReward":
		m :=map[string]*Conf_HeroExpReward{}
		loadconfigdata(&m)
		MConf_HeroExpReward = m
		return true
	case "DomainQuest":
		m :=map[string]*Conf_DomainQuest{}
		loadconfigdata(&m)
		MConf_DomainQuest = m
		return true
	case "BuySuccessRatio":
		m :=map[string]*Conf_BuySuccessRatio{}
		loadconfigdata(&m)
		MConf_BuySuccessRatio = m
		return true
	case "DomainQuestHeroMax":
		m :=map[string]*Conf_DomainQuestHeroMax{}
		loadconfigdata(&m)
		MConf_DomainQuestHeroMax = m
		return true
	case "DomainOpen":
		m :=map[string]*Conf_DomainOpen{}
		loadconfigdata(&m)
		MConf_DomainOpen = m
		return true
	case "DomainType":
		m :=map[string]*Conf_DomainType{}
		loadconfigdata(&m)
		MConf_DomainType = m
		return true
	case "Domain":
		m :=map[string]*Conf_Domain{}
		loadconfigdata(&m)
		MConf_Domain = m
		return true
	case "DomainBuildingReward":
		m :=map[string]*Conf_DomainBuildingReward{}
		loadconfigdata(&m)
		MConf_DomainBuildingReward = m
		return true
	case "DomainMineReward":
		m :=map[string]*Conf_DomainMineReward{}
		loadconfigdata(&m)
		MConf_DomainMineReward = m
		return true
	case "DomainMineProduct":
		m :=map[string]*Conf_DomainMineProduct{}
		loadconfigdata(&m)
		MConf_DomainMineProduct = m
		return true
	case "DomainChestReward":
		m :=map[string]*Conf_DomainChestReward{}
		loadconfigdata(&m)
		MConf_DomainChestReward = m
		return true
	case "JewelryStep":
		m :=map[string]*Conf_JewelryStep{}
		loadconfigdata(&m)
		MConf_JewelryStep = m
		return true
	case "BlackShop":
		m :=map[string]*Conf_BlackShop{}
		loadconfigdata(&m)
		MConf_BlackShop = m
		return true
	default:
	}
	return false
}
