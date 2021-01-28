using System;
using Gunstoreshoppingcart.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gunstoreshoppingcart
{
    public class Program
    {
        static void Main()
        {
            string response = "";

            while (response != "3")
            {
                Console.WriteLine("1.  Create a User");
                Console.WriteLine("2.  Create a Comment");
                Console.WriteLine("3.  Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");

                  response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User user = new User();
                        user.UserId = 1;
                        user.SuperUser = "yes";

                        Console.WriteLine("The user option you chose is: " + user.UserId);

                        break;
                    case "2":
                        Comment comment = new Comment();
                        comment.CommentId = 25;
                        comment.CommentDescription = "first comment";

                        Console.WriteLine("The comment option that you chose is: " + comment.CommentDescription);

                        break;
                }
                    
                Console.WriteLine("your response is: " + response);
            }



        }


    }
}


     
        
             