using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the exponent number: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            if (exponent == 0)
                Console.WriteLine($"{number} with an exponent of {exponent} = 1.");
            else if (exponent >= 1)
            {
                for (int i = 1; i <= exponent; i++)
                {
                    result *= number;
                }
                Console.WriteLine($"{number} with an exponent of {exponent} is {result}.");

            }
            else
            {
                int negativeExponent = exponent * (-1);
                for (int i = 1; i <= negativeExponent; i++)
                {
                    result *= number;
                }
                double negativeExponentResult = 1 / result;
                Console.WriteLine($"{number} with an exponent of ({exponent}) is {negativeExponentResult}.");

            }

        }
    }
}
