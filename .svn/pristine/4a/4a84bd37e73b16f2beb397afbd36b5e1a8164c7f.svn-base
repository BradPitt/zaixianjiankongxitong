using Business.BN;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OMAC.MVCControllers
{
    public class ManagerController : BaseMVCController
    {
        //
        // GET: /Manager/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RoleAdd()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult DeviceInfoList()
        {
            return View();
        }
        /// <summary>
        /// 登录界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            // 获取所有的部门
            DEPARTMENTINFO_BN depinfo = new DEPARTMENTINFO_BN();
            DataTable dt = depinfo.GetAll();

            return View(dt);
        }

        /// <summary>
        /// 根据用户名 密码进行登录
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ActionResult Logins(string userID)
        {
            USERINFO_BN user = new USERINFO_BN();
            USERINFO dtuser = (USERINFO)user.GetModel(userID);
            Session["userInfo"] = dtuser;

            return RedirectToAction("Index");
        }

    }
}
