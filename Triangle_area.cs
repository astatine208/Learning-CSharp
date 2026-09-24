using System;

namespace Problem
{
    class TriangleArea
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * AREA OF A TRIANGLE
             * ==========================================
             * Formula: Area = 0.5 * base * height
             */

            Console.Write("Enter base of the triangle (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter height of the triangle (h): ");
            double h = double.Parse(Console.ReadLine());

            double ans = 0.5 * a * h;
            Console.WriteLine($"\nArea of the triangle: 0.5 * {a} * {h} = {ans}");
        }
    }
}