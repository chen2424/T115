 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T115.DalFactory
{

    using T115.IDal;
    using T115.Common;
	
	public abstract partial class AbsFactory
    {
		public abstract IActionInfoDal CreateActionInfoDal();
		public abstract IDepartmentDal CreateDepartmentDal();
		public abstract IDepartmentActionInfoDal CreateDepartmentActionInfoDal();
		public abstract IMenuInfoDal CreateMenuInfoDal();
		public abstract IRoleDal CreateRoleDal();
		public abstract IRoleActionInfoDal CreateRoleActionInfoDal();
		public abstract IUserDal CreateUserDal();
		public abstract IUserActionDal CreateUserActionDal();
		public abstract IUserInfoRoleDal CreateUserInfoRoleDal();
	}
}