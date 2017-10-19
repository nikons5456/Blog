using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Blog.Web.Extension
{
    public static class SessionExtension
    {
        //向Session添加数据
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        //从Session获取数据
        public static T Get<T>(this ISession session,string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
