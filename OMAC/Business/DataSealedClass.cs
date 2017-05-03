using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Configuration;
using System.Reflection;


namespace Business
{
    /**//// <summary>
    /// All rights reserved
    /// ���ݷ��ʻ�����
    /// �û������޸������Լ���Ŀ����Ҫ��
    /// </summary>
    public class DataBaseLayer:IDisposable 
    {
        //���ݿ������ַ���(web.config������)
        //<add key="ConnectionString" value="server=127.0.0.1;database=DATABASE;uid=sa;pwd=" />        
        private string connectionString;
        public string ConntionString 
        {
            get 
            {
                return connectionString ; 
            }
            set 
            {
                connectionString = value;
            }
        }


        public DataBaseLayer(string strConnect,string dataType)
        {            
            this.ConntionString = strConnect;
            this.DbType = dataType;
        }


        public DataBaseLayer()
        {
            this.connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            this.dbType = ConfigurationManager.AppSettings["DataType"];
        }

        /**//// <summary>
        /// ���ݿ����� 
        /// </summary>
        private string dbType;
        public string DbType
        {
            get 
            {
                if ( dbType == string.Empty || dbType == null )
                {
                    return "Access";
                }
                else
                {
                    return dbType;
                }
            }
            set  
            {
                if ( value != string.Empty  &&  value != null )
                {
                    dbType = value;
                }
                if (dbType ==string.Empty || dbType == null)
                {
                    dbType = ConfigurationManager.AppSettings["DataType"];
                }
                if ( dbType == string.Empty || dbType == null )
                {
                    dbType = "Access";
                }
            }      
        }

       #region ���� Connection �� Command

        private IDbConnection GetConnection()
        {
            switch(this.DbType)
            {
                case "SqlServer":
                    return new System.Data.SqlClient.SqlConnection(this.ConntionString);

                case "Oracle":
                    return new System.Data.OracleClient.OracleConnection(this.ConntionString);

                case "Access":
                    return new System.Data.OleDb.OleDbConnection(this.ConntionString);
                default:
                    return new System.Data.SqlClient.SqlConnection(this.ConntionString);
            }
        }

        private IDataAdapter GetAdapater(string Sql,IDbConnection iConn)
        {
            switch(this.DbType)
            {
                case "SqlServer":
                    return new System.Data.SqlClient.SqlDataAdapter(Sql,(SqlConnection)iConn);

                case "Oracle":
                    return new System.Data.OracleClient.OracleDataAdapter(Sql,(OracleConnection)iConn);

                case "Access":
                    return new System.Data.OleDb.OleDbDataAdapter(Sql,(OleDbConnection)iConn);

                default:
                    return new System.Data.SqlClient.SqlDataAdapter(Sql,(SqlConnection)iConn);;
            }
            
        }
        #endregion

       #region  ִ�м�SQL���
        /// <summary>
        /// ִ�в�ѯ���
        /// </summary>
        /// <param name="SqlString">��ѯ���</param>
        /// <returns>DataTable </returns>
        public DataTable ExecuteQuery(string sqlString)
        {
            using (System.Data.IDbConnection  iConn = this.GetConnection())    
            {    
                //System.Data.IDbCommand iCmd  =  GetCommand(sqlString,iConn);
                DataSet ds = new DataSet();
                try
                {
                    System.Data.IDataAdapter iAdapter = this.GetAdapater(sqlString,iConn);            
                    iAdapter.Fill(ds);
                }
                catch(System.Exception e)
                {
                    LogBN.WriteLog(typeof(DataBaseLayer), e); return null;
                }    
                finally
                {
                    if(iConn.State != ConnectionState.Closed)
                    {
                        iConn.Close();
                    }
                }
                return ds.Tables[0];
            }
        }
        #endregion
        public void Dispose()
        {
           
        }
    }
}
