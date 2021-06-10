%% ------------------人物升级表.xls----------------
-record(cfg_PlayerUpgradeExp, {
  virtual_key	%% 虚拟key
  , level	%% 人物等级
  , exp	%% 升到下一级所需经验
  , maxStrength	%% 当前等级体力上限
  , maxSpirit	%% 精力上限
  , upgradeOfferStrength	%% 升级获得体力
  , upgradeOfferSpirit	%% 升级获得精力
  , maxHeroLevel	%% 英雄等级上限
  , upgradeInterior	%% 等级对应内政点数
}).
-record(cfg_MainKey, {
  virtual_key	  %% 虚拟key
  , sheetname   %% 表名
  , keyname     %% key字段名,多个用逗号(,)分开
}).
