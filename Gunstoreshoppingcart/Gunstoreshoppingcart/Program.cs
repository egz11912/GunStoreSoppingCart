using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Users objectuser = new Users();

            objectuser.SuperUser = "Eric Zuniga";
            Console.WriteLine(objectuser.SuperUser);


            Users objectuser2 = new Users();

            objectuser2.Email = "ezuniga@southwestuniversity.edu";
            Console.WriteLine(objectuser2.Email);



            Roles role1 = new Roles();

            role1.RoleName = "Team Lead";
            Console.WriteLine(role1.RoleName);

            Roles role2 = new Roles();

            role2.RoleType = "Management";
            Console.WriteLine(role2.RoleType);


        }
    }
}

 