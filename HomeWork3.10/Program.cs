using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number A: ");
            double  a=Convert.ToDouble(Console.ReadLine());
            A: Console.Write("Enter the number N: ");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n < 1)
                goto A;
            else
            {
                double result = 1;
                double finalResult = 0;
                for (int i = 1; i <= n; i++)
                {
                    result *= a;
                    finalResult += result;
                }
                Console.WriteLine($"The sum of powers of {a} from 1 to {n} is: {finalResult}");

            }

        }
     

    }
}
