-module(data_cfg).
-include("logger.hrl").
-include("data.hrl").

%% API
-compile(export_all).

get_config_record_fields(cfg_PlayerUpgradeExp)->
  record_info(fields,cfg_PlayerUpgradeExp);

get_config_record_fields(cfg_MainKey)->
  record_info(fields,cfg_MainKey);
get_config_record_fields(Record)->
  ?ERROR_OUT("can not get record_info(fields,~p)",[Record]),
  undefined.