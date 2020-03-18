using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExamples.Library
{
    public static class MatrixHelper
    {
        public static int GetRowsCount(int[,] matrix)
        {
            return (matrix?.GetLength(0)) ?? 0;
        }

        public static int GetColsCount(int[,] matrix)
        {
            return (matrix?.GetLength(1)) ?? 0;
        }

        public static int[] MainDiagonal(int[,] matrix)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            int actualDimension = Math.Min(rowCount, colCount);

            int[] result = new int[actualDimension];

            for (int i = 0; i < actualDimension; i++)
            {
                result[i] = matrix[i, i];
            }

            return result;
        }

        public static int[] SecondaryDiagonal(int[,] matrix)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            int actualDimension = Math.Min(rowCount, colCount);

            int[] result = new int[actualDimension];

            for (int col = colCount -1, row = 0; (col >= 0) && (row < rowCount); col--, row++)
            {
                result[row] = matrix[row, col];
            }

            return result;
        }

        public static int Min(int[,] matrix)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            if ((rowCount > 0) && (colCount > 0))
            {
                int min = matrix[0, 0];

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        if (matrix[row, col] < min)
                        {
                            min = matrix[row, col];
                        }
                    }
                }

                return min;
            }

            return int.MaxValue;
        }

        public static int Max(int[,] matrix)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            if ((rowCount > 0) && (colCount > 0))
            {
                int max = matrix[0, 0];

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        if (matrix[row, col] > max)
                        {
                            max = matrix[row, col];
                        }
                    }
                }

                return max;
            }

            return int.MaxValue;
        }
    }
}
