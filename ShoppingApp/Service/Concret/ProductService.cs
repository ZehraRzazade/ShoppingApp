
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret;
using ShoppingApp.Service.Abstract;
namespace ShoppingApp.Service.Concret

{
    public class ProductService : IProductService
    {
        ProductDal productDal = new ProductDal();
        CategoryService categoryService = new CategoryService();
        public void Add(Product product)
        {
           productDal.Add(product);
        }

        public void Delete(int productId)
        {
           productDal.Delete(productId);
        }

        public Product GetById(int ProductId)
        {
           return productDal.Get(ProductId);
        }

        public List<Product> GetAll()
        {
            return  productDal.GetAll();
        }

        public void Update(Product product)
        {
            productDal.Update(product);
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return productDal.GetAll().Where(p => p.CategoryId==categoryId).ToList(); 
        }
    }
}