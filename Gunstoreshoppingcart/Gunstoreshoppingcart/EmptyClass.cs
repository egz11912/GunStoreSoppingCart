using System;
using Gunstoreshoppingcart;
using Gunstoreshoppingcart.Models;
using BakeryShoppingCart.DTOS;

namespace Gunstoreshoppingcart
{
    public class Program

    {
        static void Main()
        {
            string response = "";

            Users myUser = new Users();

            while (response != "5")
            {
                myUser.PrintMenu();

                response = myUser.CaptureResponse();

                switch (response)
                {
                    case "1":
                        myUser.CreateUser();
                        break;
                    case "2":
                        myUser.CreateComment();
                        break;
                    case "3":
                        myUser.ShowallUsers();
                        break;
                    case "4":
                        myUser.ShowallComments();
                        break;
                    case "5":
                        break;
                    default:
                        break;
                        
                }
            }
        }

    }
}
