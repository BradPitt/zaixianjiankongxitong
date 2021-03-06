﻿using Business.BN;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OMAC.Controllers
{
    public class SystemController : ApiController
    {
        [HttpPost]
        public string GetMonitorTimeList()
        {
            USER_BN user_bn = new USER_BN();
            return user_bn.GetMonitorTimeList();
        }

        [HttpPost]
        public string GetFunctionTree(string part)
        {
            FUNCTIONINFO_BN fun = new FUNCTIONINFO_BN();
            return fun.GetFunctionTree(part);
        }

        [HttpPost]
        public ReturnResult SaveRole(string roleName, string funList)
        {
            ROLEINFO role = new ROLEINFO();
            role.F_NAME = roleName;
            string[] funs = funList.Split(',');
            ROLEINFO_BN role_bn = new ROLEINFO_BN();
            return role_bn.AddRole(role, funs);
        }

        /// <summary>
        /// 根据部门ID获取用户名下拉框方法
        /// </summary>
        /// <param name="code">部门ID</param>
        /// <returns></returns>
        [HttpPost]
        public ReturnResult GetNameList(string code)
        {
            ReturnResult data = new ReturnResult();
            DEPARTMENTUSER_BN depUser = new DEPARTMENTUSER_BN();
            data.data = depUser.GetNameList(code);
            return data;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns></returns>
        [HttpPost]
        public ReturnResult Logins(USERINFO user)
        {
            ReturnResult result = new ReturnResult();
            USERINFO_BN userBN = new USERINFO_BN();
            DataTable dt = userBN.GetUserList(user);

            if (dt.Rows.Count > 0)
            {
                result.success = true;
                result.data = dt;
            }
            return result;
        }

        ///// <summary>
        ///// 获取的列表
        ///// </summary>
        ///// <param name="query">查询条件</param>
        ///// <returns></returns>
        //[HttpPost]
        //public PageData GetDeviceInfo(DEVICEINFO device)
        //{
        //    DEVICEINFO_BN bn = new DEVICEINFO_BN();
        //    PageData pd = new PageData();

        //    DataTablesResult result = bn.GetDeviceInfo(device);
        //    pd.Data = result.aaData;
        //    pd.PageCount = device.limit;
        //    pd.RecordCount = Convert.ToInt32(result.iTotalRecords);
        //    return pd;
        //}

    }
}
