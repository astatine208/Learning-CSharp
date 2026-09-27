using System;
using System.ComponentModel;

namespace Practice
{
    class Basic
    {
        /*
         * ==========================================
         * BASIC ADDITION
         * ==========================================
         * Takes two integer inputs and calculates 
         * their sum using a static method.
         */
         
        // Static method required to be called from Main
        
        public static void Add(int n, int m)
        {
            int sum = n + m;
            Console.WriteLine(sum);
        }
        
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            
            Add(n, m); 
        }
    }
}