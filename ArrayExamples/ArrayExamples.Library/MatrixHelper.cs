﻿using System;
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

            for (int col = colCount - 1, row = 0; (col >= 0) && (row < rowCount); col--, row++)
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

        public static int[,] Sum(int[,] matrix1, int[,] matrix2)
        {
            int rowCount1 = GetRowsCount(matrix1);
            int colCount1 = GetColsCount(matrix1);

            int rowCount2 = GetRowsCount(matrix2);
            int colCount2 = GetColsCount(matrix2);

            if ((rowCount1 != rowCount2) || (colCount1 != colCount2))
            {
                throw new Exception($"Matrix1 ({rowCount1} X {colCount1}) doesn't have the same dimension as Matrix2 ({rowCount2} X {colCount2})!");
            }

            int[,] result = new int[rowCount1, colCount1];

            for (int row = 0; row < rowCount1; row++)
            {
                for (int col = 0; col < colCount1; col++)
                {
                    result[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }

            return result;
        }

        public static int[,] Product(int[,] matrix1, int[,] matrix2)
        {
            int rowCount1 = GetRowsCount(matrix1);
            int colCount1 = GetColsCount(matrix1);

            int rowCount2 = GetRowsCount(matrix2);
            int colCount2 = GetColsCount(matrix2);

            if (colCount1 != rowCount2)
            {
                throw new Exception($"Number of Columns ({colCount1}) from Matrix1 must be equal with the number of rows ({rowCount2}) from Matrix2!");
            }

            int[,] result = new int[rowCount1, colCount2];

            for (int row = 0; row < rowCount1; row++)
            {
                for (int col = 0; col < colCount2; col++)
                {
                    int sum = 0;

                    for (int k = 0; k < colCount1; k++)
                    {
                        sum += matrix1[row, k] * matrix2[k, col];
                    }

                    result[row, col] = sum;
                }
            }

            return result;
        }

        public static int[,] Transpose(int[,] matrix)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);


            int[,] result = new int[colCount, rowCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    result[col, row] = matrix[row, col];
                }
            }

            return result;
        }

        public static bool IsIdentity(int[,] matrix)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            if ((rowCount > 0) && (colCount > 0))
            {
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        if (row == col)
                        {
                            if (matrix[row, col] != 1)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (matrix[row, col] != 0)
                            {
                                return false;
                            }
                        }
                    }
                }

                return true;
            }

            return false;
        }

        public static int SumRow(int[,] matrix, int rowIndex)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            if ((rowCount > 0) && (colCount > 0) && (rowIndex >= 0) && (rowIndex < rowCount))
            {
                int sum = 0;

                for (int col = 0; col < colCount; col++)
                {
                    sum += matrix[rowIndex, col];
                }

                return sum;
            }

            return 0;
        }

        public static int SumCol(int[,] matrix, int colIndex)
        {
            int rowCount = GetRowsCount(matrix);
            int colCount = GetColsCount(matrix);

            if ((rowCount > 0) && (colCount > 0) && (colIndex >= 0) && (colIndex < colCount))
            {
                int sum = 0;

                for (int row = 0; row < rowCount; row++)
                {
                    sum += matrix[row, colIndex];
                }

                return sum;
            }

            return 0;
        }
    }
}
