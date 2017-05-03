﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;

namespace Business.BN
{
    /// <summary>
    /// 水文数据表(浮标)
    /// </summary>
    public class TABBUOYHYDROLOGY
    {

        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from TABBUOYHYDROLOGY");
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
        public void Add(Entity.TABBUOYHYDROLOGY model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into TABBUOYHYDROLOGY(");
            strSql.Append("DEVICECODE,DTAETIME,SENDNUM,RECVNUM,CURRENTSPD1,CURRENTDIR1,CURRENTSPD41,CURRENTDIR41,CURRENTSPD42,CURRENTDIR42,CURRENTSPD43,CURRENTDIR43,CURRENTSPD2,CURRENTDIR2,CURRENTSPD3,CURRENTDIR3,CURRENTSPD4,CURRENTDIR4,CURRENTSPD5,CURRENTDIR5,CURRENTSPD6,CURRENTDIR6,CURRENTSPD7,CURRENTDIR7,CURRENTSPD8,CURRENTDIR8,CURRENTSPD9,CURRENTDIR9,CURRENTSPD10,CURRENTDIR10,CURRENTSPD11,CURRENTDIR11,CURRENTSPD12,CURRENTDIR12,CURRENTSPD13,CURRENTDIR13,CURRENTSPD14,CURRENTDIR14,CURRENTSPD15,CURRENTDIR15,CURRENTSPD16,CURRENTDIR16,CURRENTSPD17,CURRENTDIR17,CURRENTSPD18,CURRENTDIR18,CURRENTSPD19,CURRENTDIR19,CURRENTSPD20,CURRENTDIR20,CURRENTSPD21,CURRENTDIR21,CURRENTSPD22,CURRENTDIR22,CURRENTSPD23,CURRENTDIR23,CURRENTSPD24,CURRENTDIR24,CURRENTSPD25,CURRENTDIR25,CURRENTSPD26,CURRENTDIR26,CURRENTSPD27,CURRENTDIR27,CURRENTSPD28,CURRENTDIR28,CURRENTSPD29,CURRENTDIR29,CURRENTSPD30,CURRENTDIR30,CURRENTSPD31,CURRENTDIR31,CURRENTSPD32,CURRENTDIR32,CURRENTSPD33,CURRENTDIR33,CURRENTSPD34,CURRENTDIR34,CURRENTSPD35,CURRENTDIR35,CURRENTSPD36,CURRENTDIR36,CURRENTSPD37,CURRENTDIR37,MAXWAVEHIGH,MAXWAVEPIOD,TENTHWAVEHIGH,TENTHWAVEPIOD,AVEWAVEHIGH,AVEWAVEPIOD,WALIDWAVEHIGH,WALIDWAVEPIOD,WAVEDIR,WAVENUM,RESERV0,RESERV1,RESERV2,RESERV3,RESERV4,RESERV5,RESERV6,RESERV7,RESERV8,RESERV9");
            strSql.Append(") values (");
            strSql.Append(":DEVICECODE,:DTAETIME,:SENDNUM,:RECVNUM,:CURRENTSPD1,:CURRENTDIR1,:CURRENTSPD41,:CURRENTDIR41,:CURRENTSPD42,:CURRENTDIR42,:CURRENTSPD43,:CURRENTDIR43,:CURRENTSPD2,:CURRENTDIR2,:CURRENTSPD3,:CURRENTDIR3,:CURRENTSPD4,:CURRENTDIR4,:CURRENTSPD5,:CURRENTDIR5,:CURRENTSPD6,:CURRENTDIR6,:CURRENTSPD7,:CURRENTDIR7,:CURRENTSPD8,:CURRENTDIR8,:CURRENTSPD9,:CURRENTDIR9,:CURRENTSPD10,:CURRENTDIR10,:CURRENTSPD11,:CURRENTDIR11,:CURRENTSPD12,:CURRENTDIR12,:CURRENTSPD13,:CURRENTDIR13,:CURRENTSPD14,:CURRENTDIR14,:CURRENTSPD15,:CURRENTDIR15,:CURRENTSPD16,:CURRENTDIR16,:CURRENTSPD17,:CURRENTDIR17,:CURRENTSPD18,:CURRENTDIR18,:CURRENTSPD19,:CURRENTDIR19,:CURRENTSPD20,:CURRENTDIR20,:CURRENTSPD21,:CURRENTDIR21,:CURRENTSPD22,:CURRENTDIR22,:CURRENTSPD23,:CURRENTDIR23,:CURRENTSPD24,:CURRENTDIR24,:CURRENTSPD25,:CURRENTDIR25,:CURRENTSPD26,:CURRENTDIR26,:CURRENTSPD27,:CURRENTDIR27,:CURRENTSPD28,:CURRENTDIR28,:CURRENTSPD29,:CURRENTDIR29,:CURRENTSPD30,:CURRENTDIR30,:CURRENTSPD31,:CURRENTDIR31,:CURRENTSPD32,:CURRENTDIR32,:CURRENTSPD33,:CURRENTDIR33,:CURRENTSPD34,:CURRENTDIR34,:CURRENTSPD35,:CURRENTDIR35,:CURRENTSPD36,:CURRENTDIR36,:CURRENTSPD37,:CURRENTDIR37,:MAXWAVEHIGH,:MAXWAVEPIOD,:TENTHWAVEHIGH,:TENTHWAVEPIOD,:AVEWAVEHIGH,:AVEWAVEPIOD,:WALIDWAVEHIGH,:WALIDWAVEPIOD,:WAVEDIR,:WAVENUM,:RESERV0,:RESERV1,:RESERV2,:RESERV3,:RESERV4,:RESERV5,:RESERV6,:RESERV7,:RESERV8,:RESERV9");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DTAETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD1", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD41", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR41", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD42", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR42", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD43", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR43", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD2", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD3", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD4", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD5", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD6", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD7", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD8", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD9", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD10", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD11", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR11", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD12", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR12", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD13", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR13", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD14", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR14", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD15", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR15", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD16", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR16", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD17", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR17", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD18", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR18", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD19", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR19", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD20", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR20", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD21", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR21", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD22", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR22", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD23", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR23", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD24", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR24", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD25", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR25", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD26", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR26", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD27", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR27", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD28", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR28", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD29", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR29", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD30", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR30", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD31", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR31", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD32", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR32", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD33", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR33", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD34", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR34", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD35", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR35", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD36", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR36", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD37", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR37", OracleType.Number,22) ,            
                        new OracleParameter(":MAXWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":MAXWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":TENTHWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":TENTHWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":WALIDWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":WALIDWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":WAVEDIR", OracleType.Number,22) ,            
                        new OracleParameter(":WAVENUM", OracleType.Number,22) ,            
                        new OracleParameter(":RESERV0", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV1", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV2", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV3", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV4", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV5", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV6", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV7", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV8", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV9", OracleType.Number,16)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DTAETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.CURRENTSPD1;
            parameters[5].Value = model.CURRENTDIR1;
            parameters[6].Value = model.CURRENTSPD41;
            parameters[7].Value = model.CURRENTDIR41;
            parameters[8].Value = model.CURRENTSPD42;
            parameters[9].Value = model.CURRENTDIR42;
            parameters[10].Value = model.CURRENTSPD43;
            parameters[11].Value = model.CURRENTDIR43;
            parameters[12].Value = model.CURRENTSPD2;
            parameters[13].Value = model.CURRENTDIR2;
            parameters[14].Value = model.CURRENTSPD3;
            parameters[15].Value = model.CURRENTDIR3;
            parameters[16].Value = model.CURRENTSPD4;
            parameters[17].Value = model.CURRENTDIR4;
            parameters[18].Value = model.CURRENTSPD5;
            parameters[19].Value = model.CURRENTDIR5;
            parameters[20].Value = model.CURRENTSPD6;
            parameters[21].Value = model.CURRENTDIR6;
            parameters[22].Value = model.CURRENTSPD7;
            parameters[23].Value = model.CURRENTDIR7;
            parameters[24].Value = model.CURRENTSPD8;
            parameters[25].Value = model.CURRENTDIR8;
            parameters[26].Value = model.CURRENTSPD9;
            parameters[27].Value = model.CURRENTDIR9;
            parameters[28].Value = model.CURRENTSPD10;
            parameters[29].Value = model.CURRENTDIR10;
            parameters[30].Value = model.CURRENTSPD11;
            parameters[31].Value = model.CURRENTDIR11;
            parameters[32].Value = model.CURRENTSPD12;
            parameters[33].Value = model.CURRENTDIR12;
            parameters[34].Value = model.CURRENTSPD13;
            parameters[35].Value = model.CURRENTDIR13;
            parameters[36].Value = model.CURRENTSPD14;
            parameters[37].Value = model.CURRENTDIR14;
            parameters[38].Value = model.CURRENTSPD15;
            parameters[39].Value = model.CURRENTDIR15;
            parameters[40].Value = model.CURRENTSPD16;
            parameters[41].Value = model.CURRENTDIR16;
            parameters[42].Value = model.CURRENTSPD17;
            parameters[43].Value = model.CURRENTDIR17;
            parameters[44].Value = model.CURRENTSPD18;
            parameters[45].Value = model.CURRENTDIR18;
            parameters[46].Value = model.CURRENTSPD19;
            parameters[47].Value = model.CURRENTDIR19;
            parameters[48].Value = model.CURRENTSPD20;
            parameters[49].Value = model.CURRENTDIR20;
            parameters[50].Value = model.CURRENTSPD21;
            parameters[51].Value = model.CURRENTDIR21;
            parameters[52].Value = model.CURRENTSPD22;
            parameters[53].Value = model.CURRENTDIR22;
            parameters[54].Value = model.CURRENTSPD23;
            parameters[55].Value = model.CURRENTDIR23;
            parameters[56].Value = model.CURRENTSPD24;
            parameters[57].Value = model.CURRENTDIR24;
            parameters[58].Value = model.CURRENTSPD25;
            parameters[59].Value = model.CURRENTDIR25;
            parameters[60].Value = model.CURRENTSPD26;
            parameters[61].Value = model.CURRENTDIR26;
            parameters[62].Value = model.CURRENTSPD27;
            parameters[63].Value = model.CURRENTDIR27;
            parameters[64].Value = model.CURRENTSPD28;
            parameters[65].Value = model.CURRENTDIR28;
            parameters[66].Value = model.CURRENTSPD29;
            parameters[67].Value = model.CURRENTDIR29;
            parameters[68].Value = model.CURRENTSPD30;
            parameters[69].Value = model.CURRENTDIR30;
            parameters[70].Value = model.CURRENTSPD31;
            parameters[71].Value = model.CURRENTDIR31;
            parameters[72].Value = model.CURRENTSPD32;
            parameters[73].Value = model.CURRENTDIR32;
            parameters[74].Value = model.CURRENTSPD33;
            parameters[75].Value = model.CURRENTDIR33;
            parameters[76].Value = model.CURRENTSPD34;
            parameters[77].Value = model.CURRENTDIR34;
            parameters[78].Value = model.CURRENTSPD35;
            parameters[79].Value = model.CURRENTDIR35;
            parameters[80].Value = model.CURRENTSPD36;
            parameters[81].Value = model.CURRENTDIR36;
            parameters[82].Value = model.CURRENTSPD37;
            parameters[83].Value = model.CURRENTDIR37;
            parameters[84].Value = model.MAXWAVEHIGH;
            parameters[85].Value = model.MAXWAVEPIOD;
            parameters[86].Value = model.TENTHWAVEHIGH;
            parameters[87].Value = model.TENTHWAVEPIOD;
            parameters[88].Value = model.AVEWAVEHIGH;
            parameters[89].Value = model.AVEWAVEPIOD;
            parameters[90].Value = model.WALIDWAVEHIGH;
            parameters[91].Value = model.WALIDWAVEPIOD;
            parameters[92].Value = model.WAVEDIR;
            parameters[93].Value = model.WAVENUM;
            parameters[94].Value = model.RESERV0;
            parameters[95].Value = model.RESERV1;
            parameters[96].Value = model.RESERV2;
            parameters[97].Value = model.RESERV3;
            parameters[98].Value = model.RESERV4;
            parameters[99].Value = model.RESERV5;
            parameters[100].Value = model.RESERV6;
            parameters[101].Value = model.RESERV7;
            parameters[102].Value = model.RESERV8;
            parameters[103].Value = model.RESERV9;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.TABBUOYHYDROLOGY model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update TABBUOYHYDROLOGY set ");

            strSql.Append(" DEVICECODE = :DEVICECODE , ");
            strSql.Append(" DTAETIME = :DTAETIME , ");
            strSql.Append(" SENDNUM = :SENDNUM , ");
            strSql.Append(" RECVNUM = :RECVNUM , ");
            strSql.Append(" CURRENTSPD1 = :CURRENTSPD1 , ");
            strSql.Append(" CURRENTDIR1 = :CURRENTDIR1 , ");
            strSql.Append(" CURRENTSPD41 = :CURRENTSPD41 , ");
            strSql.Append(" CURRENTDIR41 = :CURRENTDIR41 , ");
            strSql.Append(" CURRENTSPD42 = :CURRENTSPD42 , ");
            strSql.Append(" CURRENTDIR42 = :CURRENTDIR42 , ");
            strSql.Append(" CURRENTSPD43 = :CURRENTSPD43 , ");
            strSql.Append(" CURRENTDIR43 = :CURRENTDIR43 , ");
            strSql.Append(" CURRENTSPD2 = :CURRENTSPD2 , ");
            strSql.Append(" CURRENTDIR2 = :CURRENTDIR2 , ");
            strSql.Append(" CURRENTSPD3 = :CURRENTSPD3 , ");
            strSql.Append(" CURRENTDIR3 = :CURRENTDIR3 , ");
            strSql.Append(" CURRENTSPD4 = :CURRENTSPD4 , ");
            strSql.Append(" CURRENTDIR4 = :CURRENTDIR4 , ");
            strSql.Append(" CURRENTSPD5 = :CURRENTSPD5 , ");
            strSql.Append(" CURRENTDIR5 = :CURRENTDIR5 , ");
            strSql.Append(" CURRENTSPD6 = :CURRENTSPD6 , ");
            strSql.Append(" CURRENTDIR6 = :CURRENTDIR6 , ");
            strSql.Append(" CURRENTSPD7 = :CURRENTSPD7 , ");
            strSql.Append(" CURRENTDIR7 = :CURRENTDIR7 , ");
            strSql.Append(" CURRENTSPD8 = :CURRENTSPD8 , ");
            strSql.Append(" CURRENTDIR8 = :CURRENTDIR8 , ");
            strSql.Append(" CURRENTSPD9 = :CURRENTSPD9 , ");
            strSql.Append(" CURRENTDIR9 = :CURRENTDIR9 , ");
            strSql.Append(" CURRENTSPD10 = :CURRENTSPD10 , ");
            strSql.Append(" CURRENTDIR10 = :CURRENTDIR10 , ");
            strSql.Append(" CURRENTSPD11 = :CURRENTSPD11 , ");
            strSql.Append(" CURRENTDIR11 = :CURRENTDIR11 , ");
            strSql.Append(" CURRENTSPD12 = :CURRENTSPD12 , ");
            strSql.Append(" CURRENTDIR12 = :CURRENTDIR12 , ");
            strSql.Append(" CURRENTSPD13 = :CURRENTSPD13 , ");
            strSql.Append(" CURRENTDIR13 = :CURRENTDIR13 , ");
            strSql.Append(" CURRENTSPD14 = :CURRENTSPD14 , ");
            strSql.Append(" CURRENTDIR14 = :CURRENTDIR14 , ");
            strSql.Append(" CURRENTSPD15 = :CURRENTSPD15 , ");
            strSql.Append(" CURRENTDIR15 = :CURRENTDIR15 , ");
            strSql.Append(" CURRENTSPD16 = :CURRENTSPD16 , ");
            strSql.Append(" CURRENTDIR16 = :CURRENTDIR16 , ");
            strSql.Append(" CURRENTSPD17 = :CURRENTSPD17 , ");
            strSql.Append(" CURRENTDIR17 = :CURRENTDIR17 , ");
            strSql.Append(" CURRENTSPD18 = :CURRENTSPD18 , ");
            strSql.Append(" CURRENTDIR18 = :CURRENTDIR18 , ");
            strSql.Append(" CURRENTSPD19 = :CURRENTSPD19 , ");
            strSql.Append(" CURRENTDIR19 = :CURRENTDIR19 , ");
            strSql.Append(" CURRENTSPD20 = :CURRENTSPD20 , ");
            strSql.Append(" CURRENTDIR20 = :CURRENTDIR20 , ");
            strSql.Append(" CURRENTSPD21 = :CURRENTSPD21 , ");
            strSql.Append(" CURRENTDIR21 = :CURRENTDIR21 , ");
            strSql.Append(" CURRENTSPD22 = :CURRENTSPD22 , ");
            strSql.Append(" CURRENTDIR22 = :CURRENTDIR22 , ");
            strSql.Append(" CURRENTSPD23 = :CURRENTSPD23 , ");
            strSql.Append(" CURRENTDIR23 = :CURRENTDIR23 , ");
            strSql.Append(" CURRENTSPD24 = :CURRENTSPD24 , ");
            strSql.Append(" CURRENTDIR24 = :CURRENTDIR24 , ");
            strSql.Append(" CURRENTSPD25 = :CURRENTSPD25 , ");
            strSql.Append(" CURRENTDIR25 = :CURRENTDIR25 , ");
            strSql.Append(" CURRENTSPD26 = :CURRENTSPD26 , ");
            strSql.Append(" CURRENTDIR26 = :CURRENTDIR26 , ");
            strSql.Append(" CURRENTSPD27 = :CURRENTSPD27 , ");
            strSql.Append(" CURRENTDIR27 = :CURRENTDIR27 , ");
            strSql.Append(" CURRENTSPD28 = :CURRENTSPD28 , ");
            strSql.Append(" CURRENTDIR28 = :CURRENTDIR28 , ");
            strSql.Append(" CURRENTSPD29 = :CURRENTSPD29 , ");
            strSql.Append(" CURRENTDIR29 = :CURRENTDIR29 , ");
            strSql.Append(" CURRENTSPD30 = :CURRENTSPD30 , ");
            strSql.Append(" CURRENTDIR30 = :CURRENTDIR30 , ");
            strSql.Append(" CURRENTSPD31 = :CURRENTSPD31 , ");
            strSql.Append(" CURRENTDIR31 = :CURRENTDIR31 , ");
            strSql.Append(" CURRENTSPD32 = :CURRENTSPD32 , ");
            strSql.Append(" CURRENTDIR32 = :CURRENTDIR32 , ");
            strSql.Append(" CURRENTSPD33 = :CURRENTSPD33 , ");
            strSql.Append(" CURRENTDIR33 = :CURRENTDIR33 , ");
            strSql.Append(" CURRENTSPD34 = :CURRENTSPD34 , ");
            strSql.Append(" CURRENTDIR34 = :CURRENTDIR34 , ");
            strSql.Append(" CURRENTSPD35 = :CURRENTSPD35 , ");
            strSql.Append(" CURRENTDIR35 = :CURRENTDIR35 , ");
            strSql.Append(" CURRENTSPD36 = :CURRENTSPD36 , ");
            strSql.Append(" CURRENTDIR36 = :CURRENTDIR36 , ");
            strSql.Append(" CURRENTSPD37 = :CURRENTSPD37 , ");
            strSql.Append(" CURRENTDIR37 = :CURRENTDIR37 , ");
            strSql.Append(" MAXWAVEHIGH = :MAXWAVEHIGH , ");
            strSql.Append(" MAXWAVEPIOD = :MAXWAVEPIOD , ");
            strSql.Append(" TENTHWAVEHIGH = :TENTHWAVEHIGH , ");
            strSql.Append(" TENTHWAVEPIOD = :TENTHWAVEPIOD , ");
            strSql.Append(" AVEWAVEHIGH = :AVEWAVEHIGH , ");
            strSql.Append(" AVEWAVEPIOD = :AVEWAVEPIOD , ");
            strSql.Append(" WALIDWAVEHIGH = :WALIDWAVEHIGH , ");
            strSql.Append(" WALIDWAVEPIOD = :WALIDWAVEPIOD , ");
            strSql.Append(" WAVEDIR = :WAVEDIR , ");
            strSql.Append(" WAVENUM = :WAVENUM , ");
            strSql.Append(" RESERV0 = :RESERV0 , ");
            strSql.Append(" RESERV1 = :RESERV1 , ");
            strSql.Append(" RESERV2 = :RESERV2 , ");
            strSql.Append(" RESERV3 = :RESERV3 , ");
            strSql.Append(" RESERV4 = :RESERV4 , ");
            strSql.Append(" RESERV5 = :RESERV5 , ");
            strSql.Append(" RESERV6 = :RESERV6 , ");
            strSql.Append(" RESERV7 = :RESERV7 , ");
            strSql.Append(" RESERV8 = :RESERV8 , ");
            strSql.Append(" RESERV9 = :RESERV9  ");
            strSql.Append(" where  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DTAETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD1", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD41", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR41", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD42", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR42", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD43", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR43", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD2", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD3", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD4", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD5", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD6", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD7", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD8", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD9", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD10", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD11", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR11", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD12", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR12", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD13", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR13", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD14", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR14", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD15", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR15", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD16", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR16", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD17", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR17", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD18", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR18", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD19", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR19", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD20", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR20", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD21", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR21", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD22", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR22", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD23", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR23", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD24", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR24", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD25", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR25", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD26", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR26", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD27", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR27", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD28", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR28", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD29", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR29", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD30", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR30", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD31", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR31", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD32", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR32", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD33", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR33", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD34", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR34", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD35", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR35", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD36", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR36", OracleType.Number,22) ,            
                        new OracleParameter(":CURRENTSPD37", OracleType.Number,16) ,            
                        new OracleParameter(":CURRENTDIR37", OracleType.Number,22) ,            
                        new OracleParameter(":MAXWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":MAXWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":TENTHWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":TENTHWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":AVEWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":WALIDWAVEHIGH", OracleType.Number,16) ,            
                        new OracleParameter(":WALIDWAVEPIOD", OracleType.Number,16) ,            
                        new OracleParameter(":WAVEDIR", OracleType.Number,22) ,            
                        new OracleParameter(":WAVENUM", OracleType.Number,22) ,            
                        new OracleParameter(":RESERV0", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV1", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV2", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV3", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV4", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV5", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV6", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV7", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV8", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV9", OracleType.Number,16)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DTAETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.CURRENTSPD1;
            parameters[5].Value = model.CURRENTDIR1;
            parameters[6].Value = model.CURRENTSPD41;
            parameters[7].Value = model.CURRENTDIR41;
            parameters[8].Value = model.CURRENTSPD42;
            parameters[9].Value = model.CURRENTDIR42;
            parameters[10].Value = model.CURRENTSPD43;
            parameters[11].Value = model.CURRENTDIR43;
            parameters[12].Value = model.CURRENTSPD2;
            parameters[13].Value = model.CURRENTDIR2;
            parameters[14].Value = model.CURRENTSPD3;
            parameters[15].Value = model.CURRENTDIR3;
            parameters[16].Value = model.CURRENTSPD4;
            parameters[17].Value = model.CURRENTDIR4;
            parameters[18].Value = model.CURRENTSPD5;
            parameters[19].Value = model.CURRENTDIR5;
            parameters[20].Value = model.CURRENTSPD6;
            parameters[21].Value = model.CURRENTDIR6;
            parameters[22].Value = model.CURRENTSPD7;
            parameters[23].Value = model.CURRENTDIR7;
            parameters[24].Value = model.CURRENTSPD8;
            parameters[25].Value = model.CURRENTDIR8;
            parameters[26].Value = model.CURRENTSPD9;
            parameters[27].Value = model.CURRENTDIR9;
            parameters[28].Value = model.CURRENTSPD10;
            parameters[29].Value = model.CURRENTDIR10;
            parameters[30].Value = model.CURRENTSPD11;
            parameters[31].Value = model.CURRENTDIR11;
            parameters[32].Value = model.CURRENTSPD12;
            parameters[33].Value = model.CURRENTDIR12;
            parameters[34].Value = model.CURRENTSPD13;
            parameters[35].Value = model.CURRENTDIR13;
            parameters[36].Value = model.CURRENTSPD14;
            parameters[37].Value = model.CURRENTDIR14;
            parameters[38].Value = model.CURRENTSPD15;
            parameters[39].Value = model.CURRENTDIR15;
            parameters[40].Value = model.CURRENTSPD16;
            parameters[41].Value = model.CURRENTDIR16;
            parameters[42].Value = model.CURRENTSPD17;
            parameters[43].Value = model.CURRENTDIR17;
            parameters[44].Value = model.CURRENTSPD18;
            parameters[45].Value = model.CURRENTDIR18;
            parameters[46].Value = model.CURRENTSPD19;
            parameters[47].Value = model.CURRENTDIR19;
            parameters[48].Value = model.CURRENTSPD20;
            parameters[49].Value = model.CURRENTDIR20;
            parameters[50].Value = model.CURRENTSPD21;
            parameters[51].Value = model.CURRENTDIR21;
            parameters[52].Value = model.CURRENTSPD22;
            parameters[53].Value = model.CURRENTDIR22;
            parameters[54].Value = model.CURRENTSPD23;
            parameters[55].Value = model.CURRENTDIR23;
            parameters[56].Value = model.CURRENTSPD24;
            parameters[57].Value = model.CURRENTDIR24;
            parameters[58].Value = model.CURRENTSPD25;
            parameters[59].Value = model.CURRENTDIR25;
            parameters[60].Value = model.CURRENTSPD26;
            parameters[61].Value = model.CURRENTDIR26;
            parameters[62].Value = model.CURRENTSPD27;
            parameters[63].Value = model.CURRENTDIR27;
            parameters[64].Value = model.CURRENTSPD28;
            parameters[65].Value = model.CURRENTDIR28;
            parameters[66].Value = model.CURRENTSPD29;
            parameters[67].Value = model.CURRENTDIR29;
            parameters[68].Value = model.CURRENTSPD30;
            parameters[69].Value = model.CURRENTDIR30;
            parameters[70].Value = model.CURRENTSPD31;
            parameters[71].Value = model.CURRENTDIR31;
            parameters[72].Value = model.CURRENTSPD32;
            parameters[73].Value = model.CURRENTDIR32;
            parameters[74].Value = model.CURRENTSPD33;
            parameters[75].Value = model.CURRENTDIR33;
            parameters[76].Value = model.CURRENTSPD34;
            parameters[77].Value = model.CURRENTDIR34;
            parameters[78].Value = model.CURRENTSPD35;
            parameters[79].Value = model.CURRENTDIR35;
            parameters[80].Value = model.CURRENTSPD36;
            parameters[81].Value = model.CURRENTDIR36;
            parameters[82].Value = model.CURRENTSPD37;
            parameters[83].Value = model.CURRENTDIR37;
            parameters[84].Value = model.MAXWAVEHIGH;
            parameters[85].Value = model.MAXWAVEPIOD;
            parameters[86].Value = model.TENTHWAVEHIGH;
            parameters[87].Value = model.TENTHWAVEPIOD;
            parameters[88].Value = model.AVEWAVEHIGH;
            parameters[89].Value = model.AVEWAVEPIOD;
            parameters[90].Value = model.WALIDWAVEHIGH;
            parameters[91].Value = model.WALIDWAVEPIOD;
            parameters[92].Value = model.WAVEDIR;
            parameters[93].Value = model.WAVENUM;
            parameters[94].Value = model.RESERV0;
            parameters[95].Value = model.RESERV1;
            parameters[96].Value = model.RESERV2;
            parameters[97].Value = model.RESERV3;
            parameters[98].Value = model.RESERV4;
            parameters[99].Value = model.RESERV5;
            parameters[100].Value = model.RESERV6;
            parameters[101].Value = model.RESERV7;
            parameters[102].Value = model.RESERV8;
            parameters[103].Value = model.RESERV9;
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
            strSql.Append("delete from TABBUOYHYDROLOGY ");
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
        /// 获取浮标的水文数据：波浪
        /// </summary>
        public Entity.TABBUOYHYDROLOGY GetModel(string deviceCode)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append(" SELECT DTAETIME,MAXWAVEHIGH, MAXWAVEPIOD, TENTHWAVEHIGH, TENTHWAVEPIOD, AVEWAVEHIGH,AVEWAVEPIOD, WALIDWAVEHIGH, WALIDWAVEPIOD, WAVEDIR, WAVENUM ");
            strSql.Append(" FROM TABBUOYHYDROLOGY ");
            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
            strSql.Append(" AND DTAETIME=(SELECT MAX(DTAETIME) DTAETIME FROM TABBUOYHYDROLOGY WHERE DEVICECODE=:DEVICECODE) ");

            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            dbHelper.OpenConn("");
            Entity.TABBUOYHYDROLOGY model = new Entity.TABBUOYHYDROLOGY();
            DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

            dbHelper.CloseConn();
            if (ds.Rows.Count > 0)
            {
                //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                if (ds.Rows[0]["DTAETIME"].ToString() != "")
                {
                    model.DTAETIME = DateTime.Parse(ds.Rows[0]["DTAETIME"].ToString());
                }
                if (ds.Rows[0]["MAXWAVEHIGH"].ToString() != "")
                {
                    model.MAXWAVEHIGH = decimal.Parse(ds.Rows[0]["MAXWAVEHIGH"].ToString());
                }
                if (ds.Rows[0]["MAXWAVEPIOD"].ToString() != "")
                {
                    model.MAXWAVEPIOD = decimal.Parse(ds.Rows[0]["MAXWAVEPIOD"].ToString());
                }
                if (ds.Rows[0]["TENTHWAVEHIGH"].ToString() != "")
                {
                    model.TENTHWAVEHIGH = decimal.Parse(ds.Rows[0]["TENTHWAVEHIGH"].ToString());
                }
                if (ds.Rows[0]["TENTHWAVEPIOD"].ToString() != "")
                {
                    model.TENTHWAVEPIOD = decimal.Parse(ds.Rows[0]["TENTHWAVEPIOD"].ToString());
                }
                if (ds.Rows[0]["AVEWAVEHIGH"].ToString() != "")
                {
                    model.AVEWAVEHIGH = decimal.Parse(ds.Rows[0]["AVEWAVEHIGH"].ToString());
                }
                if (ds.Rows[0]["AVEWAVEPIOD"].ToString() != "")
                {
                    model.AVEWAVEPIOD = decimal.Parse(ds.Rows[0]["AVEWAVEPIOD"].ToString());
                }
                if (ds.Rows[0]["WALIDWAVEHIGH"].ToString() != "")
                {
                    model.WALIDWAVEHIGH = decimal.Parse(ds.Rows[0]["WALIDWAVEHIGH"].ToString());
                }
                if (ds.Rows[0]["WALIDWAVEPIOD"].ToString() != "")
                {
                    model.WALIDWAVEPIOD = decimal.Parse(ds.Rows[0]["WALIDWAVEPIOD"].ToString());
                }
                if (ds.Rows[0]["WAVEDIR"].ToString() != "")
                {
                    model.WAVEDIR = decimal.Parse(ds.Rows[0]["WAVEDIR"].ToString());
                }
                if (ds.Rows[0]["WAVENUM"].ToString() != "")
                {
                    model.WAVENUM = decimal.Parse(ds.Rows[0]["WAVENUM"].ToString());
                }

                return model;
            }
            else
            {
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
            strSql.Append(" FROM TABBUOYHYDROLOGY ");
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
            strSql.Append(" FROM TABBUOYHYDROLOGY ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }


    }
}

