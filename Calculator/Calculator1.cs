using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator1
    {
        public static int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
                throw new System.Exception("Zero input provided");
            return a + b;
        }

        public static int Dif(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static double Div(int a, int b)
        {
            return a*1.0 / b;
        }
    }
}
