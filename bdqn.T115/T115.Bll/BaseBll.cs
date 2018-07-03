using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.Bll
{
    using IDbSession;
    using DbSessionFactory;
    using IDal;
    public abstract class BaseBll<T> where T : class
    {
        //在业务逻辑层通过唯一入口去访问Dal
        //IDbSession dbSession = DbSessionFactory.CreateDbSession();

        //表示具体要操作的Dal
        public IBaseDal<T> currentDal { get; set; }

        //抽象方法
        public abstract void SetCurrentDal();

        public BaseBll()
        {
            SetCurrentDal();
        }

        public IDbSession DbSession
        {
            get
            {
                return DbSessionFactory.CreateDbSession();
            }
        }
        public IQueryable<T> LoadEntities(Func<T, bool> predicate)
        {
            return currentDal.LoadEntities(predicate);
        }
        //返回分页的数据
        public IQueryable<T> LoadPageEntities<s>(int pageindex, int pagesize, out int totalCount, Func<T, bool> predicate, Func<T, s> orderby, bool isAsc)
        {
            return currentDal.LoadPageEntities<s>(pageindex, pagesize, out totalCount, predicate, orderby, isAsc);
        }
        public bool Remove(T t)
        {
            return currentDal.Remove(t);
        }

        public bool Update(T t)
        {
            return currentDal.Update(t);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public T Add(T t)
        {
            return currentDal.Add(t);
        }

        public bool SaveChanges()
        {
            return DbSession.SaveChanges();
        }
    }
}
