using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 12345, rev = 0;

            while(No>0)
            {
                rev = rev * 10 + No % 10;
                No /= 10;
            }

            Console.WriteLine("Revers No :" + rev);
            Console.ReadLine();
        }
    }
}
