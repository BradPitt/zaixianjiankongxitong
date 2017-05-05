using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;

namespace Business.BN
{
    /// <summary>
    /// 气象数据表(岸基站)
    /// </summary>
    public class TABQIXG_BN
    {

        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from TABQIXG");
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
        public void Add(Entity.TABQIXG model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into TABQIXG(");
            strSql.Append("DEVICECODE,DATETIME,SENDNUM,RECVNUM,NJD,RAINFALL,TOTALRADIATION,INFRAREDRADIATION,SUNLIGHTTIME,AIRCO2,AIRTEM,HUMI,PRESSURE,WINDSPD1,WINDDIR1,WINDSPD2,WINDDIR2,WINDSPD3,WINDDIR3,WINDSPD4,WINDDIR4,WINDSPD5,WINDDIR5,WINDSPD6,WINDDIR6,WINDSPD7,WINDDIR7,WINDSPD8,WINDDIR8,WINDSPD9,WINDDIR9,WINDSPD10,WINDDIR10,AVESPD,AVEDIR,RESERV0,RESERV1,RESERV2,RESERV3,RESERV4,RESERV5,RESERV6,RESERV7,RESERV8,RESERV9");
            strSql.Append(") values (");
            strSql.Append(":DEVICECODE,:DATETIME,:SENDNUM,:RECVNUM,:NJD,:RAINFALL,:TOTALRADIATION,:INFRAREDRADIATION,:SUNLIGHTTIME,:AIRCO2,:AIRTEM,:HUMI,:PRESSURE,:WINDSPD1,:WINDDIR1,:WINDSPD2,:WINDDIR2,:WINDSPD3,:WINDDIR3,:WINDSPD4,:WINDDIR4,:WINDSPD5,:WINDDIR5,:WINDSPD6,:WINDDIR6,:WINDSPD7,:WINDDIR7,:WINDSPD8,:WINDDIR8,:WINDSPD9,:WINDDIR9,:WINDSPD10,:WINDDIR10,:AVESPD,:AVEDIR,:RESERV0,:RESERV1,:RESERV2,:RESERV3,:RESERV4,:RESERV5,:RESERV6,:RESERV7,:RESERV8,:RESERV9");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DATETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":NJD", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALL", OracleType.Number,22) ,            
                        new OracleParameter(":TOTALRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":INFRAREDRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":SUNLIGHTTIME", OracleType.Number,22) ,            
                        new OracleParameter(":AIRCO2", OracleType.Number,22) ,            
                        new OracleParameter(":AIRTEM", OracleType.Number,16) ,            
                        new OracleParameter(":HUMI", OracleType.Number,22) ,            
                        new OracleParameter(":PRESSURE", OracleType.Number,16) ,            
                        new OracleParameter(":WINDSPD1", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD2", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD3", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD4", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD5", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD6", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD7", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD8", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD9", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD10", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":AVESPD", OracleType.Number,16) ,            
                        new OracleParameter(":AVEDIR", OracleType.Number,22) ,            
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
            parameters[1].Value = model.DATETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.NJD;
            parameters[5].Value = model.RAINFALL;
            parameters[6].Value = model.TOTALRADIATION;
            parameters[7].Value = model.INFRAREDRADIATION;
            parameters[8].Value = model.SUNLIGHTTIME;
            parameters[9].Value = model.AIRCO2;
            parameters[10].Value = model.AIRTEM;
            parameters[11].Value = model.HUMI;
            parameters[12].Value = model.PRESSURE;
            parameters[13].Value = model.WINDSPD1;
            parameters[14].Value = model.WINDDIR1;
            parameters[15].Value = model.WINDSPD2;
            parameters[16].Value = model.WINDDIR2;
            parameters[17].Value = model.WINDSPD3;
            parameters[18].Value = model.WINDDIR3;
            parameters[19].Value = model.WINDSPD4;
            parameters[20].Value = model.WINDDIR4;
            parameters[21].Value = model.WINDSPD5;
            parameters[22].Value = model.WINDDIR5;
            parameters[23].Value = model.WINDSPD6;
            parameters[24].Value = model.WINDDIR6;
            parameters[25].Value = model.WINDSPD7;
            parameters[26].Value = model.WINDDIR7;
            parameters[27].Value = model.WINDSPD8;
            parameters[28].Value = model.WINDDIR8;
            parameters[29].Value = model.WINDSPD9;
            parameters[30].Value = model.WINDDIR9;
            parameters[31].Value = model.WINDSPD10;
            parameters[32].Value = model.WINDDIR10;
            parameters[33].Value = model.AVESPD;
            parameters[34].Value = model.AVEDIR;
            parameters[35].Value = model.RESERV0;
            parameters[36].Value = model.RESERV1;
            parameters[37].Value = model.RESERV2;
            parameters[38].Value = model.RESERV3;
            parameters[39].Value = model.RESERV4;
            parameters[40].Value = model.RESERV5;
            parameters[41].Value = model.RESERV6;
            parameters[42].Value = model.RESERV7;
            parameters[43].Value = model.RESERV8;
            parameters[44].Value = model.RESERV9;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.TABQIXG model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update TABQIXG set ");

            strSql.Append(" DEVICECODE = :DEVICECODE , ");
            strSql.Append(" DATETIME = :DATETIME , ");
            strSql.Append(" SENDNUM = :SENDNUM , ");
            strSql.Append(" RECVNUM = :RECVNUM , ");
            strSql.Append(" NJD = :NJD , ");
            strSql.Append(" RAINFALL = :RAINFALL , ");
            strSql.Append(" TOTALRADIATION = :TOTALRADIATION , ");
            strSql.Append(" INFRAREDRADIATION = :INFRAREDRADIATION , ");
            strSql.Append(" SUNLIGHTTIME = :SUNLIGHTTIME , ");
            strSql.Append(" AIRCO2 = :AIRCO2 , ");
            strSql.Append(" AIRTEM = :AIRTEM , ");
            strSql.Append(" HUMI = :HUMI , ");
            strSql.Append(" PRESSURE = :PRESSURE , ");
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
            strSql.Append(" AVESPD = :AVESPD , ");
            strSql.Append(" AVEDIR = :AVEDIR , ");
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
                        new OracleParameter(":DATETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":NJD", OracleType.Number,22) ,            
                        new OracleParameter(":RAINFALL", OracleType.Number,22) ,            
                        new OracleParameter(":TOTALRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":INFRAREDRADIATION", OracleType.Number,22) ,            
                        new OracleParameter(":SUNLIGHTTIME", OracleType.Number,22) ,            
                        new OracleParameter(":AIRCO2", OracleType.Number,22) ,            
                        new OracleParameter(":AIRTEM", OracleType.Number,16) ,            
                        new OracleParameter(":HUMI", OracleType.Number,22) ,            
                        new OracleParameter(":PRESSURE", OracleType.Number,16) ,            
                        new OracleParameter(":WINDSPD1", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR1", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD2", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR2", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD3", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR3", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD4", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR4", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD5", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR5", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD6", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR6", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD7", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR7", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD8", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR8", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD9", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR9", OracleType.Number,22) ,            
                        new OracleParameter(":WINDSPD10", OracleType.Number,16) ,            
                        new OracleParameter(":WINDDIR10", OracleType.Number,22) ,            
                        new OracleParameter(":AVESPD", OracleType.Number,16) ,            
                        new OracleParameter(":AVEDIR", OracleType.Number,22) ,            
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
            parameters[1].Value = model.DATETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.NJD;
            parameters[5].Value = model.RAINFALL;
            parameters[6].Value = model.TOTALRADIATION;
            parameters[7].Value = model.INFRAREDRADIATION;
            parameters[8].Value = model.SUNLIGHTTIME;
            parameters[9].Value = model.AIRCO2;
            parameters[10].Value = model.AIRTEM;
            parameters[11].Value = model.HUMI;
            parameters[12].Value = model.PRESSURE;
            parameters[13].Value = model.WINDSPD1;
            parameters[14].Value = model.WINDDIR1;
            parameters[15].Value = model.WINDSPD2;
            parameters[16].Value = model.WINDDIR2;
            parameters[17].Value = model.WINDSPD3;
            parameters[18].Value = model.WINDDIR3;
            parameters[19].Value = model.WINDSPD4;
            parameters[20].Value = model.WINDDIR4;
            parameters[21].Value = model.WINDSPD5;
            parameters[22].Value = model.WINDDIR5;
            parameters[23].Value = model.WINDSPD6;
            parameters[24].Value = model.WINDDIR6;
            parameters[25].Value = model.WINDSPD7;
            parameters[26].Value = model.WINDDIR7;
            parameters[27].Value = model.WINDSPD8;
            parameters[28].Value = model.WINDDIR8;
            parameters[29].Value = model.WINDSPD9;
            parameters[30].Value = model.WINDDIR9;
            parameters[31].Value = model.WINDSPD10;
            parameters[32].Value = model.WINDDIR10;
            parameters[33].Value = model.AVESPD;
            parameters[34].Value = model.AVEDIR;
            parameters[35].Value = model.RESERV0;
            parameters[36].Value = model.RESERV1;
            parameters[37].Value = model.RESERV2;
            parameters[38].Value = model.RESERV3;
            parameters[39].Value = model.RESERV4;
            parameters[40].Value = model.RESERV5;
            parameters[41].Value = model.RESERV6;
            parameters[42].Value = model.RESERV7;
            parameters[43].Value = model.RESERV8;
            parameters[44].Value = model.RESERV9;
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
            strSql.Append("delete from TABQIXG ");
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
        /// 获取岸基站气象数据信息
        /// </summary>
        public Entity.TABQIXG GetModel(string deviceCode)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append(" SELECT DATETIME, RAINFALL, AIRTEM, PRESSURE, NJD, AVESPD, AVEDIR ");
            strSql.Append(" FROM TABQIXG ");
            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM TABQIXG WHERE DEVICECODE=:DEVICECODE) ");

            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            Entity.TABQIXG model = new Entity.TABQIXG();
            DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

            if (ds.Rows.Count > 0)
            {
                //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                if (ds.Rows[0]["DATETIME"].ToString() != "")
                {
                    model.DATETIME = DateTime.Parse(ds.Rows[0]["DATETIME"].ToString());
                }
                if (ds.Rows[0]["RAINFALL"].ToString() != "")
                {
                    model.RAINFALL = decimal.Parse(ds.Rows[0]["RAINFALL"].ToString());
                }
                if (ds.Rows[0]["AIRTEM"].ToString() != "")
                {
                    model.AIRTEM = decimal.Parse(ds.Rows[0]["AIRTEM"].ToString());
                }
                if (ds.Rows[0]["PRESSURE"].ToString() != "")
                {
                    model.PRESSURE = decimal.Parse(ds.Rows[0]["PRESSURE"].ToString());
                }
                if (ds.Rows[0]["NJD"].ToString() != "")
                {
                    model.NJD = decimal.Parse(ds.Rows[0]["NJD"].ToString());
                }
                if (ds.Rows[0]["AVESPD"].ToString() != "")
                {
                    model.AVESPD = decimal.Parse(ds.Rows[0]["AVESPD"].ToString());
                }
                if (ds.Rows[0]["AVEDIR"].ToString() != "")
                {
                    model.AVEDIR = decimal.Parse(ds.Rows[0]["AVEDIR"].ToString());
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
            strSql.Append(" FROM TABQIXG ");
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
            strSql.Append(" FROM TABQIXG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }


    }
}

