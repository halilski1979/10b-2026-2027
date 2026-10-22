namespace _02._Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 4.4567;

            Console.WriteLine($"X={x}");
            Console.WriteLine($"X={x:f3}");
            Console.WriteLine(Math.Round(x,2));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(5>10);
        }
    }
}
