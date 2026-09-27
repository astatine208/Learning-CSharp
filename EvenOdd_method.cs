using System;

namespace Practices
{
    class CheckEvOdd
    {
        public static void Evenodd(int n) 
        {
            if(n%2==0)  Console.WriteLine("Even");
            else    Console.WriteLine("Odd");
        }

        public static void Main(string[] args)
        {
            Evenodd(10);
            Evenodd(13);
        }
    }
}