using System;

namespace Practice
{
    class Second
    {
        public static void Main(string[] args)
        {
            // 1. Multiple Variable Assignment
            int number1, number2, number3;
            number1 = number2 = number3 = 20;
            
            // String Interpolation ($"{}") is a simple way
            // to print multiple variables in one Console.WriteLine() statement.
            Console.WriteLine($"Numbers: {number1} {number2} {number3}");
        
            // 2. Variable Reassignment
            string uni = "GZU";
            uni = "UU";
            Console.WriteLine($"University: {uni}\n");


            /* 
             *                             TYPE CASTING
             * 1. Implicit / Automatic Conversion (No manual casting is required):
             *    char -> int -> long -> float -> double (small to large) 
             * 
             * 2. Explicit / Manual Conversion:
             *    double -> float -> long -> int -> char (large to small)
             */

            // 3. Explicit Type Casting (Manual)
            double salary = 4231.34;
            Console.WriteLine($"Original Double Salary: {salary}");
            int salary2 = (int)salary; // Fractional part is lost
            Console.WriteLine($"Casted Int Salary: {salary2}\n");

            // 4. Implicit Type Casting (Automatic)
            int price = 2341;
            Console.WriteLine($"Original Int Price: {price}");
            double price2 = price; // Automatically converted
            Console.WriteLine($"Implicit Double Price: {price2}\n");

            // 5. Built-in Function for Conversion
            int sal = 1238;
            Console.WriteLine($"String format: {Convert.ToString(sal)}");
            Console.WriteLine($"Double format: {Convert.ToDouble(sal)}");
            Console.WriteLine($"Char format: {Convert.ToChar(sal)}\n"); 
            // Note: 1238 might print a special unicode character

            // 6. Parse() Method
            // Parse() is used to convert a string into another data type (like int, double, float).
            string num = "12312.32";
            double num2 = double.Parse(num);
            Console.WriteLine($"Parsed Number: {num2}");
        }
    }
}