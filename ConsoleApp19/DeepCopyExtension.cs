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
        /// 注意：必须标识为可序列化[Serializable]
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
    }
}
