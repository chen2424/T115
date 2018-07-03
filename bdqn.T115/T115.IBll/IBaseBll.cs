using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.IBll
{
    public interface IBaseBll<T> where T : class
    {
        IQueryable<T> LoadEntities(Func<T, bool> predicate);
        //返回分页的数据
        IQueryable<T> LoadPageEntities<s>(int pageindex, int pagesize, out int totalCount, Func<T, bool> predicate, Func<T, s> orderby, bool isAsc);
        bool Remove(T t);

        bool Update(T t);

        T Add(T t);

        bool SaveChanges();
    }
}
