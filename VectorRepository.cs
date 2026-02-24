public class VectorRepository
{
    private List<Vector> vectors;

    public VectorRepository()
    {
        vectors = new List<Vector>();
    }

    public void AddVector(Vector v)
    {
        vectors.Add(v);
    }

    public Vector GetVector(int index)
    {
        return vectors[index];
    }
}