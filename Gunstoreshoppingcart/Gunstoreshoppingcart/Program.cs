using System;
using System.Collections.Generic;
namespace Gunstoreshoppingcart {

};

class Program
{
    static void Main()
    {

        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Console.WriteLine("Array elements are:");
            foreach (int i in a)  
            {
                Console.Write(i + "  ");   
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List elements are:");
            List<double> b = new List<double>();

            b.Add(14.5);
            b.Add(89.7);
            b.Add(76.3);
            b.Add(90.90);
            b.Add(43.2);
            b.Add(6.1);
            b.Add(100.1);
            b.Add(23.234);
            b.Add(27.21);
            b.Add(4.12);

            for (int i = 0; i < b.Count; i++)
            {
                Console.Write(b[i] + ",   ");
            }
        }
    }

}