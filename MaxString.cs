namespace GenericsD13
{
    public class MaxString
    {
        public static string Find()
        {
            var size = 3;
            var strings = new string[] { "st", "nd", "rd", "th" };
            var list = new string[size];

            Console.WriteLine("\n Enter {0} Strings \n", size);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter {0}{1} String : ", i + 1, (i < 3) ? strings[i] : strings[3]);
                list[i] = Console.ReadLine();
            }

            var max = "";
            foreach (var word in list)
                max = (word.Length > max.Length) ? word : max;

            return max;
        }
    }
}