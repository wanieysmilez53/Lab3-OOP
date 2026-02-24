public class MatrixRepository
{
    private List<Matrix> matrices;

    public MatrixRepository()
    {
        matrices = new List<Matrix>();
    }

    public void AddMatrix(Matrix matrix)
    {
        matrices.Add(matrix);
    }

    public Matrix GetMatrix(int index)
    {
        if (index >= 0 && index < matrices.Count)
        {
            return matrices[index];
        }
        return null;
    }
    public int GetMatrixCount()
    {
        return matrices.Count;
    }
}
