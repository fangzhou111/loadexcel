package configdata

// 称号.xls
type Conf_Title struct { 
	TitleID int32		`key`	/*主键ID*/
	TitleName string			/*称号名*/
	Desc string			/*称号描述*/
	Icon string			/*称号图标*/
	Priority int32			/*称号优先级*/
} 
var MConf_Title = map[string] * Conf_Title{}
func load() {
	loadconfigdata(&MConf_Title)
}
func HotUpdateConfigData(sheetname string) bool {
	switch sheetname {
	case "Title":
		m :=map[string]*Conf_Title{}
		loadconfigdata(&m)
		MConf_Title = m
		return true
	default:
	}
	return false
}
