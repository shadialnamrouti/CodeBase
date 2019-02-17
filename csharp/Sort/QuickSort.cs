using System;

namespace Codebase
{
    public static partial class Sort
    {

        public static void QuickSort<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(QuickSort));
                a.Print();
            }

            QuickSort(a, 0, a.Length - 1, verbose);
        }

        //Based on https://en.wikipedia.org/wiki/Quicksort
        public static void QuickSort<T>(this T[] a, int lo, int hi, bool verbose = true) where T : struct
        {

            if (lo < hi)
            {
                int pivot = Partition(a, lo, hi, verbose);

                QuickSort(a, lo, pivot - 1, verbose);
                QuickSort(a, pivot + 1, hi, verbose);
                
            }

        }

        //Based on https://en.wikipedia.org/wiki/Quicksort
        private static int Partition<T>(T[] a, int lo, int hi, bool verbose = true) where T : struct
        {
            T pivot = a[hi];
            int i = lo;

            for (int j = lo; j <= hi - 1; j++)
                if ((dynamic)a[j] < pivot)
                {
                    Common.Swap(ref a[i], ref a[j]);
                    if (verbose) a.Print();

                    i++;
                }

            Common.Swap(ref a[i], ref a[hi]);
            if (verbose) a.Print();

            return i;
        }
    }
}
