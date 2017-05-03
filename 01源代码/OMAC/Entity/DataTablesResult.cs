using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 所有的列表返回值
    /// </summary>
    public class DataTablesResult
    {
        // 返回第几页
        public int sEcho { get; set; }
        // 符合查询条件的一共有多少行
        public string iTotalRecords { get; set; }
        // 符合查询条件的一共有多少行
        public object iTotalDisplayRecords { get; set; }
        // 查询结果数据集
        public object aaData { get; set; }
    }
}
