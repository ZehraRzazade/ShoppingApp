using ShoppingApp.Models.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Service.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int CategoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryService);
    }
}
