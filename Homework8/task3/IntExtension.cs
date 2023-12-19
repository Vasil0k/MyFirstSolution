namespace Homework8.task3
{
    public static class IntExtension
    {
        public static int MaxValue(this int[] array) 
        {
            int max = Int32.MinValue;
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
