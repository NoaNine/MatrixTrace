﻿namespace MatrixOperations
{
    public class DataMatrix
    {
        public int[] GetElementsInSpiralOrder(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return new int[0];
            }
            int[] elementsInSpiralOrder = new int[matrix.GetLength(0)];
            return elementsInSpiralOrder; 
        }

        public int[] GetMainDiagonal(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return new int[0];
            }
            int[] mainDiagonal = new int[matrix.GetLength(0)];
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    mainDiagonal[i] = matrix[i, i];
                }
            }
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                
            }
            return mainDiagonal;
        }

        public int[] GetSecondaryDiagonal(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return new int[0];
            }
            int[] secondaryDiagonal = new int[matrix.GetLength(0)];
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                for (int j = matrix.GetLength(0) - 1, i = 0; j >= 0; i++, j--)
                {
                    secondaryDiagonal[i] = matrix[i, j];
                }
            }
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                
            }
            return secondaryDiagonal;
        }
    }
}