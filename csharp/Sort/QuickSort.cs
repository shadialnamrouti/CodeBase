using System;

namespace Codebase
{
    public static partial class Sort
    {

        //Based on https://en.wikipedia.org/wiki/Quicksort
        //Used lomuto partition scheme (see Wikipedia)
        public static void QuickSort<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(QuickSort));
                a.Print();
            }

            QuickSort(a, 0, a.Length - 1, verbose);
        }

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


        //Based on https://en.wikipedia.org/wiki/Quicksort
        //Used Hoare partition scheme (see Wikipedia)
        public static void QuickSortV2<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(QuickSortV2));
                a.Print();
            }

            QuickSortV2(a, 0, a.Length - 1, verbose);
        }

        public static void QuickSortV2<T>(this T[] a, int lo, int hi, bool verbose = true) where T : struct
        {

            if (lo < hi)
            {
                int pivot = PartitionV2(a, lo, hi, verbose);

                QuickSortV2(a, lo, pivot, verbose);
                QuickSortV2(a, pivot + 1, hi, verbose);

            }

        }

        //Based on https://en.wikipedia.org/wiki/Quicksort
        private static int PartitionV2<T>(T[] a, int lo, int hi, bool verbose = true) where T : struct
        {
            T pivot = a[(lo + hi) / 2];

            int i = lo - 1;
            int j = hi + 1;

            while (true)
            {
                do
                {
                    i++;
                } while ((dynamic)a[i] < pivot);

                do
                {
                    j--;
                } while ((dynamic)a[j] > pivot);

                if (i >= j)
                    return j;

                Common.Swap(ref a[i], ref a[j]);
                if (verbose) a.Print();
            }

        }
    }
}
