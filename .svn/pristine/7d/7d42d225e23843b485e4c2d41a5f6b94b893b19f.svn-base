using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.BN
{
    /// <summary>
    /// 浮标
    /// </summary>
    public class TABBUOY_BN
    {
        /// <summary>
        /// 获取浮标的详情
        /// </summary>
        public Entity.TABBUOY GetTABBUOYModel(string deviceCode)
        {
            Entity.TABBUOY buoy = new Entity.TABBUOY();

            TABBUOYECOLOGY_BN cology = new TABBUOYECOLOGY_BN();
            buoy.COLOGY = cology.GetModel(deviceCode);

            TABBUOYHYDROLOGY_BN hydrology = new TABBUOYHYDROLOGY_BN();
            buoy.BoLang = hydrology.GetBoLangModel(deviceCode);
            buoy.HaiLiu = hydrology.GetHaiLiuModel(deviceCode);

            TABBUOYQIXG_BN qixiang = new TABBUOYQIXG_BN();
            buoy.QiWenQiYa = qixiang.GetQiWenQiYaModel(deviceCode);
            buoy.QiXiang = qixiang.GetQiXiangModel(deviceCode);
            buoy.FengSuFengXiang = qixiang.GetFengSuFengXiangModel(deviceCode);

            TABBUOYSTATUS_BN status = new TABBUOYSTATUS_BN();
            buoy.STATUS = status.GetModel(deviceCode);

            return buoy;
        }
    }
}
