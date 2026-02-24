public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator()
    {
        validator = new DimensionValidator();
    }

    public Matrix Add(Matrix A, Matrix B)
    {
        if (!validator.ValidateMatrixAddition(A, B))
        {
            throw new Exception("Matrix dimensions do not match.");
        }

        int rows = A.GetRowCount();
        int cols = A.GetColumnCount();

        Matrix result = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double sum = A.getValue(i, j) + B.getValue(i, j);
                result.setValue(i, j, sum);
            }
        }
        return result;
    }
}