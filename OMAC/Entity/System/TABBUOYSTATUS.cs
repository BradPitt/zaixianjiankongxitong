﻿using System;
using System.Runtime.Serialization;
namespace Entity
{
    [Serializable]
    [DataContract]
    public class TABBUOYSTATUS
    {
        /// <summary>
        /// DEVICECODE
        /// </summary>
        [DataMember]
        public string DEVICECODE { get; set; }
        /// <summary>
        /// DATETIME
        /// </summary>
        [DataMember]
        public DateTime DATETIME { get; set; }
        /// <summary>
        /// SENDNUM
        /// </summary>
        [DataMember]
        public decimal SENDNUM { get; set; }
        /// <summary>
        /// RECVNUM
        /// </summary>
        [DataMember]
        public decimal RECVNUM { get; set; }
        /// <summary>
        /// LON
        /// </summary>
        [DataMember]
        public decimal LON { get; set; }
        /// <summary>
        /// LAT
        /// </summary>
        [DataMember]
        public decimal LAT { get; set; }
        /// <summary>
        /// AZIMUTH
        /// </summary>
        [DataMember]
        public decimal AZIMUTH { get; set; }
        /// <summary>
        /// VOLTAGE
        /// </summary>
        [DataMember]
        public decimal VOLTAGE { get; set; }
        /// <summary>
        /// ANCHOR
        /// </summary>
        [DataMember]
        public decimal ANCHOR { get; set; }
        /// <summary>
        /// WATERALARM
        /// </summary>
        [DataMember]
        public decimal WATERALARM { get; set; }
        /// <summary>
        /// DOORALARM
        /// </summary>
        [DataMember]
        public decimal DOORALARM { get; set; }
        /// <summary>
        /// GPSALARM
        /// </summary>
        [DataMember]
        public decimal GPSALARM { get; set; }
        /// <summary>
        /// FREEMEMO
        /// </summary>
        [DataMember]
        public decimal FREEMEMO { get; set; }
        /// <summary>
        /// SENSERSTATUS
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
    }
}