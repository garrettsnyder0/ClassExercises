using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class OptionalParameters
    {

       

        public static void SingASong(string Title, string key = "C", int numTimes = 1)
        {
            for(int i = 0; i < numTimes; i++)
            {
                Console.WriteLine($"{Title} in {key}!!");
            }
        }

        //Overload one possible option of optional parameter method
        //Can be used if you want a different output for if they passed only certain input
       /* public static void SingASong(string Title, string key)
        {
            Console.WriteLine($"{Title} in {key}!!");
            Console.WriteLine("done in overloaded method");
        }*/

        //Passing parameters in order of string, int is not allowed with just above method that has optional parameters
        //The reason is it always expects (string, string) so if it receives (string, int) that method signature doesn't exist
        public static void SingASong(string Title, int numTimes)
        {
            string key = "q";
            for (int i = 0; i < numTimes; i++)
            {
                Console.WriteLine($"{Title} in {key}!!");
            }
            Console.WriteLine("method that is not possible without callling named parameters");
        }

        static void Main(string[] args)
        {
            //SingASong("baby shark", "G", 12);
            Console.WriteLine();
            SingASong("baby shark");
            Console.WriteLine();
            SingASong("baby shark", "G");
            Console.WriteLine();
            SingASong("baby shark", 5);

            Console.ReadKey();
        }
    }
}
