using System;
using System.Drawing;


namespace firstExercise
{
    class SuppliesForSchool
    {
        static void Main(string[] args)
        {
            double pens = 5.80; 
            double markers = 7.20; 
            double preparateLiter = 1.20;

            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int countPrepLiters = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double sumPens = pens * countPens;
            double sumMarkers = markers * countMarkers;
            double sumPreparate = preparateLiter * countPrepLiters;

            double totalSum = sumPens + sumMarkers + sumPreparate;
            double percentDiscount = discountPercent / 100.0;

            double totalPrice = totalSum - (totalSum * percentDiscount);
           
            Console.WriteLine(totalPrice);

        }
    }

}