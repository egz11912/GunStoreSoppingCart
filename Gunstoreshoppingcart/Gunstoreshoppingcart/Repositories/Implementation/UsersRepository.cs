using System;
using System.Collections.Generic;
using System.Linq;
using Gunstoreshoppingcart.Exceptions;
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
            List<Users> resultList =
                currentDatabase.Where(Users => Users.UserName == name).ToList();

            if (resultList.Count > 0)
            {
                foreach (var role in resultList)
                {
                    Console.WriteLine(role.UserName);
                    Console.WriteLine(role.UserId);
                }



            }
            else
            {
                throw new UserNameNotFound("No user of that name found");
            }
        }


    }
    
}
