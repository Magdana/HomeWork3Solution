using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calcultating arithmetic Average of number");
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter the number: ");
                double numbers = Convert.ToDouble(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine($"the arithmetic average of these numbers is {sum / 5}");

        }
    }
}
