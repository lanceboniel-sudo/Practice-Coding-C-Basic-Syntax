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
            int grade;

            Console.Write("Enter your grade: ");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade <= 59)
            {
                Console.WriteLine("Your grade is: F");
            }
            else if (grade >= 60 || grade <= 69)
            {
                Console.WriteLine("Your grade is: D");
            }
            else if  (grade >= 70 || grade <= 79)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (grade >= 80 || grade <= 89)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (grade >= 90 || grade <= 100)
            {
                Console.WriteLine("Your grade is: A");
            }
            else
            {
                Console.WriteLine("Invalid grade entered.");
            }



        }
    }
}
