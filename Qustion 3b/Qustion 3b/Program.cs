/*
 Name = simranjit Singh
 Student ID = 30011264 
 Question = 3b
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qustion_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // information about main message 
            Console.WriteLine("\n\t------------------------------------------------------------------------------- ");
            Console.WriteLine("-----------\n\tCan you solve the following algebraic experession : -----------------");
            Console.WriteLine("-----------------------------\n\t2(x-3) + x = 12 ------------------------------------");
            Console.WriteLine("\n\t------------------------------------------------------------------------------- ");
            int correct;
            Console.WriteLine("Enter your guess at the value of x :");
            correct = int.Parse(Console.ReadLine());
            if (correct == 6)
            {
                Console.WriteLine(" wooo your guess is correct");
            }
            else
            {
                Console.WriteLine(" Sorrry that guess is incorrect");
            }

            Console.ReadLine();

        }
    }
}
