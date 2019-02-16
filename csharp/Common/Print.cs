using System;

namespace Codebase
{
    public static partial class Common
    {
        public static void Print<T>(this T[] array, string delimiter=" ") 
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + delimiter);

            Console.WriteLine();
        }

        public static void Print<T>(this T item, string delimiter="\n")
        {
            Console.Write(item + delimiter);
        }

    }
}
