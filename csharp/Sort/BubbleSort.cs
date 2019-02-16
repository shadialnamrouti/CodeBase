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

            
            for (int write = 0; write < a.Length; write++)
            {
                
                for (int sort = 0; sort < a.Length - 1; sort++)
                {
                    
                    if ((dynamic)a[sort] > a[sort + 1])
                    {
           
                        Common.Swap(ref a[sort + 1], ref a[sort]);

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
