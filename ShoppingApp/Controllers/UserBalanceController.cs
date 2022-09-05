using ShoppingApp.Models.Concret.Entities;
using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class UserBalanceController : Controller
    {

        UserBalanceService userBalanceService = new UserBalanceService();
        [HttpGet]
        public ActionResult UserBalance()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserBalance(int balance )
        {
            int ID = (int)HttpContext.Session["userLogin"];
            Session["balance"]=balance;
            UserBalance userBalance = userBalanceService.GetById(ID);
            int newBalance = (int)Session["balance"];
            if (userBalance==null)
            {
                UserBalance userBalances = new UserBalance();
                userBalances.Balance = balance;
                userBalances.UserId = ID;
                userBalanceService.Add(userBalances);

            }else
            {
               
                userBalance.Balance = balance;
                userBalanceService.Update(userBalance);
            }
            return  RedirectToAction("Index", "Home");
        }
    }
}