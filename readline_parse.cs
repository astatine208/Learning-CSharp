using System;

namespace Practice
{
    class UserInput
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * USER INPUT IN C#
             * ==========================================
             * Console.ReadLine() always reads data as a string.
             * To take an integer input, we must convert it using int.Parse() or Convert.ToInt32().
             */

            int a, b;

            // Taking input for 'a'
            Console.Write("Enter the first number (a): ");
            a = int.Parse(Console.ReadLine()); //Convert String to Integer

            // Taking input for 'b'
            Console.Write("Enter the second number (b): ");
            b = int.Parse(Console.ReadLine()); 

            int ans = a + b;
            Console.WriteLine($"\nResult: {a} + {b} = {ans}");
        }
    }
}