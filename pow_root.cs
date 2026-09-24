using System;

namespace Practice
{
    class MathOperations
    {
        public static void Main(string[] args)
        {
            /*
             * Math.Pow(base, exponent) -> calculates power
             * Math.Sqrt(number) -> calculates square root
             */

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Power of {x}, {y} : {Math.Pow(x, y)}");
            Console.WriteLine($"Root of {x} : {Math.Sqrt(x)}");
        }
    }
}