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

            //Based on https://en.wikipedia.org/wiki/Insertion_sort
            for (int i = 1; i < a.Length; i++)
                for (int j = i; j > 0 && (dynamic)a[j - 1] > a[j]; j--)
                {
                    Common.Swap(ref a[j], ref a[j - 1]);
                    if (verbose) a.Print();
                }
        }

        public static void InsertionSortV2<T>(this T[] a, bool verbose = false) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(InsertionSortV2));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Insertion_sort
            for (int i = 1; i < a.Length; i++)
            {
                T temp = a[i];
                int j = i - 1;
                for (; j >= 0 && (dynamic)a[j] > temp; j--)
                {
                    a[j + 1] = a[j];
                }

                a[j + 1] = temp;
                if (verbose) a.Print();
            }
        }

        public static void InsertionSortV3<T>(this T[] a, bool verbose = false) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(InsertionSortV3));
                a.Print();
            }

            InsertionSortV3Recursive(a, a.Length - 1, verbose);
        }

        private static void InsertionSortV3Recursive<T>(T[] a, int n, bool verbose) where T : struct
        {
            //Based on https://en.wikipedia.org/wiki/Insertion_sort
            if (n > 0)
                InsertionSortV3Recursive(a, n - 1, verbose);

            T temp = a[n];
            int j = n - 1;
            for (; j >= 0 && (dynamic)a[j] > temp; j--)
            {
                a[j + 1] = a[j];
            }

            a[j + 1] = temp;
            if (verbose) a.Print();
        }

    }
}
