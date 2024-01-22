namespace Homework16
{
    public static class LinqExtension
    {
        public static T Median<T>(this IEnumerable<T> collection)
        {
            if (!collection.Any())
            {
                throw new ArgumentException("collection must not be empty");
            }

            return collection.ElementAt(collection.Count() / 2);
        }
    }
}
