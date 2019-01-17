using System;
//Must add reference to project in solution explore to use
using CalculateAverages;

namespace ClassExercises
{
    class Exercises
    {
        //Starting page
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises.Main()");

            //Example calling method from separate project and class
            Console.WriteLine($"Avg: {Averages.TestAverages(60.0, 70.0, 80.0)}");


            Console.ReadKey();
        }
    }
}      
