using System;

namespace firstLab
{
    class project_creation
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projNumber = int.Parse(Console.ReadLine());

            int sumProjects = projNumber * 3;

            Console.WriteLine($"The architect {archName} will need {sumProjects} hours to complete {projNumber} project/s.");
        }
    }

}