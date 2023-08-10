using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float mult = 1;
            for (float i = 1.1F; i<=2.0; i += 0.1F)
            {
                mult *= i;
            }
            Console.WriteLine($"namravli aris {mult}");

        }
    }
}
