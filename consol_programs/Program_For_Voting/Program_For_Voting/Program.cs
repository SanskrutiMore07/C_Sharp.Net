using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_For_Voting
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;
            Console.WriteLine("Enter Age of member :");
            no = Convert.ToInt32(Console.ReadLine());
            if(no>=18)
            {
                Console.WriteLine("Is eligible for voting");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not eiligible for voting ");
                Console.ReadLine();
            }
                 
        }
    }
}
