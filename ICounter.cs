namespace GenericInterface
{
    public interface ICounter<T>
    {
        public int Count { get; }
        public T Get(int index);
    }
}
