using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public static class DeepCopyExtension
    {
        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCopy<T>(this T obj)
            where T : class
        {
            try
            {
                if (obj == null)
                {
                    return null;
                }

                string jsonString = JsonConvert.SerializeObject(obj);
                T value = JsonConvert.DeserializeObject<T>(jsonString);
                return value;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 【简单对象/集合的拷贝，可使用更高效的Utilities.DeepCopyHelper中提供的方法】
        /// 深拷贝
        /// 注意：必须标识为可序列化[Serializable]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCopy2<T>(this T obj)
            where T : class
        {
            try
            {
                if (obj == null)
                {
                    return null;
                }

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (MemoryStream stream = new MemoryStream())
                {
                    binaryFormatter.Serialize(stream, obj);
                    stream.Position = 0;
                    return (T)binaryFormatter.Deserialize(stream);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
