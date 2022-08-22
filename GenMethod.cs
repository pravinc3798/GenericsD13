namespace GenericsD13
{
    public class GenMethod
    {
       public static T FindMax<T>(T[] inputArray) where T : IComparable
        {
            T max = inputArray[0];

            if (max.GetType() == typeof(string))
            {
                int length = max.ToString().Length;
                foreach (T t in inputArray)
                    max = (t.ToString().Length.CompareTo(length) > 0) ? t : max;
                return max;
            }

            foreach (T t in inputArray)
                max = (t.CompareTo(max) > 0) ? t : max;
            return max;
        }
    }
}