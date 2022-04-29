using MVCAPP_Core.Interfaces;
using MVCAPP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_Core.ToeknServices
{
    public class UserRepository: IUserRepository
    {
       private readonly List<UserDTO> users = new List<UserDTO>();

        public UserRepository()
        {
            users.Add(
                new UserDTO
                {
                    UserName = "Shivaji",
                    Password = "Shiva@123",
                    Role="Manager"
                });
               users.Add(
               new UserDTO
               {
                   UserName = "Abhilash",
                   Password = "Abhi@123",
                   Role = "Developer"
               });
        }
    
        public UserDTO GetUser(UserModel user)
        {

            return users.Where(x => x.UserName.ToLower() == user.UserName.ToLower() && x.Password == user.Password).FirstOrDefault();

             

        }
    }
}
