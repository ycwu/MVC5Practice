using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Practice.Models.ViewModels;

namespace MVC5Practice.Controllers
{
    public class MBController : Controller
    {
        // GET: MB
        public ActionResult Index()
        {
            ViewData["Temp1"] = "暫存資料 Temp";

            var b = new ClientLoginViewModel() { FirstName="Will",LastName="Hunag" };
            ViewData["Temp2"] = b;
            ViewBag.Temp3 = b;

            return View();
        }

        public ActionResult MyForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MyForm(ClientLoginViewModel c)
        {
            if (ModelState.IsValid)
            {
                TempData["MyFormData"] = c;
                return RedirectToAction("MyFormResult");
            }
            return View();
        }

        public ActionResult MyFormResult()
        {
            return View();
        }
    }
}