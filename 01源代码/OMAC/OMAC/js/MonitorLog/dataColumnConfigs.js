var DataColumns = function () {
    var rst = {
        // 浮标 - 水质
        "TABBUOYECOLOGY0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "CURRENTTEM", title: "海浪水温" }, { field: "WATERTEM", title: "独立水温" },
            { field: "CTDTEM", title: "CTD水温" }, { field: "SALINITY", title: "盐度" }, { field: "CONDUCTIVITY", title: "电导率" },
            { field: "OXYGEN", title: "溶解氧(DO)" }, { field: "PH", title: "PH值" }, { field: "TURBIDITY", title: "浊度" },
            { field: "YLS", title: "叶绿素" }, { field: "YLSTEM", title: "叶绿素温度" }, { field: "UNDERWATERCO2", title: "水下二氧化碳" },
            { field: "OXYGENCHEMICAL", title: "化学需氧量COD" }, { field: "MNO4", title: "高锰酸盐指数" }, { field: "OXYGENBIOLOGY", title: "生化需氧量" },
            { field: "NH3N", title: "氨氮(铵盐)" }, { field: "NO3", title: "硝酸盐-氮" }, { field: "NO2", title: "亚硝酸盐-氮" },
            { field: "PO4", title: "活性磷酸盐" }, { field: "SIO3", title: "硅酸盐" }, { field: "PAHS", title: "多环芳烃" },
            { field: "P", title: "总磷" }, { field: "N", title: "总氮" }, { field: "C", title: "总有机碳" }, { field: "S", title: "硫" },
            { field: "ALKALINITY", title: "总碱度" }, { field: "SUSPENSION", title: "悬浮物" }, { field: "CYANIDE", title: "氰化物" },
            { field: "HG", title: "汞" }, { field: "CD", title: "镉" }, { field: "CD6", title: "六价铬" },
            { field: "PB", title: "铅" }, { field: "AS", title: "砷" }, { field: "YLSA", title: "叶绿素-a" },
            { field: "PHYCOCY", title: "藻蓝素" }, { field: "PHYCOER", title: "藻红素" }, { field: "COLIFORM", title: "粪大肠菌群" },
            { field: "POTENTIAL", title: "氧化还原电位" }, { field: "TOTALY", title: "总γ" }, { field: "K40", title: "40K" },
            { field: "CS134", title: "134Cs" }, { field: "CS137", title: "137Cs" }, { field: "CO60", title: "60Co" },
            { field: "CU", title: "铜" }, { field: "ZN", title: "锌" }, { field: "PHENOL", title: "挥发酚" },
            { field: "BOD5", title: "BOD5" }, { field: "ORGANIC", title: "挥发性有机物" }, { field: "DETERGENTS", title: "阴离子洗涤剂" },
            { field: "OIL", title: "油类" }, { field: "VIRUS", title: "细菌总数" }, { field: "PETRO", title: "石油烃" },
            { field: "DDT", title: "DDT" }, { field: "PCBS", title: "PCBs" }, { field: "BENZOL", title: "多氯联苯" },
            { field: "CHLO", title: "氯霉素" }, { field: "ANTIBIOTIC", title: "抗生素" }, { field: "POISONA", title: "腹泻性贝毒" },
            { field: "POISONB", title: "麻痹性贝毒" }
        ],
        // 岸基 - 水质
        "TABECOLOGY0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "WATERTEM", title: "水温" }, { field: "SALINITY", title: "盐度" }, { field: "CONDUCTIVITY", title: "电导率" },
            { field: "OXYGEN", title: "溶解氧" }, { field: "PH", title: "PH值" }, { field: "TURBIDITY", title: "浊度" },
            { field: "UNDERWATERCO2", title: "水下二氧化碳" }, { field: "OXYGENCHEMICAL", title: "化学需氧量" }, { field: "MNO4", title: "高锰酸盐指数" },
            { field: "OXYGENBIOLOGY", title: "生化需氧量" }, { field: "NH3N", title: "氨氮(铵盐)" }, { field: "NO3", title: "硝酸盐-氮" },
            { field: "NO2", title: "亚硝酸盐-氮" }, { field: "PO4", title: "活性磷酸盐" }, { field: "SIO3", title: "硅酸盐" },
            { field: "P", title: "总磷" }, { field: "N", title: "总氮" }, { field: "C", title: "总有机碳" },
            { field: "S", title: "硫" }, { field: "SUSPENSION", title: "悬浮物" }, { field: "CYANIDE", title: "氰化物" },
            { field: "HG", title: "汞" }, { field: "CR", title: "总铬" }, { field: "CR6", title: "六价铬" },
            { field: "PB", title: "铅" }, { field: "AS", title: "砷" }, { field: "YLSA", title: "叶绿素-a" },
            { field: "PHYCOCY", title: "藻蓝素" }, { field: "PHYCOER", title: "藻红素" }, { field: "COLIFORM", title: "粪大肠菌群" },
            { field: "POTENTIAL", title: "氧化还原电位" }, { field: "TOTALY", title: "总γ" }, { field: "K40", title: "40K" },
            { field: "CS134", title: "134Cs" }, { field: "CS137", title: "137Cs" }, { field: "CO60", title: "60Co" },
            { field: "CU", title: "铜" }, { field: "ZN", title: "锌" }, { field: "PHENOL", title: "挥发酚" },
            { field: "BOD5", title: "BOD5" }, { field: "ORGANIC", title: "挥发性有机物" }, { field: "DETERGENTS", title: "阴离子洗涤剂" },
            { field: "OIL", title: "油类" }, { field: "VIRUS", title: "细菌总数" }, { field: "PETRO", title: "石油烃" },
            { field: "DDT", title: "DDT" }, { field: "PCBS", title: "PCBS" }, { field: "BENZOL", title: "多氯联苯" },
            { field: "CHLO", title: "氯霉素" }, { field: "ANTIBIOTIC", title: "抗生素" }, { field: "POISONA", title: "腹泻性贝毒" },
            { field: "POISONB", title: "麻痹性贝毒" }, { field: "DEPTH", title: "水深" }, { field: "WATERLEVEL", title: "水位" },
            { field: "CURRENTSPD", title: "流速" }, { field: "CURRENTDIR", title: "流向" }, { field: "CURRENTVOL", title: "流量" },
            { field: "CD", title: "镉" }, { field: "F", title: "氟" }, { field: "NI", title: "总镍" }
        ],
        // 浮标 - 状态
        "TABBUOYSTATUS0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "LON", title: "经度" }, { field: "LAT", title: "纬度" }, { field: "AZIMUTH", title: "方位" },
            { field: "VOLTAGE", title: "电压" }, { field: "ANCHOR", title: "锚灯" }, { field: "WATERALARM", title: "水警" },
            { field: "DOORALARM", title: "门警" }, { field: "GPSALARM", title: "GPS报警" }, { field: "FREEMEMO", title: "内存" },
            { field: "SENSERSTATUS", title: "传感器状态" }
        ],
        // 岸基 - 状态
        "TABSTATUS0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "TEMPERATURE", title: "湿度状态" }, { field: "POWERSTATUS", title: "供电状态" }, { field: "FREEMEMO", title: "存储空间" },
            { field: "WATERALARM", title: "水警" }, { field: "DOORALARM", title: "门警" }, { field: "SMOGALARM", title: "烟雾状态" },
            { field: "SENSERSTATUS", title: "传感器状态" }, { field: "STATIONSTATUS", title: "状态量" }
        ],
        // 浮标 - 波浪
        "TABBUOYHYDROLOGY0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "MAXWAVEHIGH", title: "最大波高" }, { field: "MAXWAVEPIOD", title: "最大波周期" }, { field: "TENTHWAVEHIGH", title: "1/10波高" },
            { field: "TENTHWAVEPIOD", title: "1/10波周期" }, { field: "AVEWAVEHIGH", title: "平均波高" }, { field: "AVEWAVEPIOD", title: "平均波周期" },
            { field: "WALIDWAVEHIGH", title: "有效波高" }, { field: "WALIDWAVEPIOD", title: "有效波周期" }, { field: "WAVEDIR", title: "波向" },
            { field: "WAVENUM", title: "波数" }
        ],
        // 岸基 - 波浪
        "TABHYDROLOGY0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "MAXWAVEHIGH", title: "最大波高" }, { field: "MAXWAVEPIOD", title: "最大波周期" }, { field: "AVEWAVEHIGH", title: "平均波高" },
            { field: "AVEWAVEPIOD", title: "平均波周期" }, { field: "VALIDWAVEHIGH", title: "有效波高" }, { field: "VALIDWAVEPIOD", title: "有效波周期" },
            { field: "WAVEDIR", title: "波向" }
        ],
        // 浮标 - 海流
        "TABBUOYHYDROLOGY1": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "CURRENTSPD1", title: "流速1" }, { field: "CURRENTDIR1", title: "流向1" },
            { field: "CURRENTSPD2", title: "流速2" }, { field: "CURRENTDIR2", title: "流向2" },
            { field: "CURRENTSPD3", title: "流速3" }, { field: "CURRENTDIR3", title: "流向3" },
            { field: "CURRENTSPD4", title: "流速4" }, { field: "CURRENTDIR4", title: "流向4" },
            { field: "CURRENTSPD5", title: "流速5" }, { field: "CURRENTDIR5", title: "流向5" },
            { field: "CURRENTSPD6", title: "流速6" }, { field: "CURRENTDIR6", title: "流向6" },
            { field: "CURRENTSPD7", title: "流速7" }, { field: "CURRENTDIR7", title: "流向7" },
            { field: "CURRENTSPD8", title: "流速8" }, { field: "CURRENTDIR8", title: "流向8" },
            { field: "CURRENTSPD9", title: "流速9" }, { field: "CURRENTDIR9", title: "流向9" },
            { field: "CURRENTSPD10", title: "流速10" }, { field: "CURRENTDIR10", title: "流向10" },
            { field: "CURRENTSPD11", title: "流速11" }, { field: "CURRENTDIR11", title: "流向11" },
            { field: "CURRENTSPD12", title: "流速12" }, { field: "CURRENTDIR12", title: "流向12" },
            { field: "CURRENTSPD13", title: "流速13" }, { field: "CURRENTDIR13", title: "流向13" },
            { field: "CURRENTSPD14", title: "流速14" }, { field: "CURRENTDIR14", title: "流向14" },
            { field: "CURRENTSPD15", title: "流速15" }, { field: "CURRENTDIR15", title: "流向15" },
            { field: "CURRENTSPD16", title: "流速16" }, { field: "CURRENTDIR16", title: "流向16" },
            { field: "CURRENTSPD17", title: "流速17" }, { field: "CURRENTDIR17", title: "流向17" },
            { field: "CURRENTSPD18", title: "流速18" }, { field: "CURRENTDIR18", title: "流向18" },
            { field: "CURRENTSPD19", title: "流速19" }, { field: "CURRENTDIR19", title: "流向19" },
            { field: "CURRENTSPD20", title: "流速20" }, { field: "CURRENTDIR20", title: "流向20" },
            { field: "CURRENTSPD21", title: "流速21" }, { field: "CURRENTDIR21", title: "流向21" },
            { field: "CURRENTSPD22", title: "流速22" }, { field: "CURRENTDIR22", title: "流向22" },
            { field: "CURRENTSPD23", title: "流速23" }, { field: "CURRENTDIR23", title: "流向23" },
            { field: "CURRENTSPD24", title: "流速24" }, { field: "CURRENTDIR24", title: "流向24" },
            { field: "CURRENTSPD25", title: "流速25" }, { field: "CURRENTDIR25", title: "流向25" },
            { field: "CURRENTSPD26", title: "流速26" }, { field: "CURRENTDIR26", title: "流向26" },
            { field: "CURRENTSPD27", title: "流速27" }, { field: "CURRENTDIR27", title: "流向27" },
            { field: "CURRENTSPD28", title: "流速28" }, { field: "CURRENTDIR28", title: "流向28" },
            { field: "CURRENTSPD29", title: "流速29" }, { field: "CURRENTDIR29", title: "流向29" },
            { field: "CURRENTSPD30", title: "流速30" }, { field: "CURRENTDIR30", title: "流向30" },
            { field: "CURRENTSPD31", title: "流速31" }, { field: "CURRENTDIR31", title: "流向31" },
            { field: "CURRENTSPD32", title: "流速32" }, { field: "CURRENTDIR32", title: "流向32" },
            { field: "CURRENTSPD33", title: "流速33" }, { field: "CURRENTDIR33", title: "流向33" },
            { field: "CURRENTSPD34", title: "流速34" }, { field: "CURRENTDIR34", title: "流向34" },
            { field: "CURRENTSPD35", title: "流速35" }, { field: "CURRENTDIR35", title: "流向35" },
            { field: "CURRENTSPD36", title: "流速36" }, { field: "CURRENTDIR36", title: "流向36" },
            { field: "CURRENTSPD37", title: "流速37" }, { field: "CURRENTDIR37", title: "流向37" },
            { field: "CURRENTSPD38", title: "流速38" }, { field: "CURRENTDIR38", title: "流向38" },
            { field: "CURRENTSPD39", title: "流速39" }, { field: "CURRENTDIR39", title: "流向39" },
            { field: "CURRENTSPD40", title: "流速40" }, { field: "CURRENTDIR40", title: "流向40" }
        ],
        // 岸基 - 海流
        "TABHYDROLOGY1": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "DEPTH", title: "水深" }, { field: "WATERLEVEL", title: "水位" },
            { field: "CURRENTSPD1", title: "流速1" }, { field: "CURRENTDIR1", title: "流向1" },
            { field: "CURRENTSPD2", title: "流速2" }, { field: "CURRENTDIR2", title: "流向2" },
            { field: "CURRENTSPD3", title: "流速3" }, { field: "CURRENTDIR3", title: "流向3" },
            { field: "CURRENTSPD4", title: "流速4" }, { field: "CURRENTDIR4", title: "流向4" },
            { field: "CURRENTSPD5", title: "流速5" }, { field: "CURRENTDIR5", title: "流向5" },
            { field: "CURRENTSPD6", title: "流速6" }, { field: "CURRENTDIR6", title: "流向6" },
            { field: "CURRENTSPD7", title: "流速7" }, { field: "CURRENTDIR7", title: "流向7" },
            { field: "CURRENTSPD8", title: "流速8" }, { field: "CURRENTDIR8", title: "流向8" },
            { field: "CURRENTSPD9", title: "流速9" }, { field: "CURRENTDIR9", title: "流向9" },
            { field: "CURRENTSPD10", title: "流速10" }, { field: "CURRENTDIR10", title: "流向10" },
            { field: "CURRENTSPD11", title: "流速11" }, { field: "CURRENTDIR11", title: "流向11" },
            { field: "CURRENTSPD12", title: "流速12" }, { field: "CURRENTDIR12", title: "流向12" },
            { field: "CURRENTSPD13", title: "流速13" }, { field: "CURRENTDIR13", title: "流向13" },
            { field: "CURRENTSPD14", title: "流速14" }, { field: "CURRENTDIR14", title: "流向14" },
            { field: "CURRENTSPD15", title: "流速15" }, { field: "CURRENTDIR15", title: "流向15" },
            { field: "CURRENTSPD16", title: "流速16" }, { field: "CURRENTDIR16", title: "流向16" },
            { field: "CURRENTSPD17", title: "流速17" }, { field: "CURRENTDIR17", title: "流向17" },
            { field: "CURRENTSPD18", title: "流速18" }, { field: "CURRENTDIR18", title: "流向18" },
            { field: "CURRENTSPD19", title: "流速19" }, { field: "CURRENTDIR19", title: "流向19" },
            { field: "CURRENTSPD20", title: "流速20" }, { field: "CURRENTDIR20", title: "流向20" },
            { field: "CURRENTSPD21", title: "流速21" }, { field: "CURRENTDIR21", title: "流向21" },
            { field: "CURRENTSPD22", title: "流速22" }, { field: "CURRENTDIR22", title: "流向22" },
            { field: "CURRENTSPD23", title: "流速23" }, { field: "CURRENTDIR23", title: "流向23" },
            { field: "CURRENTSPD24", title: "流速24" }, { field: "CURRENTDIR24", title: "流向24" },
            { field: "CURRENTSPD25", title: "流速25" }, { field: "CURRENTDIR25", title: "流向25" },
            { field: "CURRENTSPD26", title: "流速26" }, { field: "CURRENTDIR26", title: "流向26" },
            { field: "CURRENTSPD27", title: "流速27" }, { field: "CURRENTDIR27", title: "流向27" },
            { field: "CURRENTSPD28", title: "流速28" }, { field: "CURRENTDIR28", title: "流向28" },
            { field: "CURRENTSPD29", title: "流速29" }, { field: "CURRENTDIR29", title: "流向29" },
            { field: "CURRENTSPD30", title: "流速30" }, { field: "CURRENTDIR30", title: "流向30" },
            { field: "CURRENTSPD31", title: "流速31" }, { field: "CURRENTDIR31", title: "流向31" },
            { field: "CURRENTSPD32", title: "流速32" }, { field: "CURRENTDIR32", title: "流向32" },
            { field: "CURRENTSPD33", title: "流速33" }, { field: "CURRENTDIR33", title: "流向33" },
            { field: "CURRENTSPD34", title: "流速34" }, { field: "CURRENTDIR34", title: "流向34" },
            { field: "CURRENTSPD35", title: "流速35" }, { field: "CURRENTDIR35", title: "流向35" },
            { field: "CURRENTSPD36", title: "流速36" }, { field: "CURRENTDIR36", title: "流向36" },
            { field: "CURRENTSPD37", title: "流速37" }, { field: "CURRENTDIR37", title: "流向37" },
            { field: "CURRENTSPD38", title: "流速38" }, { field: "CURRENTDIR38", title: "流向38" },
            { field: "CURRENTSPD39", title: "流速39" }, { field: "CURRENTDIR39", title: "流向39" },
            { field: "CURRENTSPD40", title: "流速40" }, { field: "CURRENTDIR40", title: "流向40" }
        ],
        // 浮标 - 气象
        "TABBUOYQIXG0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "NJD", title: "能见度" }, { field: "RAINFALLACTUAL", title: "实际雨量" }, { field: "RAINFALLPREV", title: "测前雨量" }, { field: "RAINFALL", title: "雨量" },
            { field: "TOTALRADIATION", title: "总辐射" }, { field: "INFRAREDRADIATION", title: "红外辐射" }, { field: "SUNLIGHTTIME", title: "日照时间" }, { field: "AIRCO2", title: "二氧化碳" }
        ],
        // 岸基 - 气象
        "TABQIXG0": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "NJD", title: "能见度" }, { field: "RAINFALL", title: "雨量" }, { field: "TOTALRADIATION", title: "总辐射" },
            { field: "INFRAREDRADIATION", title: "红外辐射" }, { field: "SUNLIGHTTIME", title: "日照时间" }, { field: "AIRCO2", title: "空气二氧化碳" }
        ],
        // 浮标 - 风
        "TABBUOYQIXG1": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "WINDSPD1", title: "风速1" }, { field: "WINDDIR1", title: "风向1" },
            { field: "WINDSPD2", title: "风速2" }, { field: "WINDDIR2", title: "风向2" },
            { field: "WINDSPD3", title: "风速3" }, { field: "WINDDIR3", title: "风向3" },
            { field: "WINDSPD4", title: "风速4" }, { field: "WINDDIR4", title: "风向4" },
            { field: "WINDSPD5", title: "风速5" }, { field: "WINDDIR5", title: "风向5" },
            { field: "WINDSPD6", title: "风速6" }, { field: "WINDDIR6", title: "风向6" },
            { field: "WINDSPD7", title: "风速7" }, { field: "WINDDIR7", title: "风向7" },
            { field: "WINDSPD8", title: "风速8" }, { field: "WINDDIR8", title: "风向8" },
            { field: "WINDSPD9", title: "风速9" }, { field: "WINDDIR9", title: "风向9" },
            { field: "WINDSPD10", title: "风速10" }, { field: "WINDDIR10", title: "风向10" },
            { field: "MAXWINDSPD", title: "最大风速" }, { field: "MAXWINDDIR", title: "最大风速风向" },
            { field: "MAXWINDTIME", title: "最大风速时间" }, { field: "HUGEWINDSPD", title: "极大风速" },
            { field: "HUGEWINDDIR", title: "极大风速风向" }, { field: "HUGEWINDTIME", title: "极大风速时间" },
            { field: "TENMINAVESPD", title: "10分钟平均风速" }, { field: "TENMINAVEDIR", title: "10分钟平均风向" },
            { field: "INSTANTSPD", title: "瞬时风速" }, { field: "INSTANTDIR", title: "瞬时风向" },
            { field: "TOWMINAVESPD", title: "2分钟平均风速" }, { field: "TOWMINAVEDIR", title: "2分钟平均风向" },
            { field: "AVEWINDSPD1", title: "平均风速1" }, { field: "AVEWINDDIR1", title: "平均风向1" },
            { field: "AVEWINDSPD2", title: "平均风速2" }, { field: "AVEWINDDIR1", title: "平均风向2" },
            { field: "AVEWINDSPD3", title: "平均风速3" }, { field: "AVEWINDDIR1", title: "平均风向3" },
            { field: "AVEWINDSPD4", title: "平均风速4" }, { field: "AVEWINDDIR1", title: "平均风向4" },
            { field: "AVEWINDSPD5", title: "平均风速5" }, { field: "AVEWINDDIR1", title: "平均风向5" },
            { field: "AVEWINDSPD6", title: "平均风速6" }, { field: "AVEWINDDIR1", title: "平均风向6" },
            { field: "AVEWINDSPD7", title: "平均风速7" }, { field: "AVEWINDDIR1", title: "平均风向7" },
            { field: "AVEWINDSPD8", title: "平均风速8" }, { field: "AVEWINDDIR1", title: "平均风向8" },
            { field: "AVEWINDSPD9", title: "平均风速9" }, { field: "AVEWINDDIR1", title: "平均风向9" },
            { field: "AVEWINDSPD10", title: "平均风速10" }, { field: "AVEWINDDIR10", title: "平均风向10" }
        ],
        // 岸基 - 风
        "TABQIXG1": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "WINDSPD1", title: "风速1" }, { field: "WINDDIR1", title: "风向1" },
            { field: "WINDSPD2", title: "风速2" }, { field: "WINDDIR2", title: "风向2" },
            { field: "WINDSPD3", title: "风速3" }, { field: "WINDDIR3", title: "风向3" },
            { field: "WINDSPD4", title: "风速4" }, { field: "WINDDIR4", title: "风向4" },
            { field: "WINDSPD5", title: "风速5" }, { field: "WINDDIR5", title: "风向5" },
            { field: "WINDSPD6", title: "风速6" }, { field: "WINDDIR6", title: "风向6" },
            { field: "WINDSPD7", title: "风速7" }, { field: "WINDDIR7", title: "风向7" },
            { field: "WINDSPD8", title: "风速8" }, { field: "WINDDIR8", title: "风向8" },
            { field: "WINDSPD9", title: "风速9" }, { field: "WINDDIR9", title: "风向9" },
            { field: "WINDSPD10", title: "风速10" }, { field: "WINDDIR10", title: "风向10" },
            { field: "AVESPD", title: "平均风速" }, { field: "AVEDIR", title: "平均风向" }
        ],
        // 浮标 - 气压
        "TABBUOYQIXG2": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "PRESSURE1", title: "气压1" }, { field: "PRESSURE2", title: "气压2" }, { field: "PRESSURE3", title: "气压3" },
            { field: "PRESSURE4", title: "气压4" }, { field: "PRESSURE5", title: "气压5" }, { field: "PRESSURE6", title: "气压6" },
            { field: "PRESSURE7", title: "气压7" }, { field: "PRESSURE8", title: "气压8" }, { field: "PRESSURE9", title: "气压9" },
            { field: "PRESSURE10", title: "气压10" }, { field: "MAXPRESSURE", title: "最高气压" }, { field: "MAXPRESSURETIME", title: "最高气压时间" },
            { field: "MINPRESSURE", title: "最低气压" }, { field: "MINPRESSURETIME", title: "最低气压时间" }
        ],
        // 岸基 - 气压
        "TABQIXG2": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "PRESSURE", title: "气压" }
        ],
        // 浮标 - 气温
        "TABBUOYQIXG3": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "AIRTEM1", title: "气温1" }, { field: "AIRTEM2", title: "气温2" }, { field: "AIRTEM3", title: "气温3" },
            { field: "AIRTEM4", title: "气温4" }, { field: "AIRTEM5", title: "气温5" }, { field: "AIRTEM6", title: "气温6" },
            { field: "AIRTEM7", title: "气温7" }, { field: "AIRTEM8", title: "气温8" }, { field: "AIRTEM9", title: "气温9" },
            { field: "AIRTEM10", title: "气温10" }, { field: "MAXAIRTEM", title: "最高气温" }, { field: "MAXAIRTEMTIME", title: "最高气温时间" },
            { field: "MINAIRTEM", title: "最低气温" }, { field: "MINAIRTEMTIME", title: "最低气温时间" }
        ],
        // 岸基 - 气温
        "TABQIXG3": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "AIRTEM", title: "气温" }
        ],
        // 浮标 - 湿度
        "TABBUOYQIXG4": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "HUMI1", title: "湿度1" }, { field: "HUMI2", title: "湿度2" }, { field: "HUMI3", title: "湿度3" },
            { field: "HUMI4", title: "湿度4" }, { field: "HUMI5", title: "湿度5" }, { field: "HUMI6", title: "湿度6" },
            { field: "HUMI7", title: "湿度7" }, { field: "HUMI8", title: "湿度8" }, { field: "HUMI9", title: "湿度9" },
            { field: "HUMI10", title: "湿度10" }, { field: "MAXHUMI", title: "最高湿度" }, { field: "MAXHUMITIME", title: "最高湿度时间" },
            { field: "MINHUMI", title: "最低湿度" }, { field: "MINHUMITIME", title: "最低湿度时间" }
        ],
        // 岸基 - 湿度
        "TABQIXG4": [
            {
                field: "DATETIME",
                title: "日期时间",
                formatter: function(value) {
                    return "<span style=\"white-space:nowrap;\">" + moment(value).format("YYYY-MM-DD HH:mm:ss") + "</span>";
                }
            },
            { field: "HUMI", title: "湿度" }
        ]
    };

    return rst;
}();
