using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal candy = 0;
            decimal betaling = 2m;
            decimal[] munten = new decimal[7] { 1.00m, 0.50m, 0.20m, 0.10m, 0.05m, 0.02m, 0.01m };
            int HVLMunten = 0;

            Console.WriteLine("what is the price of the candy");
            candy = decimal.Parse(Console.ReadLine());
            decimal tot = betaling - candy;
            for (int i = 0; tot > 0; i++)
            {
                if (tot>=munten[i])
                {
                   HVLMunten = decimal.ToInt32( tot / munten[i]);
                   Console.WriteLine($"{HVLMunten} munten van {munten[i]}");
                   tot -= munten[i] * HVLMunten;
                }
            }
            Console.WriteLine("this is what you get back");

        }
    }
}
