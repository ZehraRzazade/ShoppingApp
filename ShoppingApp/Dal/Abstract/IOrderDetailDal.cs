using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingApp.Dal.Abstract;
using ShoppingApp.Dal.Context;
using ShoppingApp.Models.Concret;
using System.Data.Entity;

namespace ShoppingApp.Dal.Abstract
{
    public interface IOrderDetailDal
    {
        List<OrderDetail> GetAll();
       List<OrderDetail> GetOrderById(int orderId);
        void Add(OrderDetail orderDetail);
        void Update(int OrderId);
        void Delete(int OrderId);
    }
}