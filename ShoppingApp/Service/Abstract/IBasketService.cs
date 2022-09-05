using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.Models.Concret;
using ShoppingApp.Models.Concret.Dto;

namespace ShoppingApp.Service.Abstract
{
    public interface IBasketService
    {
        List<Basket> GetAll();
        Basket Get(int id);
        void Add(Basket basket);
        void Update(Basket basket);
        void Delete(Basket basket);
        List<ProductBasketDto> GetAll(int UserId);
        List<Basket> GetAllIsNotDeleted();
        List<Basket> GetAllIsNotDeletedAndNotOrdered();
        void UpdateAndAdd(int id, int userId);
        void UpdateForCount(int id);    
        void AddByIdAndUserId(int id, int userId);  
        List<Basket> GetListByUserId(int userId);
        List<Basket> GetAllIsNotDeletedAndOrdered();
       void ChangeIsOrdered(int userId);
         void ChangeIsDeleted(int userId);
    }
}
