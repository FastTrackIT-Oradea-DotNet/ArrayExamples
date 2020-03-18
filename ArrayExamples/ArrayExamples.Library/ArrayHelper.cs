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
    }

}
