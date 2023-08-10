using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number A: ");
            double a = Convert.ToInt32(Console.ReadLine());
            A: Console.Write("Enter the number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <=0)
                goto A;
            else
            {
                double result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= a;
                    Console.WriteLine(result);
                }
            }
            
        }
    }

}
