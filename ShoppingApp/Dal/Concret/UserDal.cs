
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ShoppingApp.Dal.Abstract;
using ShoppingApp.Dal.Context;
using ShoppingApp.Models.Concret;
using System.Data.Entity;

namespace ShoppingApp.Dal.Concret
{
    public class UserDal : IUserDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(User user)
        {
            shoppingContext.User.Add(user);

            shoppingContext.SaveChanges();
        }

        public void Delete(int UserId)
        {
            shoppingContext.User.Remove(shoppingContext.User.FirstOrDefault(i => i.ID == UserId));
            shoppingContext.SaveChanges();
        }

        public User Get(int UserId)
        {
            return shoppingContext.User.Where(i => i.ID == UserId).FirstOrDefault();
        }

        public List<User> GetAll()
        {
            return shoppingContext.User.ToList();
        }

        public void Update(User user)
        {
            shoppingContext.Entry(user).State = EntityState.Modified;
            shoppingContext.SaveChanges();
        }
    }
}