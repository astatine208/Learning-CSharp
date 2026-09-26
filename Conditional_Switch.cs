using System;

namespace Practices
{
    class ConditionalSwitch
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * EVEN OR ODD NUMBER CHECKER
             * ==========================================
             * two different switch case approaches.
             */

            // Prompt user for input
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Approach 1: Using pattern matching with a new variable 'n'
            switch(num)
            {
                case int n when n % 2 == 0:
                    Console.WriteLine($"Even");
                    break;
                case int n when n % 2 != 0:
                    Console.WriteLine($"Odd");
                    break;
                default:
                    Console.WriteLine($"Out of range");
                    break;
            }

            // Approach 2: Standard switch 
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;
                case 1:
                case -1: // Captures negative odd numbers
                    Console.WriteLine("Odd");
                    break;
            }


            // Console.ReadKey(): Pauses program so terminal stays open.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}