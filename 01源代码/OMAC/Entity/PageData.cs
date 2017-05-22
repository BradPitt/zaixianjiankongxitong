using System.Data;
using System.Runtime.Serialization;

namespace Entity
{
    /// <summary>
    /// 单页数据
    /// </summary>
    [DataContract]
    public class PageData
    {
        [DataMember(Name = "total")]
        public int RecordCount { get; set; }
        [DataMember(Name = "limit")]
        public int PageCount { get; set; }
        [DataMember(Name = "rows")]
        public object Data { get; set; }
        [DataMember(Name = "message")]
        public object Message { get; set; }
    }
}
