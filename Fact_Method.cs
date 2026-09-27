using System;

namespace Practices
{
    class CheckFact
    {
        public static int Fact(int n) 
        {
            if(n==0)  return 1;
            return n*Fact(n-1);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Fact(6));
        }
    }
}