namespace GenericsD13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ---- Using Specific Data Types ---- \n");

            Console.WriteLine("\n >>>> Greatest Input : {0}", MaxInterger.Find());
            Console.WriteLine("\n >>>> Greatest Input : {0}", MaxFloat.Find());
            Console.WriteLine("\n >>>> Greatest Input : {0}", MaxString.Find());

            Console.WriteLine("\n ---- Using Generic Method ---- \n");

            Console.WriteLine("Enter 3 Integers \n"); var xyz = new int[3]; for (int i = 0; i < xyz.Length; i++) { Console.Write(" Provide input : "); xyz[i] = Convert.ToInt32(Console.ReadLine()); }
            Console.WriteLine("\n >>>> Greatest Input : {0}", GenMethod.FindMax(xyz));

            Console.WriteLine("Enter 3 Floats \n"); var abc = new float[3]; for (int i = 0; i < xyz.Length; i++) { Console.Write(" Provide input : "); abc[i] = float.Parse(Console.ReadLine()); }
            Console.WriteLine("\n >>>> Greatest Input : {0}", GenMethod.FindMax(abc));

            Console.WriteLine("Enter 3 Strings \n"); var def = new string[3]; for (int i = 0; i < xyz.Length; i++) { Console.Write(" Provide input : "); def[i] = Console.ReadLine(); }
            Console.WriteLine("\n >>>> Greatest Input : {0}", GenMethod.FindMax(def));
        }
    }
}