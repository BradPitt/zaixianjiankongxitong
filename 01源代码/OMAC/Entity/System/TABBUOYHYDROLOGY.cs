﻿using System;
using System.Runtime.Serialization;
namespace Entity
{
    /// <summary>
    /// 水文数据表(浮标)
    /// </summary>
    [Serializable]
    [DataContract]
    public class TABBUOYHYDROLOGY
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
        /// 流速
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD { get; set; }

        /// <summary>
        /// 流向
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR { get; set; }

        /// <summary>
        /// 流速1
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD1 { get; set; }
        /// <summary>
        /// 流向1
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR1 { get; set; }
        /// <summary>
        /// 流速2
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD38 { get; set; }
        /// <summary>
        /// CURRENTDIR41
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR38 { get; set; }
        /// <summary>
        /// 流速3
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD39 { get; set; }
        /// <summary>
        /// CURRENTDIR42
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR39 { get; set; }
        /// <summary>
        /// 流速4
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD40 { get; set; }
        /// <summary>
        /// CURRENTDIR43
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR40 { get; set; }
        /// <summary>
        /// 流速5
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD2 { get; set; }
        /// <summary>
        /// CURRENTDIR2
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR2 { get; set; }
        /// <summary>
        /// CURRENTSPD3
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD3 { get; set; }
        /// <summary>
        /// CURRENTDIR3
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR3 { get; set; }
        /// <summary>
        /// CURRENTSPD4
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD4 { get; set; }
        /// <summary>
        /// CURRENTDIR4
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR4 { get; set; }
        /// <summary>
        /// CURRENTSPD5
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD5 { get; set; }
        /// <summary>
        /// CURRENTDIR5
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR5 { get; set; }
        /// <summary>
        /// CURRENTSPD6
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD6 { get; set; }
        /// <summary>
        /// CURRENTDIR6
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR6 { get; set; }
        /// <summary>
        /// CURRENTSPD7
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD7 { get; set; }
        /// <summary>
        /// CURRENTDIR7
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR7 { get; set; }
        /// <summary>
        /// CURRENTSPD8
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD8 { get; set; }
        /// <summary>
        /// CURRENTDIR8
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR8 { get; set; }
        /// <summary>
        /// CURRENTSPD9
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD9 { get; set; }
        /// <summary>
        /// CURRENTDIR9
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR9 { get; set; }
        /// <summary>
        /// CURRENTSPD10
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD10 { get; set; }
        /// <summary>
        /// CURRENTDIR10
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR10 { get; set; }
        /// <summary>
        /// CURRENTSPD11
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD11 { get; set; }
        /// <summary>
        /// CURRENTDIR11
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR11 { get; set; }
        /// <summary>
        /// CURRENTSPD12
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD12 { get; set; }
        /// <summary>
        /// CURRENTDIR12
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR12 { get; set; }
        /// <summary>
        /// CURRENTSPD13
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD13 { get; set; }
        /// <summary>
        /// CURRENTDIR13
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR13 { get; set; }
        /// <summary>
        /// CURRENTSPD14
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD14 { get; set; }
        /// <summary>
        /// CURRENTDIR14
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR14 { get; set; }
        /// <summary>
        /// CURRENTSPD15
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD15 { get; set; }
        /// <summary>
        /// CURRENTDIR15
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR15 { get; set; }
        /// <summary>
        /// CURRENTSPD16
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD16 { get; set; }
        /// <summary>
        /// CURRENTDIR16
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR16 { get; set; }
        /// <summary>
        /// CURRENTSPD17
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD17 { get; set; }
        /// <summary>
        /// CURRENTDIR17
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR17 { get; set; }
        /// <summary>
        /// CURRENTSPD18
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD18 { get; set; }
        /// <summary>
        /// CURRENTDIR18
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR18 { get; set; }
        /// <summary>
        /// CURRENTSPD19
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD19 { get; set; }
        /// <summary>
        /// CURRENTDIR19
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR19 { get; set; }
        /// <summary>
        /// CURRENTSPD20
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD20 { get; set; }
        /// <summary>
        /// CURRENTDIR20
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR20 { get; set; }
        /// <summary>
        /// CURRENTSPD21
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD21 { get; set; }
        /// <summary>
        /// CURRENTDIR21
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR21 { get; set; }
        /// <summary>
        /// CURRENTSPD22
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD22 { get; set; }
        /// <summary>
        /// CURRENTDIR22
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR22 { get; set; }
        /// <summary>
        /// CURRENTSPD23
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD23 { get; set; }
        /// <summary>
        /// CURRENTDIR23
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR23 { get; set; }
        /// <summary>
        /// CURRENTSPD24
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD24 { get; set; }
        /// <summary>
        /// CURRENTDIR24
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR24 { get; set; }
        /// <summary>
        /// CURRENTSPD25
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD25 { get; set; }
        /// <summary>
        /// CURRENTDIR25
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR25 { get; set; }
        /// <summary>
        /// CURRENTSPD26
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD26 { get; set; }
        /// <summary>
        /// CURRENTDIR26
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR26 { get; set; }
        /// <summary>
        /// CURRENTSPD27
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD27 { get; set; }
        /// <summary>
        /// CURRENTDIR27
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR27 { get; set; }
        /// <summary>
        /// CURRENTSPD28
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD28 { get; set; }
        /// <summary>
        /// CURRENTDIR28
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR28 { get; set; }
        /// <summary>
        /// CURRENTSPD29
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD29 { get; set; }
        /// <summary>
        /// CURRENTDIR29
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR29 { get; set; }
        /// <summary>
        /// CURRENTSPD30
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD30 { get; set; }
        /// <summary>
        /// CURRENTDIR30
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR30 { get; set; }
        /// <summary>
        /// CURRENTSPD31
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD31 { get; set; }
        /// <summary>
        /// CURRENTDIR31
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR31 { get; set; }
        /// <summary>
        /// CURRENTSPD32
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD32 { get; set; }
        /// <summary>
        /// CURRENTDIR32
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR32 { get; set; }
        /// <summary>
        /// CURRENTSPD33
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD33 { get; set; }
        /// <summary>
        /// CURRENTDIR33
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR33 { get; set; }
        /// <summary>
        /// CURRENTSPD34
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD34 { get; set; }
        /// <summary>
        /// CURRENTDIR34
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR34 { get; set; }
        /// <summary>
        /// CURRENTSPD35
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD35 { get; set; }
        /// <summary>
        /// CURRENTDIR35
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR35 { get; set; }
        /// <summary>
        /// CURRENTSPD36
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD36 { get; set; }
        /// <summary>
        /// CURRENTDIR36
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR36 { get; set; }
        /// <summary>
        /// CURRENTSPD37
        /// </summary>
        [DataMember]
        public decimal CURRENTSPD37 { get; set; }
        /// <summary>
        /// CURRENTDIR37
        /// </summary>
        [DataMember]
        public decimal CURRENTDIR37 { get; set; }
        /// <summary>
        /// 最大波高
        /// </summary>
        [DataMember]
        public decimal MAXWAVEHIGH { get; set; }
        /// <summary>
        /// 最大波周期
        /// </summary>
        [DataMember]
        public decimal MAXWAVEPIOD { get; set; }
        /// <summary>
        /// 1/10波高
        /// </summary>
        [DataMember]
        public decimal TENTHWAVEHIGH { get; set; }
        /// <summary>
        /// 1/10波周期
        /// </summary>
        [DataMember]
        public decimal TENTHWAVEPIOD { get; set; }
        /// <summary>
        /// 平均波高
        /// </summary>
        [DataMember]
        public decimal AVEWAVEHIGH { get; set; }
        /// <summary>
        /// 平均波周期
        /// </summary>
        [DataMember]
        public decimal AVEWAVEPIOD { get; set; }
        /// <summary>
        /// 有效波高
        /// </summary>
        [DataMember]
        public decimal WALIDWAVEHIGH { get; set; }
        /// <summary>
        /// 有效波周期
        /// </summary>
        [DataMember]
        public decimal WALIDWAVEPIOD { get; set; }
        /// <summary>
        /// 波向
        /// </summary>
        [DataMember]
        public decimal WAVEDIR { get; set; }
        /// <summary>
        /// 波数
        /// </summary>
        [DataMember]
        public decimal WAVENUM { get; set; }
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
    }
}