using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLib;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.Plus(10, 5));
            Console.WriteLine(Class1.Minus(5, 8));
            Console.WriteLine(Class1.Divide(42, 10));
            Console.WriteLine(Class1.Multiply(3, 4));
            Console.ReadLine();
        }
    }
}
