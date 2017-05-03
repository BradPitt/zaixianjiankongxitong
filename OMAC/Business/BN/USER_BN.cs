using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Business.BN
{
    public class USER_BN
    {
        public string GetMonitorTimeList()
        {
            try
            {
                using (DataBaseLayer dataBaseLayer = new DataBaseLayer())
                {
                    DataTable dt = new DataTable();
                    StringBuilder strBuilder = new StringBuilder("select distinct DT from ZT");
                    strBuilder.Append("").Append(" t  where t.dt like to_date('");
                    strBuilder.Append("2016-4-23");
                    strBuilder.Append("','yyyy-mm-dd')and t.id=").Append("0136").Append(" order by DT desc");
                    //'2016/4/2 1:00:00','yyyy-mm-dd hh24:mi:ss') and t.id=:buoyId 

                    dt = dataBaseLayer.ExecuteQuery(strBuilder.ToString());

                    if (dt.Rows.Count > 0)
                    {
                        List<string> strList = new List<string>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            strList.Add(Convert.ToDateTime(dt.Rows[i][0].ToString()).ToLongTimeString());
                        }
                        return JsonConvert.SerializeObject(strList);
                    }
                }
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(USER_BN), "GetMonitorTimeList()当天获得实时数据的时间序列 程序段的异常" + ex);
                return "";
            }
            finally
            {

            }
            return "";
        }
    }
}
