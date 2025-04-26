using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE_CALC
{
     internal class Program
    {
        delegate int Calc(int a, int b);
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            Calc add = Add;
            Calc subtract = Sub;
            Calc multiply = Mul;
            int num1 = 10, num2 = 5;
            Console.WriteLine($"Add: {add(num1, num2)}");
            Console.WriteLine($"Subtract: {subtract(num1, num2)}");
            Console.WriteLine($"Multiply: {multiply(num1, num2)}");
        }
    }

}
