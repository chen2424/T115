 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T115.Bll
{
    using dbqn.T115OA.Model;
    using IBll;
	public partial class ActionInfoBll : BaseBll<ActionInfo>,IActionInfoBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.ActionInfoDal;
        }
    }	
	public partial class DepartmentBll : BaseBll<Department>,IDepartmentBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.DepartmentDal;
        }
    }	
	public partial class DepartmentActionInfoBll : BaseBll<DepartmentActionInfo>,IDepartmentActionInfoBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.DepartmentActionInfoDal;
        }
    }	
	public partial class MenuInfoBll : BaseBll<MenuInfo>,IMenuInfoBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.MenuInfoDal;
        }
    }	
	public partial class RoleBll : BaseBll<Role>,IRoleBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.RoleDal;
        }
    }	
	public partial class RoleActionInfoBll : BaseBll<RoleActionInfo>,IRoleActionInfoBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.RoleActionInfoDal;
        }
    }	
	public partial class UserBll : BaseBll<User>,IUserBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.UserDal;
        }
    }	
	public partial class UserActionBll : BaseBll<UserAction>,IUserActionBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.UserActionDal;
        }
    }	
	public partial class UserInfoRoleBll : BaseBll<UserInfoRole>,IUserInfoRoleBll
    {
        public override void SetCurrentDal()
        {
            this.currentDal = this.DbSession.UserInfoRoleDal;
        }
    }	
	
}