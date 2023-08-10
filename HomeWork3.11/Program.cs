using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {

        A: Console.Write("Enter the number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Division by zero is not a valid mathematical operation!");
            else if (n < 0)
                goto A;
            else
            {
                double result = 0;
                for (int i = 1; i <= n; i++)
                {
                    double fraction = 1.0 / i;
                    result += fraction;
                }
                Console.WriteLine($"The sum of the fraction 1/n for n = {n} is: {result}");
            }

        }
    }
}




