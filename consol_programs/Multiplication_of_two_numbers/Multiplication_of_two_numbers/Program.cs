using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("Enter The Vlues Of a  : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Vlues Of b  : ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, sum);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
