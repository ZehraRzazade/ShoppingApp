using ShoppingApp.Models.Authetications;
using ShoppingApp.Models.Concret;
using ShoppingApp.Models.Concret.Dto;
using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShoppingApp.Controllers
{

    public class BasketController : Controller
    {
        // GET: Basket
        int count = 0;
        BasketService basketService = new BasketService();

        public ActionResult Basket()
        {
            int ID = (int)HttpContext.Session["userLogin"];
          
            List<ProductBasketDto> basket = basketService.GetAll(ID);
         
            if (basket == null)
            {
                return RedirectToAction("Error", "Error");
            }
            else
            {
                  return View(basket);
                
            }

        }
        public ActionResult productList(int UserId)
        {
            return View();
        }
         public ActionResult UpdateOrAdd(int id)
        {
            List<Basket> baskets = basketService.GetAllIsNotDeleted();
            if (Session["count"]==null)
            {
                count++;
                Session["count"] = count;
            }else
            {
                int a = (int)Session["count"];
                a++;
                Session["count"] = a;

            }
            
           
            int userId = (int)HttpContext.Session["userLogin"];
            basketService.UpdateAndAdd(id, userId);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Delete(int id)
        {
            Basket basket = basketService.Get(id);
            basketService.Delete(basket);

            int a = (int)Session["count"];
            a--;
            Session["count"] = a;


            return RedirectToAction("Basket", "Basket");
        }




    }

}
