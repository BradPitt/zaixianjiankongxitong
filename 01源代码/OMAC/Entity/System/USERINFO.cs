﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Entity
{
    //se
    [Serializable]
    [DataContract]
    public class USERINFO
    {
        /// <summary>
        /// F_DEPARTMENTCODE 部门
        /// </summary>
        [DataMember]
        public string F_DEPARTMENTCODE { get; set; }

        public string DepartmentNames { set; get; }
        public string RoleNames { set; get; }

        /// <summary>
        /// Roleinfos 角色列表
        /// </summary>
        [DataMember]
        public string[] Roleinfos { get; set; }

        /// <summary>
        /// F_ACCOUNT
        /// </summary>
        [DataMember]
        public string F_ACCOUNT { get; set; }
        /// <summary>
        /// F_NAME
        /// </summary>
        [DataMember]
        public string F_NAME { get; set; }
        /// <summary>
        /// F_PASSWORD
        /// </summary>
        [DataMember]
        public string F_PASSWORD { get; set; }
        /// <summary>
        /// F_EMAIL
        /// </summary>
        [DataMember]
        public string F_EMAIL { get; set; }
        /// <summary>
        /// F_PHONE
        /// </summary>
        [DataMember]
        public string F_PHONE { get; set; }
        /// <summary>
        /// F_TEL
        /// </summary>
        [DataMember]
        public string F_TEL { get; set; }
        /// <summary>
        /// F_DESCRIPTION
        /// </summary>
        [DataMember]
        public string F_DESCRIPTION { get; set; }
        /// <summary>
        /// F_PHOTO
        /// </summary>
        [DataMember]
        public byte[] F_PHOTO { get; set; }
        /// <summary>
        /// F_ADDRESS
        /// </summary>
        [DataMember]
        public string F_ADDRESS { get; set; }
        /// <summary>
        /// F_REALNAME
        /// </summary>
        [DataMember]
        public string F_REALNAME { get; set; }
    }
}