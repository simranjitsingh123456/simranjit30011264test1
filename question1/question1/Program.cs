/*
 Name = Simranjit Singh
 Student ID = 30011264
 Question = 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // information message
            Console.WriteLine("\n\t------------------------------------------------------------------------------- ");
            Console.WriteLine(" \n\t--------------This program can give the result of base^exponent----------------");
            Console.WriteLine("\n\t------------------------------------------------------------------------------- ");

            Console.WriteLine(" Enter the value of the base :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter the value of the exponent :");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}^{num2} = {num1 ^ num2}");
            

        }
        
    }
}
