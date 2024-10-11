using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_To_Check_Student_Is_Pass_Or_Fail
{
    class Program
    {
        static void Main(string[] args)
        {
            int No;
            Console.WriteLine("Enter Persentage Of Student:");
            No = Convert.ToInt32(Console.ReadLine());

            if (No >= 80)
            {
                Console.WriteLine("Pass with destination");
                Console.ReadLine();
            }
            else if (No >= 60 && No < 80)
            {
                Console.WriteLine("Pass with 1st class");
                Console.ReadLine();
            }
            else if (No >= 40 && No < 60)
            {
                Console.WriteLine("Pass with 2nd class");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Fail");
                Console.ReadLine();
            }

        }
    }
}
