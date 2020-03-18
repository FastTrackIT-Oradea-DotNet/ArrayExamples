using ArrayExamples.Library;
using System;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadVectorAndCalculateMaxElement();
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
    }
}
