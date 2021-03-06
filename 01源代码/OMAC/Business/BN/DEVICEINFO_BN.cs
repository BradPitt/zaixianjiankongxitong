﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;
using Entity;

namespace Business.BN
{
    public class DEVICEINFO_BN
    {

        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from DEVICEINFO");
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
        public void Add(Entity.DEVICEINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into DEVICEINFO(");
            strSql.Append("DEVICECODE,DEVICENAME,DEVICEUSER,DEVICETYPE,LAYTIME,ELON,ELAT,COMTYPE,STRUCTTYPE,COMARRAY,PACKNUM,RUNNINGSTATUS,POSITION,PRODUCER,MANAGER,RESERV0,RESERV1,RESERV2");
            strSql.Append(") values (");
            strSql.Append(":DEVICECODE,:DEVICENAME,:DEVICEUSER,:DEVICETYPE,:LAYTIME,:ELON,:ELAT,:COMTYPE,:STRUCTTYPE,:COMARRAY,:PACKNUM,:RUNNINGSTATUS,:POSITION,:PRODUCER,:MANAGER,:RESERV0,:RESERV1,:RESERV2");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DEVICENAME", OracleType.VarChar,20) ,            
                        new OracleParameter(":DEVICEUSER", OracleType.VarChar,30) ,            
                        new OracleParameter(":DEVICETYPE", OracleType.Number,22) ,            
                        new OracleParameter(":LAYTIME", OracleType.DateTime) ,            
                        new OracleParameter(":ELON", OracleType.Number,16) ,            
                        new OracleParameter(":ELAT", OracleType.Number,16) ,            
                        new OracleParameter(":COMTYPE", OracleType.VarChar,50) ,            
                        new OracleParameter(":STRUCTTYPE", OracleType.Number,22) ,            
                        new OracleParameter(":COMARRAY", OracleType.Blob) ,            
                        new OracleParameter(":PACKNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RUNNINGSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":POSITION", OracleType.VarChar,20) ,            
                        new OracleParameter(":PRODUCER", OracleType.VarChar,30) ,            
                        new OracleParameter(":MANAGER", OracleType.VarChar,30) ,            
                        new OracleParameter(":RESERV0", OracleType.VarChar,50) ,            
                        new OracleParameter(":RESERV1", OracleType.VarChar,50) ,            
                        new OracleParameter(":RESERV2", OracleType.VarChar,50)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DEVICENAME;
            parameters[2].Value = model.DEVICEUSER;
            parameters[3].Value = model.DEVICETYPE;
            parameters[4].Value = model.LAYTIME;
            parameters[5].Value = model.ELON;
            parameters[6].Value = model.ELAT;
            parameters[7].Value = model.COMTYPE;
            parameters[8].Value = model.STRUCTTYPE;
            parameters[9].Value = model.COMARRAY;
            parameters[10].Value = model.PACKNUM;
            parameters[11].Value = model.RUNNINGSTATUS;
            parameters[12].Value = model.POSITION;
            parameters[13].Value = model.PRODUCER;
            parameters[14].Value = model.MANAGER;
            parameters[15].Value = model.RESERV0;
            parameters[16].Value = model.RESERV1;
            parameters[17].Value = model.RESERV2;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.DEVICEINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update DEVICEINFO set ");

            strSql.Append(" DEVICECODE = :DEVICECODE , ");
            strSql.Append(" DEVICENAME = :DEVICENAME , ");
            strSql.Append(" DEVICEUSER = :DEVICEUSER , ");
            strSql.Append(" DEVICETYPE = :DEVICETYPE , ");
            strSql.Append(" LAYTIME = :LAYTIME , ");
            strSql.Append(" ELON = :ELON , ");
            strSql.Append(" ELAT = :ELAT , ");
            strSql.Append(" COMTYPE = :COMTYPE , ");
            strSql.Append(" STRUCTTYPE = :STRUCTTYPE , ");
            strSql.Append(" COMARRAY = :COMARRAY , ");
            strSql.Append(" PACKNUM = :PACKNUM , ");
            strSql.Append(" RUNNINGSTATUS = :RUNNINGSTATUS , ");
            strSql.Append(" POSITION = :POSITION , ");
            strSql.Append(" PRODUCER = :PRODUCER , ");
            strSql.Append(" MANAGER = :MANAGER , ");
            strSql.Append(" RESERV0 = :RESERV0 , ");
            strSql.Append(" RESERV1 = :RESERV1 , ");
            strSql.Append(" RESERV2 = :RESERV2  ");
            strSql.Append(" where  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":DEVICECODE", OracleType.Char,6) ,            
                        new OracleParameter(":DEVICENAME", OracleType.VarChar,20) ,            
                        new OracleParameter(":DEVICEUSER", OracleType.VarChar,30) ,            
                        new OracleParameter(":DEVICETYPE", OracleType.Number,22) ,            
                        new OracleParameter(":LAYTIME", OracleType.DateTime) ,            
                        new OracleParameter(":ELON", OracleType.Number,16) ,            
                        new OracleParameter(":ELAT", OracleType.Number,16) ,            
                        new OracleParameter(":COMTYPE", OracleType.VarChar,50) ,            
                        new OracleParameter(":STRUCTTYPE", OracleType.Number,22) ,            
                        new OracleParameter(":COMARRAY", OracleType.Blob) ,            
                        new OracleParameter(":PACKNUM", OracleType.Number,22) ,            
                        new OracleParameter(":RUNNINGSTATUS", OracleType.Number,22) ,            
                        new OracleParameter(":POSITION", OracleType.VarChar,20) ,            
                        new OracleParameter(":PRODUCER", OracleType.VarChar,30) ,            
                        new OracleParameter(":MANAGER", OracleType.VarChar,30) ,            
                        new OracleParameter(":RESERV0", OracleType.VarChar,50) ,            
                        new OracleParameter(":RESERV1", OracleType.VarChar,50) ,            
                        new OracleParameter(":RESERV2", OracleType.VarChar,50)             
              
            };

            parameters[0].Value = model.DEVICECODE;
            parameters[1].Value = model.DEVICENAME;
            parameters[2].Value = model.DEVICEUSER;
            parameters[3].Value = model.DEVICETYPE;
            parameters[4].Value = model.LAYTIME;
            parameters[5].Value = model.ELON;
            parameters[6].Value = model.ELAT;
            parameters[7].Value = model.COMTYPE;
            parameters[8].Value = model.STRUCTTYPE;
            parameters[9].Value = model.COMARRAY;
            parameters[10].Value = model.PACKNUM;
            parameters[11].Value = model.RUNNINGSTATUS;
            parameters[12].Value = model.POSITION;
            parameters[13].Value = model.PRODUCER;
            parameters[14].Value = model.MANAGER;
            parameters[15].Value = model.RESERV0;
            parameters[16].Value = model.RESERV1;
            parameters[17].Value = model.RESERV2;
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
            strSql.Append("delete from DEVICEINFO ");
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
        /// 得到一个对象实体DataTablesResult
        /// </summary>
        public Entity.DEVICEINFO GetModel(string deviceCode) 
        {
            Entity.DEVICEINFO model =new Entity.DEVICEINFO();
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT DI.*,DA.SEAAREA,DA.PROVINCE,DA.BAY,DA.BUREAUDEVICE,DA.LOCALDEVICE,DA.SERVICE,DA.PICTUREPATH FROM DEVICEINFO DI");
            strSql.Append(" LEFT JOIN DEVICEATTACH DA ON DI.DEVICECODE=DA.DEVICECODE ");
            strSql.Append(" WHERE 1=1 ");

            List<OracleParameter> list = new List<OracleParameter>();
            strSql.Append(" AND  DI.DEVICECODE=:DEVICECODE ");
            list.Add(new OracleParameter(":DEVICECODE", deviceCode));

            try
            {
                DbAPI dbHelper = new DbAPI();
                DataTablesResult result = new DataTablesResult();

                dbHelper.OpenConn("");

                DataTable ds = dbHelper.GetDataTable(strSql.ToString(), list.ToArray());
                if (ds.Rows.Count > 0)
                {
                    model.DEVICECODE = ds.Rows[0]["DEVICECODE"].ToString();
                    model.DEVICENAME = ds.Rows[0]["DEVICENAME"].ToString();
                    model.DEVICEUSER = ds.Rows[0]["DEVICEUSER"].ToString();
                    if (ds.Rows[0]["DEVICETYPE"].ToString() != "")
                    {
                        model.DEVICETYPE = decimal.Parse(ds.Rows[0]["DEVICETYPE"].ToString());
                    }
                    if (ds.Rows[0]["LAYTIME"].ToString() != "")
                    {
                        model.LAYTIME = DateTime.Parse(ds.Rows[0]["LAYTIME"].ToString());
                    }
                    if (ds.Rows[0]["ELON"].ToString() != "")
                    {
                        model.ELON = decimal.Parse(ds.Rows[0]["ELON"].ToString());
                    }
                    if (ds.Rows[0]["ELAT"].ToString() != "")
                    {
                        model.ELAT = decimal.Parse(ds.Rows[0]["ELAT"].ToString());
                    }
                    model.COMTYPE = ds.Rows[0]["COMTYPE"].ToString();
                    if (ds.Rows[0]["STRUCTTYPE"].ToString() != "")
                    {
                        model.STRUCTTYPE = decimal.Parse(ds.Rows[0]["STRUCTTYPE"].ToString());
                    }
                    if (ds.Rows[0]["COMARRAY"].ToString() != "")
                    {
                        model.COMARRAY = (byte[])ds.Rows[0]["COMARRAY"];
                    }
                    if (ds.Rows[0]["PACKNUM"].ToString() != "")
                    {
                        model.PACKNUM = decimal.Parse(ds.Rows[0]["PACKNUM"].ToString());
                    }
                    if (ds.Rows[0]["RUNNINGSTATUS"].ToString() != "")
                    {
                        model.RUNNINGSTATUS = decimal.Parse(ds.Rows[0]["RUNNINGSTATUS"].ToString());
                    }
                    model.POSITION = ds.Rows[0]["POSITION"].ToString();
                    model.PRODUCER = ds.Rows[0]["PRODUCER"].ToString();
                    model.MANAGER = ds.Rows[0]["MANAGER"].ToString();
                    model.RESERV0 = ds.Rows[0]["RESERV0"].ToString();
                    model.RESERV1 = ds.Rows[0]["RESERV1"].ToString();
                    model.RESERV2 = ds.Rows[0]["RESERV2"].ToString();

                    model.SEAAREA = ds.Rows[0]["SEAAREA"].ToString();
                    model.SERVICE = ds.Rows[0]["SERVICE"].ToString();
                    model.PROVINCE = ds.Rows[0]["PROVINCE"].ToString();
                    model.BAY = ds.Rows[0]["BAY"].ToString();
                    model.BUREAUDEVICE = ds.Rows[0]["BUREAUDEVICE"].ToString();
                    model.LOCALDEVICE = ds.Rows[0]["LOCALDEVICE"].ToString();
                    model.PICTUREPATH = ds.Rows[0]["PICTUREPATH"].ToString();
                }
                else
                {
                    model= null;
                }

                dbHelper.CloseConn();
                return model;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(DEVICEINFO_BN), "GetDeviceInfo 程序段的异常" + ex);
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
            strSql.Append(" FROM DEVICEFULL ");
            DataTable dt = new DataTable();
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            try
            {
                dbHelper.OpenConn("");
                dt = dbHelper.GetDataTable(strSql.ToString(), parameters);
                dbHelper.CloseConn();
                return dt;

            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(DEVICEATTACH_BN), "GetMapEqipment 程序段的异常" + ex);
                return dt;
            }
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
            strSql.Append(" FROM DEVICEINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取实时数据列表
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public DataTablesResult GetDeviceInfo(DEVICEINFO device)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT * FROM( ");
            strSql.Append(" SELECT DI.DEVICECODE,DEVICENAME,DEVICEUSER,DEVICETYPE,LAYTIME,ELON,ELAT,COMTYPE,STRUCTTYPE,COMARRAY,PACKNUM,RUNNINGSTATUS,POSITION,PRODUCER,MANAGER,ROWNUM NUM ");
            strSql.Append(" FROM DEVICEINFO DI ");
            strSql.Append(" LEFT JOIN DEVICEATTACH DA ON DI.DEVICECODE=DA.DEVICECODE ");
            strSql.Append(" WHERE 1=1 ");

            List<OracleParameter> list = new List<OracleParameter>();

            // 编号
            if (!string.IsNullOrEmpty(device.DEVICECODE))
            {
                strSql.Append(" AND  DI.DEVICECODE=:DEVICECODE ");
                list.Add(new OracleParameter(":DEVICECODE", device.DEVICECODE));
            }

            // 设备类型（岸基站、浮标）
            if (device.DEVICETYPE > 0)
            {
                strSql.Append(" AND DEVICETYPE=:DEVICETYPE ");
                list.Add(new OracleParameter(":DEVICETYPE", device.DEVICETYPE));
            }
            if (!string.IsNullOrEmpty(device.SEAAREA))
            {
                if ("全部" != device.SEAAREA)
                {
                    strSql.Append(" AND SEAAREA=:SEAAREA ");
                    list.Add(new OracleParameter(":SEAAREA", device.SEAAREA));
                }
            }
            if (!string.IsNullOrEmpty(device.PROVINCE))
            {
                if ("全部" != device.PROVINCE)
                {
                    strSql.Append(" AND PROVINCE=:PROVINCE ");
                    list.Add(new OracleParameter(":PROVINCE", device.PROVINCE));
                }
            }
            if (!string.IsNullOrEmpty(device.BAY))
            {
                if ("全部" != device.BAY)
                {
                    strSql.Append(" AND BAY=:BAY ");
                    list.Add(new OracleParameter(":BAY", device.BAY));
                }
            }
            if (!string.IsNullOrEmpty(device.BUREAUDEVICE))
            {
                if ("全部" != device.BUREAUDEVICE)
                {
                    strSql.Append(" AND BUREAUDEVICE=:BUREAUDEVICE ");
                    list.Add(new OracleParameter(":BUREAUDEVICE", device.BUREAUDEVICE));
                }
            }
            if (!string.IsNullOrEmpty(device.LOCALDEVICE))
            {
                if ("全部" != device.LOCALDEVICE)
                {
                    strSql.Append(" AND LOCALDEVICE=:LOCALDEVICE ");
                    list.Add(new OracleParameter(":LOCALDEVICE", device.LOCALDEVICE));
                }
            }
            if (!string.IsNullOrEmpty(device.SERVICE))
            {
                if ("全部" != device.SERVICE)
                {
                    strSql.Append(" AND SERVICE=:SERVICE ");
                    list.Add(new OracleParameter(":SERVICE", device.SERVICE));
                }
            }
            strSql.Append(" )INFO ");
            // strSql.Append(" )INFO WHERE NUM>(:pageIndex-1)*:pageSize AND NUM<=:pageIndex*:pageSize ");
            //list.Add(new OracleParameter(":pageIndex", device.page));
            // list.Add(new OracleParameter(":pageSize", device.limit));

            try
            {
                DbAPI dbHelper = new DbAPI();
                DataTablesResult result = new DataTablesResult();

                dbHelper.OpenConn("");

                DataTable bt = dbHelper.GetDataTable(strSql.ToString(), list.ToArray());


                result.aaData = bt;
                result.sEcho = Convert.ToInt16(device.limit);
                //result.iTotalDisplayRecords = bt.Rows.Count;
                //result.iTotalRecords = bt.Rows.Count.ToString();
                result.iTotalDisplayRecords = GetDeviceInfoCount(device);
                result.iTotalRecords = GetDeviceInfoCount(device).ToString();

                dbHelper.CloseConn();
                return result;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(DEVICEINFO_BN), "GetDeviceInfo 程序段的异常" + ex);
                return null;
            }
        }


        /// <summary>
        /// 获取实时数据列表
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public int GetDeviceInfoCount(DEVICEINFO device)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT COUNT(1) ");
            strSql.Append(" FROM DEVICEINFO DI ");
            strSql.Append(" LEFT JOIN DEVICEATTACH DA ON DI.DEVICECODE=DA.DEVICECODE ");
            strSql.Append(" WHERE 1=1 ");

            List<OracleParameter> list = new List<OracleParameter>();

            // 设备类型（岸基站、浮标）
            if (device.DEVICETYPE > 0)
            {
                strSql.Append(" AND DEVICETYPE=:DEVICETYPE ");
                list.Add(new OracleParameter(":DEVICETYPE", device.DEVICETYPE));
            }
            if (!string.IsNullOrEmpty(device.SEAAREA))
            {
                strSql.Append(" AND SEAAREA=:SEAAREA ");
                list.Add(new OracleParameter(":SEAAREA", device.SEAAREA));
            }
            if (!string.IsNullOrEmpty(device.PROVINCE))
            {
                strSql.Append(" AND PROVINCE=:PROVINCE ");
                list.Add(new OracleParameter(":PROVINCE", device.PROVINCE));
            }
            if (!string.IsNullOrEmpty(device.BAY))
            {
                strSql.Append(" AND BAY=:BAY ");
                list.Add(new OracleParameter(":BAY", device.BAY));
            }
            if (!string.IsNullOrEmpty(device.BUREAUDEVICE))
            {
                strSql.Append(" AND BUREAUDEVICE=:BUREAUDEVICE ");
                list.Add(new OracleParameter(":BUREAUDEVICE", device.BUREAUDEVICE));
            }
            if (!string.IsNullOrEmpty(device.LOCALDEVICE))
            {
                strSql.Append(" AND LOCALDEVICE=:LOCALDEVICE ");
                list.Add(new OracleParameter(":LOCALDEVICE", device.LOCALDEVICE));
            }
            if (!string.IsNullOrEmpty(device.SERVICE))
            {
                strSql.Append(" AND SERVICE=:SERVICE ");
                list.Add(new OracleParameter(":SERVICE", device.SERVICE));
            }

            try
            {
                DbAPI dbHelper = new DbAPI();

                dbHelper.OpenConn("");

                object result = dbHelper.ExecuteOracleScalar(strSql.ToString(), list.ToArray());

                dbHelper.CloseConn();
                return Convert.ToInt32(result.ToString());
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(DEVICEINFO_BN), "GetDeviceInfoCount 程序段的异常" + ex);
                return 0;
            }
        }

        /// <summary>
        /// 获取当前设备信息
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public DataTablesResult getDeviceRow(string deviceCode)
        {
            StringBuilder strSql = new StringBuilder();
            
            strSql.Append(" SELECT * ");
            strSql.Append(" FROM DEVICEINFO  ");
           
            strSql.Append(" WHERE 1=1 ");

            List<OracleParameter> list = new List<OracleParameter>();

            // 编号
            if (!string.IsNullOrEmpty(deviceCode))
            {
                strSql.Append(" AND  DEVICECODE=:DEVICECODE ");
                list.Add(new OracleParameter(":DEVICECODE", deviceCode));
            }

           // strSql.Append(" )INFO ");

            try
            {
                DbAPI dbHelper = new DbAPI();
                DataTablesResult result = new DataTablesResult();

                dbHelper.OpenConn("");

                DataTable bt = dbHelper.GetDataTable(strSql.ToString(), list.ToArray());

                result.aaData = bt;
              
                dbHelper.CloseConn();
                return result;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(DEVICEINFO_BN), "GetDeviceInfo 程序段的异常" + ex);
                return null;
            }
        }

    }
}

