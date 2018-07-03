using dbqn.T115OA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace T115.DbContextFactory
{
    public class DbContextFactory
    {
        public static DbContext CreateDbContext()
        {
            DbContext db = (DbContext)CallContext.GetData("db");
            if (db == null)
            {
                db = new bdqnT1154OAEntities();
                CallContext.SetData("db", db);
            }
            return db;
        }
    }
}
