using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.Common
{
    using System.Configuration;
    using System.Reflection;

    public class Kits
    {
        public static string GetAppSettingsValue(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        public static object CreateObj(string nspace, string type)
        {
            Assembly asm = Assembly.Load(nspace);
            return asm.CreateInstance(nspace + "." + type);
        }
    }
}
