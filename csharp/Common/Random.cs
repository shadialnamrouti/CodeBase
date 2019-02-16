using System;

namespace Codebase
{
    public static partial class Common
    {
        public static T[] RandomArray<T>(int count, int min=0, int max=Int32.MaxValue, int decimalPlaces=1) 
        {
            T[] array = new T[count];
            Random rnd = new Random();

            if (typeof(T) == typeof(System.Int32))
            {
                for (int i = 0; i < count; i++)
                {
                    array[i] = (dynamic)rnd.Next(0, max);
                }
            }
            else if (typeof(T) == typeof(System.Double))
            {
                for (int i = 0; i < count; i++)
                {

                    array[i] = Math.Round((dynamic)rnd.NextDouble(),decimalPlaces);
                }
            }

            return array;
        }

        

    }
}
