using System;

namespace ArrayExamples.Library
{
    public static class ArrayHelper
    {
        public static int Max(int[] array)
        {
            if ((array ?? new int[] { }).Length == 0)
            {
                return int.MaxValue;
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int Min(int[] array)
        {
            if ((array ?? new int[] { }).Length == 0)
            {
                return int.MaxValue;
            }

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int Sum(int[] array)
        {
            if ((array ?? new int[] { }).Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int Avg(int[] array)
        {
            if ((array ?? new int[] { }).Length == 0)
            {
                return 0;
            }

            int avg = Sum(array) / array.Length;

            return avg;
        }

        public static int[] CopyRange(int[] array, int startIndex, int length)
        {
            if (array is null)
            {
                return new int[] { };
            }

            if ((startIndex < 0) || (startIndex >= array.Length))
            {
                return new int[] { };
            }

            int actualLength = Math.Min(length, array.Length - startIndex);

            int[] result = new int[actualLength];

            for (int i = 0; i < actualLength; i++)
            {
                result[i] = array[startIndex + i];
            }

            return result;
        }
    }

}
