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
    }
}
