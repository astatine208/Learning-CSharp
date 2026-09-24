using System;

namespace Problem
{
    class CircleArea
    {
        public static void Main(string[] args)
        {
            /*
             * ==========================================
             * AREA OF A CIRCLE
             * ==========================================
             * Formula: Area = PI * radius * radius
             */

            Console.Write("Enter radius of the circle (r): ");
            double r = double.Parse(Console.ReadLine());

            double ans = Math.PI * r * r; 
            // another way : Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"\nArea of the circle: PI * {r}^2 = {ans.ToString("F2")}");
        }
    }
}