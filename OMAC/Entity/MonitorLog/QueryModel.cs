using System;

namespace Entity.MonitorLog
{
    [Serializable]
    public class QueryModel
    {
        public string beginTime { get; set; }
        public string endTime { get; set; }
        public string order { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }
}
