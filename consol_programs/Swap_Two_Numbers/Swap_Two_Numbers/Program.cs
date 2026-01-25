using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10, B = 20;

            A = A + B;
            B = A - B;
            A = A - B;

            Console.WriteLine("A = " + A);
            Console.ReadLine();
            Console.WriteLine("B = " + B);
            Console.ReadLine();

        }
    }
}
