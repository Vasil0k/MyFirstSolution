namespace Homework12.Network
{
    internal class MobilePhone<T> where T : MobileNetwork
    {
        public T Network { get; set; }
    }
}
