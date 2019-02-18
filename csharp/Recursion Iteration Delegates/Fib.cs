using System;

namespace Codebase
{
    public static partial class Recursion
    {
        delegate int FibDelegate(int n);

        public static int Fib(int n, bool isRecursive = true)
        {
            FibDelegate fibDelegate;

            if (isRecursive)
                fibDelegate = new FibDelegate(FibRecursive);
            else
                fibDelegate = new FibDelegate(FibIterative);

            return fibDelegate(n);
        }

        //Recursive
        public static int FibRecursive(int n)
        {
            if (n < 2)
                return n;
            else
                return FibRecursive(n - 2) + FibRecursive(n - 1);
        }

        //Iterative
        public static int FibIterative(int n)
        {
            if (n < 2)
                return n;

            int fibN_2 = 0;
            int fibN_1 = 1;
            
            int fibN = 0;
            for (int i = 2; i <= n; i++)
            {
                fibN = fibN_2 + fibN_1;

                //Shifting fibN_2 and fibN_1 for next iteration
                fibN_2 = fibN_1;
                fibN_1 = fibN;
            }

            return fibN;
        }
    }
}
