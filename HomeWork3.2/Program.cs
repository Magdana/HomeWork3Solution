using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 100; i <= 999; i++)
                sum += i;
            Console.WriteLine($"kvela samnishna ricxvis jami aris {sum}");

            int start = 100;
            int total = 0;
            while (start <= 999)
            {
                total += start;
                start++;
            }
            Console.WriteLine($"kvela samnishna ricxvis jami aris {total}");
            start = 100;
            total = 0;
            do
            {
                total += start;
                start++;
            }
            while (start <= 999);
            Console.WriteLine($"kvela samnishna ricxvis jami aris {total}");
        }


    }
}



