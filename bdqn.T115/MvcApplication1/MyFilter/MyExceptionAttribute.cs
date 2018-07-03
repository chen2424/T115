using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.MyFilter
{
    public class MyExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            string line = filterContext.Controller.ControllerContext.Controller.ToString();
            //重写异常信息
            var log = new T115.Common.LogHelper();
            log.Error("被系统过滤捕获的异常" + filterContext.Exception);
            //重定向
            filterContext.Result = new RedirectResult("/error.html");
            filterContext.ExceptionHandled = true; //被处理了。
        }
    }
}