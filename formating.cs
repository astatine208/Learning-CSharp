using System;

namespace Practice
{
    class Formatting
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Name: {name}\n");

            int x = 20, y = 3;
            // Type Casting
            double div = (double)x / y;

            /*
             * String Interpolation -> ($"{variable}")
             * Floating Point Formatting -> variable.ToString("Fn") 
             * Here n = 1, 2, 3... (number of digits after the decimal point)
             */
            
            Console.WriteLine($"{x} / {y} = {div.ToString("F2")}");
        }
    }
}