﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;

namespace Business.BN
{
    /// <summary>
    /// 状态信息表(岸基站)
    /// </summary>
    public class TABSTATUS_BN
    {

        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from TABSTATUS");
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
        public void Add(Entity.TABSTATUS model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into TABSTATUS(");
            strSql.Append("DEVICECODE,DATETIME,SENDNUM,RECVNUM,TEMPERATURE,POWERSTATUS,FREEMEMO,WATERALARM,DOORALARM,SMOGALARM,STATIONSTATUS,RESERV0,RESERV1,RESERV2,HUMI");
            strSql.Append(") values (");
            strSql.Append(":DEVICECODE,:DATETIME,:SENDNUM,:RECVNUM,:TEMPERATURE,:POWERSTATUS,:FREEMEMO,:WATERALARM,:DOORALARM,:SMOGALARM,,:STATIONSTATUS,:RESERV0,:RESERV1,:RESERV2,:HUMI");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DATETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":TEMPERATURE", OracleType.Number,16) ,            
                        new OracleParameter(":POWERSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":FREEMEMO", OracleType.Number,22) ,            
                        new OracleParameter(":WATERALARM", OracleType.Number,22) ,            
                        new OracleParameter(":DOORALARM", OracleType.Number,22) ,            
                        new OracleParameter(":SMOGALARM", OracleType.Number,22) ,            
                        //new OracleParameter(":SENSERSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":STATIONSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":RESERV0", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV1", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV2", OracleType.Number,16),             
                        new OracleParameter(":HUMI", OracleType.Number,22)             
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DATETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.TEMPERATURE;
            parameters[5].Value = model.POWERSTATUS;
            parameters[6].Value = model.FREEMEMO;
            parameters[7].Value = model.WATERALARM;
            parameters[8].Value = model.DOORALARM;
            parameters[9].Value = model.SMOGALARM;
            //parameters[10].Value = model.SENSERSTATUS;
            parameters[11].Value = model.STATIONSTATUS;
            parameters[12].Value = model.RESERV0;
            parameters[13].Value = model.RESERV1;
            parameters[14].Value = model.RESERV2;
            parameters[15].Value = model.HUMI;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.TABSTATUS model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update TABSTATUS set ");

            strSql.Append(" DEVICECODE = :DEVICECODE , ");
            strSql.Append(" DATETIME = :DATETIME , ");
            strSql.Append(" SENDNUM = :SENDNUM , ");
            strSql.Append(" RECVNUM = :RECVNUM , ");
            strSql.Append(" TEMPERATURE = :TEMPERATURE , ");
            strSql.Append(" POWERSTATUS = :POWERSTATUS , ");
            strSql.Append(" FREEMEMO = :FREEMEMO , ");
            strSql.Append(" WATERALARM = :WATERALARM , ");
            strSql.Append(" DOORALARM = :DOORALARM , ");
            strSql.Append(" SMOGALARM = :SMOGALARM , ");
            //strSql.Append(" SENSERSTATUS = :SENSERSTATUS , ");
            strSql.Append(" STATIONSTATUS = :STATIONSTATUS , ");
            strSql.Append(" RESERV0 = :RESERV0 , ");
            strSql.Append(" RESERV1 = :RESERV1 , ");
            strSql.Append(" RESERV2 = :RESERV2 , ");
            strSql.Append(" HUMI = :HUMI  ");
            strSql.Append(" where  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DATETIME", OracleType.DateTime) ,            
                        new OracleParameter(":SENDNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RECVNUM", OracleType.Number,22) ,            
                        new OracleParameter(":TEMPERATURE", OracleType.Number,16) ,            
                        new OracleParameter(":POWERSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":FREEMEMO", OracleType.Number,22) ,            
                        new OracleParameter(":WATERALARM", OracleType.Number,22) ,            
                        new OracleParameter(":DOORALARM", OracleType.Number,22) ,            
                        new OracleParameter(":SMOGALARM", OracleType.Number,22) ,            
                        //new OracleParameter(":SENSERSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":STATIONSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":RESERV0", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV1", OracleType.Number,16) ,            
                        new OracleParameter(":RESERV2", OracleType.Number,16) ,             
                        new OracleParameter(":HUMI", OracleType.Number,22)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DATETIME;
            parameters[2].Value = model.SENDNUM;
            parameters[3].Value = model.RECVNUM;
            parameters[4].Value = model.TEMPERATURE;
            parameters[5].Value = model.POWERSTATUS;
            parameters[6].Value = model.FREEMEMO;
            parameters[7].Value = model.WATERALARM;
            parameters[8].Value = model.DOORALARM;
            parameters[9].Value = model.SMOGALARM;
            //parameters[10].Value = model.SENSERSTATUS;
            parameters[11].Value = model.STATIONSTATUS;
            parameters[12].Value = model.RESERV0;
            parameters[13].Value = model.RESERV1;
            parameters[14].Value = model.RESERV2;
            parameters[15].Value = model.HUMI;
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
            strSql.Append("delete from TABSTATUS ");
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
        /// 获取岸基站的设备状态信息
        /// </summary>
        public Entity.TABSTATUS GetModel(string deviceCode)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append(" SELECT DATETIME, SENDNUM, RECVNUM, TEMPERATURE, POWERSTATUS, FREEMEMO, WATERALARM, DOORALARM, SMOGALARM, STATIONSTATUS, HUMI ");
            strSql.Append(" FROM TABSTATUS ");
            strSql.Append(" WHERE DEVICECODE=:DEVICECODE ");
            strSql.Append(" AND DATETIME=(SELECT MAX(DATETIME) DATETIME FROM TABSTATUS WHERE DEVICECODE=:DEVICECODE) ");
            OracleParameter[] parameters = {
                    new OracleParameter(":DEVICECODE",deviceCode)
			};

            try
            {
                dbHelper.OpenConn("");
                Entity.TABSTATUS model = new Entity.TABSTATUS();
                DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

                dbHelper.CloseConn();
                if (ds.Rows.Count > 0)
                {
                    //model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                    if (ds.Rows[0]["DATETIME"].ToString() != "")
                    {
                        model.DATETIME = DateTime.Parse(ds.Rows[0]["DATETIME"].ToString());
                    }
                    if (ds.Rows[0]["SENDNUM"].ToString() != "")
                    {
                        model.SENDNUM = decimal.Parse(ds.Rows[0]["SENDNUM"].ToString());
                    }
                    if (ds.Rows[0]["RECVNUM"].ToString() != "")
                    {
                        model.RECVNUM = decimal.Parse(ds.Rows[0]["RECVNUM"].ToString());
                    }
                    if (ds.Rows[0]["TEMPERATURE"].ToString() != "")
                    {
                        model.TEMPERATURE = decimal.Parse(ds.Rows[0]["TEMPERATURE"].ToString());
                    }
                    if (ds.Rows[0]["POWERSTATUS"].ToString() != "")
                    {
                        model.POWERSTATUS = decimal.Parse(ds.Rows[0]["POWERSTATUS"].ToString());
                    }
                    if (ds.Rows[0]["FREEMEMO"].ToString() != "")
                    {
                        model.FREEMEMO = decimal.Parse(ds.Rows[0]["FREEMEMO"].ToString());
                    }
                    if (ds.Rows[0]["WATERALARM"].ToString() != "")
                    {
                        model.WATERALARM = decimal.Parse(ds.Rows[0]["WATERALARM"].ToString());
                    }
                    if (ds.Rows[0]["DOORALARM"].ToString() != "")
                    {
                        model.DOORALARM = decimal.Parse(ds.Rows[0]["DOORALARM"].ToString());
                    }
                    if (ds.Rows[0]["SMOGALARM"].ToString() != "")
                    {
                        model.SMOGALARM = decimal.Parse(ds.Rows[0]["SMOGALARM"].ToString());
                    }
                    if (ds.Rows[0]["STATIONSTATUS"].ToString() != "")
                    {
                        model.STATIONSTATUS = decimal.Parse(ds.Rows[0]["STATIONSTATUS"].ToString());
                    }
                    if (ds.Rows[0]["HUMI"].ToString() != "")
                    {
                        model.HUMI = decimal.Parse(ds.Rows[0]["HUMI"].ToString());
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
                LogBN.WriteLog(typeof(TABSTATUS_BN), "GetModel 程序段的异常" + ex);
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
            strSql.Append(" FROM TABSTATUS ");
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
            strSql.Append(" FROM TABSTATUS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }


    }
}

