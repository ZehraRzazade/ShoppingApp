using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class OrderController : Controller
    {
        OrderService orderService = new OrderService();
        BasketService basketService = new BasketService();
        OrderDetailService orderDetailService = new OrderDetailService();
    
        public ActionResult Order()
        {
            int userId = (int)HttpContext.Session["userLogin"];
          
            orderService.AddById(userId);
            orderDetailService.AddByUserId(userId);
            basketService.ChangeIsOrdered(userId);
            basketService.ChangeIsDeleted(userId);
            Session["count"] = 0;
            return View(orderService.GetAllByUserId(userId));
        }

    }
}