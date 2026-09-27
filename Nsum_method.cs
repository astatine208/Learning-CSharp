using System;
using System.Numerics;

namespace Practices
{
    class Sum
    {
        public static int Nsum(int n) 
        {
            int total=0;
            for(int i=1;i<=n;i++)
            {
                total+=i;
            }
            return total;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Nsum(10));
        }
    }
}