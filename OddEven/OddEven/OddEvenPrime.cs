using System;
using System.Collections.Generic;
using System.Text;

namespace OddEven
{
    public class OddEvenPrime
    {
        private static readonly string ODD = "ODD";
        private static readonly string EVEN = "EVEN";


        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(CheckOddEven(i));
            }
        }
        
        public static string CheckOddEven(int num)
        {
            if (num < 1 || num > 100)
                throw new ArgumentException("The number should be between 1-100 ");

            if (num % 2 == 0)
                return EVEN;

            if (num % 3 == 0)
                return ODD;

            return num.ToString();
        }
    }
}
