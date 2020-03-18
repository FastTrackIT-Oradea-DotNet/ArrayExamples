using ArrayExamples.Library;
using System;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadVectorAndExchangeSort();
        }

        private static void ReadAndPrintVector()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            ConsoleHelper.PrintArray("Array", array);
        }

        private static void ReadVectorAndCalculateElementsSum()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Sum of Elements Is: {sum}");
        }

        private static void ReadVectorAndCalculateMaxElement()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int max = ArrayHelper.Max(array);

            Console.WriteLine($"Max Element Is: {max}");
        }

        private static void ReadVectorAndCalculateMinElement()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int min = ArrayHelper.Min(array);

            Console.WriteLine($"Min Element Is: {min}");
        }

        private static void ReadVectorAndCalculateAvgElement()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int avg = ArrayHelper.Avg(array);

            Console.WriteLine($"Avg Element Is: {avg}");
        }

        private static void ReadVectorAndExtractSubArray()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int startIndex = ConsoleHelper.ReadNumber("Start Index=", 3, 0);

            int length = ConsoleHelper.ReadNumber("Length=", 3, 0);

            int[] subArray = ArrayHelper.CopyRange(array, startIndex, length);

            ConsoleHelper.PrintArray("Sub Array", subArray);
        }

        private static void ReadVectorAndRemoveSubArray()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int startIndex = ConsoleHelper.ReadNumber("Start Index=", 3, 0);

            int length = ConsoleHelper.ReadNumber("Length=", 3, 0);

            int[] newArray = ArrayHelper.RemoveRange(array, startIndex, length);

            ConsoleHelper.PrintArray("Original Array", array);
            ConsoleHelper.PrintArray("New Array After Remove", newArray);
        }

        private static void ReadVectorAndBubbleSort()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int[] sortedArray = ArrayHelper.BubbleSort(array, SortDirection.Ascending);

            ConsoleHelper.PrintArray("Original Array", array);
            ConsoleHelper.PrintArray("Sorted Array", sortedArray);
        }

        private static void ReadVectorAndExchangeSort()
        {
            int[] array = ConsoleHelper.ReadArrayFromConsole("Array");

            int[] sortedArray = ArrayHelper.ExchangeSort(array, SortDirection.Ascending);

            ConsoleHelper.PrintArray("Original Array", array);
            ConsoleHelper.PrintArray("Sorted Array", sortedArray);
        }
    }
}
