using System;
using System.Runtime.Serialization;
namespace Entity
{
    [Serializable]
    [DataContract]
    public class DEVICEINFO : DEVICEATTACH
    {
        /// <summary>
        /// DEVICECODE
        /// </summary>
        [DataMember]
        public string DEVICECODE { get; set; }
        /// <summary>
        /// DEVICENAME
        /// </summary>
        [DataMember]
        public string DEVICENAME { get; set; }
        /// <summary>
        /// DEVICEUSER
        /// </summary>
        [DataMember]
        public string DEVICEUSER { get; set; }
        /// <summary>
        /// DEVICETYPE
        /// </summary>
        [DataMember]
        public decimal DEVICETYPE { get; set; }
        /// <summary>
        /// LAYTIME
        /// </summary>
        [DataMember]
        public DateTime LAYTIME { get; set; }
        /// <summary>
        /// ELON
        /// </summary>
        [DataMember]
        public decimal ELON { get; set; }
        /// <summary>
        /// ELAT
        /// </summary>
        [DataMember]
        public decimal ELAT { get; set; }
        /// <summary>
        /// COMTYPE
        /// </summary>
        [DataMember]
        public string COMTYPE { get; set; }
        /// <summary>
        /// STRUCTTYPE
        /// </summary>
        [DataMember]
        public decimal STRUCTTYPE { get; set; }
        /// <summary>
        /// COMARRAY
        /// </summary>
        [DataMember]
        public byte[] COMARRAY { get; set; }
        /// <summary>
        /// PACKNUM
        /// </summary>
        [DataMember]
        public decimal PACKNUM { get; set; }
        /// <summary>
        /// RUNNINGSTATUS
        /// </summary>
        [DataMember]
        public decimal RUNNINGSTATUS { get; set; }
        /// <summary>
        /// POSITION
        /// </summary>
        [DataMember]
        public string POSITION { get; set; }
        /// <summary>
        /// PRODUCER
        /// </summary>
        [DataMember]
        public string PRODUCER { get; set; }
        /// <summary>
        /// MANAGER
        /// </summary>
        [DataMember]
        public string MANAGER { get; set; }
        /// <summary>
        /// RESERV0
        /// </summary>
        [DataMember]
        public string RESERV0 { get; set; }
        /// <summary>
        /// RESERV1
        /// </summary>
        [DataMember]
        public string RESERV1 { get; set; }
        /// <summary>
        /// RESERV2
        /// </summary>
        [DataMember]
        public string RESERV2 { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>	
        [DataMember]
        public int limit { get; set; }

        /// <summary>
        /// 页码
        /// </summary>	
        [DataMember]
        public int page { get; set; }
    }
}