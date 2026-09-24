using System;

namespace Practice
{
    class SwitchStatement
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * SWITCH STATEMENT IN C#
             * ==========================================
             * The switch statement selects one of many code blocks to be executed.
             * 
             * Key Keywords:
             * - switch : Evaluates a variable .
             * - case   : Compares the result with a specific value.
             * - break  : Stops the execution and exits the switch block.
             * - default: Runs if there is no case match (similar to 'else').
             */

            Console.Write("Enter a number for a day of the week (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}