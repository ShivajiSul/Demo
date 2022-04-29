using MVCAPP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_Core.Interfaces
{
   public interface IUserRepository
    {
        UserDTO GetUser(UserModel userMode);
    }
}
