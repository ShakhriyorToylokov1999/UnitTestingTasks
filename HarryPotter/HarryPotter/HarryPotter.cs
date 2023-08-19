using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    public class HarryPotter
    {
        private static double BOOK_PRICE = 8.0;

        public static double CalculatePrice(int[] basket)
        {
            double totalPrice = 0.0;
            int numBooks = basket.Length;

            while (numBooks > 0)
            {
                int uniqueBooks = GetUniqueBooks(basket);
                double discount = GetDiscount(uniqueBooks);
                double price = uniqueBooks * BOOK_PRICE * (1 - discount);
                totalPrice += price;

                for (int i = 0; i < basket.Length; i++)
                {
                    if (basket[i] > 0)
                    {
                        basket[i]--;
                    }
                }

                numBooks = GetNumBooks(basket);
            }

            return totalPrice;
        }

        private static int GetUniqueBooks(int[] basket)
        {
            int uniqueBooks = 0;

            for (int i = 0; i < basket.Length; i++)
            {
                if (basket[i] > 0)
                {
                    uniqueBooks++;
                }
            }

            return uniqueBooks;
        }

        private static int GetNumBooks(int[] basket)
        {
            int numBooks = 0;

            for (int i = 0; i < basket.Length; i++)
            {
                numBooks += basket[i];
            }

            return numBooks;
        }

        private static double GetDiscount(int numBooks)
        {
            switch (numBooks)
            {
                case 2:
                    return 0.05;
                case 3:
                    return 0.1;
                case 4:
                    return 0.2;
                case 5:
                    return 0.25;
                default:
                    return 0.0;
            }
        }
    }
}
