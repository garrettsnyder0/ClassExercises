using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {

        public static void ReadTextAtOnce()
        {

            // Read the file as one string.
            string text = File.ReadAllText(@"C:\Users\garre\Documents\MSSA\Class Examples\ClassExercises\lyrics.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(@"C:\Users\garre\Documents\MSSA\Class Examples\ClassExercises\lyrics.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

        }


        public static void ReadTextLineByLine()
        {

            string line;
            StreamReader file = new StreamReader(@"C:\Users\garre\Documents\MSSA\Class Examples\ClassExercises\lyrics.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            file.Close();

        }

        static void Main(string[] args)
        {
            try
            {
                ReadTextAtOnce();
                ReadTextLineByLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
