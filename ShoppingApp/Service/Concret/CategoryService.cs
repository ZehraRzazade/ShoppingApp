using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret;
using ShoppingApp.Service.Abstract;
namespace ShoppingApp.Service.Concret
{
    public class CategoryService : ICategoryService
    {
       CategoryDal categoryDal=new CategoryDal();
        public void Add(Category category)
        {
            categoryDal.Add(category);  
            
        }

        public void Delete(int Id)
        {
           categoryDal.Delete(Id);
        }

        public Category GetById(int CategoryId)
        {
            return categoryDal.Get(CategoryId);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }

        public void Update(Category category)
        {
           categoryDal.Update(category);
        }
    }
}
