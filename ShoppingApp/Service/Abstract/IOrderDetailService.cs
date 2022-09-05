using ShoppingApp.Models.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Service.Abstract
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
       List<OrderDetail> GetOrderById(int OrderId);
        void Add(OrderDetail orderDetail);
        void Update(int orderId);
        void Delete(int orderId);
         void AddByUserId(int userId);
    }
}