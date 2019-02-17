using System;

namespace Codebase
{
    public static partial class Common
    {
        public static int RandomInt(int min = 0, int max = Int32.MaxValue)
        {
            Random rnd = new Random();
            return (dynamic)rnd.Next(0, max);
        }

        public static double RandomDouble(int decimalPlaces = 1)
        {
            Random rnd = new Random();
            return Math.Round(rnd.NextDouble(), decimalPlaces);
        }

        public static int[] RandomArrayInt(int count, int min = 0, int max = Int32.MaxValue)
        {
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = RandomInt(min, max);

            return array;
        }

        public static double[] RandomArrayDouble(int count, int decimalPlaces = 1)
        {
            double[] array = new double[count];

            for (int i = 0; i < count; i++)
                array[i] = RandomDouble(decimalPlaces);

            return array;
        }

        public static T RandomNumber<T>(int min = 0, int max = Int32.MaxValue, int decimalPlaces = 1)
        {
            if (typeof(T) == typeof(System.Int32))
                return (dynamic)RandomInt(min, max);
            else //if (typeof(T) == typeof(System.Double))
                return (dynamic)RandomDouble(decimalPlaces);
        }

        public static T[] RandomArray<T>(int count, int min = 0, int max = Int32.MaxValue, int decimalPlaces = 1)
        {
            T[] array = new T[count];

            if (typeof(T) == typeof(System.Int32))
                for (int i = 0; i < count; i++)
                    array[i] = (dynamic)RandomInt(min, max);
            else //if (typeof(T) == typeof(System.Double))
                for (int i = 0; i < count; i++)
                    array[i] = (dynamic)RandomDouble(decimalPlaces);

            return array;
        }
    }
}
