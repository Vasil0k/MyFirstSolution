namespace Homework7
{
    public class ArrayWorker
    {
        public static T[] InvertArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int oppositeIndex = array.Length - 1 - i;
                (array[oppositeIndex], array[i]) = (array[i], array[oppositeIndex]);
            }
            return array;
        }
    }
}
