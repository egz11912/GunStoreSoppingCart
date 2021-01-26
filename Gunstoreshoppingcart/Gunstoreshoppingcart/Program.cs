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
                Console.WriteLine("2.  Create an Image");
                Console.WriteLine("3.  Create a Post");
                Console.WriteLine("4.  Create a Role");
                Console.WriteLine("5.  Create a Comment");
                Console.WriteLine("6.  Exit");

                Console.WriteLine("");
                Console.WriteLine("Please make a selection");

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Users user = new Users();
                        user.UserId = 1;
                        user.Email = "egz11912@gmail.com";
                        user.SuperUser = "yes";

                        
                        Console.WriteLine();

                        Console.WriteLine("1.  Enter User Id");
                        Console.WriteLine("2.  Enter User Email");
                        Console.WriteLine();
                        Console.WriteLine("Please make a selection");

                        response = Console.ReadLine();

                        break;
                    case "2":
                        Images image = new Images();
                        image.ArtID = 10;
                        image.ArtistName = "Ray Schumaker";

                        Console.WriteLine("The Artist name you selected is: " + image.ArtistName);

                        break;
                    case "3":
                        Posts post = new Posts();
                        post.PostId = 100;
                        post.PostType = "new submission";

                        Console.WriteLine("The post type you selected is: " + post.PostType);

                        break;
                    case "4":
                        Roles role = new Roles();
                        role.RoleType = "Administrator";
                        role.RoleName = "Team Lead";

                        Console.WriteLine("The role name you selected is: " + role.RoleName);

                        break;
                    case "5":
                        Comments comment = new Comments();
                        comment.CommentId = 43;
                        comment.CommentDescription = "Bold and Fresh";

                        Console.WriteLine("The comment description you have selected is: " + comment.CommentDescription);

                        break;

                        
                }

                
            }


        }
    }
}
