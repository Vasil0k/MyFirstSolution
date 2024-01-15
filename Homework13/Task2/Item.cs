namespace Homework13.Task2
{
    internal interface Item : IComparable<Item>
    {
        int IdNumber { get; init; }
    }
}
