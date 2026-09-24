using System;

namespace Practice
{
    class CaseConversion
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * STRING CASE CONVERSION
             * ==========================================
             * ToUpper() -> Converts all characters in a string to uppercase.
             * ToLower() -> Converts all characters in a string to lowercase.
             */

            Console.Write("Enter a word or sentence: ");
            string text = Console.ReadLine();

            // Lowercase to Uppercase
            string uppercaseText = text.ToUpper();
            
            // Uppercase to Lowercase
            string lowercaseText = text.ToLower();

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Original \t: {text}");
            Console.WriteLine($"Uppercase \t: {uppercaseText}");
            Console.WriteLine($"Lowercase \t: {lowercaseText}");
        }
    }
}