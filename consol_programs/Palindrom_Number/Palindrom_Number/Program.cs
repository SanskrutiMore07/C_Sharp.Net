using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 121, Temp = No , Rev = 0;

            while (No > 0)
            {
                Rev = Rev * 10 + No % 10;
                No /= 10;
            }
            if(Temp == Rev)
            {
                Console.WriteLine("Given Number Is palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Given Number Is Not palindrome");
                Console.ReadLine();
            }
        }
    }
}
