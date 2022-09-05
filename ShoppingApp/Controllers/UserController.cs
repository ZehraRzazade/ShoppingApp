using ShoppingApp.Models.Concret;
using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ShoppingApp.Models.Authetications;
namespace ShoppingApp.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {

        //UserLogin userList=new UserLogin();
        UserLogin userLogin = new UserLogin();
        UserService userService = new UserService();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name, string password)
        {   
           
            User user = userService.GetUser(name, password);

            if (user == null)
            {
             
                //ViewBag.Message = "Yalnis  kullanici Adi ve ya  sifre";
                return RedirectToAction("Index","Home");
            }
            else
            {
                userLogin.AddUsers(user.Name, user.ID);
                FormsAuthentication.SetAuthCookie(name, false);
                HttpContext.Session["userLogin"] = user.Name;
                HttpContext.Session["userLogin"] = user.ID;
               


                return RedirectToAction("Index", "Home");
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["count"] = 0;
            return RedirectToAction("Index", "Home");
        }

    

    }
}