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
   public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int ProductId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int ProductId);
    }
}