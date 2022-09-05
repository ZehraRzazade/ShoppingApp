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
    public interface IUserDal
        
    {
        List<User> GetAll();
        User Get(int UserID);
        void Add (User user);
        void Update ( User user);
        void Delete (int UserId);
    }
}