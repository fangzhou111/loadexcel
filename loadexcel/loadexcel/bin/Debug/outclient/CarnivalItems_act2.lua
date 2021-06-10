local list = {
[1]={id=1,FunctionId=1,SubFunctionId=101,SubFunctionValue1=10,SubFunctionValue2=0,RewardId=10101,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到10级',},
[2]={id=2,FunctionId=1,SubFunctionId=101,SubFunctionValue1=20,SubFunctionValue2=0,RewardId=10102,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到20级',},
[3]={id=3,FunctionId=1,SubFunctionId=101,SubFunctionValue1=25,SubFunctionValue2=0,RewardId=10103,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到25级',},
[4]={id=4,FunctionId=1,SubFunctionId=101,SubFunctionValue1=30,SubFunctionValue2=0,RewardId=10104,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到30级',},
[5]={id=5,FunctionId=1,SubFunctionId=101,SubFunctionValue1=35,SubFunctionValue2=0,RewardId=10105,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到35级',},
[6]={id=6,FunctionId=1,SubFunctionId=101,SubFunctionValue1=40,SubFunctionValue2=0,RewardId=10106,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到40级',},
[7]={id=7,FunctionId=1,SubFunctionId=101,SubFunctionValue1=42,SubFunctionValue2=0,RewardId=10107,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到42级',},
[8]={id=8,FunctionId=1,SubFunctionId=101,SubFunctionValue1=45,SubFunctionValue2=0,RewardId=10108,JumpId=1,SubFunctionName='领主等级',SubFunctionDesc='玩家等级达到45级',},
[9]={id=9,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1002006,SubFunctionValue2=0,RewardId=10201,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第2章',},
[10]={id=10,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1004010,SubFunctionValue2=0,RewardId=10202,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第4章',},
[11]={id=11,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1006010,SubFunctionValue2=0,RewardId=10203,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第6章',},
[12]={id=12,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1008010,SubFunctionValue2=0,RewardId=10204,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第8章',},
[13]={id=13,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1009010,SubFunctionValue2=0,RewardId=10205,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第9章',},
[14]={id=14,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1010010,SubFunctionValue2=0,RewardId=10206,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第10章',},
[15]={id=15,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1011010,SubFunctionValue2=0,RewardId=10207,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第11章',},
[16]={id=16,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1012010,SubFunctionValue2=0,RewardId=10208,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第12章',},
[17]={id=17,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1013010,SubFunctionValue2=0,RewardId=10209,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第13章',},
[18]={id=18,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1014010,SubFunctionValue2=0,RewardId=10210,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第14章',},
[19]={id=19,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1015010,SubFunctionValue2=0,RewardId=10211,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第15章',},
[20]={id=20,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1016010,SubFunctionValue2=0,RewardId=10212,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第16章',},
[21]={id=21,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1017010,SubFunctionValue2=0,RewardId=10213,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第17章',},
[22]={id=22,FunctionId=1,SubFunctionId=102,SubFunctionValue1=1018010,SubFunctionValue2=0,RewardId=10214,JumpId=1,SubFunctionName='魔兽之路',SubFunctionDesc='通关普通第18章',},
[23]={id=33,FunctionId=2,SubFunctionId=202,SubFunctionValue1=10,SubFunctionValue2=1,RewardId=20201,JumpId=5,SubFunctionName='英雄招募',SubFunctionDesc='拥有10资质以上英雄1个',},
[24]={id=34,FunctionId=2,SubFunctionId=202,SubFunctionValue1=10,SubFunctionValue2=2,RewardId=20202,JumpId=5,SubFunctionName='英雄招募',SubFunctionDesc='拥有10资质以上英雄2个',},
[25]={id=35,FunctionId=2,SubFunctionId=202,SubFunctionValue1=10,SubFunctionValue2=3,RewardId=20203,JumpId=5,SubFunctionName='英雄招募',SubFunctionDesc='拥有10资质以上英雄3个',},
[26]={id=36,FunctionId=2,SubFunctionId=202,SubFunctionValue1=10,SubFunctionValue2=4,RewardId=20204,JumpId=5,SubFunctionName='英雄招募',SubFunctionDesc='拥有10资质以上英雄4个',},
[27]={id=37,FunctionId=2,SubFunctionId=202,SubFunctionValue1=10,SubFunctionValue2=5,RewardId=20205,JumpId=5,SubFunctionName='英雄招募',SubFunctionDesc='拥有10资质以上英雄5个',},
[28]={id=38,FunctionId=2,SubFunctionId=201,SubFunctionValue1=1,SubFunctionValue2=5,RewardId=20101,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='5个英雄进阶到1阶',},
[29]={id=39,FunctionId=2,SubFunctionId=201,SubFunctionValue1=2,SubFunctionValue2=4,RewardId=20102,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='4个英雄进阶到2阶',},
[30]={id=40,FunctionId=2,SubFunctionId=201,SubFunctionValue1=3,SubFunctionValue2=4,RewardId=20103,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='4个英雄进阶到3阶',},
[31]={id=41,FunctionId=2,SubFunctionId=201,SubFunctionValue1=4,SubFunctionValue2=3,RewardId=20104,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='3个英雄进阶到4阶',},
[32]={id=42,FunctionId=2,SubFunctionId=201,SubFunctionValue1=5,SubFunctionValue2=2,RewardId=20105,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='2个英雄进阶到5阶',},
[33]={id=43,FunctionId=2,SubFunctionId=201,SubFunctionValue1=5,SubFunctionValue2=4,RewardId=20106,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='4个英雄进阶到5阶',},
[34]={id=44,FunctionId=2,SubFunctionId=201,SubFunctionValue1=6,SubFunctionValue2=3,RewardId=20107,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='3个英雄进阶到6阶',},
[35]={id=45,FunctionId=2,SubFunctionId=201,SubFunctionValue1=6,SubFunctionValue2=4,RewardId=20108,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='4个英雄进阶到6阶',},
[36]={id=46,FunctionId=2,SubFunctionId=201,SubFunctionValue1=6,SubFunctionValue2=5,RewardId=20109,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='5个英雄进阶到6阶',},
[37]={id=47,FunctionId=2,SubFunctionId=201,SubFunctionValue1=7,SubFunctionValue2=4,RewardId=20110,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='4个英雄进阶到7阶',},
[38]={id=48,FunctionId=2,SubFunctionId=201,SubFunctionValue1=7,SubFunctionValue2=5,RewardId=20111,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='5个英雄进阶到7阶',},
[39]={id=49,FunctionId=2,SubFunctionId=201,SubFunctionValue1=8,SubFunctionValue2=2,RewardId=20112,JumpId=22,SubFunctionName='英雄进阶',SubFunctionDesc='2个英雄进阶到8阶',},
[40]={id=50,FunctionId=3,SubFunctionId=301,SubFunctionValue1=4,SubFunctionValue2=4,RewardId=30101,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有4件4装等以上的装备',},
[41]={id=51,FunctionId=3,SubFunctionId=301,SubFunctionValue1=4,SubFunctionValue2=12,RewardId=30102,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有12件4装等以上的装备',},
[42]={id=52,FunctionId=3,SubFunctionId=301,SubFunctionValue1=4,SubFunctionValue2=24,RewardId=30103,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有24件4装等以上的装备',},
[43]={id=53,FunctionId=3,SubFunctionId=301,SubFunctionValue1=5,SubFunctionValue2=4,RewardId=30104,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有4件5装等以上的装备',},
[44]={id=54,FunctionId=3,SubFunctionId=301,SubFunctionValue1=5,SubFunctionValue2=8,RewardId=30105,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有8件5装等以上的装备',},
[45]={id=55,FunctionId=3,SubFunctionId=301,SubFunctionValue1=8,SubFunctionValue2=4,RewardId=30106,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有4件8装等以上的装备',},
[46]={id=56,FunctionId=3,SubFunctionId=301,SubFunctionValue1=8,SubFunctionValue2=12,RewardId=30107,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有12件8装等以上的装备',},
[47]={id=57,FunctionId=3,SubFunctionId=301,SubFunctionValue1=10,SubFunctionValue2=4,RewardId=30108,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有4件10装等以上的装备',},
[48]={id=58,FunctionId=3,SubFunctionId=301,SubFunctionValue1=10,SubFunctionValue2=8,RewardId=30109,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有8件10装等以上的装备',},
[49]={id=59,FunctionId=3,SubFunctionId=301,SubFunctionValue1=12,SubFunctionValue2=4,RewardId=30110,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有4件12装等以上的装备',},
[50]={id=60,FunctionId=3,SubFunctionId=301,SubFunctionValue1=16,SubFunctionValue2=4,RewardId=30111,JumpId=30,SubFunctionName='装备穿戴',SubFunctionDesc='拥有4件16装等以上的装备',},
[51]={id=61,FunctionId=3,SubFunctionId=302,SubFunctionValue1=10,SubFunctionValue2=24,RewardId=30201,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到10级',},
[52]={id=62,FunctionId=3,SubFunctionId=302,SubFunctionValue1=20,SubFunctionValue2=24,RewardId=30202,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到20级',},
[53]={id=63,FunctionId=3,SubFunctionId=302,SubFunctionValue1=30,SubFunctionValue2=24,RewardId=30203,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到30级',},
[54]={id=64,FunctionId=3,SubFunctionId=302,SubFunctionValue1=40,SubFunctionValue2=24,RewardId=30204,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到40级',},
[55]={id=65,FunctionId=3,SubFunctionId=302,SubFunctionValue1=50,SubFunctionValue2=24,RewardId=30205,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到50级',},
[56]={id=66,FunctionId=3,SubFunctionId=302,SubFunctionValue1=60,SubFunctionValue2=24,RewardId=30206,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到60级',},
[57]={id=67,FunctionId=3,SubFunctionId=302,SubFunctionValue1=70,SubFunctionValue2=24,RewardId=30207,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到70级',},
[58]={id=68,FunctionId=3,SubFunctionId=302,SubFunctionValue1=80,SubFunctionValue2=24,RewardId=30208,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到80级',},
[59]={id=69,FunctionId=3,SubFunctionId=302,SubFunctionValue1=90,SubFunctionValue2=24,RewardId=30209,JumpId=17,SubFunctionName='装备强化',SubFunctionDesc='24件装备强化到90级',},
[60]={id=81,FunctionId=4,SubFunctionId=501,SubFunctionValue1=10,SubFunctionValue2=0,RewardId=50101,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人10名',},
[61]={id=82,FunctionId=4,SubFunctionId=501,SubFunctionValue1=30,SubFunctionValue2=0,RewardId=50102,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人30名',},
[62]={id=83,FunctionId=4,SubFunctionId=501,SubFunctionValue1=50,SubFunctionValue2=0,RewardId=50103,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人50名',},
[63]={id=84,FunctionId=4,SubFunctionId=501,SubFunctionValue1=80,SubFunctionValue2=0,RewardId=50104,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人80名',},
[64]={id=85,FunctionId=4,SubFunctionId=501,SubFunctionValue1=100,SubFunctionValue2=0,RewardId=50105,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人100名',},
[65]={id=86,FunctionId=4,SubFunctionId=501,SubFunctionValue1=120,SubFunctionValue2=0,RewardId=50106,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人120名',},
[66]={id=87,FunctionId=4,SubFunctionId=501,SubFunctionValue1=150,SubFunctionValue2=0,RewardId=50107,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人150名',},
[67]={id=88,FunctionId=4,SubFunctionId=501,SubFunctionValue1=180,SubFunctionValue2=0,RewardId=50108,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人180名',},
[68]={id=89,FunctionId=4,SubFunctionId=501,SubFunctionValue1=200,SubFunctionValue2=0,RewardId=50109,JumpId=79,SubFunctionName='讨伐之路',SubFunctionDesc='讨伐中击败敌人200名',},
[69]={id=23,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2003004,SubFunctionValue2=0,RewardId=10301,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第3章',},
[70]={id=24,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2005004,SubFunctionValue2=0,RewardId=10302,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第5章',},
[71]={id=25,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2006004,SubFunctionValue2=0,RewardId=10303,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第6章',},
[72]={id=26,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2007004,SubFunctionValue2=0,RewardId=10304,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第7章',},
[73]={id=27,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2008004,SubFunctionValue2=0,RewardId=10305,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第8章',},
[74]={id=28,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2009004,SubFunctionValue2=0,RewardId=10306,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第9章',},
[75]={id=29,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2010004,SubFunctionValue2=0,RewardId=10307,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第10章',},
[76]={id=30,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2011004,SubFunctionValue2=0,RewardId=10308,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第11章',},
[77]={id=31,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2012004,SubFunctionValue2=0,RewardId=10309,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第12章',},
[78]={id=32,FunctionId=4,SubFunctionId=103,SubFunctionValue1=2013004,SubFunctionValue2=0,RewardId=10310,JumpId=2,SubFunctionName='挑战精英',SubFunctionDesc='精英副本通关第13章',},
[79]={id=70,FunctionId=5,SubFunctionId=401,SubFunctionValue1=3000,SubFunctionValue2=1001,RewardId=40101,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入3000名',},
[80]={id=71,FunctionId=5,SubFunctionId=401,SubFunctionValue1=1000,SubFunctionValue2=751,RewardId=40102,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入1000名',},
[81]={id=72,FunctionId=5,SubFunctionId=401,SubFunctionValue1=750,SubFunctionValue2=501,RewardId=40103,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入750名',},
[82]={id=73,FunctionId=5,SubFunctionId=401,SubFunctionValue1=500,SubFunctionValue2=301,RewardId=40104,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入500名',},
[83]={id=74,FunctionId=5,SubFunctionId=401,SubFunctionValue1=300,SubFunctionValue2=101,RewardId=40105,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入300名',},
[84]={id=75,FunctionId=5,SubFunctionId=401,SubFunctionValue1=100,SubFunctionValue2=51,RewardId=40106,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入100名',},
[85]={id=76,FunctionId=5,SubFunctionId=401,SubFunctionValue1=50,SubFunctionValue2=31,RewardId=40107,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入50名',},
[86]={id=77,FunctionId=5,SubFunctionId=401,SubFunctionValue1=30,SubFunctionValue2=11,RewardId=40108,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入30名',},
[87]={id=78,FunctionId=5,SubFunctionId=401,SubFunctionValue1=10,SubFunctionValue2=6,RewardId=40109,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入10名',},
[88]={id=79,FunctionId=5,SubFunctionId=401,SubFunctionValue1=5,SubFunctionValue2=2,RewardId=40110,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入5名',},
[89]={id=80,FunctionId=5,SubFunctionId=401,SubFunctionValue1=1,SubFunctionValue2=1,RewardId=40111,JumpId=6,SubFunctionName='竞技排名',SubFunctionDesc='竞技场排名进入1名',},
[90]={id=90,FunctionId=6,SubFunctionId=601,SubFunctionValue1=5,SubFunctionValue2=0,RewardId=60101,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第5波',},
[91]={id=91,FunctionId=6,SubFunctionId=601,SubFunctionValue1=10,SubFunctionValue2=0,RewardId=60102,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第10波',},
[92]={id=92,FunctionId=6,SubFunctionId=601,SubFunctionValue1=15,SubFunctionValue2=0,RewardId=60103,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第15波',},
[93]={id=93,FunctionId=6,SubFunctionId=601,SubFunctionValue1=20,SubFunctionValue2=0,RewardId=60104,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第20波',},
[94]={id=94,FunctionId=6,SubFunctionId=601,SubFunctionValue1=25,SubFunctionValue2=0,RewardId=60105,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第25波',},
[95]={id=95,FunctionId=6,SubFunctionId=601,SubFunctionValue1=30,SubFunctionValue2=0,RewardId=60106,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第30波',},
[96]={id=96,FunctionId=6,SubFunctionId=601,SubFunctionValue1=35,SubFunctionValue2=0,RewardId=60107,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第35波',},
[97]={id=97,FunctionId=6,SubFunctionId=601,SubFunctionValue1=40,SubFunctionValue2=0,RewardId=60108,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第40波',},
[98]={id=98,FunctionId=6,SubFunctionId=601,SubFunctionValue1=45,SubFunctionValue2=0,RewardId=60109,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第45波',},
[99]={id=99,FunctionId=6,SubFunctionId=601,SubFunctionValue1=50,SubFunctionValue2=0,RewardId=60110,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第50波',},
[100]={id=100,FunctionId=6,SubFunctionId=601,SubFunctionValue1=55,SubFunctionValue2=0,RewardId=60111,JumpId=9,SubFunctionName='泰坦之路',SubFunctionDesc='泰坦之路通关第55波',}
}
return list
