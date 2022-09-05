using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.Dal.Concret;
using ShoppingApp.Models.Concret;
using ShoppingApp.Service.Abstract;
namespace ShoppingApp.Service.Concret
{
    public class UserService : IUserService
    {
        UserDal userDal = new UserDal();
        public void Add(User user)
        {
           userDal.Add(user);
        }

        public void Delete(int userId)
        {
          userDal.Delete(userId);
        }

        public User Get(int UserId)
        {
            return  userDal.Get(UserId);
        }

        public List<User> GetAll()
        {
            return userDal.GetAll();        
        }

        public User GetUser(string name,string password)
        {

        
            var test = userDal.GetAll().Where(x => x.Name == name).ToList(); 
            var result =false;          
            
            foreach(var item in test)
            {
                 result = BCrypt.Net.BCrypt.Verify(password, item.Password);
              
            }
            

            User user = test.Where(x => x.Name == name && result==true).FirstOrDefault();
            return user;

        }

        public void Update(User user)
        {
            userDal.Update(user);
        }

    }
}
