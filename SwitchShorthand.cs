using System;

namespace Practice
{
    class SwitchShorthand
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * SWITCH EXPRESSION (SHORTHAND) IN C#
             * ==========================================
             * Introduced in C# 8.0. It is a shorter and cleaner way 
             * to write a switch statement when returning a value.
             * 
             * Syntax changes:
             * - No 'case' or 'break' keywords. Uses '=>' (lambda arrow).
             * - Variables come BEFORE the 'switch' keyword.
             * - The '_' (discard) pattern acts like 'default'.
             */

            Console.Write("Enter a number : ");
            int day=int.Parse(Console.ReadLine());

            string name = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Invalid! " 
            };

            Console.WriteLine($"\nResult: {name}");
        }
    }
}