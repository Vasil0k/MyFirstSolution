using Homework8.task1;

namespace Homework8.task4
{
    public class Bag
    {
        private Item[] _items;
        private bool _isOpen;

        public Bag() 
        {
            _items = new Item[8];
            _isOpen = true;
        }

        public void SetOpen(bool isOpen)
        {
            _isOpen = isOpen;
        }

        public void Put(Item item)
        {
            if (_isOpen)
            {
                for (int i = 0;  i < _items.Length; i++)
                {
                    if (_items[i] == null)
                    {
                        _items[i] = item;
                        Console.WriteLine($"Item {item.GetName()} is put to Bag.");
                        return;
                    }
                }

                Console.WriteLine("No free space in the Bag.");
            }
            else
            {
                Console.WriteLine("The Bag is closed");
            }
        }

        public Item Get(uint index)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, (uint) 8, nameof(index));

            if ( _isOpen)
            {
                Item item = _items[index];
                _items[index] = null;
                if ( item != null )
                {
                    Console.WriteLine($"Item {item.GetName} was taken out of the Bag.");
                } 
                else
                {
                    Console.WriteLine($"No item by index {index}");
                }
                
                return item;
            } 
            else
            {
                Console.WriteLine("The Bag is closed.");
                return null;
            }
        }
    }
}
