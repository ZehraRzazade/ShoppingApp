using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret;
using ShoppingApp.Models.Concret.Dto;
using ShoppingApp.Service.Abstract;
namespace ShoppingApp.Service.Concret
{
    public class BasketService : IBasketService
    {
        BasketDal basketDal = new BasketDal();
        ProductService productService = new ProductService();
        ProductBasketDto dto = new ProductBasketDto();
        public void Add(Basket basket)
        {
            basketDal.Add(basket);
        }

      

        public Basket Get(int id)
        {
            return basketDal.GetById(id);
        }

        public List<Basket> GetAll()
        {
            return basketDal.GetAll();
        }

        public void Update(Basket basket)
        {
            basketDal.Update(basket);
        }
        public List<ProductBasketDto> GetAll(int ID)
        {
            var test = basketDal.GetAll();
            List<Basket> baskets = test.Where(x => x.UserId == ID && x.IsDeleted == false && x.IsOrder==false).ToList();
            List<ProductBasketDto> dtos = new List<ProductBasketDto>();
            foreach (var basket in baskets)
            {
                Product prod = productService.GetById(basket.ProductId);
                ProductBasketDto data = new ProductBasketDto();
                data.Id = basket.Id;
                data.Name = prod.Name;
                data.Count = basket.Count;
                data.Price = prod.Price;
               
                dtos.Add(data);
            }
            return dtos;
        }

        public List<Basket> GetAllIsNotDeleted()
        {
            List<Basket> basketList = basketDal.GetAll().Where(b => b.IsDeleted == false).ToList();
            return basketList;
        }

        public void UpdateAndAdd(int id, int userId)
        {

            List<Basket> allBasketByUserId = GetAllIsNotDeletedAndNotOrdered().Where(b => b.UserId == userId).ToList();

            if (allBasketByUserId == null)
            {
                AddByIdAndUserId(id, userId);
            }
            else
            {
                Basket currentBasketItem = allBasketByUserId.Where(b => b.ProductId == id).ToList().FirstOrDefault();
                if (currentBasketItem != null)
                    UpdateForCount(currentBasketItem.Id);
                else
                    AddByIdAndUserId(id, userId);

            }

           
        }
        public void Delete(Basket basket)
        {
            if(basket.Count > 1)
            {
                basket.Count--;
                basketDal.Update(basket);
            }else
            {
                basketDal.Delete(basket);

            }
        
        }
        public void UpdateForCount(int id)
        {
            List<Basket> baskets = GetAllIsNotDeletedAndNotOrdered();
            foreach (Basket b in baskets)
            {
                if (b.Id == id)
                {
                    b.Count++;
                }
                basketDal.Update(b);
            }

        }
        public void AddByIdAndUserId(int id,int userId)
        {
            Basket basket = new Basket();
            basket.ProductId = id;
         
            basket.UserId = userId;
            basket.Count = 1;
            basketDal.Add(basket);

        }

        public List<Basket> GetAllIsNotDeletedAndNotOrdered()
            => basketDal.GetAll().Where(b => !b.IsDeleted&&!b.IsOrder).ToList();

        public List<Basket> GetAllIsNotDeletedAndOrdered()
            => basketDal.GetAll().Where(b => !b.IsDeleted && b.IsOrder).ToList();
        public List<Basket> GetAllIsNotDeletedAndIsNotOrdered()
          => basketDal.GetAll().Where(b => !b.IsDeleted && !b.IsOrder).ToList();

        public List<Basket> GetListByUserId(int userId)
        {

            List<Basket> baskets = GetAllIsNotDeletedAndIsNotOrdered().Where(b=>b.UserId==userId).ToList();
            return baskets;

        }
        public void ChangeIsOrdered( int userId)
        {
          List<Basket> baskets =GetAllIsNotDeletedAndNotOrdered().Where(b => b.UserId==userId).ToList();
            foreach(Basket b in baskets)
            {
                b.IsOrder = true;             
                Update(b);
            }
        }

        public void ChangeIsDeleted(int userId)
        {
            List<Basket> baskets = GetAllIsNotDeletedAndOrdered().Where(b => b.UserId == userId).ToList();
            foreach (Basket b in baskets)
            {
                b.IsDeleted = true;
                Update(b);
            }
        }
    }
}