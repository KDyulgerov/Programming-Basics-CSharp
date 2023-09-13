using System;


namespace firstExercise
{
    class Repaiting
    {
        static void Main(string[] args)
        {
            double naylon = 1.50;
            double paint = 14.50;
            double liquid = 5.00;
            double bags = 0.40;

            int qtyNaylon = int.Parse(Console.ReadLine()) + 2;
            double qtyPaint = double.Parse(Console.ReadLine());
            qtyPaint = qtyPaint + qtyPaint * 0.1;
            int qtyLiquid = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double priceNaylon = naylon * qtyNaylon;
            double pricePaint = paint * qtyPaint;
            double priceLiquid = liquid * qtyLiquid;
            double totalPrice = priceNaylon + pricePaint + priceLiquid + bags;
            double priceWorkers = (totalPrice * 0.30) * 8;
            double finalPrice = totalPrice + priceWorkers;

            Console.WriteLine(finalPrice);
        }
    }

}