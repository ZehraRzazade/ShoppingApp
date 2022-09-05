using ShoppingApp.Models.Concret;
using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    [AllowAnonymous]
    public class SignUpController : Controller
    {

        UserService userService = new UserService();
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }



        [HttpPost]
        public  ActionResult SignUp(string email, string password, string name, int age, string gender)
        {
            User user = new User();
            user.EMail = email;
            user.Password = BCrypt.Net.BCrypt.HashPassword(password);
            user.IsBlocked = false;
            user.Age = age;
            user.Gender = gender;
            user.Name = name.ToLower();
            userService.Add(user);
          
          return RedirectToAction("Index", "Home");

        }
    }
}