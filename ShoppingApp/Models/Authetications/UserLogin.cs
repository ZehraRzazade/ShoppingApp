using ShoppingApp.Models.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models.Authetications
{


    public class UserLogin
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public List<UserLogin> users = new List<UserLogin>();
        public void AddUsers( string name,int? ID)
        {
            if (ID != null && name != null)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.ID = ID;
                userLogin.Name = name;  
                users.Add(userLogin);
            }


        }
    }
}