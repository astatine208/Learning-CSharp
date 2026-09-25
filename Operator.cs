using System;

namespace Practice
{
    class AllOperators
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * ALL TYPES OF OPERATORS IN C#
             * ==========================================
             */

            // --- 1. Arithmetic Operators (For mathematical) ---
            Console.WriteLine("--- 1. Arithmetic Operators ---");
            int a = 10, b = 3;
            Console.WriteLine($"Addition (+)\t: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction (-)\t: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication (*): {a} * {b} = {a * b}");
            Console.WriteLine($"Division (/)\t: {a} / {b} = {a / b}");
            Console.WriteLine($"Modulus (%)\t: {a} % {b} = {a % b} (Remainder)");

            // --- 2. Assignment Operators (for set value) ---
            Console.WriteLine("\n--- 2. Assignment Operators ---");
            int x = 5; // Simple assignment (=)
            Console.WriteLine($"Initial x = {x}");
            x += 3;    // Same as: x = x + 3
            Console.WriteLine($"After x += 3\t: {x}");
            x -= 2;    // Same as: x = x - 2
            Console.WriteLine($"After x -= 2\t: {x}");
            x *= 2;    // Same as: x = x * 2
            Console.WriteLine($"After x *= 2\t: {x}");

            // --- 3. Relational / Comparison Operators (for compare) ---
            Console.WriteLine("\n--- 3. Relational Operators ---");
            Console.WriteLine($"Is {a} == {b}? \t: {a == b}");
            Console.WriteLine($"Is {a} != {b}? \t: {a != b}");
            Console.WriteLine($"Is {a} > {b}? \t: {a > b}");
            Console.WriteLine($"Is {a} <= {b}? \t: {a <= b}");

            // --- 4. Logical Operators
            Console.WriteLine("\n--- 4. Logical Operators ---");
            bool isTrue = true, isFalse = false;
            Console.WriteLine($"AND (&&) -> true && false \t: {isTrue && isFalse}");
            Console.WriteLine($"OR (||)  -> true || false \t: {isTrue || isFalse}");
            Console.WriteLine($"NOT (!)  -> !true \t\t: {!isTrue}");

            // --- 5. Unary Operators (increasing or decreasing value) ---
            Console.WriteLine("\n--- 5. Unary Operators ---");
            int count = 10;
            Console.WriteLine($"Original count: {count}");
            Console.WriteLine($"Post-increment (count++): {count++} (Prints first, then adds 1)");
            Console.WriteLine($"Now count is: {count}");
            Console.WriteLine($"Pre-increment (++count): {++count} (Adds 1 first, then prints)");

            // --- 6. Ternary / Conditional Operator (shortcut:If-Else) ---
            Console.WriteLine("\n--- 6. Ternary Operator (?:) ---");
            // Syntax: condition ? if_true : if_false
            string result = (a > b) ? "a is greater" : "b is greater";
            Console.WriteLine($"Ternary Result (a={a}, b={b}): {result}");
        }
    }
}