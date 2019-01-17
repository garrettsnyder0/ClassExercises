using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdds
{
    public class SumOfOdds
    {

        // Given an integer from the user return the sum of all odd integers up to that number
        // int must be >0 and <256
        // ex. passed 5 then sum = 1+3+5
        public static int sumOdds(int userNum)
        {
            if (userNum > 256 || userNum < 0)
            {
                Console.WriteLine("Not a valid input, returning 0");
                return 0;
            }

            int sum = 0;
            for (int ii = 0; ii <= userNum; ii++)
            {
                if (ii % 2 != 0)
                {
                    sum += ii;
                }
            }
            return sum;
        }

             
        static void Main(string[] args)
        {
            Console.WriteLine("From SumOfOdds.Main");
            Console.WriteLine(sumOdds(5));
            Console.WriteLine(sumOdds(9));
            Console.WriteLine(sumOdds(-1));
            Console.WriteLine(sumOdds(257));
            Console.ReadKey();
        }
    }
}
