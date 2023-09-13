using System;

namespace firstExercise
{
    class UsdToBgn
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double usd = 1.79549;

            double bgn = num * usd;

            Console.WriteLine(bgn);
        }
    }
}
