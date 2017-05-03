using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OMAC.MVCControllers
{
    public class BaseMVCController : Controller
    {
        /// <summary>
        /// 每次请求判断session
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContextBase context = filterContext.HttpContext;
            HttpResponseBase response = filterContext.HttpContext.Response;
            HttpRequestBase request = filterContext.HttpContext.Request;

            if (Session["userInfo"] == null && (filterContext.ActionDescriptor.ActionName != "Login" && filterContext.ActionDescriptor.ActionName != "Logins"))
            {
                response.Write("<script> window.location.href = \"/Manager/Login\";</script>");
                response.End();
                return;
            }

            base.OnActionExecuting(filterContext);
        }

    }
}
