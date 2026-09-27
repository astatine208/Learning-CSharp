using System;

namespace Practices
{
    class PbRef
    {
        public static void Incr(ref int n) 
        {
            n+=10;
        }

        public static void Main(string[] args)
        {
            int n=20;
            Incr(ref n);
            //public static void Incr(ref int n) 
            //`void` means the method **does not return any value. 
            //Therefore, you cannot use it directly inside `Console.WriteLine()`.
            //Console.WriteLine(Incr(ref n)); it will not work.
            Console.WriteLine(n);
        }
    }
}