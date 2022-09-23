using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculatorconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum;
            Console.WriteLine("enter 1st no:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd no:");
            b = int.Parse(Console.ReadLine());

            sum = Calculator.Calculator1.Sum(a,b);
            Console.WriteLine($"sum of {a} and {b} is {sum}");

        }

        
    }

    
}
