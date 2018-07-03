 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T115.Factory
{

    using DalFactory;
    using IDal;
    using T115.Common;
	
    public partial class Factory:AbsFactory
    {
		public override IActionInfoDal CreateActionInfoDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IActionInfoDal)Kits.CreateObj(nspace, "ActionInfoDal");
        }
		public override IDepartmentDal CreateDepartmentDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IDepartmentDal)Kits.CreateObj(nspace, "DepartmentDal");
        }
		public override IDepartmentActionInfoDal CreateDepartmentActionInfoDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IDepartmentActionInfoDal)Kits.CreateObj(nspace, "DepartmentActionInfoDal");
        }
		public override IMenuInfoDal CreateMenuInfoDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IMenuInfoDal)Kits.CreateObj(nspace, "MenuInfoDal");
        }
		public override IRoleDal CreateRoleDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IRoleDal)Kits.CreateObj(nspace, "RoleDal");
        }
		public override IRoleActionInfoDal CreateRoleActionInfoDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IRoleActionInfoDal)Kits.CreateObj(nspace, "RoleActionInfoDal");
        }
		public override IUserDal CreateUserDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IUserDal)Kits.CreateObj(nspace, "UserDal");
        }
		public override IUserActionDal CreateUserActionDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IUserActionDal)Kits.CreateObj(nspace, "UserActionDal");
        }
		public override IUserInfoRoleDal CreateUserInfoRoleDal()
        {
            string nspace = Kits.GetAppSettingsValue("dalFactory");
            return (IUserInfoRoleDal)Kits.CreateObj(nspace, "UserInfoRoleDal");
        }
	}
	
}