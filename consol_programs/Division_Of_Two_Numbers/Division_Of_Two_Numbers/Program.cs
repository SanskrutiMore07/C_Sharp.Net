using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Result;
            Console.WriteLine("Enter First Number:");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Result = Num1/Num2;
            Console.WriteLine("{0}/{1}={2}", Num1, Num2, Result);

            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
