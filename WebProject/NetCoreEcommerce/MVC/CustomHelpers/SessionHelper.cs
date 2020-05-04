using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace MVC.CustomHelpers
{
    public static class SessionHelper
    {
        //Set
        public static void SetProductJson(this ISession session,string key, object value)//"scart"
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
              
        }

        //Get
        public static T GetProductFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
