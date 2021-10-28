using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int totHour = 0;
            int totMinuts = 0;
            Console.WriteLine("how many seconds do you want to convert");
            int totSeconds = int.Parse(Console.ReadLine());

            if (totSeconds>=60)
            {
                 totMinuts = totSeconds / 60;
                totSeconds = totSeconds % 60;

                if (totMinuts>=60)
                {
                    totHour = totMinuts / 60;
                    totMinuts = totMinuts % 60;
                }
            }
            Console.WriteLine($"the tot is {totHour}hours {totMinuts}minuts and {totSeconds}seconds");

            
            
        }
    }
}
