using System;

namespace Codebase
{
    public static partial class Sort
    {

        public static void CombSort<T>(this T[] a, bool verbose = false) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(CombSort));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Comb_sort
            double gap = a.Length; // Initialize gap size
            double shrink = 1.3; // Set the gap shrink factor
            bool sorted = false;

            while (!sorted)
            {
                // Update the gap value for a next comb
                gap = Math.Floor(gap / shrink);
                if (gap <= 1)
                {
                    gap = 1;
                    sorted = true; // If there are no swaps this pass, we are done
                }

                // A single "comb" over the input list
                int i = 0;

                while (i + gap < a.Length)
                {

                    while (i + gap < a.Length) // See Shell sort for a similar idea
                    {
                        if ((dynamic)a[i] > a[i + (int)gap])
                        {
                            Common.Swap(ref a[i], ref a[i + (int)gap]);
                            sorted = false;
                            // If this assignment never happens within the loop,
                            // then there have been no swaps and the list is sorted.

                            if (verbose) a.Print();
                        }

                        i++;
                    }
                }
            }
        }
    }
}
