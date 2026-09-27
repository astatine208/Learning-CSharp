using System;

namespace Practices
{
    class Checkmax
    {
        public static int Maxi(int a,int b,int c) 
        {
            return Math.Max(a,Math.Max(b,c));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Maxi(12,456,22));
        }
    }
}