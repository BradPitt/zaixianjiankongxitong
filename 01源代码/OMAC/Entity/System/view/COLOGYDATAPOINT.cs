using System;
using System.Runtime.Serialization;

namespace Entity
{
    /// <summary>
    /// 统计分析
    /// </summary>
    [DataContract]
    public class COLOGYDATAPOINT
    {
        /// <summary>
        /// x或y轴绑定值，此处为时间
        /// </summary>
        [DataMember]
        public string argument { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        public string value { get; set; }
    }
}
