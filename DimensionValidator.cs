public class DimensionValidator
{
    // Validate Matrix dimensions

    public bool ValidateMatrixAddition(Matrix m1, Matrix m2)
    {
        if (m1.GetRowCount() == m2.GetRowCount() && m1.GetColumnCount() == m2.GetColumnCount())
        {
            return true;
        }
        return false;
    }

    // Validate Vector dimensions

    public bool ValidateVectorAddition(Vector v1, Vector v2)
    {
        if (v1.GetSize() == v2.GetSize())
        {
            return true;
        }

        return false;
    }
}