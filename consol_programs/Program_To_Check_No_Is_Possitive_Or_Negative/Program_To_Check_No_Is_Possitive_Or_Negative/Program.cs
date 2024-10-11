using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_To_Check_No_Is_Possitive_Or_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 0;
            Console.WriteLine("Enter any number");
            No = Convert.ToInt32(Console.ReadLine());
            if(No>=0)
            {
                Console.WriteLine("Given number is possitive");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Given number is negative");
                Console.ReadLine();
            }
        }
    }
}
