using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger mult = 1;
            for (int i = 10; i <= 99; i++)
            {
                mult *= i;
            }
            Console.WriteLine($"kvela ornishna ricxvis namravli aris {mult}");
        }

    }
}
