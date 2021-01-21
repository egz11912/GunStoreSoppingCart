using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2021, 11, 18);
            DateTime date2 = new DateTime(2022, 11, 18);

            if (date1 > date2)

            {
                Console.WriteLine(date1);

            }
            else

                Console.WriteLine(date2);
        }
    }
}

 