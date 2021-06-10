local list = {
[1]={Time=1,GoldPrice=10,Discount1=5,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=10,Discount2=5,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=10,EquipmentExpDoubleCrit=200000,EquipmentExpFourCrit=100000,SkillExpPrice=10,SkillExpDoubleCrit=450000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[2]={Time=2,GoldPrice=10,Discount1=5,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=10,Discount2=5,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=10,EquipmentExpDoubleCrit=200000,EquipmentExpFourCrit=100000,SkillExpPrice=10,SkillExpDoubleCrit=450000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[3]={Time=3,GoldPrice=10,Discount1=5,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=10,Discount2=5,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=10,EquipmentExpDoubleCrit=200000,EquipmentExpFourCrit=100000,SkillExpPrice=10,SkillExpDoubleCrit=450000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[4]={Time=4,GoldPrice=10,Discount1=5,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=10,Discount2=5,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=10,EquipmentExpDoubleCrit=200000,EquipmentExpFourCrit=100000,SkillExpPrice=10,SkillExpDoubleCrit=450000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[5]={Time=5,GoldPrice=20,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=20,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=20,EquipmentExpDoubleCrit=200000,EquipmentExpFourCrit=100000,SkillExpPrice=20,SkillExpDoubleCrit=450000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[6]={Time=6,GoldPrice=20,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=20,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=20,EquipmentExpDoubleCrit=200000,EquipmentExpFourCrit=100000,SkillExpPrice=20,SkillExpDoubleCrit=450000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[7]={Time=7,GoldPrice=20,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=20,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=20,EquipmentExpDoubleCrit=205000,EquipmentExpFourCrit=105000,SkillExpPrice=20,SkillExpDoubleCrit=455000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[8]={Time=8,GoldPrice=20,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=20,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=20,EquipmentExpDoubleCrit=205000,EquipmentExpFourCrit=105000,SkillExpPrice=20,SkillExpDoubleCrit=455000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[9]={Time=9,GoldPrice=20,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=20,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=20,EquipmentExpDoubleCrit=205000,EquipmentExpFourCrit=105000,SkillExpPrice=20,SkillExpDoubleCrit=455000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[10]={Time=10,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=205000,EquipmentExpFourCrit=105000,SkillExpPrice=50,SkillExpDoubleCrit=455000,SkillExpFourCrit=180000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[11]={Time=11,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=210000,EquipmentExpFourCrit=109000,SkillExpPrice=50,SkillExpDoubleCrit=460000,SkillExpFourCrit=182000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[12]={Time=12,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=210000,EquipmentExpFourCrit=109000,SkillExpPrice=50,SkillExpDoubleCrit=460000,SkillExpFourCrit=182000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[13]={Time=13,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=210000,EquipmentExpFourCrit=109000,SkillExpPrice=50,SkillExpDoubleCrit=460000,SkillExpFourCrit=182000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[14]={Time=14,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=210000,EquipmentExpFourCrit=109000,SkillExpPrice=50,SkillExpDoubleCrit=460000,SkillExpFourCrit=182000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[15]={Time=15,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=215000,EquipmentExpFourCrit=113000,SkillExpPrice=50,SkillExpDoubleCrit=465000,SkillExpFourCrit=184000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[16]={Time=16,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=215000,EquipmentExpFourCrit=113000,SkillExpPrice=50,SkillExpDoubleCrit=465000,SkillExpFourCrit=184000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[17]={Time=17,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=215000,EquipmentExpFourCrit=113000,SkillExpPrice=50,SkillExpDoubleCrit=465000,SkillExpFourCrit=184000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[18]={Time=18,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=215000,EquipmentExpFourCrit=113000,SkillExpPrice=50,SkillExpDoubleCrit=465000,SkillExpFourCrit=184000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[19]={Time=19,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=220000,EquipmentExpFourCrit=117000,SkillExpPrice=50,SkillExpDoubleCrit=470000,SkillExpFourCrit=186000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[20]={Time=20,GoldPrice=50,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=50,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=50,EquipmentExpDoubleCrit=220000,EquipmentExpFourCrit=117000,SkillExpPrice=50,SkillExpDoubleCrit=470000,SkillExpFourCrit=186000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[21]={Time=21,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=220000,EquipmentExpFourCrit=117000,SkillExpPrice=100,SkillExpDoubleCrit=470000,SkillExpFourCrit=186000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[22]={Time=22,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=220000,EquipmentExpFourCrit=117000,SkillExpPrice=100,SkillExpDoubleCrit=470000,SkillExpFourCrit=186000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[23]={Time=23,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=225000,EquipmentExpFourCrit=121000,SkillExpPrice=100,SkillExpDoubleCrit=475000,SkillExpFourCrit=188000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[24]={Time=24,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=225000,EquipmentExpFourCrit=121000,SkillExpPrice=100,SkillExpDoubleCrit=475000,SkillExpFourCrit=188000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[25]={Time=25,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=225000,EquipmentExpFourCrit=121000,SkillExpPrice=100,SkillExpDoubleCrit=475000,SkillExpFourCrit=188000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[26]={Time=26,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=225000,EquipmentExpFourCrit=121000,SkillExpPrice=100,SkillExpDoubleCrit=475000,SkillExpFourCrit=188000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[27]={Time=27,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=230000,EquipmentExpFourCrit=125000,SkillExpPrice=100,SkillExpDoubleCrit=480000,SkillExpFourCrit=190000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[28]={Time=28,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=230000,EquipmentExpFourCrit=125000,SkillExpPrice=100,SkillExpDoubleCrit=480000,SkillExpFourCrit=190000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[29]={Time=29,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=230000,EquipmentExpFourCrit=125000,SkillExpPrice=100,SkillExpDoubleCrit=480000,SkillExpFourCrit=190000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[30]={Time=30,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=230000,EquipmentExpFourCrit=125000,SkillExpPrice=100,SkillExpDoubleCrit=480000,SkillExpFourCrit=190000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[31]={Time=31,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=235000,EquipmentExpFourCrit=129000,SkillExpPrice=100,SkillExpDoubleCrit=485000,SkillExpFourCrit=192000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[32]={Time=32,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=235000,EquipmentExpFourCrit=129000,SkillExpPrice=100,SkillExpDoubleCrit=485000,SkillExpFourCrit=192000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[33]={Time=33,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=235000,EquipmentExpFourCrit=129000,SkillExpPrice=100,SkillExpDoubleCrit=485000,SkillExpFourCrit=192000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[34]={Time=34,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=235000,EquipmentExpFourCrit=129000,SkillExpPrice=100,SkillExpDoubleCrit=485000,SkillExpFourCrit=192000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[35]={Time=35,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=240000,EquipmentExpFourCrit=133000,SkillExpPrice=100,SkillExpDoubleCrit=490000,SkillExpFourCrit=194000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[36]={Time=36,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=240000,EquipmentExpFourCrit=133000,SkillExpPrice=100,SkillExpDoubleCrit=490000,SkillExpFourCrit=194000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[37]={Time=37,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=240000,EquipmentExpFourCrit=133000,SkillExpPrice=100,SkillExpDoubleCrit=490000,SkillExpFourCrit=194000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[38]={Time=38,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=240000,EquipmentExpFourCrit=133000,SkillExpPrice=100,SkillExpDoubleCrit=490000,SkillExpFourCrit=194000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[39]={Time=39,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=245000,EquipmentExpFourCrit=137000,SkillExpPrice=100,SkillExpDoubleCrit=495000,SkillExpFourCrit=196000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[40]={Time=40,GoldPrice=100,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=100,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=100,EquipmentExpDoubleCrit=245000,EquipmentExpFourCrit=137000,SkillExpPrice=100,SkillExpDoubleCrit=495000,SkillExpFourCrit=196000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[41]={Time=41,GoldPrice=150,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=150,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=150,EquipmentExpDoubleCrit=245000,EquipmentExpFourCrit=137000,SkillExpPrice=150,SkillExpDoubleCrit=495000,SkillExpFourCrit=196000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[42]={Time=42,GoldPrice=150,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=150,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=150,EquipmentExpDoubleCrit=245000,EquipmentExpFourCrit=137000,SkillExpPrice=150,SkillExpDoubleCrit=495000,SkillExpFourCrit=196000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[43]={Time=43,GoldPrice=150,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=150,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=150,EquipmentExpDoubleCrit=250000,EquipmentExpFourCrit=141000,SkillExpPrice=150,SkillExpDoubleCrit=500000,SkillExpFourCrit=198000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[44]={Time=44,GoldPrice=150,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=150,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=150,EquipmentExpDoubleCrit=250000,EquipmentExpFourCrit=141000,SkillExpPrice=150,SkillExpDoubleCrit=500000,SkillExpFourCrit=198000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[45]={Time=45,GoldPrice=200,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=200,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=200,EquipmentExpDoubleCrit=250000,EquipmentExpFourCrit=141000,SkillExpPrice=200,SkillExpDoubleCrit=500000,SkillExpFourCrit=198000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[46]={Time=46,GoldPrice=200,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=200,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=200,EquipmentExpDoubleCrit=250000,EquipmentExpFourCrit=141000,SkillExpPrice=200,SkillExpDoubleCrit=500000,SkillExpFourCrit=198000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[47]={Time=47,GoldPrice=200,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=200,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=200,EquipmentExpDoubleCrit=255000,EquipmentExpFourCrit=145000,SkillExpPrice=200,SkillExpDoubleCrit=505000,SkillExpFourCrit=200000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[48]={Time=48,GoldPrice=200,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=200,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=200,EquipmentExpDoubleCrit=255000,EquipmentExpFourCrit=145000,SkillExpPrice=200,SkillExpDoubleCrit=505000,SkillExpFourCrit=200000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[49]={Time=49,GoldPrice=200,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=200,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=200,EquipmentExpDoubleCrit=255000,EquipmentExpFourCrit=145000,SkillExpPrice=200,SkillExpDoubleCrit=505000,SkillExpFourCrit=200000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0},
[50]={Time=50,GoldPrice=200,Discount1=0,GoldDoubleCrit=0,GoldFourCrit=0,HeroExpPrice=200,Discount2=0,HeroExpDoubleCrit=0,HeroExpFourCrit=0,EquipmentExpPrice=200,EquipmentExpDoubleCrit=255000,EquipmentExpFourCrit=145000,SkillExpPrice=200,SkillExpDoubleCrit=505000,SkillExpFourCrit=200000,TalentExpPrice=20,Discount3=0,TalentExpDoubleCrit=0,TalentExpFourCrit=0}
}
return list
