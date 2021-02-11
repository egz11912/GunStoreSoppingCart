using System;
using System.IO;

namespace Gunstoreshoppingcart.FileManager
{
    public class FileManagerClass
    {
        public FileManagerClass()
        {
        }

        public void CreateAFile(string path)
        {





            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                Console.WriteLine("File already exists");

                DateTime creationTime =
                    File.GetCreationTime(path);

                Console.WriteLine("File was created on: "
                                  + creationTime);

                DateTime modifiedTime =
                    File.GetLastWriteTime(path);

                Console.WriteLine("File was modified on: "
                                  + modifiedTime);


            }
            else
            {
                Console.WriteLine("You have created the file: " +
                                  path);
                File.Create(path);
            }
        }




    }
}
