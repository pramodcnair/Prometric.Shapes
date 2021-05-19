namespace Prometric.Shape
{
    public interface ISerializeStrategy
    {
        string SerializeObject<T>(T obj);
    }
}
