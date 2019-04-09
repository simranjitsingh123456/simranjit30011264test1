/*
 Name = Simranjit Singh
 Student ID = 30011264
 Question = 2
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // information about main message 
            Console.WriteLine("\n\t------------------------------------------------------------------------------- ");
            Console.WriteLine("\n\t------------This program will give the sum total of 5 prices------------------- ");

            Console.WriteLine("\n\t------------------------------------------------------------------------------- ");

            Console.WriteLine("Enter the price of item 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of item 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of item 3:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of item 4:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of item 5:");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine($" {num1}+{num2}+{num3}+{num4}+{num5} = The total of those items is  ${num1 + num2 + num3 + num4 + num5 }");


        }
    }
}
