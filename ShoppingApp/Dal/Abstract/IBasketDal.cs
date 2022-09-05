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
  public  interface IBasketDal
    {
        List<Basket> GetAll();
        Basket GetById(int id);
        void Add(Basket basket);
        void Update(Basket  basket);
        void Delete(Basket basket);
    }
}