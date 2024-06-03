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
            store[counter++] = item;
        }

        public T Get(int index)
        {
            return store[index];
        }
    }
}
