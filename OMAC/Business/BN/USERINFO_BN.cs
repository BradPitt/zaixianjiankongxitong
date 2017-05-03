using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;

namespace Business.BN
{
    //se
    public class USERINFO_BN
    {

        public bool Exists(string F_ACCOUNT)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from USERINFO");
            strSql.Append(" where ");
            strSql.Append(" F_ACCOUNT = :F_ACCOUNT  ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36)			};
            parameters[0].Value = F_ACCOUNT;

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
        public void Add(Entity.USERINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into USERINFO(");
            strSql.Append("F_ACCOUNT,F_NAME,F_PASSWORD,F_EMAIL,F_PHONE,F_TEL,F_DESCRIPTION,F_PHOTO,F_ADDRESS,F_REALNAME");
            strSql.Append(") values (");
            strSql.Append(":F_ACCOUNT,:F_NAME,:F_PASSWORD,:F_EMAIL,:F_PHONE,:F_TEL,:F_DESCRIPTION,:F_PHOTO,:F_ADDRESS,:F_REALNAME");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.VarChar,64) ,            
                        new OracleParameter(":F_PASSWORD", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_EMAIL", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_PHONE", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_TEL", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PHOTO", OracleType.Blob) ,            
                        new OracleParameter(":F_ADDRESS", OracleType.NVarChar) ,            
                        new OracleParameter(":F_REALNAME", OracleType.NVarChar)             
              
            };

            parameters[0].Value = model.F_ACCOUNT;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_PASSWORD;
            parameters[3].Value = model.F_EMAIL;
            parameters[4].Value = model.F_PHONE;
            parameters[5].Value = model.F_TEL;
            parameters[6].Value = model.F_DESCRIPTION;
            parameters[7].Value = model.F_PHOTO;
            parameters[8].Value = model.F_ADDRESS;
            parameters[9].Value = model.F_REALNAME;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.USERINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update USERINFO set ");

            strSql.Append(" F_ACCOUNT = :F_ACCOUNT , ");
            strSql.Append(" F_NAME = :F_NAME , ");
            strSql.Append(" F_PASSWORD = :F_PASSWORD , ");
            strSql.Append(" F_EMAIL = :F_EMAIL , ");
            strSql.Append(" F_PHONE = :F_PHONE , ");
            strSql.Append(" F_TEL = :F_TEL , ");
            strSql.Append(" F_DESCRIPTION = :F_DESCRIPTION , ");
            strSql.Append(" F_PHOTO = :F_PHOTO , ");
            strSql.Append(" F_ADDRESS = :F_ADDRESS , ");
            strSql.Append(" F_REALNAME = :F_REALNAME  ");
            strSql.Append(" where F_ACCOUNT=:F_ACCOUNT  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.VarChar,64) ,            
                        new OracleParameter(":F_PASSWORD", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_EMAIL", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_PHONE", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_TEL", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PHOTO", OracleType.Blob) ,            
                        new OracleParameter(":F_ADDRESS", OracleType.NVarChar) ,            
                        new OracleParameter(":F_REALNAME", OracleType.NVarChar)             
              
            };

            parameters[0].Value = model.F_ACCOUNT;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_PASSWORD;
            parameters[3].Value = model.F_EMAIL;
            parameters[4].Value = model.F_PHONE;
            parameters[5].Value = model.F_TEL;
            parameters[6].Value = model.F_DESCRIPTION;
            parameters[7].Value = model.F_PHOTO;
            parameters[8].Value = model.F_ADDRESS;
            parameters[9].Value = model.F_REALNAME;
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
        public bool Delete(string F_ACCOUNT)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("delete from USERINFO ");
            strSql.Append(" where F_ACCOUNT=:F_ACCOUNT ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36)			};
            parameters[0].Value = F_ACCOUNT;


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
        public Entity.USERINFO GetModel(string F_ACCOUNT)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select F_ACCOUNT, F_NAME, F_PASSWORD, F_EMAIL, F_PHONE, F_TEL, F_DESCRIPTION, F_PHOTO, F_ADDRESS, F_REALNAME  ");
            strSql.Append("  from USERINFO ");
            strSql.Append(" where F_ACCOUNT=:F_ACCOUNT ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36)			};
            parameters[0].Value = F_ACCOUNT;

            dbHelper.OpenConn("");
            Entity.USERINFO model = new Entity.USERINFO();
            DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

            if (ds.Rows.Count > 0)
            {
                model.F_ACCOUNT = ds.Rows[0]["F_ACCOUNT"].ToString();
                model.F_NAME = ds.Rows[0]["F_NAME"].ToString();
                model.F_PASSWORD = ds.Rows[0]["F_PASSWORD"].ToString();
                model.F_EMAIL = ds.Rows[0]["F_EMAIL"].ToString();
                model.F_PHONE = ds.Rows[0]["F_PHONE"].ToString();
                model.F_TEL = ds.Rows[0]["F_TEL"].ToString();
                model.F_DESCRIPTION = ds.Rows[0]["F_DESCRIPTION"].ToString();
                if (ds.Rows[0]["F_PHOTO"].ToString() != "")
                {
                    model.F_PHOTO = (byte[])ds.Rows[0]["F_PHOTO"];
                }
                model.F_ADDRESS = ds.Rows[0]["F_ADDRESS"].ToString();
                model.F_REALNAME = ds.Rows[0]["F_REALNAME"].ToString();

                dbHelper.CloseConn();
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
            strSql.Append(" FROM USERINFO ");
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
            strSql.Append(" FROM USERINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据用户名、密码查询用户是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetUserList(Entity.USERINFO user)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT F_ACCOUNT,F_NAME,F_REALNAME FROM USERINFO WHERE 1=1 AND F_NAME=:F_NAME AND F_PASSWORD=:F_PASSWORD ");

            DbAPI dbHelper = new DbAPI();
            List<OracleParameter> list = new List<OracleParameter>();
            list.Add(new OracleParameter(":F_NAME", user.F_NAME));
            list.Add(new OracleParameter(":F_PASSWORD", user.F_PASSWORD));

            dbHelper.OpenConn("");
            DataTable dt = dbHelper.GetDataTable(strSql.ToString(), list.ToArray());
            dbHelper.CloseConn();

            return dt;
        }

    }
}

