//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using ShoppingApp.Models.Concret;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShoppingApp.Dal.Abstract
{
   public interface ICategoryDal
    {
        List<Category> GetAll();
        Category Get(int CategoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int CategoryId);
    }
}