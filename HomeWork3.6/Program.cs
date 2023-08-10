using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("factorial calculating");
        A: Console.Write("Enter the natural number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine($"The factorial of {num} is defined to be 1.");
            else if (num > 0)
            {
                int factorial = 1;
                int counter = 1;

                while (counter <= num)
                {
                    factorial *= counter;
                    counter++;
                }

                Console.WriteLine($"The factorial of {num}  is:  {factorial}.");
            }
            else goto A;


        }
    }
}
