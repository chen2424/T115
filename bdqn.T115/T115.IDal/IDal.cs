 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T115.IDal
{

	using dbqn.T115OA.Model;
	public partial interface IActionInfoDal :IBaseDal<ActionInfo>
    {
       
    }	
	public partial interface IDepartmentDal :IBaseDal<Department>
    {
       
    }	
	public partial interface IDepartmentActionInfoDal :IBaseDal<DepartmentActionInfo>
    {
       
    }	
	public partial interface IMenuInfoDal :IBaseDal<MenuInfo>
    {
       
    }	
	public partial interface IRoleDal :IBaseDal<Role>
    {
       
    }	
	public partial interface IRoleActionInfoDal :IBaseDal<RoleActionInfo>
    {
       
    }	
	public partial interface IUserDal :IBaseDal<User>
    {
       
    }	
	public partial interface IUserActionDal :IBaseDal<UserAction>
    {
       
    }	
	public partial interface IUserInfoRoleDal :IBaseDal<UserInfoRole>
    {
       
    }	
	
}