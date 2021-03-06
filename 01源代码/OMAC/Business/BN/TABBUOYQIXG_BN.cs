﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;

namespace Business.BN
{
    /// <summary>
    /// 气象数据表(浮标)
    /// </summary>
    public class TABBUOYQIXG_BN
    {

        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from TABBUOYQIXG");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
			};

            if (dbHelper.ExecuteNonQuery(strSql.ToString(), parameters) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Entity.TABBUOYQIXG model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into TABBUOYQIXG(");
            strSql.Append("DEVICECODE,DATETIME,SENDNUM,RECVNUM,NJD,RAINFALLACTUAL,RAINFALLPREV,RAINFALL,TOTALRADIATION,INFRAREDRADIATION,SUNLIGHTTIME,AIRCO2,AIRTEM1,AIRTEM2,AIRTEM3,AIRTEM4,AIRTEM5,AIRTEM6,AIRTEM7,AIRTEM8,AIRTEM9,AIRTEM10,MAXAIRTEM,MAXAIRTEMTIME,MINAIRTEM,MINAIRTEMTIME,HUMI1,HUMI2,HUMI3,HUMI4,HUMI5,HUMI6,HUMI7,HUMI8,HUMI9,HUMI10,MAXHUMI,MAXHUMITIME,MINHUMI,MINHUMITIME,PRESSURE1,PRESSURE2,PRESSURE3,PRESSURE4,PRESSURE5,PRESSURE6,PRESSURE7,PRESSURE8,PRESSURE9,PRESSURE10,MAXPRESSURE,MAXPRESSURETIME,MINPRESSURE,MINPRESSURETIME,WINDSPD1,WINDDIR1,WINDSPD2,WINDDIR2,WINDSPD3,WINDDIR3,WINDSPD4,WINDDIR4,WINDSPD5,WINDDIR5,WINDSPD6,WINDDIR6,WINDSPD7,WINDDIR7,WINDSPD8,WINDDIR8,WINDSPD9,WINDDIR9,WINDSPD10,WINDDIR10,MAXWINDSPD,MAXWINDDIR,MAXWINDTIME,HUGEWINDSPD,HUGEWINDDIR,HUGEWINDTIME,TENMINAVESPD,TENMINAVEDIR,INSTANTSPD,INSTANTDIR,TOWMINAVESPD,TOWMINAVEDIR,AVEWINDSPD1,AVEWINDDIR1,AVEWINDSPD2,AVEWINDDIR2,AVEWINDSPD3,AVEWINDDIR3,AVEWINDSPD4,AVEWINDDIR4,AVEWINDSPD5,AVEWINDDIR5,AVEWINDSPD6,AVEWINDDIR6,AVEWINDSPD7,AVEWINDDIR7,AVEWINDSPD8,AVEWINDDIR8,AVEWINDSPD9,AVEWINDDIR9,AVEWINDSPD10,AVEWINDDIR10,RESERV0,RESERV1,RESERV2,RESERV3,RESERV4,RESERV5,RESERV6,RESERV7,RESERV8,RESERV9,RESERV10,RESERV11,RESERV12,RESERV13,RESERV14");
            strSql.Append(") values (");
            strSql.Append(":DEVICECODE,:DATETIME,:SENDNUM,:RECVNUM,:NJD,:RAINFALLACTUAL,:RAINFALLPREV,:RAINFALL,:TOTALRADIATION,:INFRAREDRADIATION,:SUNLIGHTTIME,:AIRCO2,:AIRTEM1,:AIRTEM2,:AIRTEM3,:AIRTEM4,:AIRTEM5,:AIRTEM6,:AIRTEM7,:AIRTEM8,:AIRTEM9,:AIRTEM10,:MAXAIRTEM,:MAXAIRTEMTIME,:MINAIRTEM,:MINAIRTEMTIME,:HUMI1,:HUMI2,:HUMI3,:HUMI4,:HUMI5,:HUMI6,:HUMI7,:HUMI8,:HUMI9,:HUMI10,:MAXHUMI,:MAXHUMITIME,:MINHUMI,:MINHUMITIME,:PRESSURE1,:PRESSURE2,:PRESSURE3,:PRESSURE4,:PRESSURE5,:PRESSURE6,:PRESSURE7,:PRESSURE8,:PRESSURE9,:PRESSURE10,:MAXPRESSURE,:MAXPRESSURETIME,:MINPRESSURE,:MINPRESSURETIME,:WINDSPD1,:WINDDIR1,:WINDSPD2,:WINDDIR2,:WINDSPD3,:WINDDIR3,:WINDSPD4,:WINDDIR4,:WINDSPD5,:WINDDIR5,:WINDSPD6,:WINDDIR6,:WINDSPD7,:WINDDIR7,:WINDSPD8,:WINDDIR8,:WINDSPD9,:WINDDIR9,:WINDSPD10,:WINDDIR10,:MAXWINDSPD,:MAXWINDDIR,:MAXWINDTIME,:HUGEWINDSPD,:HUGEWINDDIR,:HUGEWINDTIME,:TENMINAVESPD,:TENMINAVEDIR,:INSTANTSPD,:INSTANTDIR,:TOWMINAVESPD,:TOWMINAVEDIR,:AVEWINDSPD1,:AVEWINDDIR1,:AVEWINDSPD2,:AVEWINDDIR2,:AVEWINDSPD3,:AVEWINDDIR3,:AVEWINDSPD4,:AVEWINDDIR4,:AVEWINDSPD5,:AVEWINDDIR5,:AVEWINDSPD6,:AVEWINDDIR6,:AVEWINDSPD7,:AVEWINDDIR7,:AVEWINDSPD8,:AVEWINDDIR8,:AVEWINDSPD9,:AVEWINDDIR9,:AVEWINDSPD10,:AVEWINDDIR10,:RESERV0,:RESERV1,:RESERV2,:RESERV3,:RESERV4,:RESERV5,:RESERV6,:RESERV7,:RESERV8,:RESERV9,:RESERV10,:RESERV11,:RESERV12,:RESERV13,:RESERV14");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DATETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":NJD", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALLACTUAL", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALLPREV", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALL", OracleType.Number,22) ,            
                        new OracleParameter(":TOTALRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":INFRAREDRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":SUNLIGHTTIME", OracleType.Number,22) ,            
                        new OracleParameter(":AIRCO2", OracleType.Number,22) ,            
                        new OracleParameter(":AIRTEM1", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM2", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM3", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM4", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM5", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM6", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM7", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM8", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM9", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM10", OracleType.Number,16) ,            
                        new OracleParameter(":MAXAIRTEM", OracleType.Number,16) ,            
                        new OracleParameter(":MAXAIRTEMTIME", OracleType.Number,22) ,            
                        new OracleParameter(":MINAIRTEM", OracleType.Number,16) ,            
                        new OracleParameter(":MINAIRTEMTIME", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI1", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI2", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI3", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI4", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI5", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI6", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI7", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI8", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI9", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI10", OracleType.Number,22) ,            
                        new OracleParameter(":MAXHUMI", OracleType.Number,22) ,            
                        new OracleParameter(":MAXHUMITIME", OracleType.Number,22) ,            
                        new OracleParameter(":MINHUMI", OracleType.Number,22) ,            
                        new OracleParameter(":MINHUMITIME", OracleType.Number,22) ,            
                        new OracleParameter(":PRESSURE1", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE2", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE3", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE4", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE5", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE6", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE7", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE8", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE9", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE10", OracleType.Number,16) ,            
                        new OracleParameter(":MAXPRESSURE", OracleType.Number,16) ,            
                        new OracleParameter(":MAXPRESSURETIME", OracleType.Number,22) ,            
                        new OracleParameter(":MINPRESSURE", OracleType.Number,16) ,            
                        new OracleParameter(":MINPRESSURETIME", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD1", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD2", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD3", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD4", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD5", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD6", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD7", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD8", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD9", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD10", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":MAXWINDSPD", OracleType.Number,16) ,            
                        new OracleParameter(":MAXWINDDIR", OracleType.Number,22) ,            
                        new OracleParameter(":MAXWINDTIME", OracleType.Number,22) ,            
                        new OracleParameter(":HUGEWINDSPD", OracleType.Number,16) ,            
                        new OracleParameter(":HUGEWINDDIR", OracleType.Number,22) ,            
                        new OracleParameter(":HUGEWINDTIME", OracleType.Number,22) ,            
                        new OracleParameter(":TENMINAVESPD", OracleType.Number,16) ,            
                        new OracleParameter(":TENMINAVEDIR", OracleType.Number,22) ,            
                        new OracleParameter(":INSTANTSPD", OracleType.Number,16) ,            
                        new OracleParameter(":INSTANTDIR", OracleType.Number,22) ,            
                        new OracleParameter(":TOWMINAVESPD", OracleType.Number,16) ,            
                        new OracleParameter(":TOWMINAVEDIR", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD1", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD2", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD3", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD4", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD5", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD6", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD7", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD8", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD9", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD10", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":RESERV0", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV1", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV2", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV3", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV4", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV5", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV6", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV7", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV8", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV9", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV10", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV11", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV12", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV13", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV14", OracleType.Number,16)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DATETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.NJD;
            parameters[5].Value = model.RAINFALLACTUAL;
            parameters[6].Value = model.RAINFALLPREV;
            parameters[7].Value = model.RAINFALL;
            parameters[8].Value = model.TOTALRADIATION;
            parameters[9].Value = model.INFRAREDRADIATION;
            parameters[10].Value = model.SUNLIGHTTIME;
            parameters[11].Value = model.AIRCO2;
            parameters[12].Value = model.AIRTEM1;
            parameters[13].Value = model.AIRTEM2;
            parameters[14].Value = model.AIRTEM3;
            parameters[15].Value = model.AIRTEM4;
            parameters[16].Value = model.AIRTEM5;
            parameters[17].Value = model.AIRTEM6;
            parameters[18].Value = model.AIRTEM7;
            parameters[19].Value = model.AIRTEM8;
            parameters[20].Value = model.AIRTEM9;
            parameters[21].Value = model.AIRTEM10;
            parameters[22].Value = model.MAXAIRTEM;
            parameters[23].Value = model.MAXAIRTEMTIME;
            parameters[24].Value = model.MINAIRTEM;
            parameters[25].Value = model.MINAIRTEMTIME;
            parameters[26].Value = model.HUMI1;
            parameters[27].Value = model.HUMI2;
            parameters[28].Value = model.HUMI3;
            parameters[29].Value = model.HUMI4;
            parameters[30].Value = model.HUMI5;
            parameters[31].Value = model.HUMI6;
            parameters[32].Value = model.HUMI7;
            parameters[33].Value = model.HUMI8;
            parameters[34].Value = model.HUMI9;
            parameters[35].Value = model.HUMI10;
            parameters[36].Value = model.MAXHUMI;
            parameters[37].Value = model.MAXHUMITIME;
            parameters[38].Value = model.MINHUMI;
            parameters[39].Value = model.MINHUMITIME;
            parameters[40].Value = model.PRESSURE1;
            parameters[41].Value = model.PRESSURE2;
            parameters[42].Value = model.PRESSURE3;
            parameters[43].Value = model.PRESSURE4;
            parameters[44].Value = model.PRESSURE5;
            parameters[45].Value = model.PRESSURE6;
            parameters[46].Value = model.PRESSURE7;
            parameters[47].Value = model.PRESSURE8;
            parameters[48].Value = model.PRESSURE9;
            parameters[49].Value = model.PRESSURE10;
            parameters[50].Value = model.MAXPRESSURE;
            parameters[51].Value = model.MAXPRESSURETIME;
            parameters[52].Value = model.MINPRESSURE;
            parameters[53].Value = model.MINPRESSURETIME;
            parameters[54].Value = model.WINDSPD1;
            parameters[55].Value = model.WINDDIR1;
            parameters[56].Value = model.WINDSPD2;
            parameters[57].Value = model.WINDDIR2;
            parameters[58].Value = model.WINDSPD3;
            parameters[59].Value = model.WINDDIR3;
            parameters[60].Value = model.WINDSPD4;
            parameters[61].Value = model.WINDDIR4;
            parameters[62].Value = model.WINDSPD5;
            parameters[63].Value = model.WINDDIR5;
            parameters[64].Value = model.WINDSPD6;
            parameters[65].Value = model.WINDDIR6;
            parameters[66].Value = model.WINDSPD7;
            parameters[67].Value = model.WINDDIR7;
            parameters[68].Value = model.WINDSPD8;
            parameters[69].Value = model.WINDDIR8;
            parameters[70].Value = model.WINDSPD9;
            parameters[71].Value = model.WINDDIR9;
            parameters[72].Value = model.WINDSPD10;
            parameters[73].Value = model.WINDDIR10;
            parameters[74].Value = model.MAXWINDSPD;
            parameters[75].Value = model.MAXWINDDIR;
            parameters[76].Value = model.MAXWINDTIME;
            parameters[77].Value = model.HUGEWINDSPD;
            parameters[78].Value = model.HUGEWINDDIR;
            parameters[79].Value = model.HUGEWINDTIME;
            parameters[80].Value = model.TENMINAVESPD;
            parameters[81].Value = model.TENMINAVEDIR;
            parameters[82].Value = model.INSTANTSPD;
            parameters[83].Value = model.INSTANTDIR;
            parameters[84].Value = model.TOWMINAVESPD;
            parameters[85].Value = model.TOWMINAVEDIR;
            parameters[86].Value = model.AVEWINDSPD1;
            parameters[87].Value = model.AVEWINDDIR1;
            parameters[88].Value = model.AVEWINDSPD2;
            parameters[89].Value = model.AVEWINDDIR2;
            parameters[90].Value = model.AVEWINDSPD3;
            parameters[91].Value = model.AVEWINDDIR3;
            parameters[92].Value = model.AVEWINDSPD4;
            parameters[93].Value = model.AVEWINDDIR4;
            parameters[94].Value = model.AVEWINDSPD5;
            parameters[95].Value = model.AVEWINDDIR5;
            parameters[96].Value = model.AVEWINDSPD6;
            parameters[97].Value = model.AVEWINDDIR6;
            parameters[98].Value = model.AVEWINDSPD7;
            parameters[99].Value = model.AVEWINDDIR7;
            parameters[100].Value = model.AVEWINDSPD8;
            parameters[101].Value = model.AVEWINDDIR8;
            parameters[102].Value = model.AVEWINDSPD9;
            parameters[103].Value = model.AVEWINDDIR9;
            parameters[104].Value = model.AVEWINDSPD10;
            parameters[105].Value = model.AVEWINDDIR10;
            parameters[106].Value = model.RESERV0;
            parameters[107].Value = model.RESERV1;
            parameters[108].Value = model.RESERV2;
            parameters[109].Value = model.RESERV3;
            parameters[110].Value = model.RESERV4;
            parameters[111].Value = model.RESERV5;
            parameters[112].Value = model.RESERV6;
            parameters[113].Value = model.RESERV7;
            parameters[114].Value = model.RESERV8;
            parameters[115].Value = model.RESERV9;
            parameters[116].Value = model.RESERV10;
            parameters[117].Value = model.RESERV11;
            parameters[118].Value = model.RESERV12;
            parameters[119].Value = model.RESERV13;
            parameters[120].Value = model.RESERV14;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.TABBUOYQIXG model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update TABBUOYQIXG set ");

            strSql.Append(" DEVICECODE = :DEVICECODE , ");
            strSql.Append(" DATETIME = :DATETIME , ");
            strSql.Append(" SENDNUM = :SENDNUM , ");
            strSql.Append(" RECVNUM = :RECVNUM , ");
            strSql.Append(" NJD = :NJD , ");
            strSql.Append(" RAINFALLACTUAL = :RAINFALLACTUAL , ");
            strSql.Append(" RAINFALLPREV = :RAINFALLPREV , ");
            strSql.Append(" RAINFALL = :RAINFALL , ");
            strSql.Append(" TOTALRADIATION = :TOTALRADIATION , ");
            strSql.Append(" INFRAREDRADIATION = :INFRAREDRADIATION , ");
            strSql.Append(" SUNLIGHTTIME = :SUNLIGHTTIME , ");
            strSql.Append(" AIRCO2 = :AIRCO2 , ");
            strSql.Append(" AIRTEM1 = :AIRTEM1 , ");
            strSql.Append(" AIRTEM2 = :AIRTEM2 , ");
            strSql.Append(" AIRTEM3 = :AIRTEM3 , ");
            strSql.Append(" AIRTEM4 = :AIRTEM4 , ");
            strSql.Append(" AIRTEM5 = :AIRTEM5 , ");
            strSql.Append(" AIRTEM6 = :AIRTEM6 , ");
            strSql.Append(" AIRTEM7 = :AIRTEM7 , ");
            strSql.Append(" AIRTEM8 = :AIRTEM8 , ");
            strSql.Append(" AIRTEM9 = :AIRTEM9 , ");
            strSql.Append(" AIRTEM10 = :AIRTEM10 , ");
            strSql.Append(" MAXAIRTEM = :MAXAIRTEM , ");
            strSql.Append(" MAXAIRTEMTIME = :MAXAIRTEMTIME , ");
            strSql.Append(" MINAIRTEM = :MINAIRTEM , ");
            strSql.Append(" MINAIRTEMTIME = :MINAIRTEMTIME , ");
            strSql.Append(" HUMI1 = :HUMI1 , ");
            strSql.Append(" HUMI2 = :HUMI2 , ");
            strSql.Append(" HUMI3 = :HUMI3 , ");
            strSql.Append(" HUMI4 = :HUMI4 , ");
            strSql.Append(" HUMI5 = :HUMI5 , ");
            strSql.Append(" HUMI6 = :HUMI6 , ");
            strSql.Append(" HUMI7 = :HUMI7 , ");
            strSql.Append(" HUMI8 = :HUMI8 , ");
            strSql.Append(" HUMI9 = :HUMI9 , ");
            strSql.Append(" HUMI10 = :HUMI10 , ");
            strSql.Append(" MAXHUMI = :MAXHUMI , ");
            strSql.Append(" MAXHUMITIME = :MAXHUMITIME , ");
            strSql.Append(" MINHUMI = :MINHUMI , ");
            strSql.Append(" MINHUMITIME = :MINHUMITIME , ");
            strSql.Append(" PRESSURE1 = :PRESSURE1 , ");
            strSql.Append(" PRESSURE2 = :PRESSURE2 , ");
            strSql.Append(" PRESSURE3 = :PRESSURE3 , ");
            strSql.Append(" PRESSURE4 = :PRESSURE4 , ");
            strSql.Append(" PRESSURE5 = :PRESSURE5 , ");
            strSql.Append(" PRESSURE6 = :PRESSURE6 , ");
            strSql.Append(" PRESSURE7 = :PRESSURE7 , ");
            strSql.Append(" PRESSURE8 = :PRESSURE8 , ");
            strSql.Append(" PRESSURE9 = :PRESSURE9 , ");
            strSql.Append(" PRESSURE10 = :PRESSURE10 , ");
            strSql.Append(" MAXPRESSURE = :MAXPRESSURE , ");
            strSql.Append(" MAXPRESSURETIME = :MAXPRESSURETIME , ");
            strSql.Append(" MINPRESSURE = :MINPRESSURE , ");
            strSql.Append(" MINPRESSURETIME = :MINPRESSURETIME , ");
            strSql.Append(" WINDSPD1 = :WINDSPD1 , ");
            strSql.Append(" WINDDIR1 = :WINDDIR1 , ");
            strSql.Append(" WINDSPD2 = :WINDSPD2 , ");
            strSql.Append(" WINDDIR2 = :WINDDIR2 , ");
            strSql.Append(" WINDSPD3 = :WINDSPD3 , ");
            strSql.Append(" WINDDIR3 = :WINDDIR3 , ");
            strSql.Append(" WINDSPD4 = :WINDSPD4 , ");
            strSql.Append(" WINDDIR4 = :WINDDIR4 , ");
            strSql.Append(" WINDSPD5 = :WINDSPD5 , ");
            strSql.Append(" WINDDIR5 = :WINDDIR5 , ");
            strSql.Append(" WINDSPD6 = :WINDSPD6 , ");
            strSql.Append(" WINDDIR6 = :WINDDIR6 , ");
            strSql.Append(" WINDSPD7 = :WINDSPD7 , ");
            strSql.Append(" WINDDIR7 = :WINDDIR7 , ");
            strSql.Append(" WINDSPD8 = :WINDSPD8 , ");
            strSql.Append(" WINDDIR8 = :WINDDIR8 , ");
            strSql.Append(" WINDSPD9 = :WINDSPD9 , ");
            strSql.Append(" WINDDIR9 = :WINDDIR9 , ");
            strSql.Append(" WINDSPD10 = :WINDSPD10 , ");
            strSql.Append(" WINDDIR10 = :WINDDIR10 , ");
            strSql.Append(" MAXWINDSPD = :MAXWINDSPD , ");
            strSql.Append(" MAXWINDDIR = :MAXWINDDIR , ");
            strSql.Append(" MAXWINDTIME = :MAXWINDTIME , ");
            strSql.Append(" HUGEWINDSPD = :HUGEWINDSPD , ");
            strSql.Append(" HUGEWINDDIR = :HUGEWINDDIR , ");
            strSql.Append(" HUGEWINDTIME = :HUGEWINDTIME , ");
            strSql.Append(" TENMINAVESPD = :TENMINAVESPD , ");
            strSql.Append(" TENMINAVEDIR = :TENMINAVEDIR , ");
            strSql.Append(" INSTANTSPD = :INSTANTSPD , ");
            strSql.Append(" INSTANTDIR = :INSTANTDIR , ");
            strSql.Append(" TOWMINAVESPD = :TOWMINAVESPD , ");
            strSql.Append(" TOWMINAVEDIR = :TOWMINAVEDIR , ");
            strSql.Append(" AVEWINDSPD1 = :AVEWINDSPD1 , ");
            strSql.Append(" AVEWINDDIR1 = :AVEWINDDIR1 , ");
            strSql.Append(" AVEWINDSPD2 = :AVEWINDSPD2 , ");
            strSql.Append(" AVEWINDDIR2 = :AVEWINDDIR2 , ");
            strSql.Append(" AVEWINDSPD3 = :AVEWINDSPD3 , ");
            strSql.Append(" AVEWINDDIR3 = :AVEWINDDIR3 , ");
            strSql.Append(" AVEWINDSPD4 = :AVEWINDSPD4 , ");
            strSql.Append(" AVEWINDDIR4 = :AVEWINDDIR4 , ");
            strSql.Append(" AVEWINDSPD5 = :AVEWINDSPD5 , ");
            strSql.Append(" AVEWINDDIR5 = :AVEWINDDIR5 , ");
            strSql.Append(" AVEWINDSPD6 = :AVEWINDSPD6 , ");
            strSql.Append(" AVEWINDDIR6 = :AVEWINDDIR6 , ");
            strSql.Append(" AVEWINDSPD7 = :AVEWINDSPD7 , ");
            strSql.Append(" AVEWINDDIR7 = :AVEWINDDIR7 , ");
            strSql.Append(" AVEWINDSPD8 = :AVEWINDSPD8 , ");
            strSql.Append(" AVEWINDDIR8 = :AVEWINDDIR8 , ");
            strSql.Append(" AVEWINDSPD9 = :AVEWINDSPD9 , ");
            strSql.Append(" AVEWINDDIR9 = :AVEWINDDIR9 , ");
            strSql.Append(" AVEWINDSPD10 = :AVEWINDSPD10 , ");
            strSql.Append(" AVEWINDDIR10 = :AVEWINDDIR10 , ");
            strSql.Append(" RESERV0 = :RESERV0 , ");
            strSql.Append(" RESERV1 = :RESERV1 , ");
            strSql.Append(" RESERV2 = :RESERV2 , ");
            strSql.Append(" RESERV3 = :RESERV3 , ");
            strSql.Append(" RESERV4 = :RESERV4 , ");
            strSql.Append(" RESERV5 = :RESERV5 , ");
            strSql.Append(" RESERV6 = :RESERV6 , ");
            strSql.Append(" RESERV7 = :RESERV7 , ");
            strSql.Append(" RESERV8 = :RESERV8 , ");
            strSql.Append(" RESERV9 = :RESERV9 , ");
            strSql.Append(" RESERV10 = :RESERV10 , ");
            strSql.Append(" RESERV11 = :RESERV11 , ");
            strSql.Append(" RESERV12 = :RESERV12 , ");
            strSql.Append(" RESERV13 = :RESERV13 , ");
            strSql.Append(" RESERV14 = :RESERV14  ");
            strSql.Append(" where  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DATETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":NJD", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALLACTUAL", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALLPREV", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALL", OracleType.Number,22) ,            
                        new OracleParameter(":TOTALRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":INFRAREDRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":SUNLIGHTTIME", OracleType.Number,22) ,            
                        new OracleParameter(":AIRCO2", OracleType.Number,22) ,            
                        new OracleParameter(":AIRTEM1", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM2", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM3", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM4", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM5", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM6", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM7", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM8", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM9", OracleType.Number,16) ,            
                        new OracleParameter(":AIRTEM10", OracleType.Number,16) ,            
                        new OracleParameter(":MAXAIRTEM", OracleType.Number,16) ,            
                        new OracleParameter(":MAXAIRTEMTIME", OracleType.Number,22) ,            
                        new OracleParameter(":MINAIRTEM", OracleType.Number,16) ,            
                        new OracleParameter(":MINAIRTEMTIME", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI1", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI2", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI3", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI4", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI5", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI6", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI7", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI8", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI9", OracleType.Number,22) ,            
                        new OracleParameter(":HUMI10", OracleType.Number,22) ,            
                        new OracleParameter(":MAXHUMI", OracleType.Number,22) ,            
                        new OracleParameter(":MAXHUMITIME", OracleType.Number,22) ,            
                        new OracleParameter(":MINHUMI", OracleType.Number,22) ,            
                        new OracleParameter(":MINHUMITIME", OracleType.Number,22) ,            
                        new OracleParameter(":PRESSURE1", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE2", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE3", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE4", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE5", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE6", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE7", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE8", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE9", OracleType.Number,16) ,            
                        new OracleParameter(":PRESSURE10", OracleType.Number,16) ,            
                        new OracleParameter(":MAXPRESSURE", OracleType.Number,16) ,            
                        new OracleParameter(":MAXPRESSURETIME", OracleType.Number,22) ,            
                        new OracleParameter(":MINPRESSURE", OracleType.Number,16) ,            
                        new OracleParameter(":MINPRESSURETIME", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD1", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD2", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD3", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD4", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD5", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD6", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD7", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD8", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD9", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD10", OracleType.Number,22) ,            
                        new OracleParameter(":WINDDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":MAXWINDSPD", OracleType.Number,16) ,            
                        new OracleParameter(":MAXWINDDIR", OracleType.Number,22) ,            
                        new OracleParameter(":MAXWINDTIME", OracleType.Number,22) ,            
                        new OracleParameter(":HUGEWINDSPD", OracleType.Number,16) ,            
                        new OracleParameter(":HUGEWINDDIR", OracleType.Number,22) ,            
                        new OracleParameter(":HUGEWINDTIME", OracleType.Number,22) ,            
                        new OracleParameter(":TENMINAVESPD", OracleType.Number,16) ,            
                        new OracleParameter(":TENMINAVEDIR", OracleType.Number,22) ,            
                        new OracleParameter(":INSTANTSPD", OracleType.Number,16) ,            
                        new OracleParameter(":INSTANTDIR", OracleType.Number,22) ,            
                        new OracleParameter(":TOWMINAVESPD", OracleType.Number,16) ,            
                        new OracleParameter(":TOWMINAVEDIR", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD1", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD2", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD3", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD4", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD5", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD6", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD7", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD8", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD9", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":AVEWINDSPD10", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWINDDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":RESERV0", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV1", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV2", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV3", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV4", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV5", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV6", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV7", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV8", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV9", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV10", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV11", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV12", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV13", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV14", OracleType.Number,16)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DATETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.NJD;
            parameters[5].Value = model.RAINFALLACTUAL;
            parameters[6].Value = model.RAINFALLPREV;
            parameters[7].Value = model.RAINFALL;
            parameters[8].Value = model.TOTALRADIATION;
            parameters[9].Value = model.INFRAREDRADIATION;
            parameters[10].Value = model.SUNLIGHTTIME;
            parameters[11].Value = model.AIRCO2;
            parameters[12].Value = model.AIRTEM1;
            parameters[13].Value = model.AIRTEM2;
            parameters[14].Value = model.AIRTEM3;
            parameters[15].Value = model.AIRTEM4;
            parameters[16].Value = model.AIRTEM5;
            parameters[17].Value = model.AIRTEM6;
            parameters[18].Value = model.AIRTEM7;
            parameters[19].Value = model.AIRTEM8;
            parameters[20].Value = model.AIRTEM9;
            parameters[21].Value = model.AIRTEM10;
            parameters[22].Value = model.MAXAIRTEM;
            parameters[23].Value = model.MAXAIRTEMTIME;
            parameters[24].Value = model.MINAIRTEM;
            parameters[25].Value = model.MINAIRTEMTIME;
            parameters[26].Value = model.HUMI1;
            parameters[27].Value = model.HUMI2;
            parameters[28].Value = model.HUMI3;
            parameters[29].Value = model.HUMI4;
            parameters[30].Value = model.HUMI5;
            parameters[31].Value = model.HUMI6;
            parameters[32].Value = model.HUMI7;
            parameters[33].Value = model.HUMI8;
            parameters[34].Value = model.HUMI9;
            parameters[35].Value = model.HUMI10;
            parameters[36].Value = model.MAXHUMI;
            parameters[37].Value = model.MAXHUMITIME;
            parameters[38].Value = model.MINHUMI;
            parameters[39].Value = model.MINHUMITIME;
            parameters[40].Value = model.PRESSURE1;
            parameters[41].Value = model.PRESSURE2;
            parameters[42].Value = model.PRESSURE3;
            parameters[43].Value = model.PRESSURE4;
            parameters[44].Value = model.PRESSURE5;
            parameters[45].Value = model.PRESSURE6;
            parameters[46].Value = model.PRESSURE7;
            parameters[47].Value = model.PRESSURE8;
            parameters[48].Value = model.PRESSURE9;
            parameters[49].Value = model.PRESSURE10;
            parameters[50].Value = model.MAXPRESSURE;
            parameters[51].Value = model.MAXPRESSURETIME;
            parameters[52].Value = model.MINPRESSURE;
            parameters[53].Value = model.MINPRESSURETIME;
            parameters[54].Value = model.WINDSPD1;
            parameters[55].Value = model.WINDDIR1;
            parameters[56].Value = model.WINDSPD2;
            parameters[57].Value = model.WINDDIR2;
            parameters[58].Value = model.WINDSPD3;
            parameters[59].Value = model.WINDDIR3;
            parameters[60].Value = model.WINDSPD4;
            parameters[61].Value = model.WINDDIR4;
            parameters[62].Value = model.WINDSPD5;
            parameters[63].Value = model.WINDDIR5;
            parameters[64].Value = model.WINDSPD6;
            parameters[65].Value = model.WINDDIR6;
            parameters[66].Value = model.WINDSPD7;
            parameters[67].Value = model.WINDDIR7;
            parameters[68].Value = model.WINDSPD8;
            parameters[69].Value = model.WINDDIR8;
            parameters[70].Value = model.WINDSPD9;
            parameters[71].Value = model.WINDDIR9;
            parameters[72].Value = model.WINDSPD10;
            parameters[73].Value = model.WINDDIR10;
            parameters[74].Value = model.MAXWINDSPD;
            parameters[75].Value = model.MAXWINDDIR;
            parameters[76].Value = model.MAXWINDTIME;
            parameters[77].Value = model.HUGEWINDSPD;
            parameters[78].Value = model.HUGEWINDDIR;
            parameters[79].Value = model.HUGEWINDTIME;
            parameters[80].Value = model.TENMINAVESPD;
            parameters[81].Value = model.TENMINAVEDIR;
            parameters[82].Value = model.INSTANTSPD;
            parameters[83].Value = model.INSTANTDIR;
            parameters[84].Value = model.TOWMINAVESPD;
            parameters[85].Value = model.TOWMINAVEDIR;
            parameters[86].Value = model.AVEWINDSPD1;
            parameters[87].Value = model.AVEWINDDIR1;
            parameters[88].Value = model.AVEWINDSPD2;
            parameters[89].Value = model.AVEWINDDIR2;
            parameters[90].Value = model.AVEWINDSPD3;
            parameters[91].Value = model.AVEWINDDIR3;
            parameters[92].Value = model.AVEWINDSPD4;
            parameters[93].Value = model.AVEWINDDIR4;
            parameters[94].Value = model.AVEWINDSPD5;
            parameters[95].Value = model.AVEWINDDIR5;
            parameters[96].Value = model.AVEWINDSPD6;
            parameters[97].Value = model.AVEWINDDIR6;
            parameters[98].Value = model.AVEWINDSPD7;
            parameters[99].Value = model.AVEWINDDIR7;
            parameters[100].Value = model.AVEWINDSPD8;
            parameters[101].Value = model.AVEWINDDIR8;
            parameters[102].Value = model.AVEWINDSPD9;
            parameters[103].Value = model.AVEWINDDIR9;
            parameters[104].Value = model.AVEWINDSPD10;
            parameters[105].Value = model.AVEWINDDIR10;
            parameters[106].Value = model.RESERV0;
            parameters[107].Value = model.RESERV1;
            parameters[108].Value = model.RESERV2;
            parameters[109].Value = model.RESERV3;
            parameters[110].Value = model.RESERV4;
            parameters[111].Value = model.RESERV5;
            parameters[112].Value = model.RESERV6;
            parameters[113].Value = model.RESERV7;
            parameters[114].Value = model.RESERV8;
            parameters[115].Value = model.RESERV9;
            parameters[116].Value = model.RESERV10;
            parameters[117].Value = model.RESERV11;
            parameters[118].Value = model.RESERV12;
            parameters[119].Value = model.RESERV13;
            parameters[120].Value = model.RESERV14;
            int rows = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("delete from TABBUOYQIXG ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
			};


            int rows = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取浮标气象数据：气温气压
        /// </summary>
        public Entity.TABBUOYQIXG GetQiWenQiYaModel(string deviceCode)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append(" SELECT DATETIME, ROUND(SUM(NVL(AIRTEM1,0)+NVL(AIRTEM2,0)+NVL(AIRTEM3,0)+ NVL(AIRTEM4,0)+NVL(AIRTEM5,0)+ NVL(AIRTEM6,0)+ NVL(AIRTEM7,0)+ NVL(AIRTEM8,0)+ NVL(AIRTEM9,0)+NVL(AIRTEM10,0))/(decode(sign(AIRTEM1),null,0,-1,1,0,0,1,1) + decode(sign(AIRTEM2),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM3),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM4),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM5),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM6),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM7),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM8),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM9),null,0,-1,1,0,0,1,1)+decode(sign(AIRTEM10),null,0,-1,1,0,0,1,1)),2) AIRTEM, MAXAIRTEM, MAXAIRTEMTIME, MINAIRTEM, MINAIRTEMTIME, ROUND(SUM(NVL(HUMI1,0)+ NVL(HUMI2,0)+ NVL(HUMI3,0)+ NVL(HUMI4,0)+ NVL(HUMI5,0)+ NVL(HUMI6,0)+ NVL(HUMI7,0)+ NVL(HUMI8,0)+ NVL(HUMI9,0)+ NVL(HUMI10,0))/(decode(sign(HUMI1),null,0,-1,1,0,0,1,1) + decode(sign(HUMI2),null,0,-1,1,0,0,1,1)+decode(sign(HUMI3),null,0,-1,1,0,0,1,1)+decode(sign(HUMI4),null,0,-1,1,0,0,1,1)+decode(sign(HUMI5),null,0,-1,1,0,0,1,1)+decode(sign(HUMI6),null,0,-1,1,0,0,1,1)+decode(sign(HUMI7),null,0,-1,1,0,0,1,1)+decode(sign(HUMI8),null,0,-1,1,0,0,1,1)+decode(sign(HUMI9),null,0,-1,1,0,0,1,1)+decode(sign(HUMI10),null,0,-1,1,0,0,1,1)),2) HUMI, MAXHUMI, MAXHUMITIME, MINHUMI, MINHUMITIME, ROUND(SUM(NVL(PRESSURE1,0)+ NVL(PRESSURE2,0)+ NVL(PRESSURE3,0)+ NVL(PRESSURE4,0)+ NVL(PRESSURE5,0)+ NVL(PRESSURE6,0)+ NVL(PRESSURE7,0)+ NVL(PRESSURE8,0)+ NVL(PRESSURE9,0)+ NVL(PRESSURE10,0))/(decode(sign(PRESSURE1),null,0,-1,1,0,0,1,1) + decode(sign(PRESSURE2),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE3),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE4),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE5),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE6),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE7),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE8),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE9),null,0,-1,1,0,0,1,1)+decode(sign(PRESSURE10),null,0,-1,1,0,0,1,1)),2) PRESSURE, MAXPRESSURE, MAXPRESSURETIME, MINPRESSURE, MINPRESSURETIME ");
            strSql.Append(" FROM TABBUOYQIXG ");
            strSql.Append(" WHERE DEVICECODE =:DEVICECODE ");
            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM TABBUOYQIXG WHERE DEVICECODE=:DEVICECODE) ");
            strSql.Append(" GROUP BY DATETIME,AIRTEM1,AIRTEM2,AIRTEM3,AIRTEM4,AIRTEM5,AIRTEM6,AIRTEM7,AIRTEM8,AIRTEM9,AIRTEM10,MAXAIRTEM, MAXAIRTEMTIME, MINAIRTEM, MINAIRTEMTIME, HUMI1,HUMI2,HUMI3,HUMI4,HUMI5,HUMI6,HUMI7,HUMI8,HUMI9,HUMI10,MAXHUMI, MAXHUMITIME, MINHUMI, MINHUMITIME,PRESSURE1,PRESSURE2,PRESSURE3,PRESSURE4,PRESSURE5,PRESSURE6,PRESSURE7,PRESSURE8,PRESSURE9,PRESSURE10,MAXPRESSURE, MAXPRESSURETIME, MINPRESSURE, MINPRESSURETIME ");

            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            try
            {
                dbHelper.OpenConn("");
                Entity.TABBUOYQIXG model = new Entity.TABBUOYQIXG();
                DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

                dbHelper.CloseConn();
                if (ds.Rows.Count > 0)
                {
                    //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                    if (ds.Rows[0]["DATETIME"].ToString() != "")
                    {
                        model.DATETIME = DateTime.Parse(ds.Rows[0]["DATETIME"].ToString());
                    }
                    if (ds.Rows[0]["AIRTEM"].ToString() != "")
                    {
                        model.AIRTEM = decimal.Parse(ds.Rows[0]["AIRTEM"].ToString());
                    }
                    if (ds.Rows[0]["MAXAIRTEM"].ToString() != "")
                    {
                        model.MAXAIRTEM = decimal.Parse(ds.Rows[0]["MAXAIRTEM"].ToString());
                    }
                    if (ds.Rows[0]["MAXAIRTEMTIME"].ToString() != "")
                    {
                        model.MAXAIRTEMTIME = decimal.Parse(ds.Rows[0]["MAXAIRTEMTIME"].ToString());
                    }
                    if (ds.Rows[0]["MINAIRTEM"].ToString() != "")
                    {
                        model.MINAIRTEM = decimal.Parse(ds.Rows[0]["MINAIRTEM"].ToString());
                    }
                    if (ds.Rows[0]["MINAIRTEMTIME"].ToString() != "")
                    {
                        model.MINAIRTEMTIME = decimal.Parse(ds.Rows[0]["MINAIRTEMTIME"].ToString());
                    }
                    if (ds.Rows[0]["HUMI"].ToString() != "")
                    {
                        model.HUMI = decimal.Parse(ds.Rows[0]["HUMI"].ToString());
                    }
                    if (ds.Rows[0]["MAXHUMI"].ToString() != "")
                    {
                        model.MAXHUMI = decimal.Parse(ds.Rows[0]["MAXHUMI"].ToString());
                    }
                    if (ds.Rows[0]["MAXHUMITIME"].ToString() != "")
                    {
                        model.MAXHUMITIME = decimal.Parse(ds.Rows[0]["MAXHUMITIME"].ToString());
                    }
                    if (ds.Rows[0]["MINHUMI"].ToString() != "")
                    {
                        model.MINHUMI = decimal.Parse(ds.Rows[0]["MINHUMI"].ToString());
                    }
                    if (ds.Rows[0]["MINHUMITIME"].ToString() != "")
                    {
                        model.MINHUMITIME = decimal.Parse(ds.Rows[0]["MINHUMITIME"].ToString());
                    }
                    if (ds.Rows[0]["PRESSURE"].ToString() != "")
                    {
                        model.PRESSURE = decimal.Parse(ds.Rows[0]["PRESSURE"].ToString());
                    }
                    if (ds.Rows[0]["MAXPRESSURE"].ToString() != "")
                    {
                        model.MAXPRESSURE = decimal.Parse(ds.Rows[0]["MAXPRESSURE"].ToString());
                    }
                    if (ds.Rows[0]["MAXPRESSURETIME"].ToString() != "")
                    {
                        model.MAXPRESSURETIME = decimal.Parse(ds.Rows[0]["MAXPRESSURETIME"].ToString());
                    }
                    if (ds.Rows[0]["MINPRESSURE"].ToString() != "")
                    {
                        model.MINPRESSURE = decimal.Parse(ds.Rows[0]["MINPRESSURE"].ToString());
                    }
                    if (ds.Rows[0]["MINPRESSURETIME"].ToString() != "")
                    {
                        model.MINPRESSURETIME = decimal.Parse(ds.Rows[0]["MINPRESSURETIME"].ToString());
                    }

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(TABBUOYQIXG_BN), "GetQiWenQiYaModel 程序段的异常" + ex);
                return null;
            }
        }

        /// <summary>
        /// 获取浮标气象数据：气象
        /// </summary>
        public Entity.TABBUOYQIXG GetQiXiangModel(string deviceCode)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append(" SELECT DATETIME, NJD,RAINFALLACTUAL,RAINFALLPREV,RAINFALL,TOTALRADIATION,INFRAREDRADIATION,SUNLIGHTTIME,AIRCO2 ");
            strSql.Append(" FROM TABBUOYQIXG ");
            strSql.Append(" WHERE DEVICECODE =:DEVICECODE ");
            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM TABBUOYQIXG WHERE DEVICECODE=:DEVICECODE) ");

            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            try
            {
                dbHelper.OpenConn("");
                Entity.TABBUOYQIXG model = new Entity.TABBUOYQIXG();
                DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

                dbHelper.CloseConn();
                if (ds.Rows.Count > 0)
                {
                    //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                    if (ds.Rows[0]["DATETIME"].ToString() != "")
                    {
                        model.DATETIME = DateTime.Parse(ds.Rows[0]["DATETIME"].ToString());
                    }
                    if (ds.Rows[0]["NJD"].ToString() != "")
                    {
                        model.NJD = decimal.Parse(ds.Rows[0]["NJD"].ToString());
                    }
                    if (ds.Rows[0]["RAINFALLACTUAL"].ToString() != "")
                    {
                        model.RAINFALLACTUAL = decimal.Parse(ds.Rows[0]["RAINFALLACTUAL"].ToString());
                    }
                    if (ds.Rows[0]["RAINFALLPREV"].ToString() != "")
                    {
                        model.RAINFALLPREV = decimal.Parse(ds.Rows[0]["RAINFALLPREV"].ToString());
                    }
                    if (ds.Rows[0]["RAINFALL"].ToString() != "")
                    {
                        model.RAINFALL = decimal.Parse(ds.Rows[0]["RAINFALL"].ToString());
                    }
                    if (ds.Rows[0]["TOTALRADIATION"].ToString() != "")
                    {
                        model.TOTALRADIATION = decimal.Parse(ds.Rows[0]["TOTALRADIATION"].ToString());
                    }
                    if (ds.Rows[0]["INFRAREDRADIATION"].ToString() != "")
                    {
                        model.INFRAREDRADIATION = decimal.Parse(ds.Rows[0]["INFRAREDRADIATION"].ToString());
                    }
                    if (ds.Rows[0]["SUNLIGHTTIME"].ToString() != "")
                    {
                        model.SUNLIGHTTIME = decimal.Parse(ds.Rows[0]["SUNLIGHTTIME"].ToString());
                    }
                    if (ds.Rows[0]["AIRCO2"].ToString() != "")
                    {
                        model.AIRCO2 = decimal.Parse(ds.Rows[0]["AIRCO2"].ToString());
                    }

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(TABBUOYQIXG_BN), "GetQiXiangModel 程序段的异常" + ex);
                return null;
            }
        }

        /// <summary>
        /// 获取浮标气象数据：风速风向
        /// </summary>
        public Entity.TABBUOYQIXG GetFengSuFengXiangModel(string deviceCode)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append(" SELECT DATETIME,TOWMINAVESPD, TOWMINAVEDIR, TENMINAVESPD, TENMINAVEDIR, MAXWINDSPD, MAXWINDDIR, HUGEWINDSPD, HUGEWINDDIR, INSTANTSPD, INSTANTDIR, MAXWINDTIME, HUGEWINDTIME ");
            strSql.Append(" FROM TABBUOYQIXG ");
            strSql.Append(" WHERE DEVICECODE =:DEVICECODE ");
            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM TABBUOYQIXG WHERE DEVICECODE=:DEVICECODE) ");

            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            try
            {
                dbHelper.OpenConn("");
                Entity.TABBUOYQIXG model = new Entity.TABBUOYQIXG();
                DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

                dbHelper.CloseConn();
                if (ds.Rows.Count > 0)
                {
                    //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                    if (ds.Rows[0]["DATETIME"].ToString() != "")
                    {
                        model.DATETIME = DateTime.Parse(ds.Rows[0]["DATETIME"].ToString());
                    }
                    if (ds.Rows[0]["TOWMINAVESPD"].ToString() != "")
                    {
                        model.TOWMINAVESPD = decimal.Parse(ds.Rows[0]["TOWMINAVESPD"].ToString());
                    }
                    if (ds.Rows[0]["TOWMINAVEDIR"].ToString() != "")
                    {
                        model.TOWMINAVEDIR = decimal.Parse(ds.Rows[0]["TOWMINAVEDIR"].ToString());
                    }
                    if (ds.Rows[0]["TENMINAVESPD"].ToString() != "")
                    {
                        model.TENMINAVESPD = decimal.Parse(ds.Rows[0]["TENMINAVESPD"].ToString());
                    }
                    if (ds.Rows[0]["TENMINAVEDIR"].ToString() != "")
                    {
                        model.TENMINAVEDIR = decimal.Parse(ds.Rows[0]["TENMINAVEDIR"].ToString());
                    }
                    if (ds.Rows[0]["MAXWINDSPD"].ToString() != "")
                    {
                        model.MAXWINDSPD = decimal.Parse(ds.Rows[0]["MAXWINDSPD"].ToString());
                    }
                    if (ds.Rows[0]["MAXWINDDIR"].ToString() != "")
                    {
                        model.MAXWINDDIR = decimal.Parse(ds.Rows[0]["MAXWINDDIR"].ToString());
                    }
                    if (ds.Rows[0]["HUGEWINDSPD"].ToString() != "")
                    {
                        model.HUGEWINDSPD = decimal.Parse(ds.Rows[0]["HUGEWINDSPD"].ToString());
                    }
                    if (ds.Rows[0]["HUGEWINDDIR"].ToString() != "")
                    {
                        model.HUGEWINDDIR = decimal.Parse(ds.Rows[0]["HUGEWINDDIR"].ToString());
                    }
                    if (ds.Rows[0]["INSTANTSPD"].ToString() != "")
                    {
                        model.INSTANTSPD = decimal.Parse(ds.Rows[0]["INSTANTSPD"].ToString());
                    }
                    if (ds.Rows[0]["INSTANTDIR"].ToString() != "")
                    {
                        model.INSTANTDIR = decimal.Parse(ds.Rows[0]["INSTANTDIR"].ToString());
                    }
                    if (ds.Rows[0]["MAXWINDTIME"].ToString() != "")
                    {
                        model.MAXWINDTIME = decimal.Parse(ds.Rows[0]["MAXWINDTIME"].ToString());
                    }
                    if (ds.Rows[0]["HUGEWINDTIME"].ToString() != "")
                    {
                        model.HUGEWINDTIME = decimal.Parse(ds.Rows[0]["HUGEWINDTIME"].ToString());
                    }

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(TABBUOYQIXG_BN), "GetFengSuFengXiangModel 程序段的异常" + ex);
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            OracleParameter[] parameters = null;
            strSql.Append("select * ");
            strSql.Append(" FROM TABBUOYQIXG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            OracleParameter[] parameters = null;
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM TABBUOYQIXG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }


    }
}

