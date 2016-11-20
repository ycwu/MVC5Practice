using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC5Practice.Controllers
{
    public class ShareDataAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData["Temp1"] = "暫存資料 Temp1";
        }
    }
}