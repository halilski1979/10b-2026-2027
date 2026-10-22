namespace _03._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            while (true)
            {
                Console.WriteLine($"a ={a}");
                if (a>9)
                {
                    break;
                }
                a++;
            }

        }
    }
}
