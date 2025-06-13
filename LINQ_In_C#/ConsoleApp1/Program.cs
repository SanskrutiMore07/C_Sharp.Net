using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Age = { 12, 23, 45, 67, 80, 54, 14, 17, 20 };
            var a = from i in Age where i >= 20 select i;

            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
