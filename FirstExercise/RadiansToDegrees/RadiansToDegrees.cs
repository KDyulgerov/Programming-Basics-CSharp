using System;


namespace firstExercise
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double angle = num * 180 / Math.PI;
           
            Console.WriteLine(angle);

        }
    }

}