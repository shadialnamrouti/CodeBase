using System;

namespace Codebase
{
    public static partial class Sort
    {
        public static void SelectionSort<T>(this T[] a, bool verbose = false) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(SelectionSort));
                a.Print();
            }


            for (int i = 0; i < a.Length - 1; i++)
            {
                int smallest = i;

                for (int j = i + 1; j < a.Length; j++)
                {

                    if ((dynamic)a[smallest] > a[j])
                    {

                        Common.Swap(ref a[smallest], ref a[j]);

                        if (verbose) a.Print();

                    }

                }

            }


        }
    }
}
