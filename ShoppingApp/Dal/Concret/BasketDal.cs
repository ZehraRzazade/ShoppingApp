
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
    public class BasketDal : IBasketDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(Basket basket)
        {
           shoppingContext.Basket.Add(basket);
            shoppingContext.SaveChanges();
        }

        public void Delete(Basket basket)
        {

            shoppingContext.Basket.Remove(basket);
            shoppingContext.SaveChanges();
        }

        public Basket GetById(int id)
        {
         
            return shoppingContext.Basket.Where(i =>i.Id== id).FirstOrDefault();
        }

        public List<Basket> GetAll()
        {
            return shoppingContext.Basket.ToList();
        }

        public void Update(Basket basket)
        {
            shoppingContext.Entry(basket).State = EntityState.Modified;
          shoppingContext.SaveChanges();
        }
    }
}
