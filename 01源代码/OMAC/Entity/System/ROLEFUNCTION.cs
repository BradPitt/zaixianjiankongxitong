using System;
using System.Runtime.Serialization;
namespace Entity 
{
		[Serializable]
    [DataContract]
	public class ROLEFUNCTION
	{
   		/// <summary>
        /// F_ID
        /// </summary>
        [DataMember]
		public string F_ID { get; set; }
		/// <summary>
        /// F_ROLECODE
        /// </summary>
        [DataMember]
		public string F_ROLECODE { get; set; }
		/// <summary>
        /// F_FUNCTIONCODE
        /// </summary>
        [DataMember]
		public string F_FUNCTIONCODE { get; set; }
			}
}