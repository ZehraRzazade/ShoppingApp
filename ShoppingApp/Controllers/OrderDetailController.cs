using ShoppingApp.Models.Concret;
using ShoppingApp.Models.Concret.Dto;
using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class OrderDetailController : Controller
    {
        OrderDetailService orderDetailService = new OrderDetailService();
       
        [HttpGet]
        public ActionResult OrderDetail(int orderId)
        {
            List<ProductOrderDetailDto> results = orderDetailService.GetOrderDetails(orderId);
           
            return View(results);
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}