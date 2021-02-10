using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart.Repositories.Implementation
{
    public class UsersRepository : MainRepository<Users>, IUsers_Repository
    {
        public UsersRepository()  
        {
        }

        public void GetAllUsersByName(string name)
        {
            throw new NotImplementedException();
        }



    }
    
}
