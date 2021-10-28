using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] punten = new int[4] { 8, 6, 9, 4 };
            int sum = 0;
            int gem = 0;
            for (int i = 0; i < punten.Length; i++)
            {
                sum += punten[i];
            }
            gem = sum / punten.Length;
            Console.WriteLine($"uw gem is ({gem}/10)");


        }
    }
}
