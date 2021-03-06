﻿using System;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OMAC.MVCControllers
{
    public class MonitorLogController : BaseMVCController
    {
        public ActionResult Index()
        {
            return View();
        }

        public void ExportExcel([FromUri]Entity.MonitorLog.QueryModel queryModel)
        {
            HttpContext curContext = System.Web.HttpContext.Current;

            var datatable = new Business.BN.MonitorLog().GetExcelList(queryModel);
            if (datatable.Rows.Count <= 0)
            {
                curContext.Response.Write("<script>alert(\"没有找到匹配的记录!\");</script>");
                curContext.Response.End();
                return;
            }

            datatable.Columns["devicename"].Caption = "invisible";

            var strFileName = "监控历史数据.xls";
            var strHeaderText = string.Format("{0} {1} 至 {2} 的监控历史数据", datatable.Rows[0]["devicename"], queryModel.beginTime, queryModel.endTime);

            curContext.Response.ContentType = "application/vnd.ms-excel";
            curContext.Response.ContentEncoding = Encoding.UTF8;
            curContext.Response.Charset = "";
            curContext.Response.AppendHeader("Content-Disposition",
                "attachment;filename=" + HttpUtility.UrlEncode(strFileName, Encoding.UTF8));

            curContext.Response.BinaryWrite(Business.NpoiHelper.Export(datatable, strHeaderText).GetBuffer());
            curContext.Response.End();
        }


    }
}
