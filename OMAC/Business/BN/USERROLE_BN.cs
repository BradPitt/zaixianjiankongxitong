using System; 
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic; 
using System.Data;

namespace Business.BN  
{
		public class USERROLE_BN
	{
   		     
		public bool Exists(string F_ID)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("select count(1) from USERROLE");
			strSql.Append(" where ");
			                                       strSql.Append(" F_ID = :F_ID  ");
                            						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.VarChar,36)			};
			parameters[0].Value = F_ID;

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
		public void Add(Entity.USERROLE model)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("insert into USERROLE(");			
            strSql.Append("F_ID,F_ACCOUNT,F_ROLECODE");
			strSql.Append(") values (");
            strSql.Append(":F_ID,:F_ACCOUNT,:F_ROLECODE");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_ID", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_ROLECODE", OracleType.VarChar,36)             
              
            };
			            
            parameters[0].Value = model.F_ID;                        
            parameters[1].Value = model.F_ACCOUNT;                        
            parameters[2].Value = model.F_ROLECODE;                        
			            dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Entity.USERROLE model)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("update USERROLE set ");
			                        
            strSql.Append(" F_ID = :F_ID , ");                                    
            strSql.Append(" F_ACCOUNT = :F_ACCOUNT , ");                                    
            strSql.Append(" F_ROLECODE = :F_ROLECODE  ");            			
			strSql.Append(" where F_ID=:F_ID  ");
						
OracleParameter[] parameters = {
			            new OracleParameter(":F_ID", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_ROLECODE", OracleType.VarChar,36)             
              
            };
						            
            parameters[0].Value = model.F_ID;                        
            parameters[1].Value = model.F_ACCOUNT;                        
            parameters[2].Value = model.F_ROLECODE;                        
            int rows=dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
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
		public bool Delete(string F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("delete from USERROLE ");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.VarChar,36)			};
			parameters[0].Value = F_ID;


			int rows=dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
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
		public Entity.USERROLE GetModel(string F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("select F_ID, F_ACCOUNT, F_ROLECODE  ");			
			strSql.Append("  from USERROLE ");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.VarChar,36)			};
			parameters[0].Value = F_ID;

			
			Entity.USERROLE model=new Entity.USERROLE();
			DataTable ds=dbHelper.GetDataTable(strSql.ToString(),parameters);
			
			if(ds.Rows.Count>0)
			{
																model.F_ID= ds.Rows[0]["F_ID"].ToString();
																																model.F_ACCOUNT= ds.Rows[0]["F_ACCOUNT"].ToString();
																																model.F_ROLECODE= ds.Rows[0]["F_ROLECODE"].ToString();
																										
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
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			OracleParameter[] parameters = null;
			strSql.Append("select * ");
			strSql.Append(" FROM USERROLE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return dbHelper.GetDataTable(strSql.ToString(),parameters);
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataTable GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			OracleParameter[] parameters = null;
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM USERROLE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbHelper.GetDataTable(strSql.ToString(),parameters);
		}

   
	}
}

