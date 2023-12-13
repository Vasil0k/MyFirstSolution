namespace Homework8.task1
{
    public class Item
    {
        private string _name;

        public Item(string name)
        {
            _name = name;
        }

        public Item() : this("unknown") { }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
