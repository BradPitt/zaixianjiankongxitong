﻿using System;
using System.Runtime.Serialization;
namespace Entity
{
    /// <summary>
    /// 状态信息表(浮标)
    /// </summary>
    [Serializable]
    [DataContract]
    public class TABBUOYSTATUS
    {
        /// <summary>
        /// 浮标号
        /// </summary>
        [DataMember]
        public string DEVICECODE { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        [DataMember]
        public DateTime DATETIME { get; set; }
        /// <summary>
        /// 发送通讯号
        /// </summary>
        [DataMember]
        public decimal SENDNUM { get; set; }
        /// <summary>
        /// 接收通讯号
        /// </summary>
        [DataMember]
        public decimal RECVNUM { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        [DataMember]
        public decimal LON { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        [DataMember]
        public decimal LAT { get; set; }
        /// <summary>
        /// 方位
        /// </summary>
        [DataMember]
        public decimal AZIMUTH { get; set; }
        /// <summary>
        /// 电压
        /// </summary>
        [DataMember]
        public decimal VOLTAGE { get; set; }
        /// <summary>
        /// 锚灯
        /// </summary>
        [DataMember]
        public decimal ANCHOR { get; set; }
        /// <summary>
        /// 水警
        /// </summary>
        [DataMember]
        public decimal WATERALARM { get; set; }
        /// <summary>
        /// 门警
        /// </summary>
        [DataMember]
        public decimal DOORALARM { get; set; }
        /// <summary>
        /// GPS报警
        /// </summary>
        [DataMember]
        public decimal GPSALARM { get; set; }
        /// <summary>
        /// 内存
        /// </summary>
        [DataMember]
        public decimal FREEMEMO { get; set; }
        /// <summary>
        /// 传感器状态
        /// </summary>
        [DataMember]
        public decimal SENSERSTATUS { get; set; }
        /// <summary>
        /// RESERV0
        /// </summary>
        [DataMember]
        public decimal RESERV0 { get; set; }
        /// <summary>
        /// RESERV1
        /// </summary>
        [DataMember]
        public decimal RESERV1 { get; set; }
        /// <summary>
        /// RESERV2
        /// </summary>
        [DataMember]
        public decimal RESERV2 { get; set; }
        /// <summary>
        /// 浮标状态
        /// </summary>
        [DataMember]
        public decimal BUOYSTATUS { get; set; }
    }
}