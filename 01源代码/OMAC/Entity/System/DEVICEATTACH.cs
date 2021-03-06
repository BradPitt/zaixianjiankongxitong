﻿using System;
using System.Runtime.Serialization;
namespace Entity
{
    [Serializable]
    [DataContract]
    public class DEVICEATTACH
    {
        /// <summary>
        /// 设备号
        /// </summary>
        [DataMember]
        public string DEVICECODE { get; set; }
        /// <summary>
        /// 海域
        /// </summary>
        [DataMember]
        public string SEAAREA { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        [DataMember]
        public string PROVINCE { get; set; }
        /// <summary>
        /// 海湾
        /// </summary>
        [DataMember]
        public string BAY { get; set; }
        /// <summary>
        /// 局属设施
        /// </summary>
        [DataMember]
        public string BUREAUDEVICE { get; set; }
        /// <summary>
        /// 地方设施
        /// </summary>
        [DataMember]
        public string LOCALDEVICE { get; set; }
        /// <summary>
        /// 业务
        /// </summary>
        [DataMember]
        public string SERVICE { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        [DataMember]
        public string PICTUREPATH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string STDTYPE { get; set; }
    }
}