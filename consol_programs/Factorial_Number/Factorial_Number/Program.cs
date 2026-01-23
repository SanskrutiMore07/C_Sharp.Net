using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 5;
            int Fact = 1;

            for(int i = 1; i<=No;i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("Factorial Of Given Number "+ No +" is "+ Fact);
            Console.ReadLine();
        }
    }
}
