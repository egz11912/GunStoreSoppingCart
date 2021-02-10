using System;
using Gunstoreshoppingcart.Models;
using System.Collections.Generic;
using System.Linq;
using Gunstoreshoppingcart.Repositories.Implementation;

namespace Gunstoreshoppingcart
{

    public class Program
    {
        static void Main()
        {
            UsersRepository repository = new UsersRepository();

            Users newUsers = new Users();
            newUsers.UserName = "Eric Z";
            newUsers.UserId = 1;    

            Users newUsers2 = new Users();
            newUsers2.UserName = "Sam R";
            newUsers2.UserId = 2;

            Users newUsers3 = new Users();
            newUsers3.UserName = "Jordan Z";
            newUsers3.UserId = 3;

            repository.Save(newUsers);
            repository.Save(newUsers2);
            repository.Save(newUsers3);

            

             
        }

    }



}

 



