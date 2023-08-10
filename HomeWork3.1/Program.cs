using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A: Console.Write("Enter the number N1: ");
            int N1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number N2: ");
            int N2=Convert.ToInt32(Console.ReadLine());
            if (N1 < N2)
            {
                int sum = 0;
                long mult = 1;
                for (int i = N1; i < N2; i++)
                {
                    sum += i;
                    mult *= i;
                }
                Console.WriteLine($"the sum of these number is {sum} and the mult is {mult}");

            }
            else 
            {
                Console.WriteLine("N1 must not be greater then N2!"); 
                goto A;
            }
            
        }
    }
}
