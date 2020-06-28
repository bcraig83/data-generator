namespace DataGenerator.Framework
{
    public interface IObjectProvider<out T>
    {
        T Fetch();
    }
}