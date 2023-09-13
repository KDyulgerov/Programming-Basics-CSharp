using System;


namespace firstExercise
{
    class BasketballEquipment
    {
        static void Main(string[] args)
        {
            int taxYear = int.Parse(Console.ReadLine());

            double basketballShoes = taxYear - (taxYear * 0.40);
            double basketballEquip = basketballShoes - (basketballShoes * 0.20);
            double basketballBall = basketballEquip / 4;
            double basketballAccessories = basketballBall / 5;

            double totalPrice = taxYear + basketballShoes + basketballEquip + basketballBall + basketballAccessories;

            Console.WriteLine(totalPrice);
        }

    }
}