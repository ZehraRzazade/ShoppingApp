
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ShoppingApp.Models.Concret;
namespace ShoppingApp.Service.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order Get(int OrderId);
        void Add(Order order);
        void Update(Order order);
        void Delete(int orderId);
        void AddById(int userId);
        List<Order>GetAllByUserId(int userId);


    }
}