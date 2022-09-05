using ShoppingApp.Models.Concret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Dal.Abstract
{
    public interface IBalanceDal
    {
         List<UserBalance> GetAllBalances();
     
        UserBalance GetById(int id);
        void Add(UserBalance userBalance);
        void Update(UserBalance userBalance);
        void Delete(int userId);

    }
}