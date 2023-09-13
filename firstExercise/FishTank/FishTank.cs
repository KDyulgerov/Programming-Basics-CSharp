using System;


namespace firstExercise
{
    class FishTank
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeAqua = lenght * width * height;
            double volumeLiters = volumeAqua / 1000;
            double litersNeed = volumeLiters * (1 - (percent / 100));

            Console.WriteLine(litersNeed);


        }
    }

}