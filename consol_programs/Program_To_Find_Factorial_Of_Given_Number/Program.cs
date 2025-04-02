using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Services;

namespace Program_To_Find_Factorial_Of_Given_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter any Number :");
            number = Convert.ToInt32(Console.ReadLine());
            for(i = 1;i<=number;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Of " +  number  + " is: " + fact);
            Console.ReadLine();
        }
    }
}
