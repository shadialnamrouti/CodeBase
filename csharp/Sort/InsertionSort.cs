using System;

namespace Codebase
{
    public static partial class Sort
    {
        public static void InsertionSort<T>(this T[] a, bool verbose = false) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(InsertionSort));
                a.Print();
            }


            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i+1; j > 0; j--)
                {

                    if ((dynamic)a[j-1] > a[j])
                    {

                        Common.Swap(ref a[j-1], ref a[j]);

                        if (verbose)
                        {
                            a.Print();
                        }
                    }

                }

            }


        }
    }
}
