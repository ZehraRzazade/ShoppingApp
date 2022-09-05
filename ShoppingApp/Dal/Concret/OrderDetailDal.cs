using ShoppingApp.Dal.Abstract;
using ShoppingApp.Models.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingApp.Dal.Context;
using System.Data.Entity;

namespace ShoppingApp.Dal.Concret
{
    public class OrderDetailDal : IOrderDetailDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(OrderDetail orderDetail)
        {

            shoppingContext.OrderDetail.Add(orderDetail);
            shoppingContext.SaveChanges();
        }

        public void Delete(int OrderId)
        {
            shoppingContext.OrderDetail.Remove(shoppingContext.OrderDetail.FirstOrDefault(i => i.Id == OrderId));
            shoppingContext.SaveChanges();
        }

        public List<OrderDetail> GetOrderById(int OrderId)
        {

            List<OrderDetail> orders = shoppingContext.OrderDetail.Where(i => i.OrderId == OrderId).ToList();
            return orders;
        }

        public List<OrderDetail> GetAll()
        {
            return shoppingContext.OrderDetail.ToList();
        }

        public void Update(int orderId)
        {
            shoppingContext.Entry(orderId).State = EntityState.Modified;
            shoppingContext.SaveChanges();
        }

    }
}