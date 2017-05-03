using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace Business.BN
{
    public class MonitorLog
    {
        /// <summary>
        /// (分页查询)从数据库中获取某个时间段的监控历史记录列表
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="beginTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="strWhere">其他查询条件</param>
        /// <param name="pageNumber">页码</param>
        /// <param name="pageSize">每页记录数</param>
        /// <returns></returns>
        private DataTable GetList(string tableName, string beginTime, string endTime, string strWhere, int pageNumber, int pageSize)
        {
            var strSql = new StringBuilder();
            strSql.Append("select d.devicename, t.* ");
            strSql.AppendFormat("from {0} t ", tableName);
            strSql.Append("left join deviceinfo d ");
            strSql.Append("on t.devicecode = d.devicecode ");
            strSql.Append("where t.DATETIME between ");
            strSql.Append("to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and ");
            strSql.Append("to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') ");
            if (!string.IsNullOrWhiteSpace(strWhere))
            {
                strSql.AppendFormat("and {0} ", strWhere);
            }
            strSql.Append("order by t.DATETIME desc");
            OracleParameter[] parameters =
            {
                new OracleParameter(":beginTime", beginTime),
                new OracleParameter(":endTime", endTime)
            };
            var dbapi = new DbAPI();
            dbapi.OpenConn("");
            var rst = dbapi.GetDataTable(DbAPI.GeneratePagingSql(strSql.ToString(), pageNumber, pageSize), parameters);
            dbapi.CloseConn();
            return rst;
        }

        /// <summary>
        /// 监控历史记录 - 水质 - 岸基
        /// </summary>
        /// <param name="queryModel">查询条件</param>
        /// <returns></returns>
        public DataTable GetShuizhiList(Entity.MonitorLog.QueryModel queryModel)
        {
            return GetList("TABECOLOGY", queryModel.beginTime, queryModel.endTime, null, queryModel.offset / queryModel.limit + 1, queryModel.limit);
        }

        /// <summary>
        /// 监控历史记录 - 水质 - 浮标
        /// </summary>
        /// <param name="queryModel">查询条件</param>
        /// <returns></returns>
        public DataTable GetShuizhiList1(Entity.MonitorLog.QueryModel queryModel)
        {
            return GetList("TABBUOYECOLOGY", queryModel.beginTime, queryModel.endTime, null, queryModel.offset / queryModel.limit + 1, queryModel.limit);
        }


    }
}
