using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.IDal
{
    using System.Linq.Expressions;
    public interface IBaseDal<T> where T : class
    {

        IQueryable<T> LoadEntities(Func<T, bool> predicate);

        IQueryable<T> LoadPageEntities<s>(int pageindex, int pagesize, out int totalCount, Func<T, bool> predicate, Func<T, s> orderby, bool isAsc);
        bool Remove(T t);

        bool Update(T t);

        T Add(T t);
    }
}
