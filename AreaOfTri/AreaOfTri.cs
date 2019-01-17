using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTri
{
    class AreaOfTri
    {

        static void testAOT()
        {
            int howMany = 5;
            for (int i = 0; i<howMany; i++)
			{

                for (int j = 0; i<howMany; j++)
			    {
                    Console.Write("\n\t");
                    Console.Write($"base: {i}, height: {j}");
                    Console.WriteLine($"{AreaOfTriangle(i, j)}");
			    }

			}

            return;
        }

        static double AreaOfTriangle(double b, double ht) => b * ht / 2.0;

        static void Main(string[] args)
        {
            Console.WriteLine("AreaOfTri.Main()");

           

            Console.ReadKey();
        }
    }
}
