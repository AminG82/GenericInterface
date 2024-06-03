namespace GenericInterface
{
    public class Collection<T> : ICollection<T>
    {
        private int counter;
        private T[] store;

        public Collection()
        {
            counter = 0;
            store = new T[10];
        }

        public int Count { get { return counter; } }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
