namespace GenericInterface
{
    public interface ICollection<T>: ICounter<T>
    {
        void Add(T item);

    }
}
