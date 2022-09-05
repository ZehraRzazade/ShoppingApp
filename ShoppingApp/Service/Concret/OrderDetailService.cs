using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret;
using ShoppingApp.Models.Concret.Dto;
using ShoppingApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Service.Concret
{
    public class OrderDetailService : IOrderDetailService

    {
        ProductOrderDetailDto productOrderDetailDto = new ProductOrderDetailDto();
        OrderDetailDal orderDetailDal = new OrderDetailDal();
        BasketService basketService = new BasketService();
        OrderService orderService = new OrderService();
        ProductService productService = new ProductService();
        public void Add(OrderDetail orderDetail)
        {

            orderDetailDal.Add(orderDetail);
        }

        public void Delete(int orderId)
        {
            orderDetailDal.Delete(orderId);
        }

        public List<OrderDetail> GetOrderById(int orderId)
        {
            List<OrderDetail> orders = orderDetailDal.GetOrderById(orderId);
            return orders;
        }

        public List<OrderDetail> GetAll()
        {
            return orderDetailDal.GetAll();
        }

        public void Update(int orderId)
        {
            orderDetailDal.Update(orderId);
        }
        public void AddByUserId(int userId)
        {
            List<Basket> baskets = basketService.GetAll().Where(b => b.UserId == userId && b.IsOrder == false && b.IsDeleted == false).ToList();
            List<Order> orders = orderService.GetAll().Where(order => order.UserId == userId).ToList();
            Order lastOrder = orders[orders.Count - 1];
            OrderDetail orderDetail = new OrderDetail();
            foreach (var basket in baskets)
            {
                orderDetail.OrderId = lastOrder.Id;
                orderDetail.BasketId = basket.Id;
                orderDetailDal.Add(orderDetail);
                //  productOrderDetailDto.orderId = orderDetail.OrderId;
            }


        }
        //    public void EnterOrderDetails(int orderId)
        //    {
        //        List<OrderDetail> orderDetails = orderDetailDal.GetAll().Where((b) => b.OrderId == orderId).ToList();
        //        ProductOrderDetailDto productOrderDetailDto = new ProductOrderDetailDto();
        //        foreach (OrderDetail order in orderDetails)
        //        {
        //            //productOrderDetailDto.orderId = order.OrderId;
        //            basketService.Get(order.BasketId);


        //        }
        //        AddProductId();
        //        AddPrdouctName();

        //    }
        //    public void AddProductId()
        //    {
        //        List<Basket> baskets = basketService.GetAll().Where(b => b.Id == productOrderDetailDto.basketId).ToList();
        //        foreach (var basket in baskets)
        //        {
        //            basket.ProductId = productOrderDetailDto.productId;
        //        }

        //    }
        //    public void AddPrdouctName()
        //    {
        //        List<Product> products = productService.GetAll().Where(p => p.Id == productOrderDetailDto.productId).ToList();
        //        foreach (var product in products)
        //        {
        //            product.Name = productOrderDetailDto.Name;
        //            product.Price = productOrderDetailDto.Price;
        //        }


        //    }

        //}
        public List<ProductOrderDetailDto> GetOrderDetails(int orderId)
        {
            List<OrderDetail> orders = orderDetailDal.GetAll().Where(i => i.OrderId == orderId).ToList();
            List<ProductOrderDetailDto> dtos = new List<ProductOrderDetailDto>();
            foreach (var order in orders)
            {
                Basket basket = basketService.Get(order.BasketId);
                Product product = productService.GetById(basket.ProductId);
                ProductOrderDetailDto orderDetail = new ProductOrderDetailDto();
                orderDetail.Name = product.Name;
                orderDetail.Count = basket.Count;
                if (basket.Count > 1)
                {
                    orderDetail.Price = basket.Count * product.Price;
                    dtos.Add(orderDetail);
                }
                else
                {
                    orderDetail.Price = product.Price;
                    dtos.Add(orderDetail);
                }


            }

            return dtos;
        }
    }

}