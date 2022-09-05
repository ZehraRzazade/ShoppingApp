using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.Models.Concret;
namespace ShoppingApp.Service.Abstract
{
    internal interface IUserService
    {
        List<User> GetAll();
        User Get(int UserId);
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
        User GetUser(string name,string password);
    }
}
