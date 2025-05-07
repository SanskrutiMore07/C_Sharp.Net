using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime_Number_Using_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a= 0;
            Console.Write("Enter any number :");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i =1;i<=n;i++)
            {
                if(n% i ==0)
                {
                    a++;
                }
            }
            if(a == 2)
            {
                Console.WriteLine("The given Number {0} is prime Number ", n);
            }
            else
            {
                Console.WriteLine("The given Number {0} is Not A Prime Number ", n);
            }
            Console.ReadLine();
        }
    }
}
