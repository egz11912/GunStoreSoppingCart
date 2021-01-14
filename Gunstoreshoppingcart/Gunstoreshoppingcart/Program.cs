using System;

namespace Gunstoreshoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Eric ";
            string lastName = "Zuniga";
            string fullName = firstName + "" + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            int sum1 = 10 + 5;        
            int sum2 = sum1 + 100;      
            int sum3 = sum2 + sum2;     
            Console.WriteLine(sum3);
        }
    }
}
