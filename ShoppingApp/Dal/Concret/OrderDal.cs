//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using ShoppingApp.Dal.Abstract;

using ShoppingApp.Models.Concret;
using System.Data.Entity;
using ShoppingApp.Dal.Context;
namespace ShoppingApp.Dal.Concret
{
    public class OrderDal : IOrderDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(Order order)
        {

           shoppingContext.Order.Add(order);
            shoppingContext.SaveChanges();
        }

        public void Delete(int OrderId)
        {
          shoppingContext.Order.Remove(shoppingContext.Order.FirstOrDefault(i => i.Id == OrderId));
            shoppingContext.SaveChanges();
        }

        public Order Get(int OrderId)
        {
           
           Order order=new Order();
            return shoppingContext.Order.Where(i => i.Id == OrderId).FirstOrDefault();
        }

        public List<Order> GetAll()
        {
            return shoppingContext.Order.ToList();
        }

        public void Update(Order order)
        {
             shoppingContext.Entry(order).State = EntityState.Modified;
            shoppingContext.SaveChanges();
        }
    }
}