using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.DbSessionFactory
{
    using IDal;
    using IDbSession;
    using System.Runtime.Remoting.Messaging;
    using DbSession;
    /// <summary>
    /// 唯一入口工厂
    /// </summary>
    public class DbSessionFactory
    {
        public static IDbSession CreateDbSession()
        {
            IDbSession dbSession = (IDbSession)CallContext.GetData("dbSession");
            if (dbSession == null)
            {
                dbSession = new DbSession();
                CallContext.SetData("dbSession", dbSession);
            }
            return dbSession;
        }
    }
}
