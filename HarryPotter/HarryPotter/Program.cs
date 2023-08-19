using System;

namespace HarryPotter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] basket = new int[5];
            int amount;
            while (i<5)
            {
                Console.WriteLine("How many copies you want from book #"+(i+1));
                amount = int.Parse(Console.ReadLine());
                basket[i] = amount;
                i++;
            }
            double totalPrice = HarryPotter.CalculatePrice(basket);
            Console.WriteLine("Total price: " + totalPrice);
        }
    }
}
