﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using Entity.MonitorLog;

namespace Business.BN
{
    public class MonitorLog
    {
        /// <summary>
        /// 根据设备类型获取设备列表
        /// </summary>
        /// <param name="devicecode">设备编号</param>
        /// <returns></returns>
        public DataTable GetDeviceList(string devicecode)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("select devicecode,devicename,devicetype from DEVICEINFO where devicetype = (select DEVICETYPE from deviceinfo where devicecode=:devicecode) ");
                strSql.Append("order by laytime desc,devicecode asc ");
                OracleParameter[] parameters =
                {
                    new OracleParameter(":devicecode", devicecode)
                };
                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.GetDataTable(strSql.ToString(), parameters);
                dbapi.CloseConn();
                return rst;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(MonitorLog), "根据设备类型获取设备列表GetDeviceList 程序段的异常" + ex);
                return null;
            }

        }

        /// <summary>
        /// (分页查询)从数据库中获取某个时间段的监控历史记录列表
        /// </summary>
        public DataTable GetList(QueryModel model)
        {
            return GetList(model.tableName, model.devicecode, model.beginTime, model.endTime, null, model.offset / model.limit + 1,
                model.limit);
        }

        /// <summary>
        /// (分页查询)从数据库中获取某个时间段的监控历史记录列表
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="devicecode">设备编号</param>
        /// <param name="beginTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="strWhere">其他查询条件</param>
        /// <param name="pageNumber">页码</param>
        /// <param name="pageSize">每页记录数</param>
        /// <returns></returns>
        private DataTable GetList(string tableName, string devicecode, string beginTime, string endTime, string strWhere, int pageNumber, int pageSize)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("select d.devicename, t.*,COUNT(*) OVER () RESULT_COUNT ");
                strSql.AppendFormat("from {0} t ", tableName);
                strSql.Append("left join deviceinfo d ");
                strSql.Append("on t.devicecode = d.devicecode ");
                strSql.Append("where t.devicecode=:devicecode and t.DATETIME between ");
                strSql.Append("to_date(:beginTime, 'YYYY-MM-DD HH24:MI:SS') and ");
                strSql.Append("to_date(:endTime, 'YYYY-MM-DD HH24:MI:SS') ");
                if (!string.IsNullOrWhiteSpace(strWhere))
                {
                    strSql.AppendFormat("and {0} ", strWhere);
                }
                strSql.Append("order by t.DATETIME desc");

                OracleParameter[] parameters =
                {
                    new OracleParameter(":devicecode", devicecode),
                    new OracleParameter(":beginTime", beginTime),
                    new OracleParameter(":endTime", endTime)
                };
                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.GetDataTable(DbAPI.GeneratePagingSql(strSql.ToString(), pageNumber, pageSize), parameters);
                dbapi.CloseConn();
                return rst;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(MonitorLog), "(分页查询)从数据库中获取某个时间段的监控历史记录列表GetList 程序段的异常" + ex);
                return null;
            }
        }

        /// <summary>
        /// 从数据库中获取某个时间段的监控历史记录列表
        /// </summary>
        public DataTable GetExcelList(QueryModel model)
        {
            try
            {
                var strSql = ExcelColumns.SqlStatement[model.order];

                OracleParameter[] parameters =
                {
                    new OracleParameter(":devicecode", model.devicecode),
                    new OracleParameter(":beginTime", model.beginTime),
                    new OracleParameter(":endTime", model.endTime)
                };
                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.GetDataTable(strSql, parameters);
                dbapi.CloseConn();
                return rst;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(MonitorLog), "获取需要导出的excel数据的方法GetExcelList 程序段的异常" + ex);
                return null;
            }

        }

    }
}
