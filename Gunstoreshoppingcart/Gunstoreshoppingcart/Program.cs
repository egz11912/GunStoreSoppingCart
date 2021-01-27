using System;
namespace Gunstoreshoppingcart.Models

{
    class Program
    {
        static void Main()
        {
            string response = "";

            while (response != "6")
            {
                Console.WriteLine("1.  Create a User");
                Console.WriteLine("2.  Create a Comment");
                Console.WriteLine("3.  Exit");

                Console.WriteLine("");
                Console.WriteLine("Please make a selection");

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Users user = new Users();
                        user.UserId = 1;
                        user.Email =
                        user.SuperUser = "";

                        
                        Console.WriteLine();

                        Console.WriteLine("1.  Enter User Id");
                        Console.WriteLine("2.  Enter User Email");
                        Console.WriteLine();
                        Console.WriteLine("Please make a selection");

                        response = Console.ReadLine();

                        break;

                    case "2":
                        Comments comment = new Comments();
                        comment.CommentId = 43;
                        comment.CommentDescription = "Bold and Fresh";

                        Console.WriteLine();

                        Console.WriteLine("1.  Enter Comment Id");
                        Console.WriteLine("2.  Enter Comment Description");
                        Console.WriteLine();
                        Console.WriteLine("Please make a selection");

                        response = Console.ReadLine();





                        break;
                     

                         

                        

                        
                }

                
            }


        }
    }
}
