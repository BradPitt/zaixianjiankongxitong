using System;
using System.Runtime.Serialization;
namespace Entity 
{
		[Serializable]
    [DataContract]
	public class ROLEINFO
	{
   		/// <summary>
        /// F_ROLECODE
        /// </summary>
        [DataMember]
		public string F_ROLECODE { get; set; }
		/// <summary>
        /// F_NAME
        /// </summary>
        [DataMember]
		public string F_NAME { get; set; }
		/// <summary>
        /// F_DESCRIPTION
        /// </summary>
        [DataMember]
		public string F_DESCRIPTION { get; set; }
			}
}