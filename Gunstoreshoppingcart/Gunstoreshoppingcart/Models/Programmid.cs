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
            List<User> userList = new List<User>();
            List<Comment> comList = new List<Comment>();
            
            while (response != "5")
            {
                Console.WriteLine("1.  Create a User");
                Console.WriteLine("2.  Create a Comment");
                Console.WriteLine("3.  Print a User List");
                Console.WriteLine("4.  Print a Comment List");
                Console.WriteLine("5.  Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");

                  response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User user = new User();
                        user.UserId = 1;
                        user.SuperUser = "yes";

                        userList.Add(user);

                        Console.WriteLine("You have created a new user");
                        break;
                    case "2":
                        Comment comment = new Comment();
                        comment.CommentId = 25;
                        comment.CommentDescription = "first comment";

                        comList.Add(comment);

                        Console.WriteLine("You have created a new comment");
                        break;
                    case "3":
                        Console.WriteLine("This is the List of Users:");

                        foreach(var listuser in userList)
                        {
                            Console.WriteLine("The user Id is: " + listuser.UserId);
                            Console.WriteLine("Is this a Super User ? " + listuser.SuperUser);
                        }
                        break;
                    case "4":
                        Console.WriteLine("This is the List of Comments:");

                        foreach (var listcomment in comList)
                        {
                            Console.WriteLine("The list comment is: " + listcomment.CommentId);
                            Console.WriteLine("The comment description is: " + listcomment.CommentDescription);
                        }
                        break;
                }
                    
             }



        }


    }
}


     
        
             