using System; 
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic; 
using System.Data;

namespace Business.BN  
{
		public class ROLEFUNCTION_BN
	{
   		     
		public bool Exists(string F_ID)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("select count(1) from ROLEFUNCTION");
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
		public void Add(Entity.ROLEFUNCTION model)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("insert into ROLEFUNCTION(");			
            strSql.Append("F_ID,F_ROLECODE,F_FUNCTIONCODE");
			strSql.Append(") values (");
            strSql.Append(":F_ID,:F_ROLECODE,:F_FUNCTIONCODE");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_ID", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_ROLECODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36)             
              
            };
			            
            parameters[0].Value = model.F_ID;                        
            parameters[1].Value = model.F_ROLECODE;                        
            parameters[2].Value = model.F_FUNCTIONCODE;                        
			            dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Entity.ROLEFUNCTION model)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("update ROLEFUNCTION set ");
			                        
            strSql.Append(" F_ID = :F_ID , ");                                    
            strSql.Append(" F_ROLECODE = :F_ROLECODE , ");                                    
            strSql.Append(" F_FUNCTIONCODE = :F_FUNCTIONCODE  ");            			
			strSql.Append(" where F_ID=:F_ID  ");
						
OracleParameter[] parameters = {
			            new OracleParameter(":F_ID", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_ROLECODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36)             
              
            };
						            
            parameters[0].Value = model.F_ID;                        
            parameters[1].Value = model.F_ROLECODE;                        
            parameters[2].Value = model.F_FUNCTIONCODE;                        
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
			strSql.Append("delete from ROLEFUNCTION ");
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
		public Entity.ROLEFUNCTION GetModel(string F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("select F_ID, F_ROLECODE, F_FUNCTIONCODE  ");			
			strSql.Append("  from ROLEFUNCTION ");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.VarChar,36)			};
			parameters[0].Value = F_ID;

			
			Entity.ROLEFUNCTION model=new Entity.ROLEFUNCTION();
			DataTable ds=dbHelper.GetDataTable(strSql.ToString(),parameters);
			
			if(ds.Rows.Count>0)
			{
																model.F_ID= ds.Rows[0]["F_ID"].ToString();
																																model.F_ROLECODE= ds.Rows[0]["F_ROLECODE"].ToString();
																																model.F_FUNCTIONCODE= ds.Rows[0]["F_FUNCTIONCODE"].ToString();
																										
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
			strSql.Append(" FROM ROLEFUNCTION ");
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
			strSql.Append(" FROM ROLEFUNCTION ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbHelper.GetDataTable(strSql.ToString(),parameters);
		}

   
	}
}

