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
            NewClass<string> myNewclass = new NewClass<string>();
            myNewclass.FirstGenericProperty = "A new string";

            NewClass<int> myNewClass2 = new NewClass<int>();
            myNewClass2.FirstGenericProperty = 12345;


            Console.WriteLine(myNewclass.FirstGenericProperty);
            Console.WriteLine(myNewClass2.FirstGenericProperty);

        }


    }
}

public class NewClass<T>
{
    public T FirstGenericProperty { get; set; }
    
}
