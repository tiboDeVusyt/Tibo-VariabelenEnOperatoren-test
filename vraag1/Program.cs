using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool leave = false;
            string word = "word";
            char letter = 'T';
            double  number1 = 12.5;
            decimal number2 = 10.2m;
            int     number3 = 8;
            byte    number4 = 6;
            float   number5 = 4.50f;
            short   number6 = 2;
            sbyte   number7 = 6;
            string input;
            do
            {
                Console.WriteLine("string = " + word);
                Console.WriteLine($"char = {letter}");
                Console.WriteLine($"double = {number1}");
                Console.WriteLine($"decimal = {number2}");
                Console.WriteLine($"int = {number3}");
                Console.WriteLine($"byte = {number4}");
                Console.WriteLine($"float = {number5}");
                Console.WriteLine($"short = {number6}");
                Console.WriteLine($"sbyte = {number7}");

                Console.WriteLine("do you want to leave y/n");
                input = Console.ReadLine();
                if (input != "y")
                {
                    leave = true;
                }
            } while (leave);









        }
    }
}
