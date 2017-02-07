using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please write second number");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("The number 2 is incorect number");
            }

            else if (num1 % num2 == 0)
               {
                    Console.WriteLine("The number 1 is divisible by the number 2");
               }
            else
               {
                    Console.WriteLine("The number 1 is not divisible by the number 2");
               }

            Console.ReadLine();
        }

    }
}
