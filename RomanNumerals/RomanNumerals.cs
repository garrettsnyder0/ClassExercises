using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class RomanNumerals
    {

        //Write a method that takes a number and converts to roman numeral
        public static string ConvertRoman(int input)
        {
            string roman = "";

            while(input > 0)
            {
                if(input >= 1000)
                {
                    roman += 'M';
                    input -= 1000;
                }
                else if (input >= 900)
                {
                    roman += "CM";
                    input -= 900;
                }
                else if(input >= 500)
                {
                    roman += 'D';
                    input -= 500;
                }
                else if (input >= 400)
                {
                    roman += "CD";
                    input -= 400;
                }
                else if (input >= 100)
                {
                    roman += 'C';
                    input -= 100;
                }
                else if (input >= 90)
                {
                    roman += "XC";
                    input -= 90;
                }
                else if (input >= 50)
                {
                    roman += 'L';
                    input -= 50;
                }
                else if (input >= 40)
                {
                    roman += "XL";
                    input -= 40;
                }
                else if (input >= 10)
                {
                    roman += 'X';
                    input -= 10;
                }
                else if (input >= 9)
                {
                    roman += "IX";
                    input -= 9;
                }
                else if (input >= 5)
                {
                    roman += 'V';
                    input -= 5;
                }
                else if (input >= 4)
                {
                    roman += "IV";
                    input -= 4;
                }
                else 
                {
                    roman += 'I';
                    input -= 1;
                }
            }

            return roman;
        }



        static void Main(string[] args)
        {

            for(int i = 1; i < 11; i ++)
            {
                Console.WriteLine(ConvertRoman(i));
            }


            //Console.WriteLine(ConvertRoman(39));
            //Console.WriteLine(ConvertRoman(246));
            //Console.WriteLine(ConvertRoman(1066));
            //Console.WriteLine(ConvertRoman(1954));
            //Console.WriteLine(ConvertRoman(2014));
            Console.ReadKey();
        }
    }
}
