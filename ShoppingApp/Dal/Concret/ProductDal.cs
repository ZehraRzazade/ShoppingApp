//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ShoppingApp.Dal.Abstract;
using ShoppingApp.Dal.Context;
using System.Data.Entity;
using ShoppingApp.Models.Concret;

namespace ShoppingApp.Dal.Concret

{
    public class ProductDal : IProductDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(Product product)
        {

           shoppingContext.Product.Add(product);

            shoppingContext.SaveChanges();
        }

        public void Delete(int ProductId)
        {
            shoppingContext.Product.Remove(shoppingContext.Product.FirstOrDefault(i => i.Id == ProductId));
            shoppingContext.SaveChanges();
        }

        public Product Get(int ProductId)
        {
            return shoppingContext.Product.Where(i => i.Id == ProductId).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return shoppingContext.Product.ToList();
        }

        public void Update(Product product)
        {
            shoppingContext.Entry(product).State = EntityState.Modified;
            shoppingContext.SaveChanges();
        }
    }
}