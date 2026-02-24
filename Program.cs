using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        InputHandler input = new InputHandler();

        Console.WriteLine("MATRIX ADDITION");

        Console.WriteLine("Input Matrix A");
        Matrix A = input.inputMatrix();

        Console.WriteLine("Input Matrix B");
        Matrix B = input.inputMatrix();

        MatrixCalculator matrixCalc = new MatrixCalculator();
        try
        {
            Matrix C = matrixCalc.Add(A, B);
            Console.WriteLine("Result Matrix: ");
            C.display();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}