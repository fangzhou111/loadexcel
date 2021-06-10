local list = {
[1]={MonsterBehaviorID=630010020,AIs='群体审判wildboss@十字军打击wildboss@圣光爆炸wildboss@血色之誓wildboss',SkillIDs='63021010@63021020@63021030@63021040@63021060@94213010@90003020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[2]={MonsterBehaviorID=630010021,AIs='狗女入场喊话wildboss@狗女增益技能wildboss',SkillIDs='63023010@70003030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[3]={MonsterBehaviorID=630110010,AIs='顺劈斩wildboss@群体狂怒wildboss@剑刃风暴wildboss@阿强顺劈斩喊话wildboss@阿强剑刃风暴喊话wildboss',SkillIDs='63131010@63121010@63121040@63131040@63131060@94213010@63131090@90003020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[4]={MonsterBehaviorID=630110011,AIs='冲击波wildboss@嗜血wildboss',SkillIDs='63131070@70003030@63131080',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[5]={MonsterBehaviorID=640390010,AIs='群体狂怒wildboss@肥马瑟放毒wildboss',SkillIDs='63121010@63131010@63121030@63121060@63121062@94213010@63121080@90003020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[6]={MonsterBehaviorID=650070030,AIs='群体暗影箭wildboss@古尔丹放绝对领域wildboss@古尔丹喊话wildboss',SkillIDs='64521010@64521020@64521030@64521040@64521060@64521090@94213010@64521110@90003020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[7]={MonsterBehaviorID=650070031,AIs='恶魔之门召唤wildboss',SkillIDs='64521070@94213010@70003030',BaseFindEnemyAIs=''},
[8]={MonsterBehaviorID=650070032,AIs='恶魔守卫狂怒wildboss@古尔丹召唤物喊话',SkillIDs='64521080@70003030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[9]={MonsterBehaviorID=650070033,AIs='灵魂献祭wildboss',SkillIDs='64521100@94213010@70003030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[10]={MonsterBehaviorID=640100010,AIs='群体寒冰箭wildboss@大巫妖连击1wildboss@大巫妖连击2wildboss@大巫妖连击3wildboss@大巫妖连击完成喊话@大巫妖连击开始喊话',SkillIDs='64221010@64221100@64221110@64221120@64221130@94213010@90003020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[11]={MonsterBehaviorID=640100011,AIs='寒冰宝珠充能wildboss@寒冰宝珠寒冰箭wildboss',SkillIDs='64221070@64221090@70003030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[12]={MonsterBehaviorID=210100200,AIs='破城攻击zymst@破胆怒吼zymst',SkillIDs='83121010@83121020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[13]={MonsterBehaviorID=210090200,AIs='震荡波zymst@顺劈斩zymst',SkillIDs='83131010@83131020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[14]={MonsterBehaviorID=244010200,AIs='震荡波zymst@顺劈斩zymst',SkillIDs='83131010@83131020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[15]={MonsterBehaviorID=210030200,AIs='寒冰宝珠zymst@群体寒冰箭zymst',SkillIDs='84221010@84221020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[16]={MonsterBehaviorID=243020200,AIs='震荡波zymst@顺劈斩zymst',SkillIDs='83131010@83131020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[17]={MonsterBehaviorID=233010060,AIs='奥术爆裂zymst@群体寒冰箭zymst',SkillIDs='84231010@84221020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[18]={MonsterBehaviorID=237010060,AIs='死亡凋零zymst@顺劈斩zymst',SkillIDs='84521010@83131020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[19]={MonsterBehaviorID=216050000,AIs='震荡波zymst@顺劈斩zymst',SkillIDs='83131010@83131020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[20]={MonsterBehaviorID=201070000,AIs='破城攻击zymst@破胆怒吼zymst@召唤盗贼zymst',SkillIDs='83121010@83121020@83121030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[21]={MonsterBehaviorID=201130000,AIs='震荡波zymst@顺劈斩zymst@召唤盗贼zymst',SkillIDs='83131010@83131020@83121030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[22]={MonsterBehaviorID=950010020,AIs='破城攻击zymst@破胆怒吼zymst@召唤盗贼zymst',SkillIDs='83121010@83121020@83121030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[23]={MonsterBehaviorID=950010010,AIs='寒冰宝珠zymst@群体寒冰箭zymst@召唤盗贼zymst',SkillIDs='84221010@84221020@83121030',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[24]={MonsterBehaviorID=207010000,AIs='震荡波zymst@顺劈斩zymst@召唤兽人zymst',SkillIDs='83131010@83131020@83121040',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[25]={MonsterBehaviorID=930070010,AIs='震荡波zymst@顺劈斩zymst@召唤兽人zymst',SkillIDs='83131010@83131020@83121040',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[26]={MonsterBehaviorID=940070030,AIs='破城攻击zymst@破胆怒吼zymst@召唤兽人zymst',SkillIDs='83121010@83121020@83121040',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[27]={MonsterBehaviorID=950070030,AIs='死亡凋零zymst@暗影箭雨zymst@召唤兽人zymst',SkillIDs='84521010@84521020@83121040',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[28]={MonsterBehaviorID=234010000,AIs='震荡波zymst@顺劈斩zymst',SkillIDs='83131010@83131020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[29]={MonsterBehaviorID=940390010,AIs='破城攻击zymst@破胆怒吼zymst',SkillIDs='83121010@83121020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[30]={MonsterBehaviorID=940360010,AIs='死亡凋零zymst@暗影箭雨zymst',SkillIDs='84521010@84521020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[31]={MonsterBehaviorID=205020060,AIs='死亡凋零zymst@暗影箭雨zymst',SkillIDs='84521010@84521020',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[32]={MonsterBehaviorID=242010061,AIs='召唤哥布林zymst',SkillIDs='84211010@84213010@70003030@94213010',BaseFindEnemyAIs=''},
[33]={MonsterBehaviorID=242010060,AIs='哥布林跑位1zymst@哥布林跑位2zymst',SkillIDs='84213020',BaseFindEnemyAIs=''},
[34]={MonsterBehaviorID=201070001,AIs='',SkillIDs='83123010@70003030',BaseFindEnemyAIs=''},
[35]={MonsterBehaviorID=207010001,AIs='',SkillIDs='83123030@70003030',BaseFindEnemyAIs=''},
[36]={MonsterBehaviorID=242010062,AIs='召唤原木宝箱zymst',SkillIDs='84213010@84211020@94213010',BaseFindEnemyAIs=''},
[37]={MonsterBehaviorID=242010063,AIs='召唤精钢宝箱zymst',SkillIDs='84213010@84211030@94213010',BaseFindEnemyAIs=''},
[38]={MonsterBehaviorID=242010064,AIs='召唤青铜宝箱zymst',SkillIDs='84213010@84211040@94213010',BaseFindEnemyAIs=''},
[39]={MonsterBehaviorID=242010065,AIs='召唤白银宝箱zymst',SkillIDs='84213010@84211050@94213010',BaseFindEnemyAIs=''},
[40]={MonsterBehaviorID=242010066,AIs='召唤黄金宝箱zymst',SkillIDs='84213010@84211060@94213010',BaseFindEnemyAIs=''},
[41]={MonsterBehaviorID=242010067,AIs='召唤钻石宝箱zymst',SkillIDs='84213010@84211070@94213010',BaseFindEnemyAIs=''},
[42]={MonsterBehaviorID=242010068,AIs='',SkillIDs='',BaseFindEnemyAIs=''},
[43]={MonsterBehaviorID=242010069,AIs='',SkillIDs='',BaseFindEnemyAIs=''},
[44]={MonsterBehaviorID=242010070,AIs='',SkillIDs='',BaseFindEnemyAIs=''},
[45]={MonsterBehaviorID=242010071,AIs='',SkillIDs='',BaseFindEnemyAIs=''},
[46]={MonsterBehaviorID=242010072,AIs='',SkillIDs='',BaseFindEnemyAIs=''},
[47]={MonsterBehaviorID=242010073,AIs='',SkillIDs='',BaseFindEnemyAIs=''},
[48]={MonsterBehaviorID=242010050,AIs='火球术Mst@召唤炸弹人Mst@冲击波Mst',SkillIDs='94211040@94211090@94211060',BaseFindEnemyAIs='自动索敌(物防循环)@反击(通用)@反击(怪物)'},
[49]={MonsterBehaviorID=750010011,AIs='寒冰爆裂jtmst@冰环@冰锥术',SkillIDs='74221030@4222010@4222020@4223010',BaseFindEnemyAIs='自动索敌军团(物防循环)@反击(通用)@反击(怪物)'},
[50]={MonsterBehaviorID=750070010,AIs='闪电超载jtmst@大地震击@闪电链@空气图腾',SkillIDs='74611010@4612010@4612030@4613010',BaseFindEnemyAIs='自动索敌军团(物防循环)@反击(通用)@反击(怪物)'},
[51]={MonsterBehaviorID=740090020,AIs='野性狂暴jtmst@裂伤@横扫',SkillIDs='71411020@1412010@1412020@1413010@91111040',BaseFindEnemyAIs='自动索敌军团(物防循环)@反击(通用)@反击(怪物)'},
[52]={MonsterBehaviorID=740090021,AIs='熊德变身回(哈缪尔)jtmst',SkillIDs='71411021@1411010@91111040',BaseFindEnemyAIs='自动索敌军团(物防循环)@反击(通用)@反击(怪物)'},
[53]={MonsterBehaviorID=730010020,AIs='复仇者之盾jtmst@奉献@神圣庇护',SkillIDs='71011010@1012010@1012020@1013010@91111040',BaseFindEnemyAIs='自动索敌军团(物防循环)@反击(通用)@反击(怪物)'},
[54]={MonsterBehaviorID=740010040,AIs='龙息术jtmst@火球术@灼烧',SkillIDs='74211020@4212030@4212040@4213020',BaseFindEnemyAIs='自动索敌军团(物防循环)@反击(通用)@反击(怪物)'}
}
return list
