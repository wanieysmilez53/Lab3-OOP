public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator()
    {
        validator = new DimensionValidator();
    }

    public Vector Add(Vector A, Vector B)
    {
        if (!validator.ValidateVectorAddition(A, B))
        {
            throw new Exception("Vector dimensions do not match.");
        }

        Vector result = new Vector(A.GetSize());

        for (int i = 0; i < A.GetSize(); i++)
        {
            result.setValue(i, A.getValue(i) + B.getValue(i));
        }
        return result;
    }
}