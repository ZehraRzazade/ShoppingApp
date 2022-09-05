using ShoppingApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingApp.Models.Concret;
using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret.Dto;

namespace ShoppingApp.Service.Concret
{
    public class OrderService : IOrderService
    {
        OrderDal orderDal = new OrderDal();
        BasketService basketService = new BasketService();
        ProductService productService = new ProductService();
        public void Add(Order order)
        {

            orderDal.Add(order);
        }

        public void AddById(int userId)
        {
            List<Basket> basketList = basketService.GetListByUserId(userId);
            Order order = new Order();
            order.Count = basketList.Count();
            order.UserId = userId;
            order.Date = DateTime.Now;
            foreach (var basket in basketList)
            {
                Product product = productService.GetById(basket.ProductId);
                int total = basket.Count * product.Price;
                order.TotalPrice += total;
            }
            orderDal.Add(order);

        }

        public void Delete(int orderId)
        {
            orderDal.Delete(orderId);
        }

        public Order Get(int OrderId)
        {
            return orderDal.Get(OrderId);
        }

        public List<Order> GetAll()
        {
            return orderDal.GetAll();
        }

        public List<Order> GetAllByUserId(int userId)
        {
            return orderDal.GetAll().Where(u =>u.UserId==userId).ToList();
        }

        public void Update(Order order)
        {
            orderDal.Update(order);
        }
    }
}
