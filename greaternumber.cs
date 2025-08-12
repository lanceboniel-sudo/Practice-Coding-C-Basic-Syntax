using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Console.Write("Enter the first integer:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number is greater than the second number.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("The first number is less than the second number.");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

        }


    }
}
