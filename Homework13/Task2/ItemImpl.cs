namespace Homework13.Task2
{
    internal class ItemImpl : Item
    {   
        private readonly int _idNumber;

        public int IdNumber { get => _idNumber; init => _idNumber = value; }

        public ItemImpl(int idNumber)
        {
            IdNumber = idNumber;
        }

        public int CompareTo(Item? other)
        {
            return other == null ? 1 : IdNumber.CompareTo(other.IdNumber);
        }

        public override string? ToString()
        {
            return $"Item: [IdNumber: {IdNumber}]";
        }
    }
}
