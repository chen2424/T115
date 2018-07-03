using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.DalFactory
{
    using T115.IDal;
    using Common;

    public abstract partial class AbsFactory
    {
 
        public static AbsFactory CreateInstance()
        {
         
            string nspace = Kits.GetAppSettingsValue("nspace");
          
            return (AbsFactory)Kits.CreateObj(nspace, "Factory");
        }
    }
}
