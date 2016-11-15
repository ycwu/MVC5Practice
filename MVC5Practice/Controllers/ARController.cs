﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace MVC5Practice.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
        public ActionResult PartialViewTest()
        {
            return PartialView();
        }

        public ActionResult ContentTest()
        {
            return Content("開發實戰", "text/plain", Encoding.GetEncoding("Big5"));
        }

        public ActionResult FileTest()
        {
            // C:\Projects\MVC5Course\MVC5Course\Content\maxresdefault.jpg

            var filePath = Server.MapPath("~/Content/maxresdefault.jpg");

            return File(filePath, "image/jpeg");
        }
        public ActionResult FileTest2()
        {
            var filePath = Server.MapPath("~/Content/maxresdefault.jpg");

            return File(filePath, "image/jpeg", "PPAP.jpg");
        }
        public ActionResult JsonTest()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var data = db.Product.OrderBy(p => p.ProductId).Take(10);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}