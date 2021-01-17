using System;

namespace GunStoreShoppingCart
{
    class InstagramPage
    {
        string users;
        string roles;
        string images;
        string posts;
        string comments;

        static void Main(string[] args)
        {
            InstagramPage page = new InstagramPage();
            page.users = "Enduser";
            page.roles = "actors";
            page.images = "pictures";
            page.posts = "new blog";
            page.comments = "what do you think";


            Console.WriteLine(page.comments);
            Console.WriteLine(page.users);
            Console.WriteLine(page.posts);

        }
    }
}
    
