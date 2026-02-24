using System;
public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }

    public double getValue(int j)
    {
        return values[j];
    }

    public void setValue(int j, double value)
    {
        values[j] = value;
    }

    public int length()
    {
        return values.Length;
    }
}

public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        rowData = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public int GetRowCount()
    {
        return rows;
    }

    public int GetColumnCount()
    {
        return cols;
    }

    public double getValue(int i, int j)
    {
        return rowData[i].getValue(j);
    }

    public void setValue(int i, int j, double value)
    {
        rowData[i].setValue(j, value);
    }

    public void display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(getValue(i, j) + "\t");
            }
            Console.WriteLine();
        }
    }
}