using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret.Entities;
using ShoppingApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Service.Concret
{
    public class UserBalanceService : IUserBalaceService
    {
        UserBalanceDal userBalanceDal = new UserBalanceDal();
        public void Add(UserBalance userBalance)
        {
            userBalanceDal.Add(userBalance);
        }

        public void Delete(int userId)
        {
            userBalanceDal.Delete(userId);
        }



        public void Update(UserBalance userBalance)
        {
            userBalanceDal.Update(userBalance);
        }
        public UserBalance GetById(int userId)
        {
            UserBalance userBalance = userBalanceDal.GetAllBalances().Where(x => x.UserId == userId).LastOrDefault();
            return userBalance;

        }

        public List<UserBalance> GetAllBalances()
        {
            return userBalanceDal.GetAllBalances();
        }
    }
}