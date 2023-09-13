using System;


namespace firstExercise
{
    class FoodDelivery
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double veganMenu = 8.15;
            double deliveryPrice = 2.50;

            int countChicken = int.Parse(Console.ReadLine());
            int countFish = int.Parse(Console.ReadLine());
            int countVegan = int.Parse(Console.ReadLine());

            double sumMenus = (chickenMenu * countChicken) + (fishMenu * countFish) + (veganMenu * countVegan);
            double desertPrice = sumMenus * 0.20;

            double totalPrice = sumMenus + desertPrice + deliveryPrice;

            Console.WriteLine(totalPrice);
        }

    }
}