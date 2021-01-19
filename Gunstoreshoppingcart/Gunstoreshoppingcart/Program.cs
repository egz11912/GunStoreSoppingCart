using System;

namespace Gunstoreshoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Users nameObject = new Users();

            nameObject.Superuser = "Eric Zuniga";

            Console.Write(nameObject.Superuser);
        }
    }
}

public class Users
{
   public string Superuser { get; set; }

    
}

public class Roles
{
   public string types { get; set; }
}

public class Images
{
   public string art { get; set; } 

}

public class Posts
{
    public string articles { get; set; } 
}

public class Comments
{
    public string good { get; set; }
}
