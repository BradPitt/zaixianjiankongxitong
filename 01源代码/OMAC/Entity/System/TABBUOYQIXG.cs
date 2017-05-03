using System;
using System.Runtime.Serialization;
namespace Entity
{
    /// <summary>
    /// 气象数据表(浮标)
    /// </summary>
    [Serializable]
    [DataContract]
    public class TABBUOYQIXG
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
        /// NJD
        /// </summary>
        [DataMember]
        public decimal NJD { get; set; }
        /// <summary>
        /// RAINFALLACTUAL
        /// </summary>
        [DataMember]
        public decimal RAINFALLACTUAL { get; set; }
        /// <summary>
        /// RAINFALLPREV
        /// </summary>
        [DataMember]
        public decimal RAINFALLPREV { get; set; }
        /// <summary>
        /// RAINFALL
        /// </summary>
        [DataMember]
        public decimal RAINFALL { get; set; }
        /// <summary>
        /// TOTALRADIATION
        /// </summary>
        [DataMember]
        public decimal TOTALRADIATION { get; set; }
        /// <summary>
        /// INFRAREDRADIATION
        /// </summary>
        [DataMember]
        public decimal INFRAREDRADIATION { get; set; }
        /// <summary>
        /// SUNLIGHTTIME
        /// </summary>
        [DataMember]
        public decimal SUNLIGHTTIME { get; set; }
        /// <summary>
        /// AIRCO2
        /// </summary>
        [DataMember]
        public decimal AIRCO2 { get; set; }
        /// <summary>
        /// AIRTEM1
        /// </summary>
        [DataMember]
        public decimal AIRTEM1 { get; set; }
        /// <summary>
        /// AIRTEM2
        /// </summary>
        [DataMember]
        public decimal AIRTEM2 { get; set; }
        /// <summary>
        /// AIRTEM3
        /// </summary>
        [DataMember]
        public decimal AIRTEM3 { get; set; }
        /// <summary>
        /// AIRTEM4
        /// </summary>
        [DataMember]
        public decimal AIRTEM4 { get; set; }
        /// <summary>
        /// AIRTEM5
        /// </summary>
        [DataMember]
        public decimal AIRTEM5 { get; set; }
        /// <summary>
        /// AIRTEM6
        /// </summary>
        [DataMember]
        public decimal AIRTEM6 { get; set; }
        /// <summary>
        /// AIRTEM7
        /// </summary>
        [DataMember]
        public decimal AIRTEM7 { get; set; }
        /// <summary>
        /// AIRTEM8
        /// </summary>
        [DataMember]
        public decimal AIRTEM8 { get; set; }
        /// <summary>
        /// AIRTEM9
        /// </summary>
        [DataMember]
        public decimal AIRTEM9 { get; set; }
        /// <summary>
        /// AIRTEM10
        /// </summary>
        [DataMember]
        public decimal AIRTEM10 { get; set; }

        /// <summary>
        /// 平均气温
        /// </summary>
        public decimal AIRTEM { get; set; }

