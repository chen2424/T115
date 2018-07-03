using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T115.IDbSession
{
    using IDal;
    /// <summary>
    /// 数据访问层唯一入口规范
    /// </summary>
    public partial interface IDbSession
    {
        //访问实体入口
        //IUserInfoDal UserInfoDal { get; }
        bool SaveChanges();
        int ExecuteSql(string sql, params System.Data.SqlClient.SqlParameter[] pars);

        List<T> ExecuteSelectQuery<T>(string sql, params System.Data.SqlClient.SqlParameter[] pars);
    }
}
