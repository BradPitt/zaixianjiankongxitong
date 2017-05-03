using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.IO;

namespace Business
{
    public class DirectoryHelper
    {
        /// <summary>
        /// 获得最新文件，以文件夹为单元
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFiles(string path)
        {
            string[] pathList = Directory.GetDirectories(path);
            List<DirectoryInfo> directoryInfos = new List<DirectoryInfo>();
            foreach (var s in pathList) 
            {
                DirectoryInfo di = new DirectoryInfo(s);
                directoryInfos.Add(di);
            }
            FileComparer fc = new FileComparer();
            Array.Sort(directoryInfos.ToArray(), fc);
            DirectoryInfo diF = directoryInfos.Last<DirectoryInfo>();


            return diF.FullName;
        }

    }
    /// <summary>
    /// 排序
    /// </summary>
    public class FileComparer : IComparer
    {
        int IComparer.Compare(Object o1, Object o2)
        {
            DirectoryInfo fi1 = o1 as DirectoryInfo;
            DirectoryInfo fi2 = o2 as DirectoryInfo;
            return fi1.CreationTime.CompareTo(fi2.CreationTime);
        }
    }

 
}