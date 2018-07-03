using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    using T115.IBll;
    public class UserController : Controller
    {
        public IUserBll ubll { get; set; }

        public IMenuInfoBll mbll { get; set; }
        public IDepartmentActionInfoBll dabll { get; set; }
        public IActionInfoBll abll { get; set; }
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            string userName = Request["UserName"];
            string password = Request["Password"];
            var user = ubll.LoadEntities(p=>p.UserName == userName && p.Password == password).FirstOrDefault();
            if(user == null){
                return Content("err");
            }
            Session[T115.Common.Key.loginKey] = user;
            int userDepartmentId = user.DepartmentId;
            var action = dabll.LoadEntities(p=>p.Department_Id == userDepartmentId).FirstOrDefault();
            var actionurl = abll.LoadEntities(p=>p.Id == action.ActionInfo_Id).FirstOrDefault();
            string url = actionurl.Url;
            return Content(url);
        }
    }
}
