using System;

namespace Codebase
{
    public static partial class Sort
    {
        public static void BubbleSort<T>(this T[] a, bool verbose=false) where T: struct
        {
            if (verbose)
            {
                Console.WriteLine(nameof(BubbleSort));
                a.Print();
            }

            
            for (int i = 0; i < a.Length; i++)
            {
                
                for (int j = 0; j < a.Length - 1; j++)
                {
                    
                    if ((dynamic)a[j] > a[j + 1])
                    {
           
                        Common.Swap(ref a[j], ref a[j+1]);

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
