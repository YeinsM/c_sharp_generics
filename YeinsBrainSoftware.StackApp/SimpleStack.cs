namespace YeinsBrainSoftware.StackApp
{
    public class SimpleStack<T> // <T> is now a generic type for class
    {
        private readonly T[] _items;
        private int _currentIndex = -1;

        public SimpleStack() => _items = new T[10];

        public int Count => _currentIndex + 1;  //_items.Length;

        public void Push(T item) => _items[++_currentIndex] = item;

        public T Pop() => _items[_currentIndex--];
    }
}