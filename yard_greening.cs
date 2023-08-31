using System;

namespace firstLab
{
    class yard_greening
    {
        static void Main(string[] args)
        {
            double priceGreen = 7.61;

            double quantity = double.Parse(Console.ReadLine());

            double finalPrice = quantity * priceGreen;
            double discountPrice = finalPrice * 0.18;

            double finalPriceTotal = finalPrice - discountPrice;

            Console.WriteLine($"The final price is: {finalPriceTotal} lv.");
            Console.WriteLine($"The discount is: {discountPrice} lv.");

        }
    }

}