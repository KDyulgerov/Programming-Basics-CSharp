using System;

namespace firstLab
{
    class pet_shop
    {
        static void Main(string[] args)
        {
            double dogFood = 2.50;
            int catFood = 4;

            int countDogFood = int.Parse(Console.ReadLine());
            int countCatFood = int.Parse(Console.ReadLine());

            Console.WriteLine($"{dogFood * countDogFood + catFood * countCatFood} lv.");

        }
    }

}