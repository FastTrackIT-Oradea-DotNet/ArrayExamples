using ArrayExamples.Library;
using System;

namespace ArrayExamples
{
    public static class ConsoleHelper
    {
        public static int ReadNumber(string message, int maxAttempts, bool allowNegative, int defaultValue)
        {
            int attemptsCount = 1;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.Write(message);
                string text = Console.ReadLine();

                isNumber = int.TryParse(text, out int number);

                if (isNumber && (allowNegative || (number >= 0)))
                {
                    return number;
                }
                else
                {
                    isNumber = false;
                    Console.WriteLine($"'{text}' is not a {(allowNegative ? "number" : "positive number")}, try again ({maxAttempts - attemptsCount} attempts remaining) ...");
                }

                attemptsCount++;

                if (attemptsCount > maxAttempts)
                {
                    Console.WriteLine($"Max attempts count exceeded, asuming {defaultValue} as default value ...");
                    return defaultValue;
                }
            }

            return defaultValue;
        }

        public static int[] ReadArrayFromConsole(string arrayName)
        {
            int length = ReadNumber($"{arrayName} Length=", 3, false, 0);

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = ReadNumber($"{arrayName} Element[{i}]=", 3, true, 0);
            }

            return array;
        }

        public static void PrintArray(string arrayName, int[] array)
        {
            string arrayElements = string.Join(", ", array ?? new int[] { });

            Console.WriteLine($"{arrayName} = [{arrayElements}]");
        }

        public static int[,] ReadMatrixFromConsole(string matrixName)
        {
            int rowCount = ReadNumber($"{matrixName} Number of Rows=", 3, false, 0);
            int colCount = ReadNumber($"{matrixName} Number of Columns=", 3, false, 0);

            int[,] matrix = new int[rowCount, colCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    matrix[row, col] = ReadNumber($"{matrixName} Element[{row},{col}]=", 3, true, 0);
                }
            }

            return matrix;
        }

        public static void PrintMatrix(string matrixName, int[,] matrix)
        {
            int rowCount = MatrixHelper.GetRowsCount(matrix);
            int colCount = MatrixHelper.GetColsCount(matrix);

            Console.WriteLine($"{matrixName} ({rowCount} X {colCount}):");

            for(int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    Console.Write($"{matrix[row, col], 3}");
                    if (col < colCount - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
