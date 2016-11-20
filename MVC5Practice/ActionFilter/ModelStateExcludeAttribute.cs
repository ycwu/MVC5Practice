using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Practice
{
    public class ModelStateExcludeAttribute : ActionFilterAttribute
    {
        public string[] Exclude { get; set; }

        public ModelStateExcludeAttribute()
        {
            Exclude = new string[] { "FirstName", "LastName" };

        }

        public ModelStateExcludeAttribute(string exclude)
        {
            if (exclude != null)
            {
                if (exclude.Contains(","))
                {
                    Exclude = exclude.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    Exclude = new string[] { exclude };
                }
            }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            foreach (var item in Exclude)
            {
                filterContext.Controller.ViewData.ModelState.Remove(item);
            }
            filterContext.Controller.ViewData["Exclude"] = Exclude;
        }
    }
}