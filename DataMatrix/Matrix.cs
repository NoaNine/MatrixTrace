﻿namespace DataMatrix
{
    public class Matrix
    {
        private int[,] _matrix;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public long Trace { get => GetTrace(); }

        public int this[int i, int j]
        {
            get => _matrix[i, j];
            set => _matrix[i, j] = value;
        }

        public Matrix(int rows, int cols)
        {
            ThrowIfOutOfRange(rows, cols);
            Rows = rows;
            Cols = cols;
            _matrix = new int[Rows, Cols];
        }

        public Matrix(int[,] matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            Rows = matrix.GetLength(0);
            Cols = matrix.GetLength(1);
            ThrowIfOutOfRange(Rows, Cols);
            _matrix = (int[,])matrix.Clone();
        }

        private int GetTrace()
        {
            int length = Rows <= Cols ? Rows : Cols;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += _matrix[i, i];
            }
            return sum;
        }

        private void ThrowIfOutOfRange(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0 || rows * cols > Array.MaxLength)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
