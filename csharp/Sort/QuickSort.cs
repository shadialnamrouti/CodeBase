using System;

namespace Codebase
{
    public static partial class Sort
    {

        public static void QuickSort<T>(this T[] a, bool verbose = false) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(QuickSort));
                a.Print();
            }

            QuickSort(a, 0, a.Length - 1, verbose);

            if (verbose)
            {
                Console.WriteLine(nameof(QuickSort));
                a.Print();
            }

        }

        public static void QuickSort<T>(this T[] a, int start, int end, bool verbose = false) where T : struct
        {

            if (start < end)
            {
                int pivot = Partition(a, start, end, verbose);

                if (pivot > 1)
                {
                    QuickSort(a, start, pivot - 1, verbose);
                }
                if (pivot + 1 < end)
                {
                    QuickSort(a, pivot + 1, end, verbose);
                }
            }

        }

        private static int Partition<T>(T[] a, int start, int end, bool verbose = false) where T : struct
        {
            T pivot = a[start];
            while (true)
            {

                while ((dynamic)a[start] < pivot)
                {
                    start++;
                }

                while ((dynamic)a[end] > pivot)
                {
                    end--;
                }

                if (start < end)
                {
                    Common.Swap(ref a[start], ref a[end]);

                    if (verbose) a.Print();

                    if ((dynamic)a[start] == a[end])
                        start++;


                }
                else
                {
                    return end;
                }
            }
        }
    }
}
