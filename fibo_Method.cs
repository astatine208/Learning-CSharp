using System;

namespace Practices
{
    class CheckFibo
    {
        public static int Fibo(int n) 
        {
            if(n<=1)  return n;
            return Fibo(n-1)+Fibo(n-2);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Fibo(6));
        }
    }
}