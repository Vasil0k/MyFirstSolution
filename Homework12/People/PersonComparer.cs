namespace Homework12.People
{
    internal class PersonComparer : IComparer<Person?>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (x != null) 
            {
                return x.CompareTo(y); 
            }

            return y.CompareTo(x);
        }
    }
}
