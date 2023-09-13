using System;

namespace firstExercise
{
    class VacationList
    {
        static void Main(string[] args)
        {
            int pagesBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalTime = pagesBook / pagesPerHour;
            int hoursNeeded = totalTime / days;

            Console.WriteLine(hoursNeeded);

        }
    }

}