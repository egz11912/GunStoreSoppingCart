using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart
{
    class Program
    {
        public class SumOnetoTwentyNumbers
        {
            public static void Main(string[] args)
            {
                int numStart = 1;
                int numLast = 20;
                int sum = 0;
                while (numStart <= numLast)
                {
                    sum = sum + numStart;
                    numStart++;
                }
                Console.Write("Sum of all Digits = " + sum);
            }
        }
    }
}


