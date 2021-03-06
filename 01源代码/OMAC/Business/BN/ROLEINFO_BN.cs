﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;
using Entity;
using NPOI.SS.Formula.Functions;

namespace Business.BN
{
    public class ROLEINFO_BN
    {

        public bool Exists(string F_ROLECODE)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from ROLEINFO");
            strSql.Append(" where ");
            strSql.Append(" F_ROLECODE = :F_ROLECODE  ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ROLECODE", OracleType.VarChar,36)			};
            parameters[0].Value = F_ROLECODE;

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
        public ReturnResult AddRole(ROLEINFO model, string[] rolefunlist)
        {
            ReturnResult result = new ReturnResult();
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            try
            {
                dbHelper.OpenConn("");
                dbHelper.OpenTrans();
                model.F_ROLECODE = dbHelper.GUID();
                strSql.Append("insert into ROLEINFO(");
                strSql.Append("F_ROLECODE,F_NAME,F_DESCRIPTION");
                strSql.Append(") values (");
                strSql.Append(":F_ROLECODE,:F_NAME,:F_DESCRIPTION");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_ROLECODE", dbHelper.CheckDBNull(model.F_ROLECODE)) ,            
                        new OracleParameter(":F_NAME", dbHelper.CheckDBNull(model.F_NAME)) ,            
                        new OracleParameter(":F_DESCRIPTION", dbHelper.CheckDBNull(model.F_DESCRIPTION))             
              
                };

                int rows = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    for (int i = 0; i < rolefunlist.Length; i++)
                    {
                        strSql.Clear();
                        strSql.Append("insert into ROLEFUNCTION(");
                        strSql.Append("F_ID,F_ROLECODE,F_FUNCTIONCODE");
                        strSql.Append(") values (");
                        strSql.Append(":F_ID,:F_ROLECODE,:F_FUNCTIONCODE");
                        strSql.Append(") ");

                        OracleParameter[] parameters1 = {
                        new OracleParameter(":F_ID", dbHelper.CheckDBNull(dbHelper.GUID())) ,            
                        new OracleParameter(":F_ROLECODE", dbHelper.CheckDBNull(model.F_ROLECODE)) ,            
                        new OracleParameter(":F_FUNCTIONCODE", dbHelper.CheckDBNull(rolefunlist[i]))             
              
                        };

                        int rows1 = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters1);
                        if (rows1 <= 0)
                        {
                            goto Over;
                        }
                    }
                    result.success = true;
                    result.Message = "操作成功";
                    dbHelper.CommitTrans();
                    dbHelper.CloseConn();
                    return result;
                }
                else
                {
                    goto Over;
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(ROLEINFO_BN), "SaveRole 程序段的异常" + ex);
                goto Over;
            }
        Over:
            result.success = false;
            result.Message = "操作失败";
            dbHelper.RollBack();
            dbHelper.CloseConn();
            return result;

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.ROLEINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update ROLEINFO set ");

            strSql.Append(" F_ROLECODE = :F_ROLECODE , ");
            strSql.Append(" F_NAME = :F_NAME , ");
            strSql.Append(" F_DESCRIPTION = :F_DESCRIPTION  ");
            strSql.Append(" where F_ROLECODE=:F_ROLECODE  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_ROLECODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.NVarChar) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar)             
              
            };

            parameters[0].Value = model.F_ROLECODE;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_DESCRIPTION;
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
        public ReturnResult DeleteRole(string F_ROLECODE)
        {
            ReturnResult result = new ReturnResult();
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            try
            {
                dbHelper.OpenConn("");
                dbHelper.OpenTrans();
                strSql.Append("delete from ROLEINFO ");
                strSql.Append(" where F_ROLECODE=:F_ROLECODE ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLECODE", dbHelper.CheckDBNull(F_ROLECODE))			
                };

                int rows = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    strSql.Clear();
                    strSql.Append("delete from ROLEFUNCTION ");
                    strSql.Append(" where F_ROLECODE=:F_ROLECODE ");
                    OracleParameter[] parameters1 = {
					        new OracleParameter(":F_ROLECODE", dbHelper.CheckDBNull(F_ROLECODE))			
                        };

                    int rows1 = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters1);
                    if (rows1 <= 0)
                    {
                        goto Over;
                    }
                    result.success = true;
                    result.Message = "操作成功";
                    dbHelper.CommitTrans();
                    dbHelper.CloseConn();
                    return result;
                }
                else
                {
                    goto Over;
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(ROLEINFO_BN), "DeleteRole 程序段的异常" + ex);
                goto Over;
            }
        Over:
            result.success = false;
            result.Message = "操作失败";
            dbHelper.RollBack();
            dbHelper.CloseConn();
            return result;

        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Entity.ROLEINFO GetModel(string F_ROLECODE)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select F_ROLECODE, F_NAME, F_DESCRIPTION  ");
            strSql.Append("  from ROLEINFO ");
            strSql.Append(" where F_ROLECODE=:F_ROLECODE ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ROLECODE", OracleType.VarChar,36)			};
            parameters[0].Value = F_ROLECODE;


            Entity.ROLEINFO model = new Entity.ROLEINFO();
            dbHelper.OpenConn("");
            DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);
            dbHelper.CloseConn();
            if (ds.Rows.Count > 0)
            {
                model.F_ROLECODE = ds.Rows[0]["F_ROLECODE"].ToString();
                model.F_NAME = ds.Rows[0]["F_NAME"].ToString();
                model.F_DESCRIPTION = ds.Rows[0]["F_DESCRIPTION"].ToString();

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
            OracleParameter[] parameters = null;
            strSql.Append("select * ");
            strSql.Append(" FROM ROLEINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            var dbapi = new DbAPI();
            dbapi.OpenConn("");
            var rst = dbapi.GetDataTable(strSql.ToString(), parameters);
            dbapi.CloseConn();
            return rst;
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
            strSql.Append(" FROM ROLEINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="roleinfo">角色实体类</param>
        /// <returns>是否成功</returns>
        public bool AddRoleMain(ROLEINFO roleinfo)
        {
            var strSql = new StringBuilder();
            var dbHelper = new DbAPI();
            strSql.Append("INSERT INTO ROLEINFO(F_ROLECODE, F_NAME, F_DESCRIPTION)VALUES(SYS_GUID(),:F_NAME,:F_DESCRIPTION)");
            OracleParameter[] parms =
            {
                new OracleParameter("F_NAME", roleinfo.F_NAME),
                new OracleParameter("F_DESCRIPTION", roleinfo.F_DESCRIPTION??"")
            };

            try
            {
                dbHelper.OpenConn("");
                var rstInt = dbHelper.ExecuteNonQuery(strSql.ToString(), parms);
                dbHelper.CloseConn();
                return rstInt > 0;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(ROLEINFO_BN), "新增角色AddRoleMain 程序段的异常" + ex);
                return false;
            }

        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="roleinfo">角色实体类</param>
        /// <returns>是否成功</returns>
        public bool EditRoleMain(ROLEINFO roleinfo)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("UPDATE ROLEINFO SET F_NAME=:F_NAME,F_DESCRIPTION=:F_DESCRIPTION WHERE F_ROLECODE=:F_ROLECODE");
            OracleParameter[] parms =
            {
                new OracleParameter("F_NAME", roleinfo.F_NAME),
                new OracleParameter("F_DESCRIPTION", roleinfo.F_DESCRIPTION),
                new OracleParameter("F_ROLECODE", roleinfo.F_ROLECODE)
            };

            try
            {
                dbHelper.OpenConn("");
                var rstInt = dbHelper.ExecuteNonQuery(strSql.ToString(), parms);
                dbHelper.CloseConn();
                return rstInt > 0;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(ROLEINFO_BN), "修改角色EditRoleMain 程序段的异常" + ex);
                return false;
            }
        }

        /// <summary>
        /// 获取全部角色(绑定下拉框)
        /// </summary>
        public DataTable GetAllRoles(string userAccount)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userAccount))
                {
                    return GetList("");
                }
                var strSql = "select A.F_ROLECODE, A.F_NAME, DECODE(B.F_ID, NULL, 0, 1) AS \"ISUSERHAS\"" +
                             " from ROLEINFO A" +
                             " LEFT JOIN (SELECT * FROM USERROLE WHERE F_ACCOUNT = :F_ACCOUNT) B" +
                             " ON A.F_ROLECODE = B.F_ROLECODE";
                OracleParameter[] parms =
                {
                    new OracleParameter("F_ACCOUNT", userAccount)
                };

                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.GetDataTable(strSql, parms);
                dbapi.CloseConn();
                return rst;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(MonitorLog), "获取全部角色(绑定下拉框)方法GetAllRoles 程序段的异常" + ex);
                return null;
            }
        }


    }
}