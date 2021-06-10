local list = {
[1]={MonsterBehaviorID=90160010,AIs='黑龙第一阶段变身@黑龙第一阶段顺劈@转火@黑龙第一阶段恐惧',SkillIDs='90160010010@90160010020@90160010030@90160010040@94213010',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[2]={MonsterBehaviorID=90160011,AIs='黑龙第二阶段变身@黑龙第二阶段变身2@黑龙第二阶段召怪@黑龙第二阶段召怪2@黑龙第二阶段吐息@黑龙第二阶段吐息2@黑龙第二阶段吐息3@黑龙第二阶段火球',SkillIDs='90160011010@90160011020@90160011030@90160011040@94213010',BaseFindEnemyAIs=''},
[3]={MonsterBehaviorID=90160012,AIs='黑龙第三阶段锁敌@黑龙第三阶段顺劈@黑龙第三阶段吐息@黑龙第三阶段恐惧@转火2@黑龙第三阶段新顺劈',SkillIDs='90160012010@90160012020@90160012030@90160012040@94213010',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[4]={MonsterBehaviorID=90160110,AIs='黑龙宝宝',SkillIDs='',BaseFindEnemyAIs='自动索敌30距(物防循环)@反击(通用)@反击(怪物)'},
[5]={MonsterBehaviorID=90160020,AIs='黑龙龙人',SkillIDs='',BaseFindEnemyAIs='自动索敌30距(物防循环)@反击(通用)@反击(怪物)'},
[6]={MonsterBehaviorID=91010010,AIs='基尔加丹之手-施放暗影箭雨',SkillIDs='9101001010@9103001030',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[7]={MonsterBehaviorID=91000010,AIs='基尔加丹开场-变身第一阶段',SkillIDs='9100001010@9100001020',BaseFindEnemyAIs=''},
[8]={MonsterBehaviorID=91000011,AIs='基尔加丹第一阶段-变身第二阶段@基尔加丹第一阶段-军团闪电第一阶段@基尔加丹第一阶段-施放暗影宝珠第一阶段@基尔加丹第三阶段-进入狂暴状态@基尔加丹第一阶段-召唤军团幻象',SkillIDs='9100001120@9100001130@9100001140@9100001150@9100001151@9100001152@94213010',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[9]={MonsterBehaviorID=91000012,AIs='基尔加丹第二阶段-变身第三阶段@基尔加丹第二阶段-施放暗影宝珠第二阶段@基尔加丹第二阶段-军团闪电第二阶段@基尔加丹第二阶段-暗影之刺第二阶段@基尔加丹第二阶段-末日决战第二阶段@基尔加丹第二阶段-末日决战第二阶段2@基尔加丹第二阶段-召唤军团幻象@基尔加丹第三阶段-进入狂暴状态',SkillIDs='9100001140@9100001220@9100001230@9100001240@9100001241@9100001242@9100001250@9100001260@9100001262@9100001270@94213010',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[10]={MonsterBehaviorID=91000013,AIs='基尔加丹第三阶段-蓝龙之盾@基尔加丹第三阶段-千魂之暗@基尔加丹第三阶段-删除使用千魂之暗AI@基尔加丹第三阶段-施放暗影宝珠第三阶段@基尔加丹第三阶段-军团闪电第三阶段@基尔加丹第三阶段-暗影之刺第三阶段@基尔加丹第三阶段-末日决战第三阶段@基尔加丹第三阶段-末日决战第三阶段2@基尔加丹第三阶段-末日决战第三阶段3@基尔加丹第三阶段-末日决战第三阶段4@基尔加丹第三阶段-入场说话@基尔加丹第三阶段-进入狂暴状态@基尔加丹第三阶段-召唤军团幻象',SkillIDs='9100001270@9100001320@9100001330@9100001340@9100001341@9100001342@9100001350@9100001360@9100001362@9100001364@9100001366@9100001370@9100001380@9100001390@94213010',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[11]={MonsterBehaviorID=91020010,AIs='暗影宝珠-施放暗影箭雨@暗影宝珠移动1-2@暗影宝珠移动2-3@暗影宝珠移动3-4@暗影宝珠移动4-5@暗影宝珠移动5-6@暗影宝珠移动6-7@暗影宝珠移动7-8@暗影宝珠移动8-9',SkillIDs='9102001010',BaseFindEnemyAIs=''},
[12]={MonsterBehaviorID=91030010,AIs='军团幻象战士-施放顺劈斩',SkillIDs='9103001010@9103001030',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[13]={MonsterBehaviorID=91030020,AIs='军团幻象法师-施放火球术',SkillIDs='9103002010@9103001030',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[14]={MonsterBehaviorID=91030030,AIs='军团幻象治疗-施放回复术',SkillIDs='9103003010@9103001030',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'},
[15]={MonsterBehaviorID=91030040,AIs='军团幻象物理-施放致死打击',SkillIDs='9103004010@9103001030',BaseFindEnemyAIs='自动索敌(敌人)@结束索敌(敌人)@反击(通用)@反击(怪物)'}
}
return list