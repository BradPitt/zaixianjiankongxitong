using System;
using System.Runtime.Serialization;
namespace Entity
{
    [Serializable]
    [DataContract]
    public class TABDICTIONARY
    {
        /// <summary>
        /// DICTIONARYID
        /// </summary>
        [DataMember]
        public string DICTIONARYID { get; set; }
        /// <summary>
        /// CONTENT
        /// </summary>
        [DataMember]
        public string CONTENT { get; set; }
        /// <summary>
        /// BEIZHU
        /// </summary>
        [DataMember]
        public string BEIZHU { get; set; }
    }
}