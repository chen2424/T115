using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.DbSession
{
    using IDbSession;
    using IDal;
    using System.Data.Entity;
    using DbContextFactory;
    public partial class DbSession : IDbSession
    {
        public DbContext db
        {
            get
            {
                return DbContextFactory.CreateDbContext();
            }
        }
        /// <summary>
        /// DAL访问入口
        /// </summary>
        //public  IUserInfoDal UserInfoDal
        //{
        //    get
        //    {
        //        return DalFactory.AbsFactory.CreateInstance().CreateUserInfoDal();
        //    }
        //}

        /// <summary>
        /// 一个业务中有可能涉及到多个表的操作，那么可以将操作的数据传递相应的方法中，打上相应标记，最后调用该方法，一次性提交到数据中去。
        /// </summary>
        /// <returns></returns>
        public virtual bool SaveChanges()
        {
            return db.SaveChanges() > 0;
        }
        public virtual int ExecuteSql(string sql, params System.Data.SqlClient.SqlParameter[] pars)
        {
            return db.Database.ExecuteSqlCommand(sql, pars);
        }

        public virtual List<T> ExecuteSelectQuery<T>(string sql, params System.Data.SqlClient.SqlParameter[] pars)
        {
            return db.Database.SqlQuery<T>(sql, pars).ToList();
        }
    }
}
