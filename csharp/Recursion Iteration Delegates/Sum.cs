using System;

namespace Codebase
{
    public static partial class Recursion
    {
        delegate int SumDelegate(int start, int end, int step);

        public static int Sum(int start, int end, int step, bool isRecursive = true)
        {
            SumDelegate sumDelegate;

            if (isRecursive)
                sumDelegate = new SumDelegate(SumRecursive);
            else
                sumDelegate = new SumDelegate(SumIterative);

            return sumDelegate(start, end, step);
        }

        //Recursive
        public static int SumRecursive(int start, int end, int step) 
        {
            if (start<=end)
                return start + SumRecursive(start + step, end, step);
            else
                return 0;
        }

        //Iterative
        public static int SumIterative(int start, int end, int step)
        {
            int Sum = 0;

            for (int i = start; i <= end; i += step)
                Sum += i;

            return Sum;
        }
        
    }
}
