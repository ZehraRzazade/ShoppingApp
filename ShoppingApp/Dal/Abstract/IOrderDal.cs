//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using ShoppingApp.Models.Concret;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Data.Entity;
namespace ShoppingApp.Dal.Abstract
{
   public interface IOrderDal
    {
        List<Order> GetAll();
       Order Get(int OrderId);
        void Add(Order order);
        void Update(Order order);
        void Delete(int OrderId);
    }
}