namespace Homework7
{
    public class Stack<T>
    {
        private T[] items;
        private int topIndex;

        public Stack(uint initialSize)
        {
            items = new T[initialSize];
            topIndex = -1;
        }

        public Stack() : this(0) { }

        public void Push(T item)
        {
            if (topIndex == items.Length - 1)
            {
                Array.Resize(ref items, (items.Length + 1) * 2);
            }

            items[++topIndex] = item;
        }

        public T Pop()
        {
            if (topIndex == -1)
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }

            return items[topIndex--];
        }

        public bool IsEmpty()
        {
            return topIndex == -1;
        }
    }
}
