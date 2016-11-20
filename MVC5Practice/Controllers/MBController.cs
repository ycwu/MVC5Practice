using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Practice.Models.ViewModels;
using System.Data.Entity.Validation;

namespace MVC5Practice.Controllers
{
    [LocalDebugOnly]
    [HandleError(ExceptionType = typeof(DbEntityValidationException), View = "Error_DbEntityValidationException")]
    public class MBController : BaseController
    {
        // GET: MB
        [ShareData]
        public ActionResult Index()
        {
            //ViewData["Temp1"] = "暫存資料 Temp";

            var b = new ClientLoginViewModel() { FirstName="Will",LastName="Hunag" };
            ViewData["Temp2"] = b;
            ViewBag.Temp3 = b;

            return View();
        }
        [ShareData]
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

        public ActionResult ProductList()
        {
            var data = db.Product.OrderBy(p => p.ProductId).Take(10);
            return View(data);
        }

        public ActionResult BatchUpdate(ProductBatchUpdateViewModel[] items)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in items)
                {
                    var product = db.Product.Find(item.ProductId);
                    product.ProductName = item.ProductName;
                    product.Active = product.Active;
                    product.Price = item.Price;
                    product.Stock = item.Stock;
                }
                db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            return View();
        }
        public ActionResult MyError()
        {
            throw new DbEntityValidationException("Error");
            return View();
        }
    }
}