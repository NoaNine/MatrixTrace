﻿using DataMatrix;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Messages.Greeting);

            InputMatrixDimension inputMatrixDimension = new InputMatrixDimension();
            int rows = inputMatrixDimension.InputRowsNumber();
            int cols = inputMatrixDimension.InputColsNumber();

            Matrix matrix = new Matrix(rows, cols);
            FillMatrix fillMatrix = new FillMatrix();
            fillMatrix.GetFilledMatrixWithRandomNumbers(matrix);

            Console.WriteLine(Properties.Messages.Matrix);
            Print print = new Print();
            print.PrintTwoDimensionalArray(matrix);

            Console.WriteLine(Properties.Messages.Trace);
            Console.WriteLine(matrix.Trace);

            MatrixInSpiralForm matrixInSpiralForm = new MatrixInSpiralForm();
            Console.WriteLine(Properties.Messages.Snail);
            print.PrintArray(matrixInSpiralForm.GetElementsInSpiralOrder(matrix));
        }
    }
}
