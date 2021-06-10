local list = {
[1]={ID=1,String='成功',},
[2]={ID=-1,String='未知错误',},
[3]={ID=-2,String='验证失败',},
[4]={ID=-3,String='不支持此平台',},
[5]={ID=-4,String='封号状态',},
[6]={ID=-5,String='未登录不能选服',},
[7]={ID=-6,String='所选服务器不存在',},
[8]={ID=-7,String='服务器爆满',},
[9]={ID=-8,String='服务器维护',},
[10]={ID=-9,String='角色被封',},
[11]={ID=-10,String='服务器已达最大在线人数',},
[12]={ID=-11,String='服务器已达最大注册人数',},
[13]={ID=-90,String='参数错误',},
[14]={ID=-91,String='文本内容不合法',},
[15]={ID=-92,String='配置错误',},
[16]={ID=-93,String='充值验证错误',},
[17]={ID=-100,String='登录GameServer失败，token错误或者失效',},
[18]={ID=-101,String='加载角色失败,没有角色',},
[19]={ID=-102,String='创建角色失败,已有角色',},
[20]={ID=-103,String='创建角色失败，请输入至少4个字符。',},
[21]={ID=-104,String='创建角色失败，输入名称过长。请不要超过14个字符。',},
[22]={ID=-105,String='创建角色失败，名称不合法',},
[23]={ID=-106,String='创建角色失败，重名',},
[24]={ID=-108,String='改名失败，名称太短。',},
[25]={ID=-109,String='改名失败，名称太长。',},
[26]={ID=-110,String='改名错误失败，名称不合法',},
[27]={ID=-111,String='改名错误失败，重名',},
[28]={ID=-112,String='改名错误失败，缺少改名卡',},
[29]={ID=-115,String='改头像错误，还未拥有此头像',},
[30]={ID=-116,String='改头像框错误，还未拥有此头像框',},
[31]={ID=-117,String='已经购买过了，不需要再购买',},
[32]={ID=-118,String='不存在的头像框',},
[33]={ID=-119,String='不能重复选阵营',},
[34]={ID=-120,String='目标名称不合法(或者不存在)',},
[35]={ID=-121,String='邮件标题不合法',},
[36]={ID=-122,String='邮件内容不合法',},
[37]={ID=-123,String='邮件不存在',},
[38]={ID=-124,String='没有附件',},
[39]={ID=-125,String='道具背包格子不够',},
[40]={ID=-126,String='英雄背包格子不够',},
[41]={ID=-127,String='装备背包格子不够',},
[42]={ID=-130,String='未找到物品',},
[43]={ID=-131,String='没有足够的物品',},
[44]={ID=-132,String='未找到物品配置信息',},
[45]={ID=-133,String='错误的物品类型',},
[46]={ID=-134,String='等级不够',},
[47]={ID=-135,String='金币不够',},
[48]={ID=-136,String='钻石不足',},
[49]={ID=-137,String='技能经验不足',},
[50]={ID=-138,String='体力不足',},
[51]={ID=-139,String='荣誉不够',},
[52]={ID=-140,String='征服点数不够',},
[53]={ID=-141,String='天赋点数不足',},
[54]={ID=-142,String='雕文经验不足',},
[55]={ID=-143,String='徽章不足',},
[56]={ID=-144,String='友好度不足',},
[57]={ID=-145,String='物品不在背包中，不能使用',},
[58]={ID=-146,String='超出物品使用最大次数限制',},
[59]={ID=-147,String='技能点不足。',},
[60]={ID=-148,String='精装碎片不足',},
[61]={ID=-149,String='贡献值不足',},
[62]={ID=-150,String='符文碎片不足',},
[63]={ID=-151,String='灵魂石不足',},
[64]={ID=-152,String='能量不足',},
[65]={ID=-153,String='精力不足',},
[66]={ID=-154,String='挑战令不足',},
[67]={ID=-155,String='宝箱钥匙不足',},
[68]={ID=-156,String='符文碎片不足',},
[69]={ID=-157,String='宠物精魄不足',},
[70]={ID=-160,String='功能未开启',},
[71]={ID=-161,String='未购买此时装',},
[72]={ID=-162,String='未获得此称号',},
[73]={ID=-170,String='VIP等级不足',},
[74]={ID=-171,String=' 已穿戴的不能置换',},
[75]={ID=-172,String=' 资质不够,不能置换',},
[76]={ID=-173,String=' 资质不同,不能置换',},
[77]={ID=-174,String=' 进阶不够,不能置换',},
[78]={ID=-175,String=' 阵营不同,不能置换',},
[79]={ID=-176,String=' 已上阵的不能置换',},
[80]={ID=-177,String='升星不够，不能置换',},
[81]={ID=-180,String='未接任务不能领取奖励或者叫找不到任务',},
[82]={ID=-181,String='未完成的任务不能提交',},
[83]={ID=-182,String='不能重复领取活跃度箱子',},
[84]={ID=-183,String='活跃度箱子条件未达到,不能领取',},
[85]={ID=-190,String='vip等级不足,不能领取奖励',},
[86]={ID=-191,String='已经领取过奖励,不能重复领取',},
[87]={ID=-200,String='未找到此装备',},
[88]={ID=-201,String='未找到装备配置',},
[89]={ID=-202,String='已达到最大等级',},
[90]={ID=-203,String='装备在英雄身上不能被消耗',},
[91]={ID=-204,String='装备已达到最大阶数',},
[92]={ID=-205,String='选择被消耗的装备错误',},
[93]={ID=-206,String='不合法的装备经验道具',},
[94]={ID=-207,String='装备经验道具数量不足',},
[95]={ID=-208,String='不能超过玩家等级',},
[96]={ID=-209,String='升级所需的阶数不足',},
[97]={ID=-210,String='进阶所需的等级不足',},
[98]={ID=-220,String='不能消耗要升级的英雄本身',},
[99]={ID=-221,String='找不到要升级的英雄',},
[100]={ID=-222,String='要消耗的英雄存在找不到的英雄',},
[101]={ID=-223,String='不能消耗上阵的英雄',},
[102]={ID=-224,String='不能超过角色等级',},
[103]={ID=-225,String='达到最大配置等级',},
[104]={ID=-226,String='不合法的英雄经验道具',},
[105]={ID=-227,String='不能消耗侍从中的英雄',},
[106]={ID=-230,String='雕文配置错误',},
[107]={ID=-231,String='找不到英雄',},
[108]={ID=-232,String='没有雕文，不需清理',},
[109]={ID=-233,String='不能选择重复的雕文',},
[110]={ID=-234,String='此位置已选中别的雕文',},
[111]={ID=-235,String='没有可激活的雕文',},
[112]={ID=-236,String='激活的雕文个数已达上限',},
[113]={ID=-237,String='没有可专精的雕文',},
[114]={ID=-238,String='雕文专精已达最大等级',},
[115]={ID=-240,String='不能消耗要升级的英雄本身',},
[116]={ID=-241,String='找不到要升级的英雄',},
[117]={ID=-242,String='要消耗的英雄存在找不到的英雄',},
[118]={ID=-243,String='英雄材料不足',},
[119]={ID=-244,String='物品材料不足',},
[120]={ID=-245,String='已达到最大阶数',},
[121]={ID=-246,String='不能消耗侍从中的英雄',},
[122]={ID=-247,String='进阶需要的等级不足',},
[123]={ID=-250,String='找不到要穿装备的英雄',},
[124]={ID=-251,String='装备已经被自己穿上了',},
[125]={ID=-252,String='装备找不到',},
[126]={ID=-253,String='装备已经被别的英雄穿上了',},
[127]={ID=-254,String='相同的部位已经被穿上了',},
[128]={ID=-255,String='职业不匹配',},
[129]={ID=-256,String='不能穿这么多件装备',},
[130]={ID=-260,String='装备找不到',},
[131]={ID=-261,String='装备没有被英雄穿上了',},
[132]={ID=-262,String='找不到英雄',},
[133]={ID=-270,String='数据错误',},
[134]={ID=-271,String='没开启该按钮',},
[135]={ID=-272,String='没激活该按钮',},
[136]={ID=-273,String='抽奖背包已满',},
[137]={ID=-280,String='宝石包裹没有该宝石',},
[138]={ID=-290,String='宝石抽奖按钮已激活',},
[139]={ID=-300,String='副本配置文件错误或者不存在',},
[140]={ID=-301,String='星星数或者副本未达到条件不能领取奖励',},
[141]={ID=-303,String='已经领取过奖励',},
[142]={ID=-304,String='体力不够,不能挑战此关卡',},
[143]={ID=-305,String='等级不够,不能挑战此关卡',},
[144]={ID=-306,String='前置章节未通关,不能挑战此关卡',},
[145]={ID=-307,String='前置关卡未过关,不能挑战此关卡',},
[146]={ID=-308,String='没挑战次数了,不能挑战此关卡',},
[147]={ID=-309,String='小怪关卡,不能重复挑战',},
[148]={ID=-310,String='挑战已经超时，请重新挑战。',},
[149]={ID=-311,String='战斗验证失败（311）',},
[150]={ID=-312,String='不能扫荡非完美过关的关卡',},
[151]={ID=-313,String='次数不够,不能扫荡',},
[152]={ID=-314,String='体力不够,不能扫荡',},
[153]={ID=-315,String='扫荡卷不够,不能扫荡',},
[154]={ID=-316,String='不能扫荡小怪关卡',},
[155]={ID=-317,String='没挑战过,不需要重置',},
[156]={ID=-318,String='重置次数已达上限',},
[157]={ID=-320,String='没有次数不能重置',},
[158]={ID=-321,String='已通关目标对手,不能挑战',},
[159]={ID=-322,String='前置对手未挑战,不能挑战',},
[160]={ID=-323,String='战斗验证失败（323）',},
[161]={ID=-324,String='未过关不能领取奖励',},
[162]={ID=-325,String='已经领取过奖励',},
[163]={ID=-326,String='上阵的英雄在试炼中已全部阵亡,不能挑战',},
[164]={ID=-330,String='不存在此背景',},
[165]={ID=-331,String='未购买的背景不能替换',},
[166]={ID=-332,String='已经买过了,不用再次购买',},
[167]={ID=-333,String='留言不存在',},
[168]={ID=-334,String='勾选留言已达上限',},
[169]={ID=-335,String='领取物质箱已达上限',},
[170]={ID=-336,String='不用重复给同一个玩家点赞',},
[171]={ID=-337,String='不能重复给同一个玩家送体力',},
[172]={ID=-338,String='赠送体力已达上限',},
[173]={ID=-339,String='目标接收体力已达上限',},
[174]={ID=-340,String='兑换英雄碎片次数已达上限',},
[175]={ID=-341,String='未点赞不能兑换英雄碎片',},
[176]={ID=-342,String='英雄(碎片)不存在',},
[177]={ID=-350,String='已经在此位置了',},
[178]={ID=-351,String='下阵失败,此英雄不在阵上',},
[179]={ID=-352,String='队长位置不能为空',},
[180]={ID=-353,String='已有相同英雄在阵上',},
[181]={ID=-360,String='副本配置文件错误或者不存在',},
[182]={ID=-361,String='未开启的资源副本',},
[183]={ID=-362,String='没资源副本挑战次数',},
[184]={ID=-363,String='等级不够不能挑战资源副本',},
[185]={ID=-364,String='挑战申请丢失，无法验证战斗（364）',},
[186]={ID=-365,String='副本战斗验证失败（365）',},
[187]={ID=-366,String='购买次数已达上限',},
[188]={ID=-367,String='没挑战成功过不能扫荡',},
[189]={ID=-368,String='扫荡资源副本次数不够',},
[190]={ID=-369,String='挑战冷却中，请稍后再来！',},
[191]={ID=-370,String='进入挑战失败,没有次数了',},
[192]={ID=-371,String='进入挑战失败,前置普通未通过',},
[193]={ID=-372,String='进入挑战失败,前置精英未通过',},
[194]={ID=-373,String='进入挑战失败,宝箱未领取',},
[195]={ID=-374,String='上报挑战泰坦之路失败,请先申请挑战',},
[196]={ID=-375,String='上报挑战泰坦之路失败,战斗验证失败',},
[197]={ID=-376,String='获取军团入侵目标奖励失败,已经领取',},
[198]={ID=-377,String='获取军团入侵目标奖励失败,不存在此奖励',},
[199]={ID=-378,String='没有重置次数不能重置',},
[200]={ID=-380,String='战场已结束',},
[201]={ID=-381,String='不在选线状态',},
[202]={ID=-384,String='世界boss已结束',},
[203]={ID=-385,String='复活中',},
[204]={ID=-386,String='开箱子时间已经结束',},
[205]={ID=-387,String='没有次数了不能开箱子',},
[206]={ID=-390,String='没挑战次数了,不能挑战boss',},
[207]={ID=-391,String='低难度boss未过关,不能挑战此难度boss',},
[208]={ID=-392,String='等级不足,不能挑战次boss',},
[209]={ID=-393,String='挑战申请丢失，无法验证战斗（393）',},
[210]={ID=-394,String='战斗验证失败（394）',},
[211]={ID=-395,String='开启宝箱失败,没有次数了',},
[212]={ID=-396,String='CD未到，不能挑战此boss。',},
[213]={ID=-397,String='没有卡牌可开启',},
[214]={ID=-398,String='今日未通关过单人boss，不能扫荡',},
[215]={ID=-400,String='找不到要镶嵌宝石的装备',},
[216]={ID=-401,String='背包没有该物品',},
[217]={ID=-402,String='没有该宝石',},
[218]={ID=-403,String='该孔已镶嵌了宝石',},
[219]={ID=-404,String='已镶嵌同类型的宝石',},
[220]={ID=-405,String='孔未开启',},
[221]={ID=-410,String='找不到要摘除宝石的装备',},
[222]={ID=-411,String='该孔没镶嵌宝石',},
[223]={ID=-420,String='找不到英雄',},
[224]={ID=-421,String='技能未开启',},
[225]={ID=-422,String='技能可能已满级',},
[226]={ID=-423,String='不能超过英雄等级',},
[227]={ID=-430,String='找不到要合成的物品',},
[228]={ID=-431,String='材料不足',},
[229]={ID=-432,String='合成数量不合法',},
[230]={ID=-440,String='找不到该装备',},
[231]={ID=-441,String='熟练度的等级配置错误',},
[232]={ID=-442,String='刷新附魔需要的道具不足',},
[233]={ID=-443,String='没有刷新附魔属性可替换',},
[234]={ID=-444,String='通用装备不能附魔',},
[235]={ID=-445,String='3星以上装备才可附魔',},
[236]={ID=-450,String='没有cd,不需重置',},
[237]={ID=-455,String='购买次数已满',},
[238]={ID=-456,String='购买次数超出上限',},
[239]={ID=-460,String='不能挑战，排名发生变化,超过可挑战范围',},
[240]={ID=-461,String='不能挑战，目标正在战斗中',},
[241]={ID=-462,String='不能挑战，你正在被挑战中',},
[242]={ID=-463,String='没有挑战次数',},
[243]={ID=-464,String='不能挑战自己',},
[244]={ID=-465,String='挑战的玩家不合法',},
[245]={ID=-470,String='没达到领奖条件',},
[246]={ID=-471,String='已领取',},
[247]={ID=-475,String='未达到领取奖励的条件。',},
[248]={ID=-476,String='已经领取过此奖励。',},
[249]={ID=-480,String='未找到商品信息',},
[250]={ID=-481,String='商品列表已超时，请重新刷新',},
[251]={ID=-482,String='商品已售卖完毕',},
[252]={ID=-483,String='刷新次数不够',},
[253]={ID=-485,String='未达到购买条件',},
[254]={ID=-490,String='购买次数达到上限',},
[255]={ID=-495,String='没有特级招募的机会',},
[256]={ID=-496,String='今日传奇召唤次数已满',},
[257]={ID=-497,String='已领取该积分奖励',},
[258]={ID=-498,String='积分不足',},
[259]={ID=-500,String='已签到',},
[260]={ID=-501,String='vip等级不足',},
[261]={ID=-505,String='不存在此累计签到奖励',},
[262]={ID=-506,String='累计天数不足，不能领取该奖励',},
[263]={ID=-507,String='已经领取此累计签到奖励',},
[264]={ID=-510,String='激活码不存在',},
[265]={ID=-511,String='激活码次数达到上限',},
[266]={ID=-512,String='不能领取该渠道的激活码礼包',},
[267]={ID=-513,String='此激活码不能在该服务器使用',},
[268]={ID=-514,String='此激活码礼包已被你领取过',},
[269]={ID=-515,String='此激活码已过期',},
[270]={ID=-516,String='此激活码不能用于该平台',},
[271]={ID=-517,String='此类激活码礼包已领取过',},
[272]={ID=-518,String='同批次激活码使用次数已满',},
[273]={ID=-520,String='当前vip可购买次数已满',},
[274]={ID=-521,String='您还没达到开放等级',},
[275]={ID=-540,String='字符过长',},
[276]={ID=-541,String='等级不足，不能聊天',},
[277]={ID=-542,String='世界聊天频道每30秒才能发送一次信息',},
[278]={ID=-543,String='频道错误',},
[279]={ID=-544,String='对方不在线',},
[280]={ID=-545,String='语音聊天时间过长',},
[281]={ID=-546,String='禁言中',},
[282]={ID=-547,String='公会聊天频道每15秒才能发送一次信息',},
[283]={ID=-550,String='没找到该物品',},
[284]={ID=-551,String='该物品不是装备',},
[285]={ID=-552,String='没找到该物品的信息',},
[286]={ID=-560,String='不能添加自己为好友',},
[287]={ID=-561,String='已经是好友了',},
[288]={ID=-562,String='您的好友数量已达上限',},
[289]={ID=-563,String='对方的好友数量达到上限',},
[290]={ID=-564,String='对方不在线',},
[291]={ID=-565,String='请求已发送,等待对方应答',},
[292]={ID=-566,String='添加好友被拒绝',},
[293]={ID=-567,String='添加好友成功',},
[294]={ID=-568,String='已经申请，请耐心等待对方应答',},
[295]={ID=-569,String='玩家名不存在',},
[296]={ID=-570,String='不是好友不能删除',},
[297]={ID=-580,String='没找到要升级栏位的英雄',},
[298]={ID=-581,String='要升级的栏位错误',},
[299]={ID=-582,String='该英雄不支持侍从',},
[300]={ID=-583,String='侍从等级配置错误',},
[301]={ID=-584,String='侍从等级已满',},
[302]={ID=-590,String='侍从目标英雄不存在',},
[303]={ID=-591,String='侍从上阵英雄不存在',},
[304]={ID=-592,String='要侍从的栏位错误',},
[305]={ID=-593,String='激活等级不足',},
[306]={ID=-594,String='星级不足',},
[307]={ID=-595,String='同一英雄不能同时侍从两个',},
[308]={ID=-597,String='该英雄信息错误',},
[309]={ID=-598,String='要卸下侍从的栏位错误',},
[310]={ID=-599,String='栏位上没有英雄',},
[311]={ID=-610,String='没找到商品信息',},
[312]={ID=-611,String='VIP等级不足',},
[313]={ID=-612,String='全服限售数量不足',},
[314]={ID=-613,String='今日限购次数已满',},
[315]={ID=-614,String='限购时间结束',},
[316]={ID=-615,String='不能超过限购个数',},
[317]={ID=-620,String='未找到月卡信息',},
[318]={ID=-621,String='今天已领取过月卡奖励',},
[319]={ID=-622,String='未购买成长基金',},
[320]={ID=-623,String='已领取过该成长基金',},
[321]={ID=-624,String='该等级没有成长基金可以领取',},
[322]={ID=-625,String='已购买过成长基金',},
[323]={ID=-626,String='未达到领取等级',},
[324]={ID=-627,String='没有可领取的成长基金',},
[325]={ID=-628,String='已超过购买时限，无法购买成长基金',},
[326]={ID=-629,String='月卡持续时间超过30天，无法再次购买。',},
[327]={ID=-630,String='英雄分解的英雄没找到',},
[328]={ID=-631,String='不能分解阵上的英雄',},
[329]={ID=-632,String='不能分解侍从中的英雄',},
[330]={ID=-633,String='每次分解英雄个数超出最大个数',},
[331]={ID=-634,String='不能分解探险中的英雄',},
[332]={ID=-635,String='碎片不存在',},
[333]={ID=-636,String='装备分解的装备没找到',},
[334]={ID=-637,String='不能分解穿在身上的装备',},
[335]={ID=-638,String='不能分解侍从中的装备',},
[336]={ID=-639,String='每次分解装备个数超出最大个数',},
[337]={ID=-640,String='该英雄不能合成',},
[338]={ID=-641,String='碎片不足',},
[339]={ID=-645,String='装备碎片不存在',},
[340]={ID=-650,String='未获得此英雄',},
[341]={ID=-651,String='英雄的好感度等级已达到最大',},
[342]={ID=-652,String='没有英灵食物',},
[343]={ID=-653,String='英灵未满级',},
[344]={ID=-654,String='英灵已满阶',},
[345]={ID=-680,String='该活动未开始或已经结束',},
[346]={ID=-681,String='找不到该活动',},
[347]={ID=-682,String='活动时间错误',},
[348]={ID=-683,String='找不到该累充奖励',},
[349]={ID=-684,String='已领取该累充奖励',},
[350]={ID=-685,String='充值数量不足，不能领取该奖励',},
[351]={ID=-686,String='数据库错误，领取奖励失败',},
[352]={ID=-690,String='该活动不存在',},
[353]={ID=-691,String='未达到该活动的领奖条件',},
[354]={ID=-692,String='已领取该奖励',},
[355]={ID=-693,String='开服登录活动奖励不存在',},
[356]={ID=-695,String='领取开服嘉年华活动2失败,活动不存在',},
[357]={ID=-696,String='领取开服嘉年华活动2失败,未完成',},
[358]={ID=-697,String='领取开服嘉年华活动2失败,已领取',},
[359]={ID=-698,String='购买开服嘉年华活动2贩售物品失败,已达到上限',},
[360]={ID=-700,String='领取开服嘉年华活动失败,活动不存在',},
[361]={ID=-701,String='领取开服嘉年华活动失败,未完成',},
[362]={ID=-702,String='领取开服嘉年华活动失败,已领取',},
[363]={ID=-703,String='开服嘉年华进度奖励必须第五天后才能领取',},
[364]={ID=-705,String='领取开服红包时间错误',},
[365]={ID=-706,String='已经领取过开服红包',},
[366]={ID=-707,String='领取开服竞技场排行奖励时间错误',},
[367]={ID=-708,String='已经领取过开服竞技场排行奖励',},
[368]={ID=-709,String='未上榜不能领取',},
[369]={ID=-710,String='该奖励不存在',},
[370]={ID=-711,String='您不可以领取该奖励',},
[371]={ID=-712,String='您已领取该奖励',},
[372]={ID=-713,String='不能领取该排名奖励',},
[373]={ID=-715,String='领取5W钻活动奖励失败,活动不存在',},
[374]={ID=-716,String='领取5W钻活动奖励失败,未完成',},
[375]={ID=-717,String='领取5W钻活动奖励失败,已领取',},
[376]={ID=-720,String='活动已过期',},
[377]={ID=-721,String='奖励不可领',},
[378]={ID=-722,String='奖励已领取',},
[379]={ID=-723,String='奖励信息错误',},
[380]={ID=-730,String='活动已结束',},
[381]={ID=-731,String='已领取该奖励',},
[382]={ID=-732,String='没达到领奖条件',},
[383]={ID=-740,String='活动已过期',},
[384]={ID=-741,String='奖励不可领',},
[385]={ID=-742,String='奖励已领取',},
[386]={ID=-743,String='奖励信息错误',},
[387]={ID=-750,String='该奖励已被领取',},
[388]={ID=-760,String='黑庙重置次用已用完',},
[389]={ID=-761,String='领取血瓶已达上限',},
[390]={ID=-762,String='回血次数已用完',},
[391]={ID=-763,String='死亡的英雄不能出战',},
[392]={ID=-764,String='没有英雄不能出战',},
[393]={ID=-765,String='已通关',},
[394]={ID=-766,String='结算前请先进入挑战',},
[395]={ID=-767,String='黑庙战斗验证失败',},
[396]={ID=-768,String='满血或者全部死亡不用回血',},
[397]={ID=-769,String='不能重复领取箱子',},
[398]={ID=-770,String='本关卡没有箱子',},
[399]={ID=-771,String='战斗验证失败（771）',},
[400]={ID=-772,String='已经挑战了其他难度的试炼，不能扫荡。',},
[401]={ID=-773,String='此难度未通关不能挑战。',},
[402]={ID=-774,String='已通关不能扫荡。',},
[403]={ID=-775,String='副本配置文件错误或者不存在',},
[404]={ID=-776,String='未开启的试练',},
[405]={ID=-777,String='没试练挑战次数',},
[406]={ID=-778,String='等级不够不能挑战试练',},
[407]={ID=-779,String='无效队长不能挑战试练',},
[408]={ID=-780,String='挑战申请丢失，无法验证战斗（780）。',},
[409]={ID=-781,String='战斗验证失败（781）',},
[410]={ID=-782,String='没挑战成功过不能扫荡',},
[411]={ID=-783,String='扫荡试练次数不够',},
[412]={ID=-790,String='活动已结束',},
[413]={ID=-791,String='该折扣不存在',},
[414]={ID=-792,String='该商品折扣今日折扣已用完',},
[415]={ID=-793,String='该商品折扣',},
[416]={ID=-794,String='该商品今天没有折扣',},
[417]={ID=-800,String='题目不存在',},
[418]={ID=-801,String='今日答题次数已满',},
[419]={ID=-810,String='活动已结束',},
[420]={ID=-811,String='已领取该奖励',},
[421]={ID=-812,String='没达到领奖条件',},
[422]={ID=-813,String='活动已结束',},
[423]={ID=-814,String='找不到此招募活动信息',},
[424]={ID=-815,String='已领取该奖励,不可重复领取',},
[425]={ID=-816,String='您没达到该奖励的领奖条件',},
[426]={ID=-820,String='野外首领配置错误',},
[427]={ID=-821,String='野外首领已逃跑',},
[428]={ID=-822,String='野外首领已被击杀',},
[429]={ID=-823,String='已有玩家正在挑战此首领，请稍后再挑战',},
[430]={ID=-824,String='您不能重复挑战此首领。',},
[431]={ID=-825,String='未对此野外首领请求协助，不能挑战',},
[432]={ID=-826,String='野外首领协助挑战次数已用完',},
[433]={ID=-827,String='只能协助进攻野外首领一次。',},
[434]={ID=-828,String='挑战申请丢失，无法验证战斗（828）。',},
[435]={ID=-829,String='野外首领战斗验证失败（829）',},
[436]={ID=-830,String='无法对他人触发的野外首领请求协助。',},
[437]={ID=-831,String='请先挑战此野外首领一次。',},
[438]={ID=-832,String='该首领已经死亡，无法分享。',},
[439]={ID=-833,String='无法重复分享',},
[440]={ID=-834,String='首领未被击杀,无法领取奖励',},
[441]={ID=-835,String='不能重复领取奖励',},
[442]={ID=-836,String='累计伤害奖励已领取',},
[443]={ID=-837,String=' 累计伤害奖励伤害未达到条件',},
[444]={ID=-840,String='您还没完成该任务',},
[445]={ID=-841,String='您已领取该奖励',},
[446]={ID=-842,String='该奖励不存在',},
[447]={ID=-850,String='已领取',},
[448]={ID=-851,String='在线时长不足',},
[449]={ID=-852,String='前一阶段的奖励还没领取',},
[450]={ID=-860,String='当前不是领取周一大礼包的活动时间',},
[451]={ID=-861,String='已领取本周的大礼包',},
[452]={ID=-870,String='该奖励已领取',},
[453]={ID=-871,String='该任务没完成',},
[454]={ID=-880,String='奖励不存在',},
[455]={ID=-881,String='已领取该奖励',},
[456]={ID=-882,String='指定兑换的道具条件不满足',},
[457]={ID=-890,String='活动已结束',},
[458]={ID=-891,String='此兑换不存在',},
[459]={ID=-892,String='收集兑换次数领取超过上限',},
[460]={ID=-917,String='不是排名第一公会会长不能开启',},
[461]={ID=-918,String='已经开启过了不能再开启',},
[462]={ID=-919,String='双倍时间未过不能重复开启',},
[463]={ID=-920,String='护送中',},
[464]={ID=-921,String='已有协助者',},
[465]={ID=-922,String='协助者今日协助次数已用完',},
[466]={ID=-923,String='不能频繁邀请',},
[467]={ID=-924,String='今日协助次数已用完',},
[468]={ID=-925,String='对方已有协助玩家了',},
[469]={ID=-926,String='对方已经开始护送了',},
[470]={ID=-927,String='5星了，不能再刷了',},
[471]={ID=-928,String='购买刷星次数已达上限',},
[472]={ID=-929,String='没有护送次数了',},
[473]={ID=-930,String='对方护送已完成',},
[474]={ID=-931,String='没有拦截次数',},
[475]={ID=-932,String='购买拦截次数已达上限',},
[476]={ID=-933,String='对方被拦截次数已达上限',},
[477]={ID=-934,String='对方正在被拦截中',},
[478]={ID=-935,String='不能重复拦截',},
[479]={ID=-936,String='不能拦截自己或者协助的人',},
[480]={ID=-942,String='觉醒配置错误。',},
[481]={ID=-959,String='战斗数据传输错误，请重试。',},
[482]={ID=-960,String='矿洞以外的领地才能刷新对手。',},
[483]={ID=-961,String='领地状态错误，无法刷新对手。',},
[484]={ID=-962,String='领地占领时间不足。',},
[485]={ID=-963,String='没有低于自身等级的领地，无法扫荡！',},
[486]={ID=-970,String='技能点未使用完，不能购买。',},
[487]={ID=-980,String='不是好友，不能赠送体力！',},
[488]={ID=-981,String='今天已经给该好友赠送过体力了！',},
[489]={ID=-982,String='今天已领取过该好友赠送的体力。',},
[490]={ID=-983,String='该好友没给你赠送体力，不能领取。',},
[491]={ID=-984,String='今日领取的好友体力已达到上限！',},
[492]={ID=-985,String='今日赠送体力已达上限！',},
[493]={ID=-990,String='竞技积分不足，不能领取！',},
[494]={ID=-991,String='已领取该积分奖励！',},
[495]={ID=-992,String='已膜拜该玩家',},
[496]={ID=-1001,String='未找到可传承英雄！',},
[497]={ID=-1002,String='不能传承给潜质更低的英雄！',},
[498]={ID=-1003,String='传承英雄比被传承英雄等级更低，无法传承！',},
[499]={ID=-1010,String='VIP等级不足',},
[500]={ID=-1011,String='购买次数已满',},
[501]={ID=-1012,String='没有刷出此商品，不能购买',},
[502]={ID=-1100,String='公会不存在',},
[503]={ID=-1101,String='没有公会不能操作',},
[504]={ID=-1102,String='权限不够不能操作',},
[505]={ID=-1103,String='公会成员已满',},
[506]={ID=-1104,String='公会官员人数已满',},
[507]={ID=-1105,String='玩家已有公会不能创建或者加入公会
',},
[508]={ID=-1106,String='等级不够不能申请加入此公会',},
[509]={ID=-1107,String='公会徽章(图标)不存在',},
[510]={ID=-1108,String='公会名称太短',},
[511]={ID=-1109,String='公会名称太长',},
[512]={ID=-1110,String='公会名称不合法',},
[513]={ID=-1111,String='公会重名',},
[514]={ID=-1112,String='公告不合法',},
[515]={ID=-1113,String='公会中未找到此玩家',},
[516]={ID=-1114,String='捐献次数已用完',},
[517]={ID=-1115,String='已达到最大建设等级',},
[518]={ID=-1116,String='未找到此玩家申请记录',},
[519]={ID=-1117,String='本周尚未挑战过公会副本，无法申请物品。',},
[520]={ID=-1118,String='今日领取公会副本奖励已达上限。',},
[521]={ID=-1119,String='公会邮件标题不能问空',},
[522]={ID=-1120,String='公会邮件标题太长',},
[523]={ID=-1121,String='公会邮件标题不合法',},
[524]={ID=-1122,String='公会邮件内容不能为空',},
[525]={ID=-1123,String='公会邮件内容太长',},
[526]={ID=-1124,String='公会邮件内容不合法',},
[527]={ID=-1125,String='公会邮件次数已用完',},
[528]={ID=-1130,String='一粒蛋今日营救次数已用完',},
[529]={ID=-1131,String='一粒蛋今日免费次数已用完',},
[530]={ID=-1132,String='一粒蛋数量已满，不能继续营救',},
[531]={ID=-1133,String='一粒蛋系统没开启',},
[532]={ID=-1134,String='今日更换过公会，暂不能使用新公会功能。',},
[533]={ID=-1140,String='此公会副本尚未开启,无法进行挑战',},
[534]={ID=-1141,String='前置副本尚未通关,无法挑战',},
[535]={ID=-1142,String='领主等级未达到挑战此公会副本需求',},
[536]={ID=-1143,String='此副本挑战次数已经用完',},
[537]={ID=-1144,String='公会副本已经通关',},
[538]={ID=-1145,String='有玩家正在进行战斗，请稍后进行挑战',},
[539]={ID=-1146,String='战斗超时',},
[540]={ID=-1147,String='战斗发生未知错误',},
[541]={ID=-1148,String='副本重置次数已用完，无法重置副本',},
[542]={ID=-1149,String='有玩家正在进行挑战，暂无法重置此副本',},
[543]={ID=-1150,String='副本尚未开启，无法重置',},
[544]={ID=-1151,String='首领正在被其他玩家挑战，请稍后尝试。',},
[545]={ID=-1202,String='该雕文已满级！',},
[546]={ID=-1210,String='没有找到装备雕文的英雄',},
[547]={ID=-1211,String='未找到要装备的雕文',},
[548]={ID=-1212,String='该雕文已被其他英雄穿上了',},
[549]={ID=-1213,String='相同属性的雕文只能装备一个',},
[550]={ID=-1220,String='该雕文碎片不能合成',},
[551]={ID=-1240,String='对方排名更高，不能连续挑战',},
[552]={ID=-1250,String='周签到活动已结束',},
[553]={ID=-1251,String='今日已签到',},
[554]={ID=-1260,String='普通每日充值活动已结束',},
[555]={ID=-1261,String='普通每日充值活动今日奖励已领取',},
[556]={ID=-1262,String='普通每日充值活动今日奖励不可领取',},
[557]={ID=-1265,String='幸运抽钻活动已经结束',},
[558]={ID=-1266,String='幸运抽钻次数已经用完',},
[559]={ID=-1270,String='欢乐机抽奖活动已结束',},
[560]={ID=-1271,String='该欢乐机活动奖励已领取',},
[561]={ID=-1272,String='欢乐机抽奖次数不足，不可领取',},
[562]={ID=-1280,String='下载评论活动已结束',},
[563]={ID=-1281,String='您已经领取过这个奖励了！',},
[564]={ID=-1282,String='您已经领取过这个奖励了！',},
[565]={ID=-1285,String='未到活动奖励领取时间！',},
[566]={ID=-1286,String='报歉，您不满足领取该奖励的条件！',},
[567]={ID=-1287,String='您已经领取过这个奖励了！',},
[568]={ID=-1295,String='您已经领取过这个奖励了！',},
[569]={ID=-1296,String='报歉，您还不能领取这个奖励！',},
[570]={ID=-1300,String='限时抽英雄活动已结束',},
[571]={ID=-1301,String='抽奖积分不足，不能领取此奖励',},
[572]={ID=-1310,String='未分解过此英雄，无法重生',},
[573]={ID=-1321,String='每日累充活动未开始',},
[574]={ID=-1322,String='未找到每日累充活动',},
[575]={ID=-1323,String='每日累充活动时间错误',},
[576]={ID=-1324,String='找不到该奖励',},
[577]={ID=-1325,String='该奖励已领取（1325）',},
[578]={ID=-1326,String='充值额度不足，不能领取该奖励',},
[579]={ID=-1330,String='没有达到奖励领取条件（-1330）',},
[580]={ID=-1331,String='不能重复领取奖励',},
[581]={ID=-1332,String='不满足领取条件，无法领取（-1332）',},
[582]={ID=-1333,String='活动已结束',},
[583]={ID=-1340,String='找不到商品信息，请重新获取商品信息！',},
[584]={ID=-1341,String='该商品的限购次数已满',},
[585]={ID=-1342,String='该折扣商品已售罄',},
[586]={ID=-1343,String='此批次商品已过期，请重新获取商品信息！',},
[587]={ID=-1344,String='国庆抢购已结束，敬请期待其他活动！',},
[588]={ID=-1351,String='争霸赛未开启',},
[589]={ID=-1352,String='未达到参赛要求等级',},
[590]={ID=-1353,String='报名已截止',},
[591]={ID=-1354,String='已报名',},
[592]={ID=-1355,String='本次您已经支持过一名玩家了',},
[593]={ID=-1356,String='您支持的玩家没有入围当前赛事',},
[594]={ID=-1357,String='本次比赛胜负已分，无法支持玩家',},
[595]={ID=-1358,String='本次比赛已经开始，无法支持玩家',},
[596]={ID=-1381,String='今日已接的任务数量已达上限',},
[597]={ID=-1382,String='当前已接的任务列表已达上限',},
[598]={ID=-1383,String='任务无法接取',},
[599]={ID=-1384,String='英雄已在探险中',},
[600]={ID=-1385,String='找不到探险英雄',},
[601]={ID=-1386,String='英雄数量超过上限',},
[602]={ID=-1387,String='请至少出战一个英雄',},
[603]={ID=-1388,String='购买的任务成功率超过上限',},
[604]={ID=-1389,String='购买的成功率不存在',},
[605]={ID=-1390,String='找不到任务',},
[606]={ID=-1391,String='任务时间未到',},
[607]={ID=-1401,String='前置节点未满级，不能激活',},
[608]={ID=-1402,String='其他神器页未达到条件, 不能激活',},
[609]={ID=-1403,String='节点已达满级，不能再升级',},
[610]={ID=-1409,String='该符文已被装备，无法回收',},
[611]={ID=-1410,String='找不到符文',},
[612]={ID=-1411,String='不能吞噬自己升级',},
[613]={ID=-1412,String='精炼过的符文不能被吞噬',},
[614]={ID=-1413,String='穿戴的符文不能被吞噬',},
[615]={ID=-1414,String='所选道具太多,已超过等级上限了',},
[616]={ID=-1415,String='精炼所需强化等级不足',},
[617]={ID=-1416,String='精炼已达最大等级',},
[618]={ID=-1417,String='此类符文不可以精炼',},
[619]={ID=-1418,String='符文穿戴数量已达上限',},
[620]={ID=-1420,String='禁魔监狱当前层已满星,不能再刷星',},
[621]={ID=-1421,String='找不到禁魔监狱信息',},
[622]={ID=-1422,String='禁魔监狱数据与战斗验证数据不匹配',},
[623]={ID=-1423,String='没有通关,不能领取奖励',},
[624]={ID=-1424,String='已领取当前层奖励',},
[625]={ID=-1425,String='今日重置次数已用完',},
[626]={ID=-1430,String='找不到宠物',},
[627]={ID=-1431,String='所选道具太多,已超过等级上限了',},
[628]={ID=-1432,String='宠物升星所需要的等级不足',},
[629]={ID=-1433,String='宠物已满星',},
[630]={ID=-1434,String='穿在身上的宠物不能分解',},
[631]={ID=-1500,String='突破英雄不存在',},
[632]={ID=-1501,String='英雄天赋已满级',},
[633]={ID=-1502,String='天赋突破配置错误',},
[634]={ID=-1510,String='圣物等级已满',},
[635]={ID=-1511,String='未通关要求的战役关卡，无法开启圣物',},
[636]={ID=-1520,String='讨伐关卡不存在',},
[637]={ID=-1521,String='结束讨伐关卡错误',},
[638]={ID=-1522,String='攻击次数不合法',},
[639]={ID=-1523,String='章节ID不存在',},
[640]={ID=-1524,String='未通关全部章节，不能领取',},
[641]={ID=-1525,String='已领取，不能重复领取',},
[642]={ID=-1526,String='前置关卡没完成',},
[643]={ID=-1527,String='前置章节没完成',},
[644]={ID=-1528,String='非boss关卡',},
[645]={ID=-1529,String='boss关卡错误',},
[646]={ID=-1530,String='重生英雄不存在',},
[647]={ID=-1531,String='阵上英雄不能重生',},
[648]={ID=-1532,String='重生装备不存在',},
[649]={ID=-1533,String='穿在身上的装备不能重生',},
[650]={ID=-1540,String='饰品不存在',},
[651]={ID=-1541,String='非饰品类装备不可合成',},
[652]={ID=-1542,String='需要5个相同品质的饰品才可合成',},
[653]={ID=-1550,String='该进度宝箱奖励已领取',},
[654]={ID=-1551,String='该进度宝箱奖励不存在',},
[655]={ID=-1552,String='公会建设进度不足，不能领取该奖励',},
[656]={ID=-1560,String='该奖励已经领取',},
[657]={ID=-1561,String='未满足奖励领取条件',},
[658]={ID=-1562,String='挑战次数不足',},
[659]={ID=-1563,String='该对手已被击败，不能重复挑战',},
[660]={ID=-1564,String='找不到挑战目标',}
}
return list