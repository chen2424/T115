using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.EFDal
{
    public class BaseDal<T> where T:class
    {
        public DbContext db
        {
            get
            {
                return T115.DbContextFactory.DbContextFactory.CreateDbContext();
            }
        }

        public virtual IQueryable<T> LoadEntities(Func<T, bool> predicate)
        {
            return db.Set<T>().
                Where(predicate)
                .AsQueryable();
        }
        //返回分页的数据
        public virtual IQueryable<T> LoadPageEntities<s>(int pageindex, int pagesize, out int totalCount, Func<T, bool> predicate, Func<T, s> orderby, bool isAsc)
        {
            totalCount = db.Set<T>().Where(predicate).Count();
            if (isAsc)
            {
                return db.Set<T>()
                    .Where(predicate)
                    .OrderBy(orderby)
                    .Skip((pageindex - 1) * pagesize)
                    .Take(pagesize)
                    .AsQueryable();
            }
            else
            {
                return db.Set<T>()
                   .Where(predicate)
                   .OrderByDescending(orderby)
                   .Skip((pageindex - 1) * pagesize)
                   .Take(pagesize)
                   .AsQueryable();
            }
        }
        public virtual bool Remove(T t)
        {
            //修改代理类实体的状态为删除状态
            db.Entry<T>(t).State = System.Data.EntityState.Deleted;
            return true;
        }

        public virtual bool Update(T t)
        {
            //修改代理类实体的状态
            db.Entry<T>(t).State = System.Data.EntityState.Modified;
            return true;
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual T Add(T t)
        {
            return db.Set<T>().Add(t);
        }
    }
}
