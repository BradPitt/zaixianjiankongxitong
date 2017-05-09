using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 单页数据
    /// </summary>
    [DataContract]
    public class JSONCodec
    {
        public static string ToJson(object objectToSerialize)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(objectToSerialize.GetType());
                serializer.WriteObject(ms, objectToSerialize);
                ms.Position = 0;
                using (StreamReader reader = new StreamReader(ms))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static T FromJson<T>(string jsonString)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }
    }
}
