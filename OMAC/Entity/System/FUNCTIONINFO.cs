using System;
using System.Runtime.Serialization;
namespace Entity 
{
	[Serializable]
    [DataContract]
	public class FUNCTIONINFO
	{
   		/// <summary>
        /// F_FUNCTIONCODE
        /// </summary>
        [DataMember]
		public string F_FUNCTIONCODE { get; set; }
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
		/// <summary>
        /// F_CAPTION
        /// </summary>
        [DataMember]
		public string F_CAPTION { get; set; }
		/// <summary>
        /// F_PRIORITY
        /// </summary>
        [DataMember]
		public decimal F_PRIORITY { get; set; }
		/// <summary>
        /// F_PARENTID
        /// </summary>
        [DataMember]
		public string F_PARENTID { get; set; }
		/// <summary>
        /// URL
        /// </summary>
        [DataMember]
		public string URL { get; set; }
	}
}