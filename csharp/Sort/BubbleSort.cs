using System;

namespace Codebase
{
    public static partial class Sort
    {

        public static void BubbleSort<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(BubbleSort));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Bubble_sort
            int n = a.Length;
            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 1; i <= n - 1; i++)
                {
                    /* if this pair is out of order */
                    if ((dynamic)a[i - 1] > a[i])
                    {

                        /* swap them and remember something changed */
                        Common.Swap(ref a[i - 1], ref a[i]);
                        swapped = true;

                        if (verbose) a.Print();
                    }

                }
            } while (swapped);

        }

        public static void BubbleSortV2<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(BubbleSortV2));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Bubble_sort
            int n = a.Length;
            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 1; i <= n - 1; i++)
                {
                    /* if this pair is out of order */
                    if ((dynamic)a[i - 1] > a[i])
                    {

                        /* swap them and remember something changed */
                        Common.Swap(ref a[i - 1], ref a[i]);
                        swapped = true;

                        if (verbose) a.Print();
                    }
                }
                n--;
            } while (swapped);

        }

        public static void BubbleSortV3<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(BubbleSortV3));
                a.Print();
            }
            //Based on https://en.wikipedia.org/wiki/Bubble_sort
            int n = a.Length;
            do
            {
                int newn = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    /* if this pair is out of order */
                    if ((dynamic)a[i - 1] > a[i])
                    {
                        /* swap them and remember something changed */
                        Common.Swap(ref a[i - 1], ref a[i]);
                        newn = i;

                        if (verbose) a.Print();
                    }
                }
                n = newn;
            } while (n > 1);
        }
    }
}
