﻿using Business.BN;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using Entity.System;

namespace OMAC.Controllers
{
    public class SystemController : ApiController
    {
        #region 主页修改

        
        [HttpPost]
        public dynamic GetFunctionTreeV2(string part)
        {
            var bn = new FUNCTIONINFO_BN();
            var rst=bn.GetFunctionTree2(part);
            return JsonConvert.DeserializeObject<dynamic>(rst);
        }

        #endregion

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
        public string GetFunctionTree2(string part)
        {
            FUNCTIONINFO_BN fun = new FUNCTIONINFO_BN();
            return fun.GetFunctionTree2(part);
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
        [HttpPost]
        public DataTablesResult GetDeviceInfoList(string bianhao, string haiqu, string shengfen, string haiwan, string jushusheshi, string difangsheshi, string yewu, int dType)
        {
            DEVICEINFO device = new DEVICEINFO();
            device.DEVICECODE = bianhao;
            device.SEAAREA = haiqu;
            device.PROVINCE = shengfen;
            device.BAY = haiwan;
            device.BUREAUDEVICE = jushusheshi;
            device.LOCALDEVICE = difangsheshi;
            device.SERVICE = yewu;
            device.DEVICETYPE = dType;
            DEVICEINFO_BN fun = new DEVICEINFO_BN();
            return fun.GetDeviceInfo(device);
        }

        // 设备详细信息
        [HttpPost]
        public Entity.DEVICEINFO GetModel(string deviceCode)
        {
            DEVICEINFO_BN fun = new DEVICEINFO_BN();
            return fun.GetModel(deviceCode);
        }

        // 实时数据读取 浮标
        [HttpPost]
        public string GetSSSJ(string deviceCode, int dType)
        {
            DEVICEINFO_BN drow = new DEVICEINFO_BN();
            DataTablesResult deviceRow = drow.getDeviceRow(deviceCode);

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (1 == dType) //岸基
            {
                TAB_BN anji = new TAB_BN();
                Entity.TAB data = anji.GetTABModel(deviceCode);
                dictionary.Add("ShuiZhi", data.ShuiZhi);
                dictionary.Add("ShuiWen", data.ShuiWen);
                dictionary.Add("QIXG", data.QIXG);
                dictionary.Add("STATUS", data.STATUS);
                dictionary.Add("DEVICEROW", deviceRow.aaData);
                dictionary.Add("BiaoZhun", data.BiaoZhun);
            }
            else //浮标
            {
                TABBUOY_BN buoy = new TABBUOY_BN();
                Entity.TABBUOY data = buoy.GetTABBUOYModel(deviceCode);
                dictionary.Add("COLOGY", data.COLOGY);
                dictionary.Add("BoLang", data.BoLang);
                dictionary.Add("HaiLiu", data.HaiLiu);
                dictionary.Add("QiWenQiYa", data.QiWenQiYa);
                dictionary.Add("QiXiang", data.QiXiang);
                dictionary.Add("FengSuFengXiang", data.FengSuFengXiang);
                dictionary.Add("STATUS", data.STATUS);
                dictionary.Add("DEVICEROW", deviceRow.aaData);
                dictionary.Add("BiaoZhun", data.BiaoZhun);
            }
            return JsonConvert.SerializeObject(dictionary);

        }

        /// <summary>
        /// 获取监测要素的信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public DataTable GetElementsList()
        {
            DICTIONARY_BN dic = new DICTIONARY_BN();
            return dic.GetList();
        }

        /// <summary>
        /// 趋势分析图表
        /// </summary>
        /// <param name="deviceCode"></param>
        /// <param name="strId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetQuShiFenXi(string deviceCode, string strId, string startDate, string endDate, string deviceType)
        {
            if (deviceType == "1")
            {
                // 岸基站
                TABECOLOGY_BN co = new TABECOLOGY_BN();
                return co.TrendAnalysis(deviceCode, strId, startDate, endDate);
            }
            else if (deviceType == "2")
            {
                // 浮标
                TABBUOYECOLOGY_BN co = new TABBUOYECOLOGY_BN();
                return co.TrendAnalysis(deviceCode, strId, startDate, endDate);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 同步分析图表
        /// </summary>
        /// <param name="deviceCode"></param>
        /// <param name="strId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetTongBuFenXi(string deviceCode, string strId, string startDate, string endDate, string deviceType)
        {
            if (deviceType == "1")
            {
                // 岸基站
                TABECOLOGY_BN co = new TABECOLOGY_BN();
                return co.SynchronizeAnalysis(deviceCode, strId, startDate, endDate);
            }
            else if (deviceType == "2")
            {
                // 浮标
                TABBUOYECOLOGY_BN co = new TABBUOYECOLOGY_BN();
                return co.SynchronizeAnalysis(deviceCode, strId, startDate, endDate);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取达标率
        /// </summary>
        /// <param name="devicecode">设备编号</param>
        /// <param name="jcys">监测项目</param>
        /// <param name="beginDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetDabiaolv(string devicecode, string jcys, string beginDate, string endDate)
        {
            var bn = new Pingjia();
            return bn.GetDabiaolv(devicecode, jcys, beginDate, endDate);
        }

        /// <summary>
        /// 获取系统日志列表
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet]
        public PageData GetSystemLogList(string logType, string startDate, string endDate, int pageNumber, int pageSize)
        {
            SYSTEMLOG_BN log = new SYSTEMLOG_BN();
            PageData pd = new PageData();
            DataTablesResult result = log.GetList(logType, startDate, endDate, pageNumber, pageSize);
            pd.Data = result.aaData;
            pd.PageCount = pageSize;
            pd.RecordCount = Convert.ToInt32(result.iTotalRecords);
            return pd;
        }


        #region 系统设置

        /// <summary>
        /// 获取部门树
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<TreeEntity> GetDepartmentTree()
        {
            var bn = new DEPARTMENTINFO_BN();
            var tree = bn.GetDepartmentTree();
            return tree;
        }

        /// <summary>
        /// 获取部门树
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<TreeEntity> GetDepartmentTreeByUser(string userAccount)
        {
            var bn = new DEPARTMENTINFO_BN();
            var tree = bn.GetDepartmentTreeByUser(userAccount);
            return tree;
        }

        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="deptName">部门名称</param>
        /// <param name="pid">父节点ID</param>
        /// <returns>是否成功的JSON结果</returns>
        [HttpGet]
        public dynamic AddDepartment(string deptName, string pid)
        {
            var bn = new DEPARTMENTINFO_BN();
            var rst = bn.AddDepartment(deptName, pid)
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":true,\"msg\":\"\"}";

            return JsonConvert.DeserializeObject<dynamic>(rst);
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="deptName">部门名称</param>
        /// <param name="id">部门ID</param>
        /// <returns>是否成功的JSON结果</returns>
        [HttpGet]
        public dynamic UpdateDepartment(string deptName, string id)
        {
            var bn = new DEPARTMENTINFO_BN();
            var rst = bn.UpdateDepartment(deptName, id)
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":true,\"msg\":\"\"}";

            return JsonConvert.DeserializeObject<dynamic>(rst);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">部门ID</param>
        /// <returns>是否成功的JSON结果</returns>
        [HttpGet]
        public dynamic DeleteDepartment(string id)
        {
            var bn = new DEPARTMENTINFO_BN();
            var rst = bn.DeleteDepartment(id)
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":true,\"msg\":\"\"}";

            return JsonConvert.DeserializeObject<dynamic>(rst);
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="queryModel">查询条件</param>
        /// <returns></returns>
        [HttpGet]
        public Entity.MonitorLog.BootstrapTableDataModel GetRoleList([FromUri]Entity.System.view.QueryModel queryModel)
        {
            var bn = new USERROLE_BN();
            var rows = bn.GetRoleList(queryModel);
            var rst = new Entity.MonitorLog.BootstrapTableDataModel
            {
                rows = rows,
                total = rows.Rows.Count > 0 ? Convert.ToInt32(rows.Rows[0]["RESULT_COUNT"]) : 0
            };
            return rst;
        }

        /// <summary>
        /// 获取全部角色(绑定下拉框)
        /// </summary>
        [HttpGet]
        public DataTable GetAllRoles(string userAccount)
        {
            var bn = new ROLEINFO_BN();
            var rst = bn.GetAllRoles(userAccount);
            return rst;
        }


        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>是否成功的JSON结果</returns>
        [HttpGet]
        public dynamic DeleteRole(string id)
        {
            var bn = new USERROLE_BN();
            var rst = bn.DeleteRole(id)
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":false,\"msg\":\"\"}";

            return JsonConvert.DeserializeObject<dynamic>(rst);
        }

        /// <summary>
        /// 新增/修改角色
        /// </summary>
        /// <param name="roleinfo">角色实体类</param>
        /// <returns>返回状态对象</returns>
        public dynamic EditRole(Entity.ROLEINFO roleinfo)
        {
            var bn = new ROLEINFO_BN();
            bool isOk = string.IsNullOrWhiteSpace(roleinfo.F_ROLECODE)
                ? bn.AddRoleMain(roleinfo)
                : bn.EditRoleMain(roleinfo);

            return JsonConvert.DeserializeObject<dynamic>(isOk
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":false,\"msg\":\"\"}");
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="queryModel">查询条件</param>
        [HttpGet]
        public Entity.MonitorLog.BootstrapTableDataModel GetUserList([FromUri]Entity.System.view.QueryModelUser queryModel)
        {
            var bn = new USERINFO_BN();
            var rows = bn.GetUsersList(queryModel);
            var rst = new Entity.MonitorLog.BootstrapTableDataModel
            {
                rows = rows,
                total = rows.Rows.Count > 0 ? Convert.ToInt32(rows.Rows[0]["RESULT_COUNT"]) : 0
            };
            return rst;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns>是否成功的JSON结果</returns>
        [HttpGet]
        public dynamic DeleteUser(string id)
        {
            var bn = new USERINFO_BN();
            var rst = bn.DeleteUser(id)
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":false,\"msg\":\"\"}";

            return JsonConvert.DeserializeObject<dynamic>(rst);
        }

        /// <summary>
        /// 新增/修改用户
        /// </summary>
        /// <param name="userinfo">用户实体类</param>
        /// <returns>返回状态对象</returns>
        public dynamic EditUser(Entity.USERINFO userinfo)
        {
            var bn = new USERINFO_BN();
            bool isOk = string.IsNullOrWhiteSpace(userinfo.F_ACCOUNT)
                ? bn.AddUserMain(userinfo)
                : bn.EditUserMain(userinfo);

            return JsonConvert.DeserializeObject<dynamic>(isOk
                ? "{\"status\":true,\"msg\":\"\"}"
                : "{\"status\":false,\"msg\":\"\"}");
        }

        #endregion



    }
}
