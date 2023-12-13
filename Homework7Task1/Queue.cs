namespace Homework7
{
    public class Queue<T>
    {
        private T[] items;
        private int tailIndex;

        public Queue(uint initialSize)
        {
            items = new T[initialSize];
            tailIndex = -1;
        }

        public Queue() : this(0) { }

        public bool IsEmpty()
        {
            return tailIndex == -1;
        }

        public void Push(T item)
        {
            if (tailIndex == items.Length - 1)
            {
                Array.Resize(ref items, (items.Length + 1) * 2);
            }

            items[++tailIndex] = item;
        }

        public T Pop()
        {
            if (tailIndex == -1)
            {
                throw new IndexOutOfRangeException("The queue is empty");
            }

            T headItem = items[0];
            ShiftItemsLeft();
            return headItem;
        }

        public int Size()
        {
            return tailIndex + 1;
        }

        private void ShiftItemsLeft()
        {
            T[] shiftedItems = new T[items.Length];
            Array.Copy(items, 1, shiftedItems, 0, items.Length - 1);
            items = shiftedItems;
            tailIndex--;
        }
    }
}
