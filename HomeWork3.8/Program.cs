using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A: Console.Write("Enter the number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number >= 1)
            {

                int square = 1;
                int cube = 1;
                for (int i = 1; i <= number; i++)
                {
                    square = i * i;
                    cube = square * i;
                    Console.WriteLine($"Square of {i} = {square}");
                    Console.WriteLine($"Cube of {i} = {cube}");
                }
            }
            else goto A;
            
             
           
        }
    }
}
