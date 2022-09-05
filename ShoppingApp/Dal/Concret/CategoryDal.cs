
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using ShoppingApp.Dal.Abstract;
using ShoppingApp.Dal.Context;
using ShoppingApp.Models.Concret;
namespace ShoppingApp.Dal.Concret
{
    public class CategoryDal : ICategoryDal
    {
        private ShoppingContext shoppingContext = new ShoppingContext();
        public void Add(Category category)
        {
            shoppingContext.Category.Add(category);
            shoppingContext.SaveChanges();

        }

        public void Delete(int CategoryId)
        {

            shoppingContext.Category.Remove(shoppingContext.Category.Where(i => i.Id == CategoryId).First());
            shoppingContext.SaveChanges();
        }

        public Category Get(int CategoryId)
        {
            Category category = new Category();
            return shoppingContext.Category.Where(i => i.Id == CategoryId).FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return shoppingContext.Category.ToList();
        }

        public void Update(Category category)
        {
            shoppingContext.Entry(category).State = EntityState.Modified;
            shoppingContext.SaveChanges();
        }
    }
}