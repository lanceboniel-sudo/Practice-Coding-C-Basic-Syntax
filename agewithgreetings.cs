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
            string name;

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            switch (age >= 18)
            {
                case true:
                    {
                        Console.WriteLine("You are an adult.");
                    }
                    break;
                case false:
                    {
                       Console.WriteLine("You are a minor.");
                    }
                    break;


            }
        }
    }
}
