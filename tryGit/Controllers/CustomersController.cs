using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tryGit.BLL;
using tryGit.Models;

namespace tryGit.Controllers
{
    public class CustomersController : Controller
    {

        ProductManager _Manager = new ProductManager();
    
            [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product productObj)
        {
            try
            {
                var isSave = _Manager.SaveProduct(productObj);
                if (isSave)
                {
                    ViewBag.SMessage("Product Add Successfully");
                }
                else
                {
                    ViewBag.FMessage("Product Not Save");
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMessage(exception.Message);
            }
            return View();
        }
    }
}