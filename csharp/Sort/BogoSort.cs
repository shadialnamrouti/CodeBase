using System;

namespace Codebase
{
    public static partial class Sort
    {
        public static void BogoSort<T>(this T[] a, bool verbose = true) where T : struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(BogoSort));
                a.Print();
            }

            //Based on https://en.wikipedia.org/wiki/Bogosort

            while (!a.IsArraySorted())
            {
                a.ShuffleArray();
                if (verbose) a.Print();
            }
        }

        private static bool IsArraySorted<T>(this T[] a)
        {
            bool isSorted = true;

            for (int i = 0; i < a.Length - 1; i++)
                if ((dynamic)a[i] > a[i + 1])
                    isSorted = false;
            return isSorted;

            //Note the return can be used immediately inside the loop
            //But this was avoided because in JQuery there is a problem doing so 
            //i.e. if someone wants to mirror the JQuery version
        }

        //Based on https://en.wikipedia.org/wiki/Bogosort
        //Recreates a list in random order by removing elements in random positions
        private static T[] ShuffleArray<T>(this T[] a)
        {
            T[] newList = new T[a.Length];
            int[] usedIndecies = new int[a.Length];

            int index = -1;
            int randomPosition = 0;

            while (index < a.Length - 1)
            {
                randomPosition = Common.RandomInt(0, a.Length);

                if (!IsFound(usedIndecies, index, randomPosition))
                {
                    index++;
                    newList[index] = a[randomPosition];
                    usedIndecies[index] = randomPosition;
                }
            }

            Array.Copy(newList,a,a.Length);

            return newList;
        }

        private static bool IsFound(int[] exceptionsIndices, int lastIndexToSearch, int randomPosition)
        {
            bool found = false;

            for (int i = 0; i <= lastIndexToSearch; i++)
                if (randomPosition == exceptionsIndices[i])
                    found = true;

            return found;
        }
    }
}
