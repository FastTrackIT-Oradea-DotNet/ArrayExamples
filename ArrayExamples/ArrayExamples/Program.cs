using ArrayExamples.Library;
using System;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadMatricesAndCalculateProduct();
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

        private static void ReadAndPrintMatrix()
        {
            int[,] matrix = ConsoleHelper.ReadMatrixFromConsole("Matrix");

            ConsoleHelper.PrintMatrix("Matrix", matrix);
        }

        private static void ReadMatrixAndPrintMainDiagonal()
        {
            int[,] matrix = ConsoleHelper.ReadMatrixFromConsole("Matrix");

            int[] mainDiagonal = MatrixHelper.MainDiagonal(matrix);

            ConsoleHelper.PrintMatrix("Matrix", matrix);
            ConsoleHelper.PrintArray("Main Diagonal", mainDiagonal);
        }

        private static void ReadMatrixAndPrintSecondaryDiagonal()
        {
            int[,] matrix = ConsoleHelper.ReadMatrixFromConsole("Matrix");

            int[] mainDiagonal = MatrixHelper.SecondaryDiagonal(matrix);

            ConsoleHelper.PrintMatrix("Matrix", matrix);
            ConsoleHelper.PrintArray("Secondary Diagonal", mainDiagonal);
        }

        private static void ReadMatrixAndPrintMinAndMax()
        {
            int[,] matrix = ConsoleHelper.ReadMatrixFromConsole("Matrix");

            int min = MatrixHelper.Min(matrix);
            int max = MatrixHelper.Max(matrix);

            ConsoleHelper.PrintMatrix("Matrix", matrix);
            Console.WriteLine($"Min element={min}");
            Console.WriteLine($"Max element={max}");
        }

        private static void ReadMatricesAndCalculateSum()
        {
            int[,] matrix1 = ConsoleHelper.ReadMatrixFromConsole("Matrix1");
            int[,] matrix2 = ConsoleHelper.ReadMatrixFromConsole("Matrix2");

            int[,] sum = MatrixHelper.Sum(matrix1, matrix2);


            ConsoleHelper.PrintMatrix("Matrix1", matrix1);
            ConsoleHelper.PrintMatrix("Matrix2", matrix2);
            ConsoleHelper.PrintMatrix("Sum", sum);
        }

        private static void ReadMatricesAndCalculateProduct()
        {
            int[,] matrix1 = ConsoleHelper.ReadMatrixFromConsole("Matrix1");
            int[,] matrix2 = ConsoleHelper.ReadMatrixFromConsole("Matrix2");

            int[,] prod = MatrixHelper.Product(matrix1, matrix2);


            ConsoleHelper.PrintMatrix("Matrix1", matrix1);
            ConsoleHelper.PrintMatrix("Matrix2", matrix2);
            ConsoleHelper.PrintMatrix("Product", prod);

            /*
             * Example:
             * 
             (0  1)   (1  1  1  1) = (0  0  0  0)
             (2  2) X (0  0  0  0)   (2  2  2  2)
             (1  3)                  (1  1  1  1)
            */
        }
    }
}
