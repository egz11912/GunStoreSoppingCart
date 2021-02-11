using System;
using Gunstoreshoppingcart.Models;
using System.Collections.Generic;
using System.Linq;
using Gunstoreshoppingcart.Repositories.Implementation;
using System.IO;
using Gunstoreshoppingcart.FileManager;

namespace Gunstoreshoppingcart
{

    public class Program
    {
        static void Main()
        {
            string path = "file.txt";
            string moveToPath = "../file.txt";

            FileManagerClass newManager =
                new FileManagerClass();

            newManager.CreateAFile(path);

             

            

        }

    }



}

 