        /// <summary>
        /// MAXAIRTEM
        /// </summary>
        [DataMember]
        public decimal MAXAIRTEM { get; set; }
        /// <summary>
        /// MAXAIRTEMTIME
        /// </summary>
        [DataMember]
        public decimal MAXAIRTEMTIME { get; set; }
        /// <summary>
        /// MINAIRTEM
        /// </summary>
        [DataMember]
        public decimal MINAIRTEM { get; set; }
        /// <summary>
        /// MINAIRTEMTIME
        /// </summary>
        [DataMember]
        public decimal MINAIRTEMTIME { get; set; }
        /// <summary>
        /// HUMI1
        /// </summary>
        [DataMember]
        public decimal HUMI1 { get; set; }
        /// <summary>
        /// HUMI2
        /// </summary>
        [DataMember]
        public decimal HUMI2 { get; set; }
        /// <summary>
        /// HUMI3
        /// </summary>
        [DataMember]
        public decimal HUMI3 { get; set; }
        /// <summary>
        /// HUMI4
        /// </summary>
        [DataMember]
        public decimal HUMI4 { get; set; }
        /// <summary>
        /// HUMI5
        /// </summary>
        [DataMember]
        public decimal HUMI5 { get; set; }
        /// <summary>
        /// HUMI6
        /// </summary>
        [DataMember]
        public decimal HUMI6 { get; set; }
        /// <summary>
        /// HUMI7
        /// </summary>
        [DataMember]
        public decimal HUMI7 { get; set; }
        /// <summary>
        /// HUMI8
        /// </summary>
        [DataMember]
        public decimal HUMI8 { get; set; }
        /// <summary>
        /// HUMI9
        /// </summary>
        [DataMember]
        public decimal HUMI9 { get; set; }
        /// <summary>
        /// HUMI10
        /// </summary>
        [DataMember]
        public decimal HUMI10 { get; set; }

        /// <summary>
        /// 平均湿度
        /// </summary>
        public decimal HUM { get; set; }

        /// <summary>
        /// MAXHUMI
        /// </summary>
        [DataMember]
        public decimal MAXHUMI { get; set; }
        /// <summary>
        /// MAXHUMITIME
        /// </summary>
        [DataMember]
        public decimal MAXHUMITIME { get; set; }
        /// <summary>
        /// MINHUMI
        /// </summary>
        [DataMember]
        public decimal MINHUMI { get; set; }
        /// <summary>
        /// MINHUMITIME
        /// </summary>
        [DataMember]
        public decimal MINHUMITIME { get; set; }
        /// <summary>
        /// PRESSURE1
        /// </summary>
        [DataMember]
        public decimal PRESSURE1 { get; set; }
        /// <summary>
        /// PRESSURE2
        /// </summary>
        [DataMember]
        public decimal PRESSURE2 { get; set; }
        /// <summary>
        /// PRESSURE3
        /// </summary>
        [DataMember]
        public decimal PRESSURE3 { get; set; }
        /// <summary>
        /// PRESSURE4
        /// </summary>
        [DataMember]
        public decimal PRESSURE4 { get; set; }
        /// <summary>
        /// PRESSURE5
        /// </summary>
        [DataMember]
        public decimal PRESSURE5 { get; set; }
        /// <summary>
        /// PRESSURE6
        /// </summary>
        [DataMember]
        public decimal PRESSURE6 { get; set; }
        /// <summary>
        /// PRESSURE7
        /// </summary>
        [DataMember]
        public decimal PRESSURE7 { get; set; }
        /// <summary>
        /// PRESSURE8
        /// </summary>
        [DataMember]
        public decimal PRESSURE8 { get; set; }
        /// <summary>
        /// PRESSURE9
        /// </summary>
        [DataMember]
        public decimal PRESSURE9 { get; set; }
        /// <summary>
        /// PRESSURE10
        /// </summary>
        [DataMember]
        public decimal PRESSURE10 { get; set; }

        /// <summary>
        /// 平均气压
        /// </summary>
        public decimal PRESSURE { get; set; }

