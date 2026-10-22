namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 6, 4, 3 };
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i];
            }
            Console.WriteLine(s);
        }
    }
}
