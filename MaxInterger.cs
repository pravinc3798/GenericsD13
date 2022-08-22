namespace GenericsD13
{
    public class MaxInterger
    {
        public static int Find()
        {
            var size = 3;
            var strings = new string[] { "st", "nd", "rd", "th" };
            var list = new int[size];

            Console.WriteLine("\n Enter {0} Integers \n", size);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter {0}{1} Number : ", i + 1, (i < 3) ? strings[i] : strings[3]);
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            var max = 0;
            foreach (var num in list)
                max = (num > max) ? num : max;
            
            return max;
        }
    }
}