using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.Models.Concret;
namespace ShoppingApp.Service.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int ProductId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        List<Product> GetAllByCategoryId(int categoryId);
    }
}
