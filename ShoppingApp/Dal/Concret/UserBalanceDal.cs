using ShoppingApp.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingApp.Models.Concret.Entities;
using ShoppingApp.Dal.Context;
using System.Data.Entity;

namespace ShoppingApp.Dal.Concret
{
    public class UserBalanceDal : IBalanceDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(Models.Concret.Entities.UserBalance userBalance)
        {
            shoppingContext.UserBalance.Add(userBalance);

            shoppingContext.SaveChanges();
        }

        public void Delete(int userId)
        {
            shoppingContext.UserBalance.Remove(shoppingContext.UserBalance.FirstOrDefault(i => i.UserId== userId));
            shoppingContext.SaveChanges();
        }

        public Models.Concret.Entities.UserBalance GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Models.Concret.Entities.UserBalance userBalance)
        {
            shoppingContext.Entry(userBalance).State = EntityState.Modified;
            shoppingContext.SaveChanges();
        }
        public List<UserBalance> GetAllBalances()
        {
            return shoppingContext.UserBalance.ToList();
        }
    }
}