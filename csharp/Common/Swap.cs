using System;

namespace Codebase
{
    public static partial class Common
    {
        public static void Swap<T>(ref T a, ref T b) where T: struct
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
