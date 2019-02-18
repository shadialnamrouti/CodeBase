using System;

namespace Codebase
{
    public static partial class Recursion
    {
        
        //Delegate: Defaulted to recursive version
        delegate int FactDelegate(int item);
        public static int Fact(int item, bool isRecursion = true)
        {
            FactDelegate factDelegate;

            if (isRecursion)
                factDelegate = new FactDelegate(FactRecursion);
            else
                factDelegate = new FactDelegate(FactIterative);

            return factDelegate(item);
        }

        //Recursive
        public static int FactRecursion(int item) 
        {
            if (item == 0 || item == 1)
                return 1;
            else
                return item * FactRecursion(item - 1);
        }

        //Iterative
        public static int FactIterative(int item)
        {
            int Fact = 1;

            for (int i = item; i >= 1; i--)
                Fact *= i;

            return Fact;
        }



    }
}
