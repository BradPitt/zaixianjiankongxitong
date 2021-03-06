﻿using System.Collections.Generic;

namespace Entity.MonitorLog
{
    public class ExcelColumns
    {
        public static Dictionary<string, string> SqlStatement = new Dictionary<string, string>
        {
            // 浮标 - 水质
            {
                "TABBUOYECOLOGY0",
                "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"CURRENTTEM\" \"海浪水温\", t.\"WATERTEM\" \"独立水温\", " +
                "t.\"CTDTEM\" \"CTD水温\", t.\"SALINITY\" \"盐度\", t.\"CONDUCTIVITY\" \"电导率\", " +
                "t.\"OXYGEN\" \"溶解氧(DO)\", t.\"PH\" \"PH值\", t.\"TURBIDITY\" \"浊度\", t.\"YLS\" \"叶绿素\", " +
                "t.\"YLSTEM\" \"叶绿素温度\", t.\"UNDERWATERCO2\" \"水下二氧化碳\", t.\"OXYGENCHEMICAL\" \"化学需氧量COD\", " +
                "t.\"MNO4\" \"高锰酸盐指数\", t.\"OXYGENBIOLOGY\" \"生化需氧量\", t.\"NH3N\" \"氨氮(铵盐)\", " +
                "t.\"NO3\" \"硝酸盐-氮\", t.\"NO2\" \"亚硝酸盐-氮\", t.\"PO4\" \"活性磷酸盐\", t.\"SIO3\" \"硅酸盐\", " +
                "t.\"PAHS\" \"多环芳烃\", t.\"P\" \"总磷\", t.\"N\" \"总氮\", t.\"C\" \"总有机碳\", t.\"S\" \"硫\", " +
                "t.\"ALKALINITY\" \"总碱度\", t.\"SUSPENSION\" \"悬浮物\", t.\"CYANIDE\" \"氰化物\", t.\"HG\" \"汞\", " +
                "t.\"CD\" \"镉\", t.\"CR6\" \"六价铬\", t.\"PB\" \"铅\", t.\"AS\" \"砷\", t.\"YLSA\" \"叶绿素-a\", " +
                "t.\"PHYCOCY\" \"藻蓝素\", t.\"PHYCOER\" \"藻红素\", t.\"COLIFORM\" \"粪大肠菌群\", " +
                "t.\"POTENTIAL\" \"氧化还原电位\", t.\"TOTALY\" \"总γ\", t.\"K40\" \"40K\", t.\"CS134\" \"134Cs\", " +
                "t.\"CS137\" \"137Cs\", t.\"CO60\" \"60Co\", t.\"CU\" \"铜\", t.\"ZN\" \"锌\", t.\"PHENOL\" \"挥发酚\", " +
                "t.\"BOD5\" \"BOD5\", t.\"ORGANIC\" \"挥发性有机物\", t.\"DETERGENTS\" \"阴离子洗涤剂\", t.\"OIL\" \"油类\", " +
                "t.\"VIRUS\" \"细菌总数\", t.\"PETRO\" \"石油烃\", t.\"DDT\" \"DDT\", t.\"PCBS\" \"PCBs\", " +
                "t.\"BENZOL\" \"多氯联苯\", t.\"CHLO\" \"氯霉素\", t.\"ANTIBIOTIC\" \"抗生素\", t.\"POISONA\" \"腹泻性贝毒\", " +
                "t.\"POISONB\" \"麻痹性贝毒\" FROM TABBUOYECOLOGY t left join deviceinfo d on t.devicecode = d.devicecode " +
                "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') " +
                "and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') order by t.DATETIME desc"
            },

            {
                // 岸基 - 水质
                "TABECOLOGY0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"WATERTEM\" \"水温\", t.\"SALINITY\" \"盐度\", t.\"CONDUCTIVITY\" \"电导率\", " +
                               "t.\"OXYGEN\" \"溶解氧\", t.\"PH\" \"PH值\", t.\"TURBIDITY\" \"浊度\", t.\"UNDERWATERCO2\" \"水下二氧化碳\", " +
                               "t.\"OXYGENCHEMICAL\" \"化学需氧量\", t.\"MNO4\" \"高锰酸盐指数\", t.\"OXYGENBIOLOGY\" \"生化需氧量\", " +
                               "t.\"NH3N\" \"氨氮(铵盐)\", t.\"NO3\" \"硝酸盐-氮\", t.\"NO2\" \"亚硝酸盐-氮\", t.\"PO4\" \"活性磷酸盐\", " +
                               "t.\"SIO3\" \"硅酸盐\", t.\"P\" \"总磷\", t.\"N\" \"总氮\", t.\"C\" \"总有机碳\", t.\"S\" \"硫\", " +
                               "t.\"SUSPENSION\" \"悬浮物\", t.\"CYANIDE\" \"氰化物\", t.\"HG\" \"汞\", t.\"CR\" \"总铬\", t.\"CR6\" \"六价铬\", " +
                               "t.\"PB\" \"铅\", t.\"AS\" \"砷\", t.\"YLSA\" \"叶绿素-a\", t.\"PHYCOCY\" \"藻蓝素\", t.\"PHYCOER\" \"藻红素\", " +
                               "t.\"COLIFORM\" \"粪大肠菌群\", t.\"POTENTIAL\" \"氧化还原电位\", t.\"TOTALY\" \"总γ\", t.\"K40\" \"40K\", " +
                               "t.\"CS134\" \"134Cs\", t.\"CS137\" \"137Cs\", t.\"CO60\" \"60Co\", t.\"CU\" \"铜\", t.\"ZN\" \"锌\", " +
                               "t.\"PHENOL\" \"挥发酚\", t.\"BOD5\" \"BOD5\", t.\"ORGANIC\" \"挥发性有机物\", t.\"DETERGENTS\" \"阴离子洗涤剂\", " +
                               "t.\"OIL\" \"油类\", t.\"VIRUS\" \"细菌总数\", t.\"PETRO\" \"石油烃\", t.\"DDT\" \"DDT\", t.\"PCBS\" \"PCBS\", " +
                               "t.\"BENZOL\" \"多氯联苯\", t.\"CHLO\" \"氯霉素\", t.\"ANTIBIOTIC\" \"抗生素\", t.\"POISONA\" \"腹泻性贝毒\", " +
                               "t.\"POISONB\" \"麻痹性贝毒\", t.\"DEPTH\" \"水深\", t.\"WATERLEVEL\" \"水位\", t.\"CURRENTSPD\" \"流速\", " +
                               "t.\"CURRENTDIR\" \"流向\", t.\"CURRENTVOL\" \"流量\", t.\"CD\" \"镉\", t.\"F\" \"氟\", t.\"NI\" \"总镍\" " +
                               "FROM TABECOLOGY t left join deviceinfo d on t.devicecode = d.devicecode where t.devicecode=:devicecode and " +
                               "t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                               "order by t.DATETIME desc"
            },
            {
                // 浮标 - 状态
                "TABBUOYSTATUS0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"LON\" \"经度\", t.\"LAT\" \"纬度\", t.\"AZIMUTH\" \"方位\", " +
                                  "t.\"VOLTAGE\" \"电压\", t.\"ANCHOR\" \"锚灯\", t.\"WATERALARM\" \"水警\", t.\"DOORALARM\" \"门警\", " +
                                  "t.\"GPSALARM\" \"GPS报警\", t.\"FREEMEMO\" \"内存\", t.\"SENSERSTATUS\" \"传感器状态\" " +
                                  "FROM TABBUOYSTATUS t left join deviceinfo d on t.devicecode = d.devicecode " +
                                  "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                  "order by t.DATETIME desc"
            },
            {
                // 岸基 - 状态
                "TABSTATUS0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"TEMPERATURE\" \"湿度状态\", t.\"POWERSTATUS\" \"供电状态\", " +
                              "t.\"FREEMEMO\" \"存储空间\", t.\"WATERALARM\" \"水警\", t.\"DOORALARM\" \"门警\", t.\"SMOGALARM\" \"烟雾状态\", " +
                              "t.\"SENSERSTATUS\" \"传感器状态\", t.\"STATIONSTATUS\" \"状态量\" " +
                              "FROM TABSTATUS t left join deviceinfo d on t.devicecode = d.devicecode " +
                              "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                              "order by t.DATETIME desc"
            },
            {
                // 浮标 - 波浪
                "TABBUOYHYDROLOGY0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"MAXWAVEHIGH\" \"最大波高\", t.\"MAXWAVEPIOD\" \"最大波周期\", " +
                                     "t.\"TENTHWAVEHIGH\" \"1/10波高\", t.\"TENTHWAVEPIOD\" \"1/10波周期\", t.\"AVEWAVEHIGH\" \"平均波高\", " +
                                     "t.\"AVEWAVEPIOD\" \"平均波周期\", t.\"WALIDWAVEHIGH\" \"有效波高\", t.\"WALIDWAVEPIOD\" \"有效波周期\", " +
                                     "t.\"WAVEDIR\" \"波向\", t.\"WAVENUM\" \"波数\" " +
                                     "FROM TABBUOYHYDROLOGY t left join deviceinfo d on t.devicecode = d.devicecode " +
                                     "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                     "order by t.DATETIME desc"
            },
            {
                // 岸基 - 波浪
                "TABHYDROLOGY0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"MAXWAVEHIGH\" \"最大波高\", t.\"MAXWAVEPIOD\" \"最大波周期\", " +
                                 "t.\"AVEWAVEHIGH\" \"平均波高\", t.\"AVEWAVEPIOD\" \"平均波周期\", t.\"VALIDWAVEHIGH\" \"有效波高\", " +
                                 "t.\"VALIDWAVEPIOD\" \"有效波周期\", t.\"WAVEDIR\" \"波向\" " +
                                 "FROM TABHYDROLOGY t left join deviceinfo d on t.devicecode = d.devicecode " +
                                 "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                 "order by t.DATETIME desc"
            },
            {
                // 浮标 - 海流
                "TABBUOYHYDROLOGY1", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"CURRENTSPD1\" \"流速1\", t.\"CURRENTDIR1\" \"流向1\", " +
                                     "t.\"CURRENTSPD2\" \"流速2\", t.\"CURRENTDIR2\" \"流向2\", t.\"CURRENTSPD3\" \"流速3\", " +
                                     "t.\"CURRENTDIR3\" \"流向3\", t.\"CURRENTSPD4\" \"流速4\", t.\"CURRENTDIR4\" \"流向4\", " +
                                     "t.\"CURRENTSPD5\" \"流速5\", t.\"CURRENTDIR5\" \"流向5\", t.\"CURRENTSPD6\" \"流速6\", " +
                                     "t.\"CURRENTDIR6\" \"流向6\", t.\"CURRENTSPD7\" \"流速7\", t.\"CURRENTDIR7\" \"流向7\", " +
                                     "t.\"CURRENTSPD8\" \"流速8\", t.\"CURRENTDIR8\" \"流向8\", t.\"CURRENTSPD9\" \"流速9\", " +
                                     "t.\"CURRENTDIR9\" \"流向9\", t.\"CURRENTSPD10\" \"流速10\", t.\"CURRENTDIR10\" \"流向10\", " +
                                     "t.\"CURRENTSPD11\" \"流速11\", t.\"CURRENTDIR11\" \"流向11\", t.\"CURRENTSPD12\" \"流速12\", " +
                                     "t.\"CURRENTDIR12\" \"流向12\", t.\"CURRENTSPD13\" \"流速13\", t.\"CURRENTDIR13\" \"流向13\", " +
                                     "t.\"CURRENTSPD14\" \"流速14\", t.\"CURRENTDIR14\" \"流向14\", t.\"CURRENTSPD15\" \"流速15\", " +
                                     "t.\"CURRENTDIR15\" \"流向15\", t.\"CURRENTSPD16\" \"流速16\", t.\"CURRENTDIR16\" \"流向16\", " +
                                     "t.\"CURRENTSPD17\" \"流速17\", t.\"CURRENTDIR17\" \"流向17\", t.\"CURRENTSPD18\" \"流速18\", " +
                                     "t.\"CURRENTDIR18\" \"流向18\", t.\"CURRENTSPD19\" \"流速19\", t.\"CURRENTDIR19\" \"流向19\", " +
                                     "t.\"CURRENTSPD20\" \"流速20\", t.\"CURRENTDIR20\" \"流向20\", t.\"CURRENTSPD21\" \"流速21\", " +
                                     "t.\"CURRENTDIR21\" \"流向21\", t.\"CURRENTSPD22\" \"流速22\", t.\"CURRENTDIR22\" \"流向22\", " +
                                     "t.\"CURRENTSPD23\" \"流速23\", t.\"CURRENTDIR23\" \"流向23\", t.\"CURRENTSPD24\" \"流速24\", " +
                                     "t.\"CURRENTDIR24\" \"流向24\", t.\"CURRENTSPD25\" \"流速25\", t.\"CURRENTDIR25\" \"流向25\", " +
                                     "t.\"CURRENTSPD26\" \"流速26\", t.\"CURRENTDIR26\" \"流向26\", t.\"CURRENTSPD27\" \"流速27\", " +
                                     "t.\"CURRENTDIR27\" \"流向27\", t.\"CURRENTSPD28\" \"流速28\", t.\"CURRENTDIR28\" \"流向28\", " +
                                     "t.\"CURRENTSPD29\" \"流速29\", t.\"CURRENTDIR29\" \"流向29\", t.\"CURRENTSPD30\" \"流速30\", " +
                                     "t.\"CURRENTDIR30\" \"流向30\", t.\"CURRENTSPD31\" \"流速31\", t.\"CURRENTDIR31\" \"流向31\", " +
                                     "t.\"CURRENTSPD32\" \"流速32\", t.\"CURRENTDIR32\" \"流向32\", t.\"CURRENTSPD33\" \"流速33\", " +
                                     "t.\"CURRENTDIR33\" \"流向33\", t.\"CURRENTSPD34\" \"流速34\", t.\"CURRENTDIR34\" \"流向34\", " +
                                     "t.\"CURRENTSPD35\" \"流速35\", t.\"CURRENTDIR35\" \"流向35\", t.\"CURRENTSPD36\" \"流速36\", " +
                                     "t.\"CURRENTDIR36\" \"流向36\", t.\"CURRENTSPD37\" \"流速37\", t.\"CURRENTDIR37\" \"流向37\", " +
                                     "t.\"CURRENTSPD38\" \"流速38\", t.\"CURRENTDIR38\" \"流向38\", t.\"CURRENTSPD39\" \"流速39\", " +
                                     "t.\"CURRENTDIR39\" \"流向39\", t.\"CURRENTSPD40\" \"流速40\", t.\"CURRENTDIR40\" \"流向40\" " +
                                     "FROM TABBUOYHYDROLOGY t left join deviceinfo d on t.devicecode = d.devicecode " +
                                     "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                     "order by t.DATETIME desc"
            },
            {
                // 岸基 - 海流
                "TABHYDROLOGY1", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"DEPTH\" \"水深\", t.\"WATERLEVEL\" \"水位\", t.\"CURRENTSPD1\" \"流速1\", " +
                                 "t.\"CURRENTDIR1\" \"流向1\", t.\"CURRENTSPD2\" \"流速2\", t.\"CURRENTDIR2\" \"流向2\", t.\"CURRENTSPD3\" \"流速3\", " +
                                 "t.\"CURRENTDIR3\" \"流向3\", t.\"CURRENTSPD4\" \"流速4\", t.\"CURRENTDIR4\" \"流向4\", t.\"CURRENTSPD5\" \"流速5\", " +
                                 "t.\"CURRENTDIR5\" \"流向5\", t.\"CURRENTSPD6\" \"流速6\", t.\"CURRENTDIR6\" \"流向6\", t.\"CURRENTSPD7\" \"流速7\", " +
                                 "t.\"CURRENTDIR7\" \"流向7\", t.\"CURRENTSPD8\" \"流速8\", t.\"CURRENTDIR8\" \"流向8\", t.\"CURRENTSPD9\" \"流速9\", " +
                                 "t.\"CURRENTDIR9\" \"流向9\", t.\"CURRENTSPD10\" \"流速10\", t.\"CURRENTDIR10\" \"流向10\", t.\"CURRENTSPD11\" \"流速11\", " +
                                 "t.\"CURRENTDIR11\" \"流向11\", t.\"CURRENTSPD12\" \"流速12\", t.\"CURRENTDIR12\" \"流向12\", t.\"CURRENTSPD13\" \"流速13\", " +
                                 "t.\"CURRENTDIR13\" \"流向13\", t.\"CURRENTSPD14\" \"流速14\", t.\"CURRENTDIR14\" \"流向14\", t.\"CURRENTSPD15\" \"流速15\", " +
                                 "t.\"CURRENTDIR15\" \"流向15\", t.\"CURRENTSPD16\" \"流速16\", t.\"CURRENTDIR16\" \"流向16\", t.\"CURRENTSPD17\" \"流速17\", " +
                                 "t.\"CURRENTDIR17\" \"流向17\", t.\"CURRENTSPD18\" \"流速18\", t.\"CURRENTDIR18\" \"流向18\", t.\"CURRENTSPD19\" \"流速19\", " +
                                 "t.\"CURRENTDIR19\" \"流向19\", t.\"CURRENTSPD20\" \"流速20\", t.\"CURRENTDIR20\" \"流向20\", t.\"CURRENTSPD21\" \"流速21\", " +
                                 "t.\"CURRENTDIR21\" \"流向21\", t.\"CURRENTSPD22\" \"流速22\", t.\"CURRENTDIR22\" \"流向22\", t.\"CURRENTSPD23\" \"流速23\", " +
                                 "t.\"CURRENTDIR23\" \"流向23\", t.\"CURRENTSPD24\" \"流速24\", t.\"CURRENTDIR24\" \"流向24\", t.\"CURRENTSPD25\" \"流速25\", " +
                                 "t.\"CURRENTDIR25\" \"流向25\", t.\"CURRENTSPD26\" \"流速26\", t.\"CURRENTDIR26\" \"流向26\", t.\"CURRENTSPD27\" \"流速27\", " +
                                 "t.\"CURRENTDIR27\" \"流向27\", t.\"CURRENTSPD28\" \"流速28\", t.\"CURRENTDIR28\" \"流向28\", t.\"CURRENTSPD29\" \"流速29\", " +
                                 "t.\"CURRENTDIR29\" \"流向29\", t.\"CURRENTSPD30\" \"流速30\", t.\"CURRENTDIR30\" \"流向30\", t.\"CURRENTSPD31\" \"流速31\", " +
                                 "t.\"CURRENTDIR31\" \"流向31\", t.\"CURRENTSPD32\" \"流速32\", t.\"CURRENTDIR32\" \"流向32\", t.\"CURRENTSPD33\" \"流速33\", " +
                                 "t.\"CURRENTDIR33\" \"流向33\", t.\"CURRENTSPD34\" \"流速34\", t.\"CURRENTDIR34\" \"流向34\", t.\"CURRENTSPD35\" \"流速35\", " +
                                 "t.\"CURRENTDIR35\" \"流向35\", t.\"CURRENTSPD36\" \"流速36\", t.\"CURRENTDIR36\" \"流向36\", t.\"CURRENTSPD37\" \"流速37\", " +
                                 "t.\"CURRENTDIR37\" \"流向37\", t.\"CURRENTSPD38\" \"流速38\", t.\"CURRENTDIR38\" \"流向38\", t.\"CURRENTSPD39\" \"流速39\", " +
                                 "t.\"CURRENTDIR39\" \"流向39\", t.\"CURRENTSPD40\" \"流速40\", t.\"CURRENTDIR40\" \"流向40\" " +
                                 "FROM TABHYDROLOGY t left join deviceinfo d on t.devicecode = d.devicecode " +
                                 "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                 "order by t.DATETIME desc"
            },
            {
                // 浮标 - 气象
                "TABBUOYQIXG0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"NJD\" \"能见度\", t.\"RAINFALLACTUAL\" \"实际雨量\", t.\"RAINFALLPREV\" \"测前雨量\", " +
                                "t.\"RAINFALL\" \"雨量\", t.\"TOTALRADIATION\" \"总辐射\", t.\"INFRAREDRADIATION\" \"红外辐射\", t.\"SUNLIGHTTIME\" \"日照时间\", " +
                                "t.\"AIRCO2\" \"二氧化碳\" " +
                                "FROM TABBUOYQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                                "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                "order by t.DATETIME desc"
            },
            {
                // 岸基 - 气象
                "TABQIXG0", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"NJD\" \"能见度\", t.\"RAINFALL\" \"雨量\", t.\"TOTALRADIATION\" \"总辐射\", " +
                            "t.\"INFRAREDRADIATION\" \"红外辐射\", t.\"SUNLIGHTTIME\" \"日照时间\", t.\"AIRCO2\" \"空气二氧化碳\" " +
                            "FROM TABQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                            "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                            "order by t.DATETIME desc"
            },
            {
                // 浮标 - 风
                "TABBUOYQIXG1", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"WINDSPD1\" \"风速1\", t.\"WINDDIR1\" \"风向1\", t.\"WINDSPD2\" \"风速2\", " +
                                "t.\"WINDDIR2\" \"风向2\", t.\"WINDSPD3\" \"风速3\", t.\"WINDDIR3\" \"风向3\", t.\"WINDSPD4\" \"风速4\", t.\"WINDDIR4\" \"风向4\", " +
                                "t.\"WINDSPD5\" \"风速5\", t.\"WINDDIR5\" \"风向5\", t.\"WINDSPD6\" \"风速6\", t.\"WINDDIR6\" \"风向6\", t.\"WINDSPD7\" \"风速7\", " +
                                "t.\"WINDDIR7\" \"风向7\", t.\"WINDSPD8\" \"风速8\", t.\"WINDDIR8\" \"风向8\", t.\"WINDSPD9\" \"风速9\", t.\"WINDDIR9\" \"风向9\", " +
                                "t.\"WINDSPD10\" \"风速10\", t.\"WINDDIR10\" \"风向10\", t.\"MAXWINDSPD\" \"最大风速\", t.\"MAXWINDDIR\" \"最大风速风向\", " +
                                "t.\"MAXWINDTIME\" \"最大风速时间\", t.\"HUGEWINDSPD\" \"极大风速\", t.\"HUGEWINDDIR\" \"极大风速风向\", t.\"HUGEWINDTIME\" \"极大风速时间\", " +
                                "t.\"TENMINAVESPD\" \"10分钟平均风速\", t.\"TENMINAVEDIR\" \"10分钟平均风向\", t.\"INSTANTSPD\" \"瞬时风速\", t.\"INSTANTDIR\" \"瞬时风向\", " +
                                "t.\"TOWMINAVESPD\" \"2分钟平均风速\", t.\"TOWMINAVEDIR\" \"2分钟平均风向\", t.\"AVEWINDSPD1\" \"平均风速1\", t.\"AVEWINDDIR1\" \"平均风向1\", " +
                                "t.\"AVEWINDSPD2\" \"平均风速2\", t.\"AVEWINDDIR1\" \"平均风向2\", t.\"AVEWINDSPD3\" \"平均风速3\", t.\"AVEWINDDIR1\" \"平均风向3\", " +
                                "t.\"AVEWINDSPD4\" \"平均风速4\", t.\"AVEWINDDIR1\" \"平均风向4\", t.\"AVEWINDSPD5\" \"平均风速5\", t.\"AVEWINDDIR1\" \"平均风向5\", " +
                                "t.\"AVEWINDSPD6\" \"平均风速6\", t.\"AVEWINDDIR1\" \"平均风向6\", t.\"AVEWINDSPD7\" \"平均风速7\", t.\"AVEWINDDIR1\" \"平均风向7\", " +
                                "t.\"AVEWINDSPD8\" \"平均风速8\", t.\"AVEWINDDIR1\" \"平均风向8\", t.\"AVEWINDSPD9\" \"平均风速9\", t.\"AVEWINDDIR1\" \"平均风向9\", " +
                                "t.\"AVEWINDSPD10\" \"平均风速10\", t.\"AVEWINDDIR10\" \"平均风向10\" " +
                                "FROM TABBUOYQIXG t left join deviceinfo d on t.devicecode = d.devicecode where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                "order by t.DATETIME desc"
            },
            {
                // 岸基 - 风
                "TABQIXG1", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"WINDSPD1\" \"风速1\", t.\"WINDDIR1\" \"风向1\", t.\"WINDSPD2\" \"风速2\", t.\"WINDDIR2\" \"风向2\", " +
                            "t.\"WINDSPD3\" \"风速3\", t.\"WINDDIR3\" \"风向3\", t.\"WINDSPD4\" \"风速4\", t.\"WINDDIR4\" \"风向4\", t.\"WINDSPD5\" \"风速5\", " +
                            "t.\"WINDDIR5\" \"风向5\", t.\"WINDSPD6\" \"风速6\", t.\"WINDDIR6\" \"风向6\", t.\"WINDSPD7\" \"风速7\", t.\"WINDDIR7\" \"风向7\", " +
                            "t.\"WINDSPD8\" \"风速8\", t.\"WINDDIR8\" \"风向8\", t.\"WINDSPD9\" \"风速9\", t.\"WINDDIR9\" \"风向9\", t.\"WINDSPD10\" \"风速10\", " +
                            "t.\"WINDDIR10\" \"风向10\", t.\"AVESPD\" \"平均风速\", t.\"AVEDIR\" \"平均风向\" " +
                            "FROM TABQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                            "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                            "order by t.DATETIME desc"
            },
            {
                // 浮标 - 气压
                "TABBUOYQIXG2", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"PRESSURE1\" \"气压1\", t.\"PRESSURE2\" \"气压2\", t.\"PRESSURE3\" \"气压3\", " +
                                "t.\"PRESSURE4\" \"气压4\", t.\"PRESSURE5\" \"气压5\", t.\"PRESSURE6\" \"气压6\", t.\"PRESSURE7\" \"气压7\", t.\"PRESSURE8\" \"气压8\", " +
                                "t.\"PRESSURE9\" \"气压9\", t.\"PRESSURE10\" \"气压10\", t.\"MAXPRESSURE\" \"最高气压\", t.\"MAXPRESSURETIME\" \"最高气压时间\", " +
                                "t.\"MINPRESSURE\" \"最低气压\", t.\"MINPRESSURETIME\" \"最低气压时间\" " +
                                "FROM TABBUOYQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                                "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                "order by t.DATETIME desc"
            },
            {
                // 岸基 - 气压
                "TABQIXG2", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"PRESSURE\" \"气压\" " +
                            "FROM TABQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                            "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                            "order by t.DATETIME desc"
            },
            {
                // 浮标 - 气温
                "TABBUOYQIXG3", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"AIRTEM1\" \"气温1\", t.\"AIRTEM2\" \"气温2\", t.\"AIRTEM3\" \"气温3\", t.\"AIRTEM4\" \"气温4\", " +
                                "t.\"AIRTEM5\" \"气温5\", t.\"AIRTEM6\" \"气温6\", t.\"AIRTEM7\" \"气温7\", t.\"AIRTEM8\" \"气温8\", t.\"AIRTEM9\" \"气温9\", " +
                                "t.\"AIRTEM10\" \"气温10\", t.\"MAXAIRTEM\" \"最高气温\", t.\"MAXAIRTEMTIME\" \"最高气温时间\", t.\"MINAIRTEM\" \"最低气温\", " +
                                "t.\"MINAIRTEMTIME\" \"最低气温时间\" " +
                                "FROM TABBUOYQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                                "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                "order by t.DATETIME desc"
            },
            {
                // 岸基 - 气温
                "TABQIXG3", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"AIRTEM\" \"气温\" " +
                            "FROM TABQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                            "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                            "order by t.DATETIME desc"
            },
            {
                // 浮标 - 湿度
                "TABBUOYQIXG4", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"HUMI1\" \"湿度1\", t.\"HUMI2\" \"湿度2\", t.\"HUMI3\" \"湿度3\", t.\"HUMI4\" \"湿度4\", " +
                                "t.\"HUMI5\" \"湿度5\", t.\"HUMI6\" \"湿度6\", t.\"HUMI7\" \"湿度7\", t.\"HUMI8\" \"湿度8\", t.\"HUMI9\" \"湿度9\", " +
                                "t.\"HUMI10\" \"湿度10\", t.\"MAXHUMI\" \"最高湿度\", t.\"MAXHUMITIME\" \"最高湿度时间\", t.\"MINHUMI\" \"最低湿度\", " +
                                "t.\"MINHUMITIME\" \"最低湿度时间\" " +
                                "FROM TABBUOYQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                                "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                                "order by t.DATETIME desc"
            },
            {
                // 岸基 - 湿度
                "TABQIXG4", "SELECT d.devicename,t.\"DATETIME\" \"日期时间\", t.\"HUMI\" \"湿度\" " +
                            "FROM TABQIXG t left join deviceinfo d on t.devicecode = d.devicecode " +
                            "where t.devicecode=:devicecode and t.DATETIME between to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') " +
                            "order by t.DATETIME desc"
            }
        };




    }
}
