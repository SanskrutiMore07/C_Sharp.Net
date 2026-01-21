using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter Age : ");
            int Age = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine($"Hello {Name}! Your Age Is {Age}");
            Console.ReadLine();
        }
    }
}
