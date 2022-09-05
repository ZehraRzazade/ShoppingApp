using ShoppingApp.Dal.Context;
using ShoppingApp.Models.Concret;
using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
       ProductService productService= new ProductService();
        [HttpGet]
        
        public ActionResult Index()
        {
            
            
                ViewBag.Message = TempData["UserID"];
            
            return View(productService.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        
        public ActionResult Category()
        {
            return View();
        } 
    }
}