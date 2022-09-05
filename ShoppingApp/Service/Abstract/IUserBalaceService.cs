using ShoppingApp.Models.Concret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Service.Abstract
{
  public interface IUserBalaceService
    {
       UserBalance GetById(int userId);

        void Add(UserBalance userBalance);
        void Update(UserBalance userBalance);
        void Delete(int userId);
        List<UserBalance> GetAllBalances();
    }
}
