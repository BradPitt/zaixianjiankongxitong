using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Entity
{
    /// <summary>
    /// 浮标类
    /// </summary>
    [Serializable]
    [DataContract]
    public class TABBUOY
    {
        /// <summary>
        /// 生态数据表
        /// </summary>
        public TABBUOYECOLOGY COLOGY { get; set; }

        /// <summary>
        /// 水文数据表:波浪
        /// </summary>
        public TABBUOYHYDROLOGY BoLang { get; set; }

        /// <summary>
        /// 水文数据表:海流
        /// </summary>
        public List<Entity.TABBUOYHYDROLOGY> HaiLiu { get; set; }

        /// <summary>
        /// 气象数据表:气温气压
        /// </summary>
        public TABBUOYQIXG QiWenQiYa { get; set; }

        /// <summary>
        /// 气象数据表:气象
        /// </summary>
        public TABBUOYQIXG QiXiang { get; set; }

        /// <summary>
        /// 气象数据表:风速风向
        /// </summary>
        public TABBUOYQIXG FengSuFengXiang { get; set; }

        /// <summary>
        /// 状态信息表
        /// </summary>
        public TABBUOYSTATUS STATUS { get; set; }

    }
}
