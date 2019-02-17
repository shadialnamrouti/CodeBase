using System;

namespace Codebase
{
    public static partial class Sort
    {
        public static void SelectionSort<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(SelectionSort));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Selection_sort
            /* a[0] to a[n-1] is the array to sort */

            int n = a.Length; // initialise to a's length

            /* advance the position through the entire array */
            /*   (could do j < n-1 because single element is also min element) */
            for (int j = 0; j < n - 1; j++)
            {
                /* find the min element in the unsorted a[j .. n-1] */

                /* assume the min is the first element */
                int iMin = j;
                /* test against elements after j to find the smallest */
                for (int i = j + 1; i < n; i++)
                {
                    /* if this element is less, then it is the new minimum */
                    if ((dynamic)a[i] < a[iMin])
                    {
                        /* found new minimum; remember its index */
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    Common.Swap(ref a[j], ref a[iMin]);
                    if (verbose) a.Print();
                }
            }
        }


        public static void BingoSort<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(BingoSort));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Selection_sort
            //This procedure sorts in ascending order.
            int max = a.Length - 1;
            //The first iteration is written to look very similar to the subsequent ones, but  without swaps. 
            T nextValue = a[max];

            for (int i = max - 1; i >= 0; i--)
                if ((dynamic)a[i] > nextValue)
                    nextValue = a[i];

            while (max > 0 && (dynamic)a[max] == nextValue)
                max--;

            while (max > 0)
            {
                T value = nextValue;
                nextValue = a[max];

                for (int i = max - 1; i >= 0; i--)
                    if ((dynamic)a[i] == value)
                    {
                        Common.Swap(ref a[i], ref a[max]);
                        if (verbose) a.Print();

                        max--;

                    }
                    else if ((dynamic)a[i] > nextValue)
                        nextValue = a[i];


                while (max > 0 && (dynamic)a[max] == nextValue)
                    max--;
            }
        }
    }
}