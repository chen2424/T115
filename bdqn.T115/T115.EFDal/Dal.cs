 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T115.EFDal
{
    using dbqn.T115OA.Model;
    using T115.IDal;
	public partial class ActionInfoDal : BaseDal<ActionInfo>,IActionInfoDal
    {
       
    }	
	public partial class DepartmentDal : BaseDal<Department>,IDepartmentDal
    {
       
    }	
	public partial class DepartmentActionInfoDal : BaseDal<DepartmentActionInfo>,IDepartmentActionInfoDal
    {
       
    }	
	public partial class MenuInfoDal : BaseDal<MenuInfo>,IMenuInfoDal
    {
       
    }	
	public partial class RoleDal : BaseDal<Role>,IRoleDal
    {
       
    }	
	public partial class RoleActionInfoDal : BaseDal<RoleActionInfo>,IRoleActionInfoDal
    {
       
    }	
	public partial class UserDal : BaseDal<User>,IUserDal
    {
       
    }	
	public partial class UserActionDal : BaseDal<UserAction>,IUserActionDal
    {
       
    }	
	public partial class UserInfoRoleDal : BaseDal<UserInfoRole>,IUserInfoRoleDal
    {
       
    }	
	
}