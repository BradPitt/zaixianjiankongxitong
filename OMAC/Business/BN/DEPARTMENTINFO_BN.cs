﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;

namespace Business.BN
{
    public class DEPARTMENTINFO_BN
    {

        public bool Exists(string F_DEPARTMENTCODE)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from DEPARTMENTINFO");
            strSql.Append(" where ");
            strSql.Append(" F_DEPARTMENTCODE = :F_DEPARTMENTCODE  ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_DEPARTMENTCODE", OracleType.VarChar,36)			};
            parameters[0].Value = F_DEPARTMENTCODE;

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
        public void Add(Entity.DEPARTMENTINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into DEPARTMENTINFO(");
            strSql.Append("F_DEPARTMENTCODE,F_NAME,F_DESCRIPTION,F_PARENT");
            strSql.Append(") values (");
            strSql.Append(":F_DEPARTMENTCODE,:F_NAME,:F_DESCRIPTION,:F_PARENT");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_DEPARTMENTCODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.NVarChar) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PARENT", OracleType.VarChar,36)             
              
            };

            parameters[0].Value = model.F_DEPARTMENTCODE;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_DESCRIPTION;
            parameters[3].Value = model.F_PARENT;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.DEPARTMENTINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update DEPARTMENTINFO set ");

            strSql.Append(" F_DEPARTMENTCODE = :F_DEPARTMENTCODE , ");
            strSql.Append(" F_NAME = :F_NAME , ");
            strSql.Append(" F_DESCRIPTION = :F_DESCRIPTION , ");
            strSql.Append(" F_PARENT = :F_PARENT  ");
            strSql.Append(" where F_DEPARTMENTCODE=:F_DEPARTMENTCODE  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_DEPARTMENTCODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.NVarChar) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PARENT", OracleType.VarChar,36)             
              
            };

            parameters[0].Value = model.F_DEPARTMENTCODE;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_DESCRIPTION;
            parameters[3].Value = model.F_PARENT;
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
        public bool Delete(string F_DEPARTMENTCODE)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("delete from DEPARTMENTINFO ");
            strSql.Append(" where F_DEPARTMENTCODE=:F_DEPARTMENTCODE ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_DEPARTMENTCODE", OracleType.VarChar,36)			};
            parameters[0].Value = F_DEPARTMENTCODE;


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
        /// 得到一个对象实体
        /// </summary>
        public Entity.DEPARTMENTINFO GetModel(string F_DEPARTMENTCODE)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select F_DEPARTMENTCODE, F_NAME, F_DESCRIPTION, F_PARENT  ");
            strSql.Append("  from DEPARTMENTINFO ");
            strSql.Append(" where F_DEPARTMENTCODE=:F_DEPARTMENTCODE ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_DEPARTMENTCODE", OracleType.VarChar,36)			};
            parameters[0].Value = F_DEPARTMENTCODE;


            Entity.DEPARTMENTINFO model = new Entity.DEPARTMENTINFO();
            DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

            if (ds.Rows.Count > 0)
            {
                model.F_DEPARTMENTCODE = ds.Rows[0]["F_DEPARTMENTCODE"].ToString();
                model.F_NAME = ds.Rows[0]["F_NAME"].ToString();
                model.F_DESCRIPTION = ds.Rows[0]["F_DESCRIPTION"].ToString();
                model.F_PARENT = ds.Rows[0]["F_PARENT"].ToString();

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
            strSql.Append(" FROM DEPARTMENTINFO");
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
            strSql.Append(" FROM DEPARTMENTINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取所有的数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select * ");
            strSql.Append(" FROM DEPARTMENTINFO");
            dbHelper.OpenConn("");

            DataTable bt = dbHelper.GetDataTable(strSql.ToString(),null);
            dbHelper.CloseConn();
            return bt;
        }

    }
}