        /// <summary>
        /// MAXPRESSURE
        /// </summary>
        [DataMember]
        public decimal MAXPRESSURE { get; set; }
        /// <summary>
        /// MAXPRESSURETIME
        /// </summary>
        [DataMember]
        public decimal MAXPRESSURETIME { get; set; }
        /// <summary>
        /// MINPRESSURE
        /// </summary>
        [DataMember]
        public decimal MINPRESSURE { get; set; }
        /// <summary>
        /// MINPRESSURETIME
        /// </summary>
        [DataMember]
        public decimal MINPRESSURETIME { get; set; }
        /// <summary>
        /// WINDSPD1
        /// </summary>
        [DataMember]
        public decimal WINDSPD1 { get; set; }
        /// <summary>
        /// WINDDIR1
        /// </summary>
        [DataMember]
        public decimal WINDDIR1 { get; set; }
        /// <summary>
        /// WINDSPD2
        /// </summary>
        [DataMember]
        public decimal WINDSPD2 { get; set; }
        /// <summary>
        /// WINDDIR2
        /// </summary>
        [DataMember]
        public decimal WINDDIR2 { get; set; }
        /// <summary>
        /// WINDSPD3
        /// </summary>
        [DataMember]
        public decimal WINDSPD3 { get; set; }
        /// <summary>
        /// WINDDIR3
        /// </summary>
        [DataMember]
        public decimal WINDDIR3 { get; set; }
        /// <summary>
        /// WINDSPD4
        /// </summary>
        [DataMember]
        public decimal WINDSPD4 { get; set; }
        /// <summary>
        /// WINDDIR4
        /// </summary>
        [DataMember]
        public decimal WINDDIR4 { get; set; }
        /// <summary>
        /// WINDSPD5
        /// </summary>
        [DataMember]
        public decimal WINDSPD5 { get; set; }
        /// <summary>
        /// WINDDIR5
        /// </summary>
        [DataMember]
        public decimal WINDDIR5 { get; set; }
        /// <summary>
        /// WINDSPD6
        /// </summary>
        [DataMember]
        public decimal WINDSPD6 { get; set; }
        /// <summary>
        /// WINDDIR6
        /// </summary>
        [DataMember]
        public decimal WINDDIR6 { get; set; }
        /// <summary>
        /// WINDSPD7
        /// </summary>
        [DataMember]
        public decimal WINDSPD7 { get; set; }
        /// <summary>
        /// WINDDIR7
        /// </summary>
        [DataMember]
        public decimal WINDDIR7 { get; set; }
        /// <summary>
        /// WINDSPD8
        /// </summary>
        [DataMember]
        public decimal WINDSPD8 { get; set; }
        /// <summary>
        /// WINDDIR8
        /// </summary>
        [DataMember]
        public decimal WINDDIR8 { get; set; }
        /// <summary>
        /// WINDSPD9
        /// </summary>
        [DataMember]
        public decimal WINDSPD9 { get; set; }
        /// <summary>
        /// WINDDIR9
        /// </summary>
        [DataMember]
        public decimal WINDDIR9 { get; set; }
        /// <summary>
        /// WINDSPD10
        /// </summary>
        [DataMember]
        public decimal WINDSPD10 { get; set; }
        /// <summary>
        /// WINDDIR10
        /// </summary>
        [DataMember]
        public decimal WINDDIR10 { get; set; }
        /// <summary>
        /// MAXWINDSPD
        /// </summary>
        [DataMember]
        public decimal MAXWINDSPD { get; set; }
        /// <summary>
        /// MAXWINDDIR
        /// </summary>
        [DataMember]
        public decimal MAXWINDDIR { get; set; }
        /// <summary>
        /// MAXWINDTIME
        /// </summary>
        [DataMember]
        public decimal MAXWINDTIME { get; set; }
        /// <summary>
        /// HUGEWINDSPD
        /// </summary>
        [DataMember]
        public decimal HUGEWINDSPD { get; set; }
        /// <summary>
        /// HUGEWINDDIR
        /// </summary>
        [DataMember]
        public decimal HUGEWINDDIR { get; set; }
        /// <summary>
        /// HUGEWINDTIME
        /// </summary>
        [DataMember]
        public decimal HUGEWINDTIME { get; set; }
        /// <summary>
        /// TENMINAVESPD
        /// </summary>
        [DataMember]
        public decimal TENMINAVESPD { get; set; }
        /// <summary>
        /// TENMINAVEDIR
        /// </summary>
        [DataMember]
        public decimal TENMINAVEDIR { get; set; }
        /// <summary>
        /// INSTANTSPD
        /// </summary>
        [DataMember]
        public decimal INSTANTSPD { get; set; }
        /// <summary>
        /// INSTANTDIR
        /// </summary>
        [DataMember]
        public decimal INSTANTDIR { get; set; }
        /// <summary>
        /// TOWMINAVESPD
        /// </summary>
        [DataMember]
        public decimal TOWMINAVESPD { get; set; }
        /// <summary>
        /// TOWMINAVEDIR
        /// </summary>
        [DataMember]
        public decimal TOWMINAVEDIR { get; set; }
        /// <summary>
        /// AVEWINDSPD1
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD1 { get; set; }
        /// <summary>
        /// AVEWINDDIR1
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR1 { get; set; }
        /// <summary>
        /// AVEWINDSPD2
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD2 { get; set; }
        /// <summary>
        /// AVEWINDDIR2
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR2 { get; set; }
        /// <summary>
        /// AVEWINDSPD3
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD3 { get; set; }
        /// <summary>
        /// AVEWINDDIR3
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR3 { get; set; }
        /// <summary>
        /// AVEWINDSPD4
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD4 { get; set; }
        /// <summary>
        /// AVEWINDDIR4
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR4 { get; set; }
        /// <summary>
        /// AVEWINDSPD5
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD5 { get; set; }
        /// <summary>
        /// AVEWINDDIR5
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR5 { get; set; }
        /// <summary>
        /// AVEWINDSPD6
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD6 { get; set; }
        /// <summary>
        /// AVEWINDDIR6
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR6 { get; set; }
        /// <summary>
        /// AVEWINDSPD7
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD7 { get; set; }
        /// <summary>
        /// AVEWINDDIR7
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR7 { get; set; }
        /// <summary>
        /// AVEWINDSPD8
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD8 { get; set; }
        /// <summary>
        /// AVEWINDDIR8
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR8 { get; set; }
        /// <summary>
        /// AVEWINDSPD9
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD9 { get; set; }
        /// <summary>
        /// AVEWINDDIR9
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR9 { get; set; }
        /// <summary>
        /// AVEWINDSPD10
        /// </summary>
        [DataMember]
        public decimal AVEWINDSPD10 { get; set; }
        /// <summary>
        /// AVEWINDDIR10
        /// </summary>
        [DataMember]
        public decimal AVEWINDDIR10 { get; set; }
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
        /// RESERV3
        /// </summary>
        [DataMember]
        public decimal RESERV3 { get; set; }
        /// <summary>
        /// RESERV4
        /// </summary>
        [DataMember]
        public decimal RESERV4 { get; set; }
        /// <summary>
        /// RESERV5
        /// </summary>
        [DataMember]
        public decimal RESERV5 { get; set; }
        /// <summary>
        /// RESERV6
        /// </summary>
        [DataMember]
        public decimal RESERV6 { get; set; }
        /// <summary>
        /// RESERV7
        /// </summary>
        [DataMember]
        public decimal RESERV7 { get; set; }
        /// <summary>
        /// RESERV8
        /// </summary>
        [DataMember]
        public decimal RESERV8 { get; set; }
        /// <summary>
        /// RESERV9
        /// </summary>
        [DataMember]
        public decimal RESERV9 { get; set; }
        /// <summary>
        /// RESERV10
        /// </summary>
        [DataMember]
        public decimal RESERV10 { get; set; }
        /// <summary>
        /// RESERV11
        /// </summary>
        [DataMember]
        public decimal RESERV11 { get; set; }
        /// <summary>
        /// RESERV12
        /// </summary>
        [DataMember]
        public decimal RESERV12 { get; set; }
        /// <summary>
        /// RESERV13
        /// </summary>
        [DataMember]
        public decimal RESERV13 { get; set; }
        /// <summary>
        /// RESERV14
        /// </summary>
        [DataMember]
        public decimal RESERV14 { get; set; }
    }
}