using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacci Series");

            for(int i = 1; i<=10;i++)
            {
                Console.Write(a + "");
                Console.ReadLine();
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
