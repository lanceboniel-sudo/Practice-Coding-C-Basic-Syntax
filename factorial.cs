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
            int num, fact, count;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            fact = num;
            count = num - 1;

            while (count > 1)
            {
                fact *= count;
                count--;
            }

            Console.WriteLine($"The factorial of {num} is {fact}");
            Console.ReadLine();
        }
    }
}
